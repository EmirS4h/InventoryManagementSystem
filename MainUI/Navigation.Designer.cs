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
            this.userProjectsCount = new System.Windows.Forms.Label();
            this.userProjectsCompletedCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userProjectsLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(67, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(131, 28);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Default User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Projects : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userProjectsCount
            // 
            this.userProjectsCount.AutoSize = true;
            this.userProjectsCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userProjectsCount.Location = new System.Drawing.Point(164, 46);
            this.userProjectsCount.Name = "userProjectsCount";
            this.userProjectsCount.Size = new System.Drawing.Size(46, 21);
            this.userProjectsCount.TabIndex = 2;
            this.userProjectsCount.Text = "9999";
            // 
            // userProjectsCompletedCount
            // 
            this.userProjectsCompletedCount.AutoSize = true;
            this.userProjectsCompletedCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userProjectsCompletedCount.Location = new System.Drawing.Point(164, 85);
            this.userProjectsCompletedCount.Name = "userProjectsCompletedCount";
            this.userProjectsCompletedCount.Size = new System.Drawing.Size(46, 21);
            this.userProjectsCompletedCount.TabIndex = 4;
            this.userProjectsCompletedCount.Text = "9999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Projects Completed : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Projects Left : ";
            // 
            // userProjectsLeft
            // 
            this.userProjectsLeft.AutoSize = true;
            this.userProjectsLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userProjectsLeft.Location = new System.Drawing.Point(164, 120);
            this.userProjectsLeft.Name = "userProjectsLeft";
            this.userProjectsLeft.Size = new System.Drawing.Size(46, 21);
            this.userProjectsLeft.TabIndex = 6;
            this.userProjectsLeft.Text = "9999";
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 155);
            this.Controls.Add(this.userProjectsLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userProjectsCompletedCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userProjectsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Navigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userProjectsCount;
        private System.Windows.Forms.Label userProjectsCompletedCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userProjectsLeft;
    }
}