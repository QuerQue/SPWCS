namespace SPWCS
{
    partial class UsersManagement
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
            this.AddNewUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.ShowUsers = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.DataGridOfAllUsers = new System.Windows.Forms.DataGridView();
            this.ChangeAccessPermission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOfAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewUser
            // 
            this.AddNewUser.Location = new System.Drawing.Point(12, 12);
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(122, 23);
            this.AddNewUser.TabIndex = 0;
            this.AddNewUser.Text = "Add New User";
            this.AddNewUser.UseVisualStyleBackColor = true;
            this.AddNewUser.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(12, 41);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(122, 23);
            this.DeleteUser.TabIndex = 1;
            this.DeleteUser.Text = "Delete User";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // ShowUsers
            // 
            this.ShowUsers.Location = new System.Drawing.Point(12, 70);
            this.ShowUsers.Name = "ShowUsers";
            this.ShowUsers.Size = new System.Drawing.Size(122, 23);
            this.ShowUsers.TabIndex = 2;
            this.ShowUsers.Text = "Show Users";
            this.ShowUsers.UseVisualStyleBackColor = true;
            this.ShowUsers.Click += new System.EventHandler(this.ShowUsers_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(402, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(122, 23);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(402, 327);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(122, 23);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DataGridOfAllUsers
            // 
            this.DataGridOfAllUsers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DataGridOfAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridOfAllUsers.Location = new System.Drawing.Point(140, 47);
            this.DataGridOfAllUsers.Name = "DataGridOfAllUsers";
            this.DataGridOfAllUsers.Size = new System.Drawing.Size(383, 260);
            this.DataGridOfAllUsers.TabIndex = 5;
            this.DataGridOfAllUsers.Visible = false;
            // 
            // ChangeAccessPermission
            // 
            this.ChangeAccessPermission.Location = new System.Drawing.Point(12, 100);
            this.ChangeAccessPermission.Name = "ChangeAccessPermission";
            this.ChangeAccessPermission.Size = new System.Drawing.Size(122, 39);
            this.ChangeAccessPermission.TabIndex = 6;
            this.ChangeAccessPermission.Text = "Change Access Permission";
            this.ChangeAccessPermission.UseVisualStyleBackColor = true;
            this.ChangeAccessPermission.Click += new System.EventHandler(this.ChangeAccessPermission_Click);
            // 
            // UsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 362);
            this.Controls.Add(this.ChangeAccessPermission);
            this.Controls.Add(this.DataGridOfAllUsers);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.ShowUsers);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.AddNewUser);
            this.Name = "UsersManagement";
            this.Text = "UsersManagement";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOfAllUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewUser;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button ShowUsers;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView DataGridOfAllUsers;
        private System.Windows.Forms.Button ChangeAccessPermission;
    }
}