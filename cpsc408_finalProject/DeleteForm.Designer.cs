namespace cpsc408_finalProject
{
    partial class DeleteForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.fname_input = new System.Windows.Forms.TextBox();
            this.lname_input = new System.Windows.Forms.TextBox();
            this.sid_input = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(780, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete an Athlete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student Athlete ID";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(314, 190);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(187, 43);
            this.search_button.TabIndex = 5;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // fname_input
            // 
            this.fname_input.Location = new System.Drawing.Point(49, 107);
            this.fname_input.Name = "fname_input";
            this.fname_input.Size = new System.Drawing.Size(143, 26);
            this.fname_input.TabIndex = 6;
            // 
            // lname_input
            // 
            this.lname_input.Location = new System.Drawing.Point(335, 107);
            this.lname_input.Name = "lname_input";
            this.lname_input.Size = new System.Drawing.Size(143, 26);
            this.lname_input.TabIndex = 7;
            // 
            // sid_input
            // 
            this.sid_input.Location = new System.Drawing.Point(597, 107);
            this.sid_input.Name = "sid_input";
            this.sid_input.Size = new System.Drawing.Size(143, 26);
            this.sid_input.TabIndex = 8;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(314, 621);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(187, 43);
            this.delete_button.TabIndex = 9;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(660, 649);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Chapman Panthers";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 676);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.sid_input);
            this.Controls.Add(this.lname_input);
            this.Controls.Add(this.fname_input);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox fname_input;
        private System.Windows.Forms.TextBox lname_input;
        private System.Windows.Forms.TextBox sid_input;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label15;
    }
}