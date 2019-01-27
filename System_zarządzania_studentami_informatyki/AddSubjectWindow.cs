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
    public partial class AddSubjectWindow : Form
    {
        public AddSubjectWindow()
        {
            InitializeComponent();
        }


        //  Funkcja dodaje przedmiot.
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
            

            Subjects subject = new Subjects();

            // Warunek.
            // Sprawdza czy pola nie są puste.
            if (name.Trim() == "" || tch.Trim() == "" || descr.Trim() == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola.", "Dodaj przedmiot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (subject.checkSubjectName(name))
            {
                if (subject.insertSubject(name, tch, met, descr))
                {
                    MessageBox.Show("Pomyślnie dodano nowy przedmiot!", "Dodaj przedmiot", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
