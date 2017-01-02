namespace SPWCS
{
    partial class User
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
            this.LogOut = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.CheckReservation = new System.Windows.Forms.Button();
            this.Events = new System.Windows.Forms.Button();
            this.Archive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(402, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(122, 23);
            this.LogOut.TabIndex = 0;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(12, 99);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(122, 23);
            this.Users.TabIndex = 1;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // CheckReservation
            // 
            this.CheckReservation.Location = new System.Drawing.Point(12, 12);
            this.CheckReservation.Name = "CheckReservation";
            this.CheckReservation.Size = new System.Drawing.Size(122, 23);
            this.CheckReservation.TabIndex = 2;
            this.CheckReservation.Text = "Check Reservation";
            this.CheckReservation.UseVisualStyleBackColor = true;
            this.CheckReservation.Click += new System.EventHandler(this.CheckReservation_Click);
            // 
            // Events
            // 
            this.Events.Location = new System.Drawing.Point(12, 41);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(122, 23);
            this.Events.TabIndex = 3;
            this.Events.Text = "Events";
            this.Events.UseVisualStyleBackColor = true;
            this.Events.Click += new System.EventHandler(this.Events_Click);
            // 
            // Archive
            // 
            this.Archive.Location = new System.Drawing.Point(12, 70);
            this.Archive.Name = "Archive";
            this.Archive.Size = new System.Drawing.Size(122, 23);
            this.Archive.TabIndex = 4;
            this.Archive.Text = "Archive";
            this.Archive.UseVisualStyleBackColor = true;
            this.Archive.Click += new System.EventHandler(this.Archive_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(536, 362);
            this.Controls.Add(this.Archive);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.CheckReservation);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.LogOut);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button CheckReservation;
        private System.Windows.Forms.Button Events;
        private System.Windows.Forms.Button Archive;
    }
}