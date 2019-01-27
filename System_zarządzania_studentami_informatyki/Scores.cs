using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace System_zarządzania_studentami_informatyki
{
    class Scores
    {
        mySqlConn database = new mySqlConn();


        //  Dodawanie nowej oceny do bazy danych MySQL.
        public bool insertScore(int studentID, int subjectID, double scoreValue)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`student_id`, `subject_id`, `student_score`) VALUES (@sid,@suid,@scr)", database.getConnection);

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentID;
            command.Parameters.Add("@suid", MySqlDbType.Int32).Value = subjectID;
            command.Parameters.Add("@scr", MySqlDbType.Double).Value = scoreValue;

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

        //  Funkcja sprawdza, czy ocena została już przypisana w danym przedmiocie.
        public bool studentScoreExist(int studentID, int subjectID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `student_id` = @sid AND `subject_id` = @suid", database.getConnection);

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentID;
            command.Parameters.Add("@suid", MySqlDbType.Int32).Value = subjectID;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        

        public DataTable getStudentsScore()
        {
            MySqlCommand command = new MySqlCommand();

            command.Connection = database.getConnection;
            command.CommandText = ("SELECT SCORE.student_id, STUDENT.imie, STUDENT.nazwisko, SCORE.subject_id, SUBJECT.przedmiot, SCORE." +
            "student_score FROM STUDENT INNER JOIN score on student.id = score.student_id INNER JOIN subject on score.subject_id = subject.id");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        
        public DataTable getSubjectScores(int subjectID)
        {
            MySqlCommand command = new MySqlCommand();

            command.Connection = database.getConnection;
            command.CommandText = ("SELECT SCORE.student_id, STUDENT.imie, STUDENT.nazwisko, SCORE.subject_id, SUBJECT.przedmiot, SCORE." +
            "student_score FROM STUDENT INNER JOIN score on student.id = score.student_id INNER JOIN subject on score.subject_id = subject.id WHERE score.subject_id = " + subjectID);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        

        public DataTable getStudentScores(int studentID)
        {
            MySqlCommand command = new MySqlCommand();

            command.Connection = database.getConnection;
            command.CommandText = ("SELECT SCORE.student_id, STUDENT.imie, STUDENT.nazwisko, SCORE.subject_id, SUBJECT.przedmiot, SCORE." +
            "student_score FROM STUDENT INNER JOIN score on student.id = score.student_id INNER JOIN subject on score.subject_id = subject.id WHERE score.student_id = " + studentID);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }


        //  Usuwanie ocen.
        public bool deleteScore(int studentID, int subjectID)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `student_id` = @sid AND subject_id = @suid", database.getConnection);

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentID;
            command.Parameters.Add("@suid", MySqlDbType.Int32).Value = subjectID;

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
    }
}
