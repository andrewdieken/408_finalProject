using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cpsc408_finalProject
{
    public partial class Form2 : Form
    {
        public string stid;
        public string curr_year;
        public string curr_term;
        public string curr_bench;
        public string curr_clean;
        public string curr_squat;

        //set all game stats variables 
        public string setTouchdowns;
        public string setYards;
        public string setReceptions;
        public string setCarries;
        public string setTackles;
        public string setSacks;
        public string setInterceptions;

        AddMaxRecordForm addmaxrecform;
        EditMaxRecord editmaxrecform;
        EditGameStats editgamestatsform;
        Form1 form1Ref;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            this.addmaxrecform = new AddMaxRecordForm(this);
            this.editmaxrecform = new EditMaxRecord(this);
            this.editgamestatsform = new EditGameStats(this);

            this.form1Ref = form1;
            statusDisplayOption_input.Text = "Active";
            getActiveStudents();
        }

        /*
         * Name: getActiveStudents
         * Runs query which returns all stuent athletes where Status = 'Active'
         * Populates dataGridView1 with results
         */
        public void getActiveStudents()
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectStatement = new MySqlCommand("SELECT a.*, p.Position from studentathlete a join positions p on a.StudentID = p.sid WHERE a.Status = 'Active' order by StudentID; ", conn);

                DataTable ds = new DataTable();
                MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                myDa.Fill(ds);

                dataGridView1.DataSource = ds;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: getInactiveStudents
         * Runs query which returns all student athletes where Status = 'Inactive'
         * Populates dataGridView1 with results
         */
        public void getInactiveStudents()
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectStatement = new MySqlCommand("SELECT a.*, p.Position from studentathlete a join positions p on a.StudentID = p.sid WHERE a.Status = 'Inactive' order by StudentID; ", conn);

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

        /*
         * Name: getMaxRecords
         * Runs query which returns all max records from athlete specified by user
         * @param sid : returned when user selects student athlete
         */
        public void getMaxRecords(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectStatement = new MySqlCommand("SELECT m.* FROM MaxRecords m WHERE sid = @val1; ", conn);
                selectStatement.Parameters.AddWithValue("@val1", sid);

                DataTable ds = new DataTable();
                MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                myDa.Fill(ds);

                dataGridView2.DataSource = ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: getTouchdowns 
         * Runs query which selects touchdowns from GameStats table
         * @param sid : returned when user selects student athlete
         */
        public void getTouchdowns(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectTouchdowns = new MySqlCommand("SELECT Stats->\"$.Touchdowns\" FROM gamestats WHERE sid = @val1", conn);

                selectTouchdowns.Parameters.AddWithValue("@val1", sid);

                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectTouchdowns);
                adpt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    setTouchdowns = row.Field<string>(0);
                    touchdown_label.Text = setTouchdowns;
                    editgamestatsform.setTouchdowns = setTouchdowns;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: getRushingYards
         * Runs query which selects RushingYards from GameStats table
         * @param sid : returned when user selects student athlete
         */
        public void getRushingYards(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectTouchdowns = new MySqlCommand("SELECT Stats->\"$.RushingYards\" FROM gamestats WHERE sid = @val1", conn);

                selectTouchdowns.Parameters.AddWithValue("@val1", sid);

                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectTouchdowns);
                adpt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    setYards = row.Field<string>(0);
                    rushingyards_label.Text = setYards;
                    editgamestatsform.setYards = setYards;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: getReceptions
         * Runs query which selects recpetions from GameStats table
         * @param sid : returned when user selects student athlete
         */
        public void getReceptions(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectTouchdowns = new MySqlCommand("SELECT Stats->\"$.Receptions\" FROM gamestats WHERE sid = @val1", conn);

                selectTouchdowns.Parameters.AddWithValue("@val1", sid);

                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectTouchdowns);
                adpt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    setReceptions = row.Field<string>(0);
                    receptions_label.Text = setReceptions;
                    editgamestatsform.setReceptions = setReceptions;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: getCarries
         * Runs query which selects carries from GameStats table
         * @param sid : returned when user selects student athlete
         */
        public void getCarries(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectTouchdowns = new MySqlCommand("SELECT Stats->\"$.Carries\" FROM gamestats WHERE sid = @val1", conn);

                selectTouchdowns.Parameters.AddWithValue("@val1", sid);

                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectTouchdowns);
                adpt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    setCarries = row.Field<string>(0);
                    carries_label.Text = setCarries;
                    editgamestatsform.setCarries = setCarries;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: getTackles
         * Runs query which selects tackles from GameStats table
         * @param sid : returned when user selects student athlete
         */
        public void getTackles(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectTouchdowns = new MySqlCommand("SELECT Stats->\"$.Tackles\" FROM gamestats WHERE sid = @val1", conn);

                selectTouchdowns.Parameters.AddWithValue("@val1", sid);

                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectTouchdowns);
                adpt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    setTackles = row.Field<string>(0);
                    tackle_label.Text = setTackles;
                    editgamestatsform.setTackles = setTackles;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: getSacks 
         * Runs query which selects sacks from GameStats table
         * @param sid : returned when user selects student athlete
         */
        public void getSacks(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectTouchdowns = new MySqlCommand("SELECT Stats->\"$.Sacks\" FROM gamestats WHERE sid = @val1", conn);

                selectTouchdowns.Parameters.AddWithValue("@val1", sid);

                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectTouchdowns);
                adpt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    setSacks = row.Field<string>(0);
                    sacks_label.Text = setSacks;
                    editgamestatsform.setSacks = setSacks;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: getInterceptions
         * Runs query which selects interceptions from GameStats table
         * @param sid : returned when user selects student athlete
         */
        public void getInterceptions(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectTouchdowns = new MySqlCommand("SELECT Stats->\"$.Interceptions\" FROM gamestats WHERE sid = @val1", conn);

                selectTouchdowns.Parameters.AddWithValue("@val1", sid);

                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectTouchdowns);
                adpt.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    setInterceptions = row.Field<string>(0);
                    interceptions_label.Text = setInterceptions;
                    editgamestatsform.setInterceptions = setInterceptions;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: dataGridView1_CellContentClick
         * When user selects a student athlete from dataGridView1, 
         * * fname label gets populated from selected athlete
         * * lname label gets populated from selected athlete
         * * status combo box gets populated from selected athlete
         * * position gets populated from selected athlete
         * * stid gets set to StudentID from selected athlete in current Form, addmaxrecform, editmaxrecform, and editgamestatsform
         * * getMaxRecords, getTouchDowns, getRushingYards, getReceptions, getCarries, getTackles, getSacks, getInterceptions functions get run
         */
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string fname = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string lname = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string status = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                stid = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                addmaxrecform.stid = stid;
                editmaxrecform.stid = stid;
                editgamestatsform.stid = stid;
                string position = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;


                fname_label.Text = fname;
                lname_label.Text = lname;
                stid_label.Text = stid;
                position_label.Text = position;
                status_input.Text = status;
                

                getMaxRecords(stid);
                getTouchdowns(stid);
                getRushingYards(stid);
                getReceptions(stid);
                getCarries(stid);
                getTackles(stid);
                getSacks(stid);
                getInterceptions(stid);
            }
        }

        /*
         * Name: dataGridView2_CellContentClick
         * When user selects a max record from dataGridView2
         * * year, term, bench, clean, & squat get set to be accessed in editmaxrecform 
         */
        private void dataGridView2_CellContentClick(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                curr_year = dataGridView2.SelectedRows[0].Cells[1].Value + string.Empty;
                curr_term = dataGridView2.SelectedRows[0].Cells[2].Value + string.Empty;
                curr_bench = dataGridView2.SelectedRows[0].Cells[3].Value + string.Empty;
                curr_clean = dataGridView2.SelectedRows[0].Cells[4].Value + string.Empty;
                curr_squat = dataGridView2.SelectedRows[0].Cells[5].Value + string.Empty;

                //set variables to be accessed in editmaxrecordform
                editmaxrecform.curr_year = curr_year;
                editmaxrecform.curr_term = curr_term;
                editmaxrecform.curr_bench = curr_bench;
                editmaxrecform.curr_clean = curr_clean;
                editmaxrecform.curr_squat = curr_squat;
            }

        }

        /*
         *Name: addMax_button_Click
         * When 'Add' button gets clicked next to dataGridView2, addmaxrecform opens 
         */
        private void addMax_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                addmaxrecform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Must select an athlete to add a record");
            }
        }

        /*
         * Name: editMax_button_Click 
         * When 'Edit' button gets clicked next to dataGridView2, editmaxrecform opens
         */
        private void editMax_button_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                editmaxrecform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Must select a record to edit");
            }
        }

        /*
         * Name: editStat_button_Click
         * When 'Edit' button gets clicked next to game stats box, editgamestatsform opens
         */
        private void editStat_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editgamestatsform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Must select an athlete to edit");
            }
        }

        /*
         * Name: setStatus_button_Click
         * When user clicks 'OK' button when an athlete status is changed a query is run to update StudentAthlete table with new status
         * If status is chagned to 'Active' then getActiveStudents function is called
         * If staus is changed to 'Inactive' then getInactiveStudents function is called
         */
        private void setStatus_button_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand updateStatusStatement = new MySqlCommand("UPDATE StudentAthlete SET Status = @val1 WHERE StudentID = @val2", conn);

                updateStatusStatement.Parameters.AddWithValue("@val1", status_input.Text);
                updateStatusStatement.Parameters.AddWithValue("@val2", stid.ToString());

                MySqlDataReader myReader;
                conn.Open();
                myReader = updateStatusStatement.ExecuteReader();
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

            //refresh datagridview1
            if (statusDisplayOption_input.Text == "Active")
            {
                getActiveStudents();
            }
            else if (statusDisplayOption_input.Text == "Inactive")
            {
                getInactiveStudents();
            }
            
        }

        /*
         * Name: ok_displayAll_button_Click
         * When 'OK' button is clicked after show status is changed, either getActiveStudents or getInactiveStudents function is run
         */
        private void ok_displayAll_button_Click(object sender, EventArgs e)
        {
            if (statusDisplayOption_input.Text == "Active")
            {
                getActiveStudents();
            }
            else if (statusDisplayOption_input.Text == "Inactive")
            {
                getInactiveStudents();
            }
        }


    }
}
