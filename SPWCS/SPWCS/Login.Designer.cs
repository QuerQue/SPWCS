namespace SPWCS
{
    partial class Login
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
            this.loginTB = new System.Windows.Forms.TextBox();
            this.LabelPwd = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logInButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(170, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(240, 53);
            this.loginTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(137, 20);
            this.loginTB.TabIndex = 1;
            // 
            // LabelPwd
            // 
            this.LabelPwd.AutoSize = true;
            this.LabelPwd.BackColor = System.Drawing.Color.Transparent;
            this.LabelPwd.Location = new System.Drawing.Point(170, 83);
            this.LabelPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPwd.Name = "LabelPwd";
            this.LabelPwd.Size = new System.Drawing.Size(53, 13);
            this.LabelPwd.TabIndex = 2;
            this.LabelPwd.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(240, 83);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(137, 20);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPWCS.Properties.Resources.loginicon;
            this.pictureBox1.Location = new System.Drawing.Point(23, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 163);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // logInButton
            // 
            this.logInButton.Image = global::SPWCS.Properties.Resources.Ok_icon;
            this.logInButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logInButton.Location = new System.Drawing.Point(259, 141);
            this.logInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(117, 32);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 205);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.LabelPwd);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "SPWCS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label LabelPwd;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

