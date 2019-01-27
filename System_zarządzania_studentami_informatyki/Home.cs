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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        // Przycisk Strona główna.
        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            userControlHome1.BringToFront();
        }

        // Przycisk Info.
        private void InfoButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = InfoButton.Height;
            SidePanel.Top = InfoButton.Top;
            userControlInfo1.BringToFront();
        }

        // Przycisk Dodaj studenta.
        private void addNewStudentButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = addNewStudentButton.Height;
            SidePanel.Top = addNewStudentButton.Top;
            AddStudentWindow addStdF = new AddStudentWindow();
            addStdF.Show(this);
        }

        // Przycisk Edytuj studenta.
        private void editStudentButton_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = editStudentButton.Height;
            SidePanel.Top = editStudentButton.Top;
            EditStudentWindow addStdF = new EditStudentWindow();
            addStdF.Show(this);
        }

        // Przycisk Lista studentów.
        private void listStudentsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = listStudentsButton.Height;
            SidePanel.Top = listStudentsButton.Top;
            ListStudentWindow addStdF = new ListStudentWindow();
            addStdF.Show(this);
        }

        // Przycisk Dodaj przedmiot.
        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = addSubjectButton.Height;
            SidePanel.Top = addSubjectButton.Top;
            AddSubjectWindow addStdF = new AddSubjectWindow();
            addStdF.Show(this);
        }

        // Przycisk Przedmioty.
        private void listSubjectsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = listSubjectsButton.Height;
            SidePanel.Top = listSubjectsButton.Top;
            EditSubjectWindow addStdF = new EditSubjectWindow();
            addStdF.Show(this);
        }

        // Przycisk Pokaż oceny.
        private void listScoresButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = listScoresButton.Height;
            SidePanel.Top = listScoresButton.Top;
            ScoresWindow addStdF = new ScoresWindow();
            addStdF.Show(this);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            userControlHome1.BringToFront();
        }
    }
}
