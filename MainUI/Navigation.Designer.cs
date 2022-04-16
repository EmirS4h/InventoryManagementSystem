namespace MainUI
{
    partial class Navigation
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalProjectCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.projectsCompleted = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectsLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(58, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(109, 30);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Proje :";
            // 
            // totalProjectCount
            // 
            this.totalProjectCount.AutoSize = true;
            this.totalProjectCount.Location = new System.Drawing.Point(184, 79);
            this.totalProjectCount.Name = "totalProjectCount";
            this.totalProjectCount.Size = new System.Drawing.Size(31, 15);
            this.totalProjectCount.TabIndex = 3;
            this.totalProjectCount.Text = "9999";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamamlanan Proje :";
            // 
            // projectsCompleted
            // 
            this.projectsCompleted.AutoSize = true;
            this.projectsCompleted.Location = new System.Drawing.Point(184, 104);
            this.projectsCompleted.Name = "projectsCompleted";
            this.projectsCompleted.Size = new System.Drawing.Size(31, 15);
            this.projectsCompleted.TabIndex = 5;
            this.projectsCompleted.Text = "9999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamamlanmamış Proje :";
            // 
            // projectsLeft
            // 
            this.projectsLeft.AutoSize = true;
            this.projectsLeft.Location = new System.Drawing.Point(184, 129);
            this.projectsLeft.Name = "projectsLeft";
            this.projectsLeft.Size = new System.Drawing.Size(31, 15);
            this.projectsLeft.TabIndex = 7;
            this.projectsLeft.Text = "9999";
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(227, 681);
            this.Controls.Add(this.projectsLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectsCompleted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalProjectCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalProjectCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label projectsCompleted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label projectsLeft;
    }
}