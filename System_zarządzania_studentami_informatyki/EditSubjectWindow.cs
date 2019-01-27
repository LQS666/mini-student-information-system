using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_zarządzania_studentami_informatyki
{
    public partial class EditSubjectWindow : Form
    {
        public EditSubjectWindow()
        {
            InitializeComponent();
        }

        Subjects subject = new Subjects();
        int pos;

        private void EditSubjectWindow_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }

        // Wypełnianie ListBoxa.
        void reloadListBoxData()
        {
            ListBoxSubjects.DataSource = subject.getAllSubjects();
            ListBoxSubjects.ValueMember = "id";
            ListBoxSubjects.DisplayMember = "przedmiot";

            ListBoxSubjects.SelectedItem = null;

            // Wyświetlanie liczby wszystkich studentów.
            SubjectsCounter.Text = ("Liczba wszystkich przedmiotów: " + subject.totalSubjects());
        }


        // Funkcja wyświetlająca wszystkie dane.
        void showData(int index)
        {
            DataRow dr = subject.getAllSubjects().Rows[index];

            ListBoxSubjects.SelectedIndex = index;

            TextBoxID.Text = dr.ItemArray[0].ToString();

            TextBoxSubjectName.Text = dr.ItemArray[1].ToString();

            TextBoxTeacherName.Text = dr.ItemArray[2].ToString();

            if ((dr.ItemArray[3].ToString() == "Cwiczenia"))
            {
                radioButtonCw.Checked = true;
            }
            else
            {
                radioButtonW.Checked = true;
            }

            TextBoxDesc.Text = dr.ItemArray[4].ToString();
        }


        // Funkcja, która po klknięciu w pozycję na liście wyświetla jej szczegóły w boxach tekstowych.
        private void ListBoxSubjects_Click_1(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)ListBoxSubjects.SelectedItem;
            pos = ListBoxSubjects.SelectedIndex;
            showData(pos);
        }


        

        // Dodawanie nowego przedmiotu.
        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            string name = TextBoxSubjectName.Text;
            string tch = TextBoxTeacherName.Text;
            string met = "Cwiczenia";

            if (radioButtonW.Checked)
            {
                met = "Wyklad";
            }

            string descr = TextBoxDesc.Text;

            if (name.Trim() == "" || tch.Trim() == "" || descr.Trim() == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola.", "Dodaj przedmiot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (subject.checkSubjectName(name))
            {
                if (subject.insertSubject(name, tch, met, descr))
                {
                    MessageBox.Show("Pomyślnie dodano nowy przedmiot!", "Dodaj przedmiot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Coś poszło nie tak. Spróbuj jeszcze raz.", "Dodaj przedmiot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Ten przedmiot już istnieje", "Dodaj przedmiot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Usuwanie przedmiotu.
        private void DeleteSubjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                int subjectID = Convert.ToInt32(TextBoxID.Text);

                if ((MessageBox.Show("Czy na pewno chcesz usunąć ten przedmiot?", "Usuń przedmiot", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (subject.deleteSubject(subjectID))
                    {
                        MessageBox.Show("Przedmiot usunięty pomyślnie.", "Usuń przedmiot", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TextBoxID.Text = "";
                        TextBoxSubjectName.Text = "";
                        TextBoxTeacherName.Text = "";
                        TextBoxDesc.Text = "";

                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Przedmiot nie został usunięty.", "Usuń przedmiot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Zły numer ID", "Usuń przedmiot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pos = 0;
        }

        // Przycisk Reset.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            TextBoxID.Text = "";
            TextBoxSubjectName.Text = "";
            TextBoxTeacherName.Text = "";
            radioButtonCw.Checked = true;
            TextBoxDesc.Text = "";
        }
    }
}
