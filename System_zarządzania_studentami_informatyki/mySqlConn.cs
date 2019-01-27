using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_zarządzania_studentami_informatyki
{
    class mySqlConn
    {
        // Połączenie z bazą danych
        // IP serwera; port; nazwa użytkownika; hasło; nazwa bazy danych

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=student_it_system");


        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        // Nawiązywanie połączenia z bazą danych.

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }

        // Zamykanie połączenia z bazą danych.

        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }

    }
}
