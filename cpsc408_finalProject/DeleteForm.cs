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

namespace cpsc408_finalProject
{
    public partial class DeleteForm : Form
    {
        public bool buttonWasClicked = false;
        Form1 form1Ref;
        public DeleteForm(Form1 form1)
        {
            InitializeComponent();
            this.form1Ref = form1;
        }

        /*
        * Name: searchAthlete 
        * Checks to make sure users has entered info into at least one field
        * If user enters an ID, query is run to return all inform from all tables where the StudentID = input
        * If user enters first name, query is run to return all info from all tables where FirstName = input 
        * If user enters last name, query is run to return all info from all tables where LastName = input
        * If user enters both first and last name, query is run to return all info from all tables where FirstName & LastName = input
        * If user enters all fields, query is run to return all info from all tables where StudentID = input
        */
        public void searchAthlete()
        {
            string firstName = fname_input.Text;
            string lastName = lname_input.Text;
            string stid = sid_input.Text;

            //is there at least one box filled 
            if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName) && String.IsNullOrWhiteSpace(stid))
            {
                MessageBox.Show("At least one input field must be filled");
            }
            //is student id box filled
            if (!String.IsNullOrWhiteSpace(stid))
            {
                try
                {
                    string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                    MySqlConnection conn = new MySqlConnection(sqlConnString);
                    MySqlCommand selectStatement = new MySqlCommand("SELECT sa.*, mr.Year, mr.Term, mr.Bench, mr.Clean, mr.Squat, gs.Stats, p.Position FROM StudentAthlete sa LEFT JOIN maxrecords mr ON sa.StudentID = mr.sid LEFT JOIN gamestats gs ON sa.StudentID = gs.sid LEFT JOIN positions p ON sa.StudentID = p.sid WHERE sa.StudentID = @val1 GROUP BY StudentID", conn);
                    selectStatement.Parameters.AddWithValue("@val1", stid);

                    DataTable ds = new DataTable();
                    MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                    myDa.Fill(ds);

                    dataGridView1.DataSource = ds;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //checks if first name and last name boxes are filled
            else if (!String.IsNullOrWhiteSpace(firstName) && !String.IsNullOrWhiteSpace(lastName))
            {
                try
                {
                    string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                    MySqlConnection conn = new MySqlConnection(sqlConnString);
                    MySqlCommand selectStatement = new MySqlCommand("SELECT sa.*, mr.Year, mr.Term, mr.Bench, mr.Clean, mr.Squat, gs.Stats, p.Position FROM StudentAthlete sa LEFT JOIN maxrecords mr ON sa.StudentID = mr.sid LEFT JOIN gamestats gs ON sa.StudentID = gs.sid LEFT JOIN positions p ON sa.StudentID = p.sid WHERE sa.FirstName = @val1, sa.LastName = @val2 GROUP BY StudentID", conn);
                    selectStatement.Parameters.AddWithValue("@val1", firstName);
                    selectStatement.Parameters.AddWithValue("@val2", lastName);

                    DataTable ds = new DataTable();
                    MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                    myDa.Fill(ds);

                    dataGridView1.DataSource = ds;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //check if first name box is filled
            else if (!String.IsNullOrWhiteSpace(firstName))
            {
                try
                {
                    string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                    MySqlConnection conn = new MySqlConnection(sqlConnString);
                    MySqlCommand selectStatement = new MySqlCommand("SELECT sa.*, mr.Year, mr.Term, mr.Bench, mr.Clean, mr.Squat, gs.Stats, p.Position FROM StudentAthlete sa LEFT JOIN maxrecords mr ON sa.StudentID = mr.sid LEFT JOIN gamestats gs ON sa.StudentID = gs.sid LEFT JOIN positions p ON sa.StudentID = p.sid WHERE sa.FirstName = @val1 GROUP BY StudentID", conn);
                    selectStatement.Parameters.AddWithValue("@val1", firstName);

                    DataTable ds = new DataTable();
                    MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                    myDa.Fill(ds);

                    dataGridView1.DataSource = ds;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //check if last name box is filled
            else if (!String.IsNullOrWhiteSpace(lastName))
            {
                try
                {
                    string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                    MySqlConnection conn = new MySqlConnection(sqlConnString);
                    MySqlCommand selectStatement = new MySqlCommand("SELECT sa.*, mr.Year, mr.Term, mr.Bench, mr.Clean, mr.Squat, gs.Stats, p.Position FROM StudentAthlete sa LEFT JOIN maxrecords mr ON sa.StudentID = mr.sid LEFT JOIN gamestats gs ON sa.StudentID = gs.sid LEFT JOIN positions p ON sa.StudentID = p.sid WHERE sa.LastName = @val1 GROUP BY StudentID", conn);
                    selectStatement.Parameters.AddWithValue("@val1", lastName);

                    DataTable ds = new DataTable();
                    MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                    myDa.Fill(ds);

                    dataGridView1.DataSource = ds;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /*
        * Name: deletePosition 
        * Deletes all records from Positions table where sid = input
        */
        public void deletePosition(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand deletePositionStatement = new MySqlCommand("DELETE FROM Positions WHERE sid = @val1", conn);
                deletePositionStatement.Parameters.AddWithValue("@val1", sid);
                MySqlDataReader myReaderPositions;
                conn.Open();
                myReaderPositions = deletePositionStatement.ExecuteReader();
                while (myReaderPositions.Read())
                {
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: deleteGameStats
         * Deletes student athlete record from GameStats table where sid = input
         */
        public void deleteGameStats(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand deleteGameStatsStatement = new MySqlCommand("DELETE FROM GameStats WHERE sid = @val2", conn);
                deleteGameStatsStatement.Parameters.AddWithValue("@val2", sid);
                MySqlDataReader myReaderGameStats;
                conn.Open();
                myReaderGameStats = deleteGameStatsStatement.ExecuteReader();
                while (myReaderGameStats.Read())
                {
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: deleteMaxRecords
         * Deletes all records from MaxRecords table where sid = input
         */
        public void deleteMaxRecords(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand deleteMaxRecordsStatement = new MySqlCommand("DELETE FROM MaxRecords WHERE sid = @val3", conn);
                deleteMaxRecordsStatement.Parameters.AddWithValue("@val3", sid);
                MySqlDataReader myReaderMaxRecords;
                conn.Open();
                myReaderMaxRecords = deleteMaxRecordsStatement.ExecuteReader();
                while (myReaderMaxRecords.Read())
                {
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //delete from stuent athlete table
        /*
         * Name: deleteAthlete
         * Deletes athlete receord from StudentAthlete table where StudentID = input
         */
        public void deleteAthlete(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand deleteStudentAthleteStatement = new MySqlCommand("DELETE FROM StudentAthlete WHERE StudentID = @val4", conn);
                deleteStudentAthleteStatement.Parameters.AddWithValue("@val4", sid);
                MySqlDataReader myReaderStudentAthlete;
                conn.Open();
                myReaderStudentAthlete = deleteStudentAthleteStatement.ExecuteReader();
                while (myReaderStudentAthlete.Read())
                {
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: search_button_Click
         * when users clicks "search" button, searchAthlete function gets run
         */
        private void search_button_Click(object sender, EventArgs e)
        {
            searchAthlete();
        }

        /*
         *Name: delete_button_Click
         * When user clicks "delete" button, deletePosition, deleteGameStats, deleteMaxRecords, deleteAthlete, and searchAthlete gets run
         */
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string stid = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;

                deletePosition(stid);
                deleteGameStats(stid);
                deleteMaxRecords(stid);
                deleteAthlete(stid);
                MessageBox.Show("All Records Deleted");
                //updates datagridview with records deleted
                searchAthlete();
            }
        }
    }
}
