using MySql.Data.MySqlClient;
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
    public partial class ListStudentWindow : Form
    {
        public ListStudentWindow()
        {
            InitializeComponent();
        }

        Students student = new Students();

        // Funkcja obsługująca listę użytkowników (datagridview).
        private void ListStudentWindow_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");

            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 80;
            
            dataGridView1.DataSource = student.getStudents(command);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];

            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;

            StudentsCounter_Click.Text = ("Liczba wszystkich studentów: " + dataGridView1.Rows.Count);
        }

        // Przycisk Odśwież.
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`");

            dataGridView1.DataSource = student.getStudents(command);

            StudentsCounter_Click.Text = ("Liczba wszystkich studentów: " + dataGridView1.Rows.Count);
        }
    }
}
