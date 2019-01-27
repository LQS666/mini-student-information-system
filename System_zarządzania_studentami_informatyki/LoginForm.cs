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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        

        // Funkcja logowania.
        // Po wpisaniu poprawnych danych pozwala przejść dalej.
        // Po wpisaniu błędnych danych wyświetla odpowiedni komunikat.

        private void loginButton_Click(object sender, EventArgs e)
        {
            mySqlConn db = new mySqlConn();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn AND `password` = @pass", db.getConnection);

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nieprawidłowa nazwa użytkownika lub hasło. Wpisz poprawne dane.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funkcja odpowiadająca za zamykanie aplikacji po naciśnięciu "X".
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
