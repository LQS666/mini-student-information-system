using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_zarządzania_studentami_informatyki
{
    public partial class EditStudentWindow : Form
    {
        public EditStudentWindow()
        {
            InitializeComponent();
        }

        Students student = new Students();

        private void editStudentWindow_Load_1(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT * FROM `student`"));
        }
        


        // Funkcja obsługująca listę użytkowników (datagridview).
        public void fillGrid(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 80;

            dataGridView1.DataSource = student.getStudents(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];

            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;

            // Zlicza liczbę studentów.
            StudentsCounter_Click.Text = ("Liczba wszystkich studentów: " + dataGridView1.Rows.Count);
        }


        // Funkcja przekazuje dane z tabeli (datagridview) do pól w lewej części okna.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBoxImie.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBoxNazwisko.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Kobieta"))
            {
                radioButtonK.Checked = true;
            }
            else
            {
                radioButtonM.Checked = true;
            }

            TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TextBoxAdres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TextBoxAdres2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            byte[] zdjecieStudenta;
            zdjecieStudenta = (byte[])dataGridView1.CurrentRow.Cells[8].Value;
            MemoryStream zdjecie = new MemoryStream(zdjecieStudenta);
            StudentImageBox.Image = Image.FromStream(zdjecie);
        }

        

        // Wyszukiwarka listy studentów.
        private void SearchButton_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`imie`,`nazwisko`,`miasto`,`kraj`)LIKE'%" + TextBoxSearch.Text + "%'");
            fillGrid(command);
        }

        // Zmiana zdjęcia Studenta
        private void StudentImageUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                StudentImageBox.Image = Image.FromFile(opf.FileName);
            }
        }

        // Resetowanie danych w polach.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            TextBoxID.Text = "";
            TextBoxImie.Text = "";
            TextBoxNazwisko.Text = "";
            TextBoxAdres.Text = "";
            TextBoxAdres2.Text = "";
            TextBoxPhone.Text = "";
            StudentImageBox.Image = null;
            radioButtonM.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        // Pobieranie zdjęcia studenta na komputer użytkownika aplikacji.
        private void StudentImageDownloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + TextBoxID.Text);
            if ((StudentImageBox.Image == null))
            {
                MessageBox.Show("Brak zdjęcia.");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                StudentImageBox.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }

        }

        //  Funkcja sprawdzająca poprawność danych.
        bool verif()
        {
            if ((TextBoxImie.Text.Trim() == "")
                        || (TextBoxNazwisko.Text.Trim() == "")
                        || (TextBoxAdres.Text.Trim() == "")
                        || (TextBoxAdres2.Text.Trim() == "")
                        || (TextBoxPhone.Text.Trim() == "")
                        || (StudentImageBox.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        // Funkcja dodaje nowego studenta.
        private void AddStudentButton_Click_1(object sender, EventArgs e)
        {
            Students student = new Students();
            string imie = TextBoxImie.Text;
            string nazwisko = TextBoxNazwisko.Text;
            DateTime dataUrodzenia = dateTimePicker1.Value;
            string telefon = TextBoxPhone.Text;
            string miasto = TextBoxAdres.Text;
            string kraj = TextBoxAdres2.Text;
            string plec = "Mężczyzna";

            if (radioButtonK.Checked)
            {
                plec = "Kobieta";
            }

            MemoryStream zdjecieStudenta = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;


            // Student nie może mieć mniej niż 12 lat i nie więcej niż 80.

            if (((this_year - born_year) < 12) || ((this_year - born_year) > 80))
            {
                MessageBox.Show("Zła data urodzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (StudentImageBox.Image == null)
            {
                if (radioButtonM.Checked)
                {
                    StudentImageBox.Image = global::System_zarządzania_studentami_informatyki.Properties.Resources.maleImage;
                    if (verif())
                    {
                        StudentImageBox.Image.Save(zdjecieStudenta, StudentImageBox.Image.RawFormat);
                        if (student.insertStudent(imie, nazwisko, dataUrodzenia, plec, telefon, miasto, kraj, zdjecieStudenta))
                        {
                            MessageBox.Show("Pomyślnie dodano nowego studenta!", "Dodaj studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    StudentImageBox.Image = global::System_zarządzania_studentami_informatyki.Properties.Resources.femaleImage;
                    if (verif())
                    {
                        StudentImageBox.Image.Save(zdjecieStudenta, StudentImageBox.Image.RawFormat);
                        if (student.insertStudent(imie, nazwisko, dataUrodzenia, plec, telefon, miasto, kraj, zdjecieStudenta))
                        {
                            MessageBox.Show("Pomyślnie dodano nowego studenta!", "Dodaj studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else if (verif())
            {
                StudentImageBox.Image.Save(zdjecieStudenta, StudentImageBox.Image.RawFormat);
                if (student.insertStudent(imie, nazwisko, dataUrodzenia, plec, telefon, miasto, kraj, zdjecieStudenta))
                {
                    MessageBox.Show("Pomyślnie dodano nowego studenta!", "Dodaj studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Coś poszło nie tak. Spróbuj jeszcze raz.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Funkcja aktualizuje dane bieżącego studenta.
        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            int id;
            string imie = TextBoxImie.Text;
            string nazwisko = TextBoxNazwisko.Text;
            DateTime dataUrodzenia = dateTimePicker1.Value;
            string telefon = TextBoxPhone.Text;
            string miasto = TextBoxAdres.Text;
            string kraj = TextBoxAdres2.Text;

            string plec = "Mężczyzna";

            if (radioButtonK.Checked)
            {
                plec = "Kobieta";
            }

            MemoryStream zdjecieStudenta = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            // Student nie może mieć mniej niż 12 lat i nie więcej niż 80.

            if (((this_year - born_year) < 12) || ((this_year - born_year) > 80))
            {
                MessageBox.Show("Zła data urodzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(TextBoxID.Text);

                    StudentImageBox.Image.Save(zdjecieStudenta, StudentImageBox.Image.RawFormat);
                    if (student.updateStudent(id, imie, nazwisko, dataUrodzenia, plec, telefon, miasto, kraj, zdjecieStudenta))
                    {
                        MessageBox.Show("Pomyślnie zaktualizowano informacje!", "Edycja studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new MySqlCommand("SELECT * FROM `student`"));
                    }
                    else
                    {
                        MessageBox.Show("Coś poszło nie tak. Spróbuj jeszcze raz.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edycja studenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Funkcja usuwa studenta.
        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(TextBoxID.Text);

                if ((MessageBox.Show("Czy na pewno chcesz usunąć tego studenta?", "Usuń studenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student usunięty pomyślnie", "Usuń studenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new MySqlCommand("SELECT * FROM `student`"));
                        
                        TextBoxID.Text = "";
                        TextBoxImie.Text = "";
                        TextBoxNazwisko.Text = "";
                        TextBoxAdres.Text = "";
                        TextBoxAdres2.Text = "";
                        TextBoxPhone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        StudentImageBox.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student nie został usunięty.", "Usuń studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Wprowadź poprawne dane.", "Usuń studenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Przycisk odśwież.
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");

            dataGridView1.DataSource = student.getStudents(command);

            StudentsCounter_Click.Text = ("Liczba wszystkich studentów: " + dataGridView1.Rows.Count);
        }

        private void radioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            StudentImageBox.BackgroundImage = global::System_zarządzania_studentami_informatyki.Properties.Resources.maleImage;
        }

        private void radioButtonK_CheckedChanged(object sender, EventArgs e)
        {
            StudentImageBox.BackgroundImage = global::System_zarządzania_studentami_informatyki.Properties.Resources.femaleImage;
        }
    }
}
