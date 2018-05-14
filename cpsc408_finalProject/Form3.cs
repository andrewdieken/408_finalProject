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
    public partial class Form3 : Form
    {
        int newID;
        Form1 form1Ref;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;

            this.form1Ref = form1;
            
        }

        /*
        * Name: addStudentAthlete
        * 
        */
        public void addStudentAthlete()
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand insertStatement = new MySqlCommand("INSERT INTO StudentAthlete(FirstName, LastName, Status) VALUES(@val1, @val2, @val3);", conn);
                insertStatement.Parameters.AddWithValue("@val1", fName_input.Text);
                insertStatement.Parameters.AddWithValue("@val2", lName_input.Text);
                insertStatement.Parameters.AddWithValue("@val3", status_input.Text);
                MySqlDataReader myReader;
                conn.Open();
                myReader = insertStatement.ExecuteReader();
                while (myReader.Read())
                {
                }
                //don't think we need if statement becaue if statement goes through then there will always be a key to return
                if (insertStatement.LastInsertedId != null)
                {
                    insertStatement.Parameters.Add(new MySqlParameter("newID", insertStatement.LastInsertedId));
                }
                newID = Convert.ToInt32(insertStatement.Parameters["@newID"].Value);
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //add into positions
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand insertStatement = new MySqlCommand("INSERT INTO Positions(sid, Position) VALUES(@val1, @val2);", conn);
                insertStatement.Parameters.AddWithValue("@val1", newID);
                insertStatement.Parameters.AddWithValue("@val2", position_input.Text);

                MySqlDataReader myReader;
                conn.Open();
                myReader = insertStatement.ExecuteReader();
                while (myReader.Read())
                {
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //add into game stats
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand insertStatement = new MySqlCommand("INSERT INTO GameStats(sid, Stats) VALUES(@val1, '{\"Touchdowns\": 0, \"RushingYards\": 0, \"Receptions\": 0, \"Carries\": 0, \"Tackles\": 0, \"Sacks\": 0, \"Interceptions\": 0}' );", conn);
                insertStatement.Parameters.AddWithValue("@val1", newID);

                MySqlDataReader myReader;
                conn.Open();
                myReader = insertStatement.ExecuteReader();
                while (myReader.Read())
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
         * Name: add_button_Click
         * 
         */
        private void add_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(fName_input.Text) || String.IsNullOrWhiteSpace(lName_input.Text) || String.IsNullOrWhiteSpace(status_input.Text) || String.IsNullOrWhiteSpace(position_input.Text))
            {
                MessageBox.Show("All Fields Must be Filled");
            }
            else
            {
                addStudentAthlete();
                this.Close();
            }
        }
    }
}
