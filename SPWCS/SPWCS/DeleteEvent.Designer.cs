namespace SPWCS
{
    partial class DeleteEvent
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eventcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(179, 217);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(37, 217);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event name";
            // 
            // eventcomboBox
            // 
            this.eventcomboBox.FormattingEnabled = true;
            this.eventcomboBox.Location = new System.Drawing.Point(133, 34);
            this.eventcomboBox.Name = "eventcomboBox";
            this.eventcomboBox.Size = new System.Drawing.Size(121, 21);
            this.eventcomboBox.TabIndex = 5;
            this.eventcomboBox.SelectedIndexChanged += new System.EventHandler(this.eventcomboBox_SelectedIndexChanged);
            // 
            // DeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.eventcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "DeleteEvent";
            this.Text = "DeleteEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eventcomboBox;
    }
}