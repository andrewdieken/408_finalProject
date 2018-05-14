namespace cpsc408_finalProject
{
    partial class ReportsForm
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
            this.lbClub_button = new System.Windows.Forms.Button();
            this.max_bench_button = new System.Windows.Forms.Button();
            this.year_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.max_squat_button = new System.Windows.Forms.Button();
            this.max_clean_button = new System.Windows.Forms.Button();
            this.generate_all_button = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.export_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Reports";
            // 
            // lbClub_button
            // 
            this.lbClub_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClub_button.Location = new System.Drawing.Point(70, 47);
            this.lbClub_button.Name = "lbClub_button";
            this.lbClub_button.Size = new System.Drawing.Size(131, 39);
            this.lbClub_button.TabIndex = 1;
            this.lbClub_button.Text = "1000 LB Club";
            this.lbClub_button.UseVisualStyleBackColor = true;
            this.lbClub_button.Click += new System.EventHandler(this.lbClub_button_Click);
            // 
            // max_bench_button
            // 
            this.max_bench_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_bench_button.Location = new System.Drawing.Point(70, 92);
            this.max_bench_button.Name = "max_bench_button";
            this.max_bench_button.Size = new System.Drawing.Size(131, 38);
            this.max_bench_button.TabIndex = 2;
            this.max_bench_button.Text = "Max Bench";
            this.max_bench_button.UseVisualStyleBackColor = true;
            this.max_bench_button.Click += new System.EventHandler(this.max_bench_button_Click);
            // 
            // year_input
            // 
            this.year_input.Location = new System.Drawing.Point(157, 111);
            this.year_input.Name = "year_input";
            this.year_input.Size = new System.Drawing.Size(100, 26);
            this.year_input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Year:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.max_squat_button);
            this.groupBox1.Controls.Add(this.max_clean_button);
            this.groupBox1.Controls.Add(this.generate_all_button);
            this.groupBox1.Controls.Add(this.max_bench_button);
            this.groupBox1.Controls.Add(this.lbClub_button);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 290);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Report Type";
            // 
            // max_squat_button
            // 
            this.max_squat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_squat_button.Location = new System.Drawing.Point(70, 180);
            this.max_squat_button.Name = "max_squat_button";
            this.max_squat_button.Size = new System.Drawing.Size(131, 38);
            this.max_squat_button.TabIndex = 5;
            this.max_squat_button.Text = "Max Squat";
            this.max_squat_button.UseVisualStyleBackColor = true;
            this.max_squat_button.Click += new System.EventHandler(this.max_squat_button_Click);
            // 
            // max_clean_button
            // 
            this.max_clean_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_clean_button.Location = new System.Drawing.Point(70, 136);
            this.max_clean_button.Name = "max_clean_button";
            this.max_clean_button.Size = new System.Drawing.Size(131, 38);
            this.max_clean_button.TabIndex = 4;
            this.max_clean_button.Text = "Max Clean";
            this.max_clean_button.UseVisualStyleBackColor = true;
            this.max_clean_button.Click += new System.EventHandler(this.max_clean_button_Click);
            // 
            // generate_all_button
            // 
            this.generate_all_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_all_button.Location = new System.Drawing.Point(70, 224);
            this.generate_all_button.Name = "generate_all_button";
            this.generate_all_button.Size = new System.Drawing.Size(131, 46);
            this.generate_all_button.TabIndex = 3;
            this.generate_all_button.Text = "Game Stats";
            this.generate_all_button.UseVisualStyleBackColor = true;
            this.generate_all_button.Click += new System.EventHandler(this.generate_all_button_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(818, 497);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Chapman Panthers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(665, 435);
            this.dataGridView1.TabIndex = 31;
            // 
            // export_button
            // 
            this.export_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_button.Location = new System.Drawing.Point(17, 473);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(262, 46);
            this.export_button.TabIndex = 32;
            this.export_button.Text = "EXPORT";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 524);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.year_input);
            this.Controls.Add(this.label1);
            this.Name = "ReportsForm";
            this.Text = "Enter Year:";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lbClub_button;
        private System.Windows.Forms.Button max_bench_button;
        private System.Windows.Forms.TextBox year_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generate_all_button;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.Button max_squat_button;
        private System.Windows.Forms.Button max_clean_button;
    }
}