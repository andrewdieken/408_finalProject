using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cpsc408_finalProject
{
    public partial class ReportsForm : Form
    {
        Form1 form1Ref;
        public ReportsForm(Form1 form1)
        {
            InitializeComponent();
            this.form1Ref = form1;
        }

        /*
         * Name: ThousandLBClubReport
         * 
         */
        public void ThousandLBClubReport()
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectRecords = new MySqlCommand("SELECT sub1.FirstName, sub1.LastName, v.Year, (v.Bench + v.Squat + v.Clean) Total FROM(SELECT * FROM StudentAthlete WHERE Status = 'Active') sub1 JOIN v ON sub1.StudentID = v.sid WHERE((Bench + Squat + Clean) > 1000) AND v.Year = @val1 GROUP BY sub1.StudentID ORDER BY v.Year, Total DESC; ", conn);
                selectRecords.Parameters.AddWithValue("@val1", year_input.Text);
                //fill data table with query results
                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectRecords);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        /*
         *Name: maxBenchRecordReport
         * 
         */
        public void maxBenchRecordReport()
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectRecords = new MySqlCommand("SELECT sa.FirstName, sa.LastName, v.Bench FROM StudentAthlete sa JOIN v ON sa.StudentID = v.sid WHERE Year = @val1 ORDER BY v.Bench DESC; ", conn);
                selectRecords.Parameters.AddWithValue("@val1", year_input.Text);
                //fill data table with query results
                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectRecords);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
        /*
         *Name: maxSquatRecrdReport
         * 
         */
        public void maxSquatRecordReport()
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectRecords = new MySqlCommand("SELECT sa.FirstName, sa.LastName, v.Squat FROM StudentAthlete sa JOIN v ON sa.StudentID = v.sid WHERE Year = @val1 ORDER BY v.Squat DESC;", conn);
                selectRecords.Parameters.AddWithValue("@val1", year_input.Text);
                //fill data table with query results
                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectRecords);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        /*
         * Name: maxCleanReport
         * 
         */
        public void maxCleanRecordReport()
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectRecords = new MySqlCommand("SELECT sa.FirstName, sa.LastName, v.Clean FROM StudentAthlete sa JOIN v ON sa.StudentID = v.sid WHERE Year = @val1 ORDER BY v.Clean DESC; ", conn);
                selectRecords.Parameters.AddWithValue("@val1", year_input.Text);
                //fill data table with query results
                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectRecords);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: generateAll
         * 
         */
        public void generateAll()
        {
            try
            {
                string sqlConnString = "server=127.0.0.1;uid=andrewdieken;pwd=HelpJeep97;database=cpsc408_final";
                MySqlConnection conn = new MySqlConnection(sqlConnString);
                MySqlCommand selectAll = new MySqlCommand("select sa.*, P.Position, Stats->\"$.Sacks\" AS Sacks, Stats->\"$.Carries\" AS Carries, Stats->\"$.Tackles\" AS Tackles, Stats->\"$.Receptions\" AS Receptions, Stats->\"$.Touchdowns\" AS Touchdown, Stats->\"$.RushingYards\" AS RushingYards, Stats->\"$.Interceptions\" AS Interceptions from StudentAthlete sa JOIN GameStats S ON sa.StudentID = S.sid JOIN Positions P ON sa.StudentID = P.sid;", conn);
                //fill data table with query results
                DataTable dt = new DataTable();
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectAll);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * Name: lbClub_button_Click
         * 
         */
        private void lbClub_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(year_input.Text))
            {
                MessageBox.Show("Please Enter a Year");
            }
            else
            {
                ThousandLBClubReport();
            }
        }

        /*
         * Name: generate_all_button_Click
         * 
         */
        private void generate_all_button_Click(object sender, EventArgs e)
        {
            generateAll();
        }

        /*
         * Name: max_bench_button_Click
         * 
         */
        private void max_bench_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(year_input.Text))
            {
                MessageBox.Show("Please Enter a Year");
            }
            else
            {
                maxBenchRecordReport();
            }
        }

        /*
         * Name: max_clean_button_Click
         * 
         */
        private void max_clean_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(year_input.Text))
            {
                MessageBox.Show("Please Enter a Year");
            }
            else
            {
                maxCleanRecordReport();
            }
        }

        /*
         * Name: max_squat_button_Click
         * 
         */
        private void max_squat_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(year_input.Text))
            {
                MessageBox.Show("Please Enter a Year");
            }
            else
            {
                maxSquatRecordReport();
            }
        }

        /*
         *Name: export_button_Click
         * 
         */
        private void export_button_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                workbook.SaveAs("Report.csv");
                MessageBox.Show("Export Successful");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

    }
}
