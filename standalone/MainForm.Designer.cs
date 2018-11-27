﻿namespace AILogsExporter
{
    partial class MainForm
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
            this.applicationIdTextBox = new System.Windows.Forms.TextBox();
            this.applicationIdLabel = new System.Windows.Forms.Label();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimeLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimeLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.logFilePathLabel = new System.Windows.Forms.Label();
            this.logFilePathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // applicationIdTextBox
            // 
            this.applicationIdTextBox.Location = new System.Drawing.Point(520, 51);
            this.applicationIdTextBox.Name = "applicationIdTextBox";
            this.applicationIdTextBox.Size = new System.Drawing.Size(422, 29);
            this.applicationIdTextBox.TabIndex = 0;
            // 
            // applicationIdLabel
            // 
            this.applicationIdLabel.AutoSize = true;
            this.applicationIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applicationIdLabel.Location = new System.Drawing.Point(35, 38);
            this.applicationIdLabel.Name = "applicationIdLabel";
            this.applicationIdLabel.Size = new System.Drawing.Size(257, 42);
            this.applicationIdLabel.TabIndex = 1;
            this.applicationIdLabel.Text = "Application ID:";
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apiKeyLabel.Location = new System.Drawing.Point(35, 118);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(162, 42);
            this.apiKeyLabel.TabIndex = 2;
            this.apiKeyLabel.Text = "API Key:";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Location = new System.Drawing.Point(520, 131);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(422, 29);
            this.apiKeyTextBox.TabIndex = 3;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(520, 210);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(422, 29);
            this.startDateTimePicker.TabIndex = 4;
            // 
            // startDateTimeLabel
            // 
            this.startDateTimeLabel.AutoSize = true;
            this.startDateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startDateTimeLabel.Location = new System.Drawing.Point(35, 198);
            this.startDateTimeLabel.Name = "startDateTimeLabel";
            this.startDateTimeLabel.Size = new System.Drawing.Size(411, 42);
            this.startDateTimeLabel.TabIndex = 5;
            this.startDateTimeLabel.Text = "Start Date Time (Local):";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(520, 290);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(422, 29);
            this.endDateTimePicker.TabIndex = 6;
            // 
            // endDateTimeLabel
            // 
            this.endDateTimeLabel.AutoSize = true;
            this.endDateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endDateTimeLabel.Location = new System.Drawing.Point(35, 278);
            this.endDateTimeLabel.Name = "endDateTimeLabel";
            this.endDateTimeLabel.Size = new System.Drawing.Size(400, 42);
            this.endDateTimeLabel.TabIndex = 7;
            this.endDateTimeLabel.Text = "End Date Time (Local):";
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exportButton.Location = new System.Drawing.Point(42, 441);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(224, 86);
            this.exportButton.TabIndex = 8;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // logFilePathLabel
            // 
            this.logFilePathLabel.AutoSize = true;
            this.logFilePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logFilePathLabel.Location = new System.Drawing.Point(34, 358);
            this.logFilePathLabel.Name = "logFilePathLabel";
            this.logFilePathLabel.Size = new System.Drawing.Size(248, 42);
            this.logFilePathLabel.TabIndex = 9;
            this.logFilePathLabel.Text = "Log File Path:";
            // 
            // logFilePathTextBox
            // 
            this.logFilePathTextBox.Location = new System.Drawing.Point(520, 371);
            this.logFilePathTextBox.Name = "logFilePathTextBox";
            this.logFilePathTextBox.Size = new System.Drawing.Size(422, 29);
            this.logFilePathTextBox.TabIndex = 10;
            this.logFilePathTextBox.Text = "C:\\traces.log";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 582);
            this.Controls.Add(this.logFilePathTextBox);
            this.Controls.Add(this.logFilePathLabel);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.endDateTimeLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimeLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.apiKeyTextBox);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.applicationIdLabel);
            this.Controls.Add(this.applicationIdTextBox);
            this.Name = "MainForm";
            this.Text = "AILogsExporter by https://bartlomiejmucha.com, v. 0.1 beta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox applicationIdTextBox;
        private System.Windows.Forms.Label applicationIdLabel;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startDateTimeLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label endDateTimeLabel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label logFilePathLabel;
        private System.Windows.Forms.TextBox logFilePathTextBox;
    }
}
