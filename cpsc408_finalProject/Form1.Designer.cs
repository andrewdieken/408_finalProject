namespace cpsc408_finalProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewAll_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.addAthlete_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reports_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(136, 19);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(411, 40);
            this.title1.TabIndex = 0;
            this.title1.Text = "CHAPMAN FOOTBALL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATABASE";
            // 
            // viewAll_button
            // 
            this.viewAll_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAll_button.Location = new System.Drawing.Point(283, 405);
            this.viewAll_button.Name = "viewAll_button";
            this.viewAll_button.Size = new System.Drawing.Size(118, 38);
            this.viewAll_button.TabIndex = 2;
            this.viewAll_button.Text = "VIEW ALL";
            this.viewAll_button.UseVisualStyleBackColor = true;
            this.viewAll_button.Click += new System.EventHandler(this.viewAll_button_Click);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(283, 449);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(118, 38);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "SEARCH";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // addAthlete_button
            // 
            this.addAthlete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAthlete_button.Location = new System.Drawing.Point(238, 493);
            this.addAthlete_button.Name = "addAthlete_button";
            this.addAthlete_button.Size = new System.Drawing.Size(210, 38);
            this.addAthlete_button.TabIndex = 4;
            this.addAthlete_button.Text = "ADD ATHLETE";
            this.addAthlete_button.UseVisualStyleBackColor = true;
            this.addAthlete_button.Click += new System.EventHandler(this.addAthlete_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(283, 537);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(118, 38);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // reports_button
            // 
            this.reports_button.Location = new System.Drawing.Point(283, 581);
            this.reports_button.Name = "reports_button";
            this.reports_button.Size = new System.Drawing.Size(118, 38);
            this.reports_button.TabIndex = 7;
            this.reports_button.Text = "REPORTS";
            this.reports_button.UseVisualStyleBackColor = true;
            this.reports_button.Click += new System.EventHandler(this.reports_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 651);
            this.Controls.Add(this.reports_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.addAthlete_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.viewAll_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewAll_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button addAthlete_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button reports_button;
    }
}

