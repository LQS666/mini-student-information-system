using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace System_zarządzania_studentami_informatyki
{
    class Subjects
    {
        mySqlConn database = new mySqlConn();

        //  Dodawanie nowego przedmiotu do bazy danych MySQL.
        public bool insertSubject(string subjectName, string teacherName, string methodDone, string description)
        {

            MySqlCommand command = new MySqlCommand("INSERT INTO `subject`(`przedmiot`, `wykladowca`, `rodzaj_zajec`, `opis`) VALUES (@name,@tch,@met,@descr)", database.getConnection);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = subjectName;
            command.Parameters.Add("@tch", MySqlDbType.VarChar).Value = teacherName;
            command.Parameters.Add("@met", MySqlDbType.VarChar).Value = methodDone;
            command.Parameters.Add("@descr", MySqlDbType.VarChar).Value = description;

            database.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //  Aktualizowanie danych o wybranym przedmiocie (edycja).
        public bool updateSubject(int subjectID, string subjectName, string teacherName, string methodDone, string description)
        {

            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `przedmiot`=@name,`wykladowca`=@tch,`methodDone`=@met,`opis`=@descr WHERE `id` = @suid", database.getConnection);

            command.Parameters.Add("@suid", MySqlDbType.Int32).Value = subjectID;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = subjectName;
            command.Parameters.Add("@tch", MySqlDbType.VarChar).Value = teacherName;
            command.Parameters.Add("@met", MySqlDbType.VarChar).Value = methodDone;
            command.Parameters.Add("@descr", MySqlDbType.VarChar).Value = description;

            database.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //  Usuwanie przedmiotu.
        public bool deleteSubject(int subjectID)
        {

            MySqlCommand command = new MySqlCommand("DELETE FROM `subject` WHERE `id` = @SUID", database.getConnection);

            command.Parameters.Add("@SUID", MySqlDbType.Int32).Value = subjectID;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Sprawdzanie, czy dany przedmiot już istnieje w bazie danych.
        public bool checkSubjectName(string subjectName, int subjectId = 0)
        {
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM subject WHERE przedmiot=@sName And id <> @suID", database.getConnection);

            command.Parameters.Add("@sName", MySqlDbType.VarChar).Value = subjectName;
            command.Parameters.Add("@suID", MySqlDbType.Int32).Value = subjectId;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //  Pobieranie przedmiotów z bazy danych MySQL.
        public DataTable getAllSubjects()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM subject", database.getConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }


        //  Wyszukiwanie przedmiotu po numerze ID.
        public DataTable getSubjectById(int subjectID)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM subject WHERE id = @suid", database.getConnection);

            command.Parameters.Add("@suid", MySqlDbType.VarChar).Value = subjectID;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        //  Wysyłanie query do bazy danych.
        string execCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, database.getConnection);
            database.openConnection();
            String count = command.ExecuteScalar().ToString();
            database.closeConnection();
            return count;
        }

        //  Sprawdzanie ilości przedmiotów w bazie danych.
        public string totalSubjects()
        {
            return execCount("SELECT COUNT(*) FROM `subject`");
        }
    }
}
