namespace cpsc408_finalProject
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.fName_input = new System.Windows.Forms.TextBox();
            this.lName_input = new System.Windows.Forms.TextBox();
            this.status_input = new System.Windows.Forms.ComboBox();
            this.position_input = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position";
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(174, 338);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(82, 41);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // fName_input
            // 
            this.fName_input.Location = new System.Drawing.Point(134, 56);
            this.fName_input.Name = "fName_input";
            this.fName_input.Size = new System.Drawing.Size(168, 26);
            this.fName_input.TabIndex = 5;
            // 
            // lName_input
            // 
            this.lName_input.Location = new System.Drawing.Point(134, 119);
            this.lName_input.Name = "lName_input";
            this.lName_input.Size = new System.Drawing.Size(168, 26);
            this.lName_input.TabIndex = 6;
            // 
            // status_input
            // 
            this.status_input.FormattingEnabled = true;
            this.status_input.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status_input.Location = new System.Drawing.Point(134, 190);
            this.status_input.Name = "status_input";
            this.status_input.Size = new System.Drawing.Size(168, 28);
            this.status_input.TabIndex = 7;
            // 
            // position_input
            // 
            this.position_input.FormattingEnabled = true;
            this.position_input.Items.AddRange(new object[] {
            "Defensive Line",
            "Linebacker",
            "Defensive Back",
            "Offensive Line",
            "Receiver",
            "Running Back",
            "Quarterback"});
            this.position_input.Location = new System.Drawing.Point(134, 266);
            this.position_input.Name = "position_input";
            this.position_input.Size = new System.Drawing.Size(168, 28);
            this.position_input.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(275, 387);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Chapman Panthers";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 414);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.position_input);
            this.Controls.Add(this.status_input);
            this.Controls.Add(this.lName_input);
            this.Controls.Add(this.fName_input);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox fName_input;
        private System.Windows.Forms.TextBox lName_input;
        private System.Windows.Forms.ComboBox status_input;
        private System.Windows.Forms.ComboBox position_input;
        private System.Windows.Forms.Label label15;
    }
}