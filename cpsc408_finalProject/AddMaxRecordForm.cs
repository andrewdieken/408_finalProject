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
    public partial class AddMaxRecordForm : Form
    {
        public string stid;
        Form2 form2ref;
        public AddMaxRecordForm(Form2 form2)
        {
            InitializeComponent();

            this.form2ref = form2;
        }

        /*
         * Name: insertMaxRecords 
         * Runs insert statement into MaxRecords table with information from user 
         */
        public void insertMaxRecord(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand insertStatement = new MySqlCommand("INSERT INTO MaxRecords(sid, Year, Term, Bench, Clean, Squat) VALUES(@val1,@val2,@val3,@val4,@val5,@val6);", conn);
                insertStatement.Parameters.AddWithValue("@val1", sid);
                insertStatement.Parameters.AddWithValue("@val2", year_input.Text);
                insertStatement.Parameters.AddWithValue("@val3", term_input.Text);
                insertStatement.Parameters.AddWithValue("@val4", bench_input.Text);
                insertStatement.Parameters.AddWithValue("@val5", clean_input.Text);
                insertStatement.Parameters.AddWithValue("@val6", squat_input.Text);
                MySqlDataReader myReader;
                conn.Open();
                myReader = insertStatement.ExecuteReader();
                MessageBox.Show("Data Saved");
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
        * Name: addRecord_button_click 
        * function checks all text boxes to ensure user has filled in all necessary fields
        */
        private void addRecord_button_Click(object sender, EventArgs e)
        {
            if (year_input.Text == "")
                MessageBox.Show("all fields must be filled in");
            else if (term_input.Text == "")
                MessageBox.Show("all fields must be filled in");
            else if (bench_input.Text == "")
                MessageBox.Show("all fields must be filled in");
            else if (clean_input.Text == "")
                MessageBox.Show("all fields must be filled in");
            else if (squat_input.Text == "")
                MessageBox.Show("all fields must be filled in");
            else
            {
                insertMaxRecord(stid);
                form2ref.getMaxRecords(stid);
                year_input.Clear();
                bench_input.Clear();
                squat_input.Clear();
                clean_input.Clear();
                this.Close();
            }

        }
    }

}
