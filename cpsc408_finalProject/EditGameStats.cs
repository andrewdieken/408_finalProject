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
    public partial class EditGameStats : Form
    {
        Form2 form2Ref;
        public string stid;
        //set all game stats variables
        public string setTouchdowns;
        public string setYards;
        public string setReceptions;
        public string setCarries;
        public string setTackles;
        public string setSacks;
        public string setInterceptions;

        public EditGameStats(Form2 form2)
        {
            InitializeComponent();
            this.form2Ref = form2;
        }

        /*
         * Name: EditGameStats_Load
         * when form is loaded, all text boxs are populated with values gathered from Form2
         */
        private void EditGameStats_Load(object sender, EventArgs e)
        {
            touchdowns_input.Text = setTouchdowns;
            yards_input.Text = setYards;
            receptions_input.Text = setReceptions;
            carries_input.Text = setCarries;
            tackles_input.Text = setTackles;
            sacks_input.Text = setSacks;
            interceptions_input.Text = setInterceptions;
        }

        /*
         * Name: updateGameStats
         * Runs query which updates GameStats table with values entered into text boxes by user
         */
        public void updateGameStats(string sid)
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand updateGameStats = new MySqlCommand("START TRANSACTION; UPDATE GameStats SET Stats = JSON_SET(Stats, \"$.Touchdowns\", @val2, \"$.RushingYards\", @val3, \"$.Receptions\", @val4, \"$.Carries\", @val5, \"$.Tackles\", @val6, \"$.Sacks\", @val7, \"$.Interceptions\", @val8) WHERE sid = @val1; COMMIT;", conn);
                updateGameStats.Parameters.AddWithValue("@val1", sid);
                updateGameStats.Parameters.AddWithValue("@val2", Convert.ToInt32(touchdowns_input.Text));
                updateGameStats.Parameters.AddWithValue("@val3", Convert.ToInt32(yards_input.Text));
                updateGameStats.Parameters.AddWithValue("@val4", Convert.ToInt32(receptions_input.Text));
                updateGameStats.Parameters.AddWithValue("@val5", Convert.ToInt32(carries_input.Text));
                updateGameStats.Parameters.AddWithValue("@val6", Convert.ToInt32(tackles_input.Text));
                updateGameStats.Parameters.AddWithValue("@val7", Convert.ToInt32(sacks_input.Text));
                updateGameStats.Parameters.AddWithValue("@val8", Convert.ToInt32(interceptions_input.Text));
                MySqlDataReader myReaderStudentAthlete;
                conn.Open();
                myReaderStudentAthlete = updateGameStats.ExecuteReader();
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
         * Name: confirm_button_Click
         * When user clicks "confirm" button, updateGameStats function gets run and gamestats labels found on Form2 get updated
         */
        private void confirm_button_Click(object sender, EventArgs e)
        {
            updateGameStats(stid);
            form2Ref.getTouchdowns(stid);
            form2Ref.getRushingYards(stid);
            form2Ref.getReceptions(stid);
            form2Ref.getCarries(stid);
            form2Ref.getTackles(stid);
            form2Ref.getSacks(stid);
            form2Ref.getInterceptions(stid);
            this.Close();
        }

    }
}
