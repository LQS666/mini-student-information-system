using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_zarządzania_studentami_informatyki
{
    public partial class AddStudentWindow : Form
    {
        public AddStudentWindow()
        {
            InitializeComponent();
        }

        private void AddStudentWindow_Load(object sender, EventArgs e)
        {

        }


        private void radioButtonK_CheckedChanged(object sender, EventArgs e)
        {
            StudentImageBox.BackgroundImage = global::System_zarządzania_studentami_informatyki.Properties.Resources.femaleImage;
        }

        private void radioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            StudentImageBox.BackgroundImage = global::System_zarządzania_studentami_informatyki.Properties.Resources.maleImage;
        }

        // Dodawanie studenta.
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            string imie = TextBoxImie.Text;
            string nazwisko = TextBoxNazwisko.Text;
            DateTime dataUrodzenia = dateTimePicker1.Value;
            string telefon = TextBoxPhone.Text;
            string miasto = TextBoxAdres.Text;
            string kraj = TextBoxAdres2.Text;
            string plec = "Mezczyzna";

            if (radioButtonK.Checked)
            {
                plec = "Kobieta";
            }

            MemoryStream zdjecieStudenta = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;


            // Lista warunków.
            // Student nie może mieć mniej niż 12 lat i nie więcej niż 80.
            if (((this_year - born_year) < 12) || ((this_year - born_year) > 80))
            {
                MessageBox.Show("Zła data urodzenia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (StudentImageBox.Image == null)
            {
                if(radioButtonM.Checked)
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
                } else
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

        //  Funkcja pozwala dodać zdjęcie użytkownika.
        private void StudentImageUploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                StudentImageBox.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
