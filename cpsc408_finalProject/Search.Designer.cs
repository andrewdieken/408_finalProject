namespace cpsc408_finalProject
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.search_for_input = new System.Windows.Forms.ComboBox();
            this.search_sign_input = new System.Windows.Forms.ComboBox();
            this.number_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_for_input
            // 
            this.search_for_input.FormattingEnabled = true;
            this.search_for_input.Items.AddRange(new object[] {
            "Bench",
            "Squat",
            "Clean",
            "Touchdowns",
            "Interceptions",
            "Sacks",
            "Tackles",
            "Yards"});
            this.search_for_input.Location = new System.Drawing.Point(6, 69);
            this.search_for_input.Name = "search_for_input";
            this.search_for_input.Size = new System.Drawing.Size(127, 28);
            this.search_for_input.TabIndex = 0;
            // 
            // search_sign_input
            // 
            this.search_sign_input.FormattingEnabled = true;
            this.search_sign_input.Items.AddRange(new object[] {
            ">",
            "<",
            "="});
            this.search_sign_input.Location = new System.Drawing.Point(6, 141);
            this.search_sign_input.Name = "search_sign_input";
            this.search_sign_input.Size = new System.Drawing.Size(70, 28);
            this.search_sign_input.TabIndex = 1;
            // 
            // number_input
            // 
            this.number_input.Location = new System.Drawing.Point(6, 212);
            this.number_input.Name = "number_input";
            this.number_input.Size = new System.Drawing.Size(127, 26);
            this.number_input.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEARCH BY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(393, 509);
            this.dataGridView1.TabIndex = 4;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(6, 287);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(178, 44);
            this.search_button.TabIndex = 5;
            this.search_button.Text = "SEARCH";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_for_input);
            this.groupBox1.Controls.Add(this.search_button);
            this.groupBox1.Controls.Add(this.search_sign_input);
            this.groupBox1.Controls.Add(this.number_input);
            this.groupBox1.Location = new System.Drawing.Point(42, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 337);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(611, 670);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Chapman Panthers";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 697);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox search_for_input;
        private System.Windows.Forms.ComboBox search_sign_input;
        private System.Windows.Forms.TextBox number_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
    }
}