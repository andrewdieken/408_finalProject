namespace cpsc408_finalProject
{
    partial class EditMaxRecord
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
            this.confirmEdit_button = new System.Windows.Forms.Button();
            this.squat_input = new System.Windows.Forms.TextBox();
            this.clean_input = new System.Windows.Forms.TextBox();
            this.bench_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.term_label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmEdit_button
            // 
            this.confirmEdit_button.Location = new System.Drawing.Point(147, 432);
            this.confirmEdit_button.Name = "confirmEdit_button";
            this.confirmEdit_button.Size = new System.Drawing.Size(203, 45);
            this.confirmEdit_button.TabIndex = 23;
            this.confirmEdit_button.Text = "Confirm Edit";
            this.confirmEdit_button.UseVisualStyleBackColor = true;
            this.confirmEdit_button.Click += new System.EventHandler(this.confirmEdit_button_Click);
            // 
            // squat_input
            // 
            this.squat_input.Location = new System.Drawing.Point(190, 376);
            this.squat_input.Name = "squat_input";
            this.squat_input.Size = new System.Drawing.Size(121, 26);
            this.squat_input.TabIndex = 22;
            // 
            // clean_input
            // 
            this.clean_input.Location = new System.Drawing.Point(190, 310);
            this.clean_input.Name = "clean_input";
            this.clean_input.Size = new System.Drawing.Size(121, 26);
            this.clean_input.TabIndex = 21;
            // 
            // bench_input
            // 
            this.bench_input.Location = new System.Drawing.Point(190, 246);
            this.bench_input.Name = "bench_input";
            this.bench_input.Size = new System.Drawing.Size(121, 26);
            this.bench_input.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Squat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Clean";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bench";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Edit Max Record";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(228, 122);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(0, 20);
            this.year_label.TabIndex = 24;
            // 
            // term_label
            // 
            this.term_label.AutoSize = true;
            this.term_label.Location = new System.Drawing.Point(228, 184);
            this.term_label.Name = "term_label";
            this.term_label.Size = new System.Drawing.Size(0, 20);
            this.term_label.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(372, 487);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Chapman Panthers";
            // 
            // EditMaxRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 514);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.term_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.confirmEdit_button);
            this.Controls.Add(this.squat_input);
            this.Controls.Add(this.clean_input);
            this.Controls.Add(this.bench_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditMaxRecord";
            this.Text = "EditMaxRecord";
            this.Load += new System.EventHandler(this.EditMaxRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmEdit_button;
        private System.Windows.Forms.TextBox squat_input;
        private System.Windows.Forms.TextBox clean_input;
        private System.Windows.Forms.TextBox bench_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label term_label;
        private System.Windows.Forms.Label label15;
    }
}