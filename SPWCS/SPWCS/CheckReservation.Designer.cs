namespace SPWCS
{
    partial class CheckReservation
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
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.DataGridOfCheckReservation = new System.Windows.Forms.DataGridView();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ShowReservationButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.pdfButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOfCheckReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartDateLabel.Location = new System.Drawing.Point(86, 35);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(104, 13);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "Choose starting date";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.EndDateLabel.Location = new System.Drawing.Point(86, 72);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(102, 13);
            this.EndDateLabel.TabIndex = 1;
            this.EndDateLabel.Text = "Choose ending date";
            // 
            // DataGridOfCheckReservation
            // 
            this.DataGridOfCheckReservation.AllowUserToAddRows = false;
            this.DataGridOfCheckReservation.AllowUserToDeleteRows = false;
            this.DataGridOfCheckReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridOfCheckReservation.Location = new System.Drawing.Point(89, 133);
            this.DataGridOfCheckReservation.Name = "DataGridOfCheckReservation";
            this.DataGridOfCheckReservation.ReadOnly = true;
            this.DataGridOfCheckReservation.Size = new System.Drawing.Size(345, 224);
            this.DataGridOfCheckReservation.TabIndex = 2;
            this.DataGridOfCheckReservation.Visible = false;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(234, 29);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 3;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(234, 66);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 4;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // ShowReservationButton
            // 
            this.ShowReservationButton.Location = new System.Drawing.Point(184, 104);
            this.ShowReservationButton.Name = "ShowReservationButton";
            this.ShowReservationButton.Size = new System.Drawing.Size(142, 23);
            this.ShowReservationButton.TabIndex = 5;
            this.ShowReservationButton.Text = "Show these events";
            this.ShowReservationButton.UseVisualStyleBackColor = true;
            this.ShowReservationButton.Click += new System.EventHandler(this.ShowReservationButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(433, 375);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pdfButton
            // 
            this.pdfButton.Location = new System.Drawing.Point(89, 375);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(75, 23);
            this.pdfButton.TabIndex = 7;
            this.pdfButton.Text = "Drop to pdf";
            this.pdfButton.UseVisualStyleBackColor = true;
            this.pdfButton.Visible = false;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // CheckReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 422);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ShowReservationButton);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.DataGridOfCheckReservation);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Name = "CheckReservation";
            this.Text = "Check Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOfCheckReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DataGridView DataGridOfCheckReservation;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Button ShowReservationButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button pdfButton;
    }
}