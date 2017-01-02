namespace SPWCS
{
    partial class MoveToArchive
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
            this.SelectEventsID = new System.Windows.Forms.Label();
            this.EventsID = new System.Windows.Forms.TextBox();
            this.archive = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectEventsID
            // 
            this.SelectEventsID.AutoSize = true;
            this.SelectEventsID.BackColor = System.Drawing.Color.Transparent;
            this.SelectEventsID.Location = new System.Drawing.Point(29, 24);
            this.SelectEventsID.Name = "SelectEventsID";
            this.SelectEventsID.Size = new System.Drawing.Size(88, 13);
            this.SelectEventsID.TabIndex = 0;
            this.SelectEventsID.Text = "Select event\'s ID";
            // 
            // EventsID
            // 
            this.EventsID.Location = new System.Drawing.Point(143, 24);
            this.EventsID.Name = "EventsID";
            this.EventsID.Size = new System.Drawing.Size(128, 20);
            this.EventsID.TabIndex = 1;
            // 
            // archive
            // 
            this.archive.Location = new System.Drawing.Point(32, 82);
            this.archive.Name = "archive";
            this.archive.Size = new System.Drawing.Size(93, 23);
            this.archive.TabIndex = 2;
            this.archive.Text = "Archive";
            this.archive.UseVisualStyleBackColor = true;
            this.archive.Click += new System.EventHandler(this.archive_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(178, 81);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(92, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // MoveToArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 135);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.archive);
            this.Controls.Add(this.EventsID);
            this.Controls.Add(this.SelectEventsID);
            this.Name = "MoveToArchive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoveToArchive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectEventsID;
        private System.Windows.Forms.TextBox EventsID;
        private System.Windows.Forms.Button archive;
        private System.Windows.Forms.Button cancel;
    }
}