namespace cpsc408_finalProject
{
    partial class AddMaxRecordForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bench_input = new System.Windows.Forms.TextBox();
            this.clean_input = new System.Windows.Forms.TextBox();
            this.squat_input = new System.Windows.Forms.TextBox();
            this.addRecord_button = new System.Windows.Forms.Button();
            this.term_input = new System.Windows.Forms.ComboBox();
            this.year_input = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Max Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Term";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bench";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Clean";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Squat";
            // 
            // bench_input
            // 
            this.bench_input.Location = new System.Drawing.Point(147, 217);
            this.bench_input.Name = "bench_input";
            this.bench_input.Size = new System.Drawing.Size(121, 26);
            this.bench_input.TabIndex = 8;
            // 
            // clean_input
            // 
            this.clean_input.Location = new System.Drawing.Point(147, 281);
            this.clean_input.Name = "clean_input";
            this.clean_input.Size = new System.Drawing.Size(121, 26);
            this.clean_input.TabIndex = 9;
            // 
            // squat_input
            // 
            this.squat_input.Location = new System.Drawing.Point(147, 347);
            this.squat_input.Name = "squat_input";
            this.squat_input.Size = new System.Drawing.Size(121, 26);
            this.squat_input.TabIndex = 10;
            // 
            // addRecord_button
            // 
            this.addRecord_button.Location = new System.Drawing.Point(104, 403);
            this.addRecord_button.Name = "addRecord_button";
            this.addRecord_button.Size = new System.Drawing.Size(203, 45);
            this.addRecord_button.TabIndex = 11;
            this.addRecord_button.Text = "Add";
            this.addRecord_button.UseVisualStyleBackColor = true;
            this.addRecord_button.Click += new System.EventHandler(this.addRecord_button_Click);
            // 
            // term_input
            // 
            this.term_input.FormattingEnabled = true;
            this.term_input.Items.AddRange(new object[] {
            "Start",
            "End"});
            this.term_input.Location = new System.Drawing.Point(147, 149);
            this.term_input.Name = "term_input";
            this.term_input.Size = new System.Drawing.Size(121, 28);
            this.term_input.TabIndex = 7;
            // 
            // year_input
            // 
            this.year_input.Location = new System.Drawing.Point(147, 84);
            this.year_input.Name = "year_input";
            this.year_input.Size = new System.Drawing.Size(121, 26);
            this.year_input.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(291, 462);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Chapman Panthers";
            // 
            // AddMaxRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 489);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.addRecord_button);
            this.Controls.Add(this.squat_input);
            this.Controls.Add(this.clean_input);
            this.Controls.Add(this.bench_input);
            this.Controls.Add(this.term_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.year_input);
            this.Controls.Add(this.label1);
            this.Name = "AddMaxRecordForm";
            this.Text = "AddMaxRecordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bench_input;
        private System.Windows.Forms.TextBox clean_input;
        private System.Windows.Forms.TextBox squat_input;
        private System.Windows.Forms.Button addRecord_button;
        private System.Windows.Forms.ComboBox term_input;
        private System.Windows.Forms.TextBox year_input;
        private System.Windows.Forms.Label label15;
    }
}