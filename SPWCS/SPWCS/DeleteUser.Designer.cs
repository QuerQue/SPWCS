namespace SPWCS
{
    partial class DeleteUser
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
            this.logintbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.ConfirmDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintbox
            // 
            this.logintbox.Location = new System.Drawing.Point(143, 24);
            this.logintbox.Name = "logintbox";
            this.logintbox.Size = new System.Drawing.Size(128, 20);
            this.logintbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User\'s login";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(178, 81);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(93, 23);
            this.Cancelbutton.TabIndex = 2;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // ConfirmDelete
            // 
            this.ConfirmDelete.Location = new System.Drawing.Point(32, 81);
            this.ConfirmDelete.Name = "ConfirmDelete";
            this.ConfirmDelete.Size = new System.Drawing.Size(93, 23);
            this.ConfirmDelete.TabIndex = 3;
            this.ConfirmDelete.Text = "Delete";
            this.ConfirmDelete.UseVisualStyleBackColor = true;
            this.ConfirmDelete.Click += new System.EventHandler(this.ConfirmDelete_Click);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 135);
            this.Controls.Add(this.ConfirmDelete);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logintbox);
            this.Name = "DeleteUser";
            this.Text = "Delete user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logintbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button ConfirmDelete;
    }
}