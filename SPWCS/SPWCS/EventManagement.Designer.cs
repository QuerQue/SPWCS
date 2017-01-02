namespace SPWCS
{
    partial class EventManagement
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
            this.AddEventButton = new System.Windows.Forms.Button();
            this.DeleteEventButton = new System.Windows.Forms.Button();
            this.ModifyEventButton = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.showEventButton = new System.Windows.Forms.Button();
            this.eventsDataGrid = new System.Windows.Forms.DataGridView();
            this.toPDFButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEventButton
            // 
            this.AddEventButton.Location = new System.Drawing.Point(12, 12);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(86, 23);
            this.AddEventButton.TabIndex = 0;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // DeleteEventButton
            // 
            this.DeleteEventButton.Location = new System.Drawing.Point(12, 41);
            this.DeleteEventButton.Name = "DeleteEventButton";
            this.DeleteEventButton.Size = new System.Drawing.Size(86, 23);
            this.DeleteEventButton.TabIndex = 1;
            this.DeleteEventButton.Text = "Delete Event";
            this.DeleteEventButton.UseVisualStyleBackColor = true;
            this.DeleteEventButton.Click += new System.EventHandler(this.DeleteEventButton_Click);
            // 
            // ModifyEventButton
            // 
            this.ModifyEventButton.Location = new System.Drawing.Point(12, 70);
            this.ModifyEventButton.Name = "ModifyEventButton";
            this.ModifyEventButton.Size = new System.Drawing.Size(86, 23);
            this.ModifyEventButton.TabIndex = 2;
            this.ModifyEventButton.Text = "Modify Event";
            this.ModifyEventButton.UseVisualStyleBackColor = true;
            this.ModifyEventButton.Click += new System.EventHandler(this.ModifyEventButton_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(319, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(122, 23);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(319, 289);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(122, 23);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // showEventButton
            // 
            this.showEventButton.Location = new System.Drawing.Point(12, 99);
            this.showEventButton.Name = "showEventButton";
            this.showEventButton.Size = new System.Drawing.Size(86, 23);
            this.showEventButton.TabIndex = 6;
            this.showEventButton.Text = "Show Events";
            this.showEventButton.UseVisualStyleBackColor = true;
            this.showEventButton.Click += new System.EventHandler(this.showEventButton_Click);
            // 
            // eventsDataGrid
            // 
            this.eventsDataGrid.AllowUserToAddRows = false;
            this.eventsDataGrid.AllowUserToDeleteRows = false;
            this.eventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGrid.Location = new System.Drawing.Point(117, 46);
            this.eventsDataGrid.Name = "eventsDataGrid";
            this.eventsDataGrid.ReadOnly = true;
            this.eventsDataGrid.Size = new System.Drawing.Size(323, 228);
            this.eventsDataGrid.TabIndex = 7;
            this.eventsDataGrid.Visible = false;
            // 
            // toPDFButton
            // 
            this.toPDFButton.Location = new System.Drawing.Point(117, 289);
            this.toPDFButton.Name = "toPDFButton";
            this.toPDFButton.Size = new System.Drawing.Size(122, 23);
            this.toPDFButton.TabIndex = 8;
            this.toPDFButton.Text = "Drop to pdf";
            this.toPDFButton.UseVisualStyleBackColor = true;
            this.toPDFButton.Click += new System.EventHandler(this.toPDFButton_Click);
            this.toPDFButton.Visible = false;
            // 
            // EventManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 324);
            this.Controls.Add(this.toPDFButton);
            this.Controls.Add(this.eventsDataGrid);
            this.Controls.Add(this.showEventButton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.ModifyEventButton);
            this.Controls.Add(this.DeleteEventButton);
            this.Controls.Add(this.AddEventButton);
            this.Name = "EventManagement";
            this.Text = "Event Management";
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button DeleteEventButton;
        private System.Windows.Forms.Button ModifyEventButton;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button showEventButton;
        private System.Windows.Forms.DataGridView eventsDataGrid;
        private System.Windows.Forms.Button toPDFButton;
    }
}