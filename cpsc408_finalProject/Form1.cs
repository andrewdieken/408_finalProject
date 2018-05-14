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
    public partial class Form1 : Form
    {

        Form2 form2;
        Form3 form3;
        DeleteForm deleteform;
        Search searchform;
        ReportsForm reportsform;

        public Form1()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            this.form2 = new Form2(this);
            this.form3 = new Form3(this);
            this.deleteform = new DeleteForm(this);
            this.searchform = new Search(this);
            this.reportsform = new ReportsForm(this);
        }

        /*
         * Name: viewAll_button_Click
         * When 'View All' button is clicked, Form2 is loaded and getActiveStudents function is run
         */
        private void viewAll_button_Click(object sender, EventArgs e)
        {
            form2.getActiveStudents();
            form2.ShowDialog();
        }

        /*
         * Name: addAthlete_button_Click
         * When 'Add Athlete' button is clicked, Form3 is loaded 
         */
        private void addAthlete_button_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

        /*
         * Name: delete_button_Click 
         * When 'Delete' is clicked, deleteForm is loaded
         */
        private void delete_button_Click(object sender, EventArgs e)
        {
            deleteform.ShowDialog();
        }

        /*
         * Name: search_button_Click
         * When 'Search' button is clicked, searchForm is loaded
         */
        private void search_button_Click(object sender, EventArgs e)
        {
            searchform.ShowDialog();
        }

        /*
         * Name: reports_button_Click
         * When 'Reports' button is clicked, reportsForm is loaded
         */
        private void reports_button_Click(object sender, EventArgs e)
        {
            reportsform.ShowDialog();
        }
    }
}
