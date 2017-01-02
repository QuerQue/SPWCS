namespace SPWCS
{
    partial class Archive
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
            this.showCurrentEventsButton = new System.Windows.Forms.Button();
            this.showArchiveButton = new System.Windows.Forms.Button();
            this.MoveToArchive = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.archiveDataGrid = new System.Windows.Forms.DataGridView();
            this.toPDFButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // showCurrentEventsButton
            // 
            this.showCurrentEventsButton.Location = new System.Drawing.Point(12, 12);
            this.showCurrentEventsButton.Name = "showCurrentEventsButton";
            this.showCurrentEventsButton.Size = new System.Drawing.Size(122, 23);
            this.showCurrentEventsButton.TabIndex = 0;
            this.showCurrentEventsButton.Text = "Show Current Events";
            this.showCurrentEventsButton.UseVisualStyleBackColor = true;
            this.showCurrentEventsButton.Click += new System.EventHandler(this.ShowCurrentEvents_Click);
            // 
            // showArchiveButton
            // 
            this.showArchiveButton.Location = new System.Drawing.Point(12, 42);
            this.showArchiveButton.Name = "showArchiveButton";
            this.showArchiveButton.Size = new System.Drawing.Size(122, 23);
            this.showArchiveButton.TabIndex = 1;
            this.showArchiveButton.Text = "Show Archive";
            this.showArchiveButton.UseVisualStyleBackColor = true;
            this.showArchiveButton.Click += new System.EventHandler(this.showArchiveButton_Click);
            // 
            // MoveToArchive
            // 
            this.MoveToArchive.Location = new System.Drawing.Point(12, 71);
            this.MoveToArchive.Name = "MoveToArchive";
            this.MoveToArchive.Size = new System.Drawing.Size(122, 23);
            this.MoveToArchive.TabIndex = 2;
            this.MoveToArchive.Text = "Move To Archive";
            this.MoveToArchive.UseVisualStyleBackColor = true;
            this.MoveToArchive.Click += new System.EventHandler(this.MoveToArchive_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(449, 327);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // archiveDataGrid
            // 
            this.archiveDataGrid.AllowUserToAddRows = false;
            this.archiveDataGrid.AllowUserToDeleteRows = false;
            this.archiveDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveDataGrid.Location = new System.Drawing.Point(150, 42);
            this.archiveDataGrid.Name = "archiveDataGrid";
            this.archiveDataGrid.ReadOnly = true;
            this.archiveDataGrid.Size = new System.Drawing.Size(373, 263);
            this.archiveDataGrid.TabIndex = 4;
            this.archiveDataGrid.Visible = false;
            // 
            // toPDFButton
            // 
            this.toPDFButton.Location = new System.Drawing.Point(150, 327);
            this.toPDFButton.Name = "toPDFButton";
            this.toPDFButton.Size = new System.Drawing.Size(109, 23);
            this.toPDFButton.TabIndex = 5;
            this.toPDFButton.Text = "Drop do PDF";
            this.toPDFButton.UseVisualStyleBackColor = false;
            this.toPDFButton.Click += new System.EventHandler(this.toPDFButton_Click);
            this.toPDFButton.Visible = false;
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 362);
            this.Controls.Add(this.toPDFButton);
            this.Controls.Add(this.archiveDataGrid);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.MoveToArchive);
            this.Controls.Add(this.showArchiveButton);
            this.Controls.Add(this.showCurrentEventsButton);
            this.Name = "Archive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archives";
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showCurrentEventsButton;
        private System.Windows.Forms.Button showArchiveButton;
        private System.Windows.Forms.Button MoveToArchive;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView archiveDataGrid;
        private System.Windows.Forms.Button toPDFButton;
    }
}