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
    public partial class Search : Form
    {
        Form1 form1Ref;
        int num;
        public Search(Form1 form1)
        {
            InitializeComponent();

            this.form1Ref = form1;

            number_input.Text = "Enter a number";
        }

        /*
         * Name: searchResults
         * 
         */
        public void searchResults()
        {
            num = Convert.ToInt32(number_input.Text);
            //search for bench
            if (search_for_input.Text == "Bench")
            {
                //search for '>'
                if (search_sign_input.Text == ">")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectStatement = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN maxrecords mr ON sa.StudentID = mr.sid WHERE Bench > @val1 GROUP BY StudentID;", conn);
                        selectStatement.Parameters.AddWithValue("@val1", number_input.Text);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("fail =");
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '<'
                else if (search_sign_input.Text == "<")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectStatement = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN maxrecords mr ON sa.StudentID = mr.sid WHERE Bench < @val1 GROUP BY StudentID;", conn);
                        selectStatement.Parameters.AddWithValue("@val1", number_input.Text);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("fail =");
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '='
                else if (search_sign_input.Text == "=")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectStatement = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN maxrecords mr ON sa.StudentID = mr.sid WHERE Bench = @val1 GROUP BY StudentID;", conn);
                        selectStatement.Parameters.AddWithValue("@val1", number_input.Text);
                        
                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("fail =");
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //search for squat
            else if (search_for_input.Text == "Squat")
            {
                //search for '>'
                if (search_sign_input.Text == ">")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectStatement = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN maxrecords mr ON sa.StudentID = mr.sid WHERE Squat > @val1 GROUP BY StudentID;", conn);
                        selectStatement.Parameters.AddWithValue("@val1", number_input.Text);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("fail =");
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '<'
                else if (search_sign_input.Text == "<")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectStatement = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN maxrecords mr ON sa.StudentID = mr.sid WHERE Squat < @val1 GROUP BY StudentID;", conn);
                        selectStatement.Parameters.AddWithValue("@val1", number_input.Text);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("fail =");
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '='
                else if (search_sign_input.Text == "=")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectStatement = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN maxrecords mr ON sa.StudentID = mr.sid WHERE Squat = @val1 GROUP BY StudentID;", conn);
                        selectStatement.Parameters.AddWithValue("@val1", number_input.Text);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("fail =");
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //search for clean
            else if (search_for_input.Text == "Clean")
            {

                //NOT WORKING???

                //search for '>'
                if (search_sign_input.Text == ">")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectStatement = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN maxrecords mr ON sa.StudentID = mr.sid WHERE Clean > @val1 GROUP BY StudentID;", conn);
                        selectStatement.Parameters.AddWithValue("@val1", number_input.Text);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("fail =");
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '<'
                else if (search_sign_input.Text == "<")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectStatement = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN maxrecords mr ON sa.StudentID = mr.sid WHERE Clean < @val1 GROUP BY StudentID;", conn);
                        selectStatement.Parameters.AddWithValue("@val1", number_input.Text);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("fail =");
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '='
                else if (search_sign_input.Text == "=")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectStatement = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN maxrecords mr ON sa.StudentID = mr.sid WHERE Clean = @val1 GROUP BY StudentID;", conn);
                        selectStatement.Parameters.AddWithValue("@val1", number_input.Text);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectStatement);

                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("fail =");
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //search for touchdowns
            else if (search_for_input.Text == "Touchdowns")
            {
                //search for '>'
                if (search_sign_input.Text == ">")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Touchdowns\") > @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '<'
                else if (search_sign_input.Text == "<")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Touchdowns\") < @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '='
                else if (search_sign_input.Text == "=")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Touchdowns\") = @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //search for interceptions
            else if (search_for_input.Text == "Interceptions")
            {
                //search for '>'
                if (search_sign_input.Text == ">")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Interceptions\") > @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '<'
                else if (search_sign_input.Text == "<")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Interceptions\") < @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '='
                else if (search_sign_input.Text == "=")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Interceptions\") = @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //search for sacks
            else if (search_for_input.Text == "Sacks")
            {
                //search for '>'
                if (search_sign_input.Text == ">")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Sacks\") > @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '<'
                else if (search_sign_input.Text == "<")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Sacks\") < @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '='
                else if (search_sign_input.Text == "=")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Sacks\") = @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //search for tackles
            else if (search_for_input.Text == "Tackles")
            {
                //search for '>'
                if (search_sign_input.Text == ">")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Tackles\") > @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '<'
                else if (search_sign_input.Text == "<")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Tackles\") < @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '='
                else if (search_sign_input.Text == "=")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Tackles\") = @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            //search for yards
            else if (search_for_input.Text == "Yards")
            {
                //search for '>'
                if (search_sign_input.Text == ">")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Yards\") > @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '<'
                else if (search_sign_input.Text == "<")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Yards\") < @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //search for '='
                else if (search_sign_input.Text == "=")
                {
                    try
                    {
                        string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                        MySqlConnection conn = new MySqlConnection(sqlConnString);
                        MySqlCommand selectTouchdowns = new MySqlCommand("SELECT sa.FirstName, sa.LastName FROM StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid WHERE JSON_EXTRACT(Stats, \"$.Yards\") = @val1;", conn);
                        selectTouchdowns.Parameters.AddWithValue("@val1", num);

                        DataTable ds = new DataTable();
                        MySqlDataAdapter myDa = new MySqlDataAdapter(selectTouchdowns);
                        myDa.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        /*
         * Name: search_button_Click
         * 
         */
        private void search_button_Click(object sender, EventArgs e)
        {
            searchResults();
        }

    }
}
