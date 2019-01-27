using MySql.Data.MySqlClient;
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
    public partial class ScoresWindow : Form
    {
        public ScoresWindow()
        {
            InitializeComponent();
        }
        
        Scores score = new Scores();
        Students student = new Students();
        Subjects subject = new Subjects();


        // Funkcja uruchamia się po otwarciu okna.
        // Pobiera dane o studentach i ocenach, które są wyświetla w odpowiednich polach.

        private void ScoresWindow_Load(object sender, EventArgs e)
        {
            dataGridViewScoresList.DataSource = score.getStudentsScore();

            MySqlCommand command = new MySqlCommand("SELECT `id`, `imie`, `nazwisko` FROM `student`");
            dataGridViewStudentsList.DataSource = student.getStudents(command);
            
            ComboBoxSubject.DataSource = subject.getAllSubjects();
            ComboBoxSubject.DisplayMember = "przedmiot";
            ComboBoxSubject.ValueMember = "id";
        }
        

        // Funkcja pobiera dane z tabel i wyświetla je w odpowiednich polach.
        // Informacje o studentach. 
        private void dataGridViewStudentsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxStudentID.Text = dataGridViewStudentsList.CurrentRow.Cells[0].Value.ToString();
            TextBoxImie.Text = dataGridViewStudentsList.CurrentRow.Cells[1].Value.ToString();
            TextBoxNazwisko.Text = dataGridViewStudentsList.CurrentRow.Cells[2].Value.ToString();
        }


        // Funkcja pobiera dane z tabel i wyświetla je w odpowiednich polach.
        // Informacje o ocenach.
        private void dataGridViewScoresList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxStudentID.Text = dataGridViewScoresList.CurrentRow.Cells[0].Value.ToString();
            ComboBoxSubject.SelectedValue = dataGridViewScoresList.CurrentRow.Cells[3].Value;
        }


        // Dodawanie nowej oceny.
        private void AddScoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(TextBoxStudentID.Text);
                int subjectID = Convert.ToInt32(ComboBoxSubject.SelectedValue);
                double scoreValue = Convert.ToDouble(TextBoxScore.Text);
                
                if (!score.studentScoreExist(studentID, subjectID))
                {
                    if (score.insertScore(studentID, subjectID, scoreValue))
                    {
                        MessageBox.Show("Ocena została dodana pomyślnie.", "Dodaj ocenę", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocena nie została dodana.", "Dodaj ocenę", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Ocena już została przypisana do tego przedmiotu.", "Dodaj ocenę", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dodaj ocenę", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Usuwanie istniejącej oceny.
        private void DeleteScoreButton_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(dataGridViewScoresList.CurrentRow.Cells[0].Value.ToString());
            int subjectID = int.Parse(dataGridViewScoresList.CurrentRow.Cells[3].Value.ToString());

            if (MessageBox.Show("Czy na pewno chcesz usunąć tę ocenę?", "Usuń ocenę", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentID, subjectID))
                {
                    MessageBox.Show("Ocena została pomyślnie usunięta.", "Usuń ocenę", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewScoresList.DataSource = score.getStudentsScore();
                }
                else
                {
                    MessageBox.Show("Ocena nie została usunięta.", "Usuń ocenę", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        // Przycisk Odśwież.
        private void RefreshScoresButton_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT `id`, `imie`, `nazwisko` FROM `student`");

            dataGridViewStudentsList.DataSource = student.getStudents(command);

            dataGridViewScoresList.DataSource = score.getStudentsScore();
        }
    }
}
