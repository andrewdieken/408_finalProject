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
    public partial class EditMaxRecord : Form
    {
        public string stid;
        public string curr_year;
        public string curr_term;
        public string curr_bench;
        public string curr_clean;
        public string curr_squat;
        Form2 form2ref;
        public EditMaxRecord(Form2 form2)
        {
            InitializeComponent();

            this.form2ref = form2;

        }

        /*
         * Name: editMaxRecord
         * Runs query that updates MaxRecords table to values found in textboxes entered in by user
         */
        public void editMaxRecord(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand updateMaxRecordStatement = new MySqlCommand("START TRANSACTION; UPDATE maxrecords SET Year = @val1, Term = @val2, Bench = @val3, Clean = @val4, Squat = @val5 WHERE sid = @val6 AND Year = @val7 AND Term = @val8; COMMIT;", conn);

                updateMaxRecordStatement.Parameters.AddWithValue("@val1", year_label.Text);
                updateMaxRecordStatement.Parameters.AddWithValue("@val2", term_label.Text);
                updateMaxRecordStatement.Parameters.AddWithValue("@val3", bench_input.Text);
                updateMaxRecordStatement.Parameters.AddWithValue("@val4", clean_input.Text);
                updateMaxRecordStatement.Parameters.AddWithValue("@val5", squat_input.Text);
                updateMaxRecordStatement.Parameters.AddWithValue("@val6", sid);
                updateMaxRecordStatement.Parameters.AddWithValue("@val7", year_label.Text);
                updateMaxRecordStatement.Parameters.AddWithValue("@val8", term_label.Text);

                MySqlDataReader myReader;
                conn.Open();
                myReader = updateMaxRecordStatement.ExecuteReader();
                MessageBox.Show("Update Complete");
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
         * Name: confirmEdit_button_Click
         * When user clicks "confirm" button, editMaxRecord function gets called and which also gets run in Form2 to update MaxRecordGirdView
         * Form closes
         */
        private void confirmEdit_button_Click(object sender, EventArgs e)
        {
            editMaxRecord(stid);
            form2ref.getMaxRecords(stid);
            this.Close();
        }

        /*
         * When form is loaded, the labes and textboxes gets populated with values from Form2
         * Only 'bench', 'clean', & 'squat' are enabled to edit
         */
        private void EditMaxRecord_Load(object sender, EventArgs e)
        {
            year_label.Text = curr_year;
            term_label.Text = curr_term;
            bench_input.Text = curr_bench;
            clean_input.Text = curr_clean;
            squat_input.Text = curr_squat;
        }
    }
}
