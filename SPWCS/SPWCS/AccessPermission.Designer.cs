namespace SPWCS
{
    partial class AccessPermission
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
            this.Back = new System.Windows.Forms.Button();
            this.UsersLogin = new System.Windows.Forms.Label();
            this.loginBox1 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.AccessPerm = new System.Windows.Forms.Label();
            this.selectAccessPermission = new System.Windows.Forms.Label();
            this.typesCB = new System.Windows.Forms.ComboBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(449, 327);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Done_Click);
            // 
            // UsersLogin
            // 
            this.UsersLogin.AutoSize = true;
            this.UsersLogin.BackColor = System.Drawing.Color.Transparent;
            this.UsersLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UsersLogin.Location = new System.Drawing.Point(12, 9);
            this.UsersLogin.Name = "UsersLogin";
            this.UsersLogin.Size = new System.Drawing.Size(82, 17);
            this.UsersLogin.TabIndex = 1;
            this.UsersLogin.Text = "User\'s login";
            // 
            // loginBox1
            // 
            this.loginBox1.Location = new System.Drawing.Point(12, 25);
            this.loginBox1.Name = "loginBox1";
            this.loginBox1.Size = new System.Drawing.Size(100, 20);
            this.loginBox1.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.Transparent;
            this.Name.Location = new System.Drawing.Point(12, 52);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(0, 13);
            this.Name.TabIndex = 3;
            // 
            // AccessPerm
            // 
            this.AccessPerm.AutoSize = true;
            this.AccessPerm.BackColor = System.Drawing.Color.Transparent;
            this.AccessPerm.Location = new System.Drawing.Point(12, 75);
            this.AccessPerm.Name = "AccessPerm";
            this.AccessPerm.Size = new System.Drawing.Size(0, 13);
            this.AccessPerm.TabIndex = 4;
            // 
            // selectAccessPermission
            // 
            this.selectAccessPermission.AutoSize = true;
            this.selectAccessPermission.BackColor = System.Drawing.Color.Transparent;
            this.selectAccessPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectAccessPermission.Location = new System.Drawing.Point(12, 97);
            this.selectAccessPermission.Name = "selectAccessPermission";
            this.selectAccessPermission.Size = new System.Drawing.Size(169, 17);
            this.selectAccessPermission.TabIndex = 5;
            this.selectAccessPermission.Text = "Select Access Permission";
            // 
            // typesCB
            // 
            this.typesCB.FormattingEnabled = true;
            this.typesCB.Items.AddRange(new object[] {
            "Employee",
            "Supervisor",
            "Admin"});
            this.typesCB.Location = new System.Drawing.Point(15, 118);
            this.typesCB.Name = "typesCB";
            this.typesCB.Size = new System.Drawing.Size(121, 21);
            this.typesCB.TabIndex = 6;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(368, 327);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.change_Click);
            // 
            // AccessPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 362);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.typesCB);
            this.Controls.Add(this.selectAccessPermission);
            this.Controls.Add(this.AccessPerm);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.loginBox1);
            this.Controls.Add(this.UsersLogin);
            this.Controls.Add(this.Back);
            //this.Name = "AccessPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccessPermission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label UsersLogin;
        private System.Windows.Forms.TextBox loginBox1;
        private new System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label AccessPerm;
        private System.Windows.Forms.Label selectAccessPermission;
        private System.Windows.Forms.ComboBox typesCB;
        private System.Windows.Forms.Button changeButton;
    }
}