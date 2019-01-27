using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace System_zarządzania_studentami_informatyki
{
    class Students
    {
        mySqlConn database = new mySqlConn();


        //  Dodawanie nowego studenta do bazy danych MySQL
        public bool insertStudent(string imie, string nazwisko, DateTime dataUrodzenia, string plec, string telefon, string miasto, string kraj, MemoryStream zdjecieStudenta)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`imie`, `nazwisko`, `dataUrodzenia`,`plec`, `telefon`, `miasto`, `kraj`, `zdjecieStudenta`)" +
                " VALUES (@fn, @ln, @bdt, @gdr, @phn, @adrs, @adrs2, @pic)", database.getConnection);

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = imie;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = nazwisko;
            command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = dataUrodzenia;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = plec;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = telefon;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = miasto;
            command.Parameters.Add("@adrs2", MySqlDbType.VarChar).Value = kraj;
            command.Parameters.Add("@pic", MySqlDbType.Blob).Value = zdjecieStudenta.ToArray();

            database.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                database.closeConnection();
                return true;
            }
            else
            {
                database.closeConnection();
                return false;
            }
        }

        // Pobieranie studentów z bazy danych MySQL
        public DataTable getStudents(MySqlCommand command)
        {
            command.Connection = database.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Usuwanie studenta
        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `id` = @studentID", database.getConnection);
            command.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id;
            database.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                database.closeConnection();
                return true;
            }
            else
            {
                database.closeConnection();
                return false;
            }

        }

        //  Aktualizowanie danych o wybranym studencie (edycja)
        public bool updateStudent(int id, string imie, string nazwisko, DateTime dataUrodzenia, string plec, string telefon, string miasto, string kraj, MemoryStream zdjecieStudenta)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `imie`=@fn,`nazwisko`=@ln,`dataUrodzenia`=@bdt,`plec`=@gdr,`telefon`=@phn,`miasto`=@adrs,`kraj`=@adrs2,`zdjecieStudenta`=@pic WHERE id=@ID", database.getConnection);

            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = imie;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = nazwisko;
            command.Parameters.Add("@bdt", MySqlDbType.DateTime).Value = dataUrodzenia;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = plec;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = telefon;
            command.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = miasto;
            command.Parameters.Add("@adrs2", MySqlDbType.VarChar).Value = kraj;
            command.Parameters.Add("@pic", MySqlDbType.Blob).Value = zdjecieStudenta.ToArray();

            database.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                database.closeConnection();
                return true;
            }
            else
            {
                database.closeConnection();
                return false;
            }

        }

        //  Wysyłanie query do bazy danych
        string execCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, database.getConnection);
            database.openConnection();

            String count = command.ExecuteScalar().ToString();
            database.closeConnection();

            return count;
        }
    }
}
