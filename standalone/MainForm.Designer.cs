namespace AILogsExporter
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
            this.exportButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.logFilePathLabel = new System.Windows.Forms.Label();
            this.logFilePathTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.queryProjectLabel = new System.Windows.Forms.Label();
            this.queryTopLabel = new System.Windows.Forms.Label();
            this.queryTopNumericBox = new System.Windows.Forms.NumericUpDown();
            this.queryTopByLabel = new System.Windows.Forms.Label();
            this.insertBatchNumberLineCheckBox = new System.Windows.Forms.CheckBox();
            this.exportAllBatchesCheckBox = new System.Windows.Forms.CheckBox();
            this.statusLineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.queryTopNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // applicationIdTextBox
            // 
            this.applicationIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applicationIdTextBox.Location = new System.Drawing.Point(385, 102);
            this.applicationIdTextBox.Name = "applicationIdTextBox";
            this.applicationIdTextBox.Size = new System.Drawing.Size(728, 39);
            this.applicationIdTextBox.TabIndex = 0;
            // 
            // applicationIdLabel
            // 
            this.applicationIdLabel.AutoSize = true;
            this.applicationIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applicationIdLabel.Location = new System.Drawing.Point(31, 96);
            this.applicationIdLabel.Name = "applicationIdLabel";
            this.applicationIdLabel.Size = new System.Drawing.Size(257, 42);
            this.applicationIdLabel.TabIndex = 1;
            this.applicationIdLabel.Text = "Application ID:";
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apiKeyLabel.Location = new System.Drawing.Point(31, 180);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(162, 42);
            this.apiKeyLabel.TabIndex = 2;
            this.apiKeyLabel.Text = "API Key:";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apiKeyTextBox.Location = new System.Drawing.Point(384, 186);
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(729, 39);
            this.apiKeyTextBox.TabIndex = 3;
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exportButton.Location = new System.Drawing.Point(38, 795);
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
            this.logFilePathLabel.Location = new System.Drawing.Point(31, 264);
            this.logFilePathLabel.Name = "logFilePathLabel";
            this.logFilePathLabel.Size = new System.Drawing.Size(248, 42);
            this.logFilePathLabel.TabIndex = 9;
            this.logFilePathLabel.Text = "Log File Path:";
            // 
            // logFilePathTextBox
            // 
            this.logFilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logFilePathTextBox.Location = new System.Drawing.Point(385, 270);
            this.logFilePathTextBox.Name = "logFilePathTextBox";
            this.logFilePathTextBox.Size = new System.Drawing.Size(728, 39);
            this.logFilePathTextBox.TabIndex = 10;
            this.logFilePathTextBox.Text = "C:\\traces.log";
            // 
            // descriptionLinkLabel
            // 
            this.descriptionLinkLabel.AutoSize = true;
            this.descriptionLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLinkLabel.Location = new System.Drawing.Point(33, 35);
            this.descriptionLinkLabel.Name = "descriptionLinkLabel";
            this.descriptionLinkLabel.Size = new System.Drawing.Size(763, 29);
            this.descriptionLinkLabel.TabIndex = 12;
            this.descriptionLinkLabel.TabStop = true;
            this.descriptionLinkLabel.Text = "https://github.com/bartlomiejmucha/Application-Insights-Logs-Exporter";
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryLabel.Location = new System.Drawing.Point(31, 348);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(130, 42);
            this.queryLabel.TabIndex = 9;
            this.queryLabel.Text = "Query:";
            // 
            // queryTextBox
            // 
            this.queryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryTextBox.Location = new System.Drawing.Point(38, 414);
            this.queryTextBox.Multiline = true;
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(1075, 151);
            this.queryTextBox.TabIndex = 10;
            this.queryTextBox.Text = "traces \r\n| where timestamp > ago(1d)\r\n| extend line = strcat(format_datetime(time" +
    "stamp, \"yyyy-M-dd\"),\"|\",message)";
            // 
            // queryProjectLabel
            // 
            this.queryProjectLabel.AutoSize = true;
            this.queryProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryProjectLabel.Location = new System.Drawing.Point(35, 632);
            this.queryProjectLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.queryProjectLabel.Name = "queryProjectLabel";
            this.queryProjectLabel.Size = new System.Drawing.Size(168, 32);
            this.queryProjectLabel.TabIndex = 13;
            this.queryProjectLabel.Text = "| project line";
            // 
            // queryTopLabel
            // 
            this.queryTopLabel.AutoSize = true;
            this.queryTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryTopLabel.Location = new System.Drawing.Point(35, 584);
            this.queryTopLabel.Name = "queryTopLabel";
            this.queryTopLabel.Size = new System.Drawing.Size(69, 32);
            this.queryTopLabel.TabIndex = 14;
            this.queryTopLabel.Text = "| top";
            // 
            // queryTopNumericBox
            // 
            this.queryTopNumericBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryTopNumericBox.Location = new System.Drawing.Point(113, 584);
            this.queryTopNumericBox.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.queryTopNumericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.queryTopNumericBox.Name = "queryTopNumericBox";
            this.queryTopNumericBox.Size = new System.Drawing.Size(154, 39);
            this.queryTopNumericBox.TabIndex = 15;
            this.queryTopNumericBox.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // queryTopByLabel
            // 
            this.queryTopByLabel.AutoSize = true;
            this.queryTopByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryTopByLabel.Location = new System.Drawing.Point(273, 584);
            this.queryTopByLabel.Name = "queryTopByLabel";
            this.queryTopByLabel.Size = new System.Drawing.Size(234, 32);
            this.queryTopByLabel.TabIndex = 16;
            this.queryTopByLabel.Text = "by timestamp asc";
            // 
            // insertBatchNumberLineCheckBox
            // 
            this.insertBatchNumberLineCheckBox.AutoSize = true;
            this.insertBatchNumberLineCheckBox.Location = new System.Drawing.Point(41, 716);
            this.insertBatchNumberLineCheckBox.Name = "insertBatchNumberLineCheckBox";
            this.insertBatchNumberLineCheckBox.Size = new System.Drawing.Size(245, 29);
            this.insertBatchNumberLineCheckBox.TabIndex = 17;
            this.insertBatchNumberLineCheckBox.Text = "Insert batch number line";
            this.insertBatchNumberLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // exportAllBatchesCheckBox
            // 
            this.exportAllBatchesCheckBox.AutoSize = true;
            this.exportAllBatchesCheckBox.Checked = true;
            this.exportAllBatchesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportAllBatchesCheckBox.Location = new System.Drawing.Point(41, 751);
            this.exportAllBatchesCheckBox.Name = "exportAllBatchesCheckBox";
            this.exportAllBatchesCheckBox.Size = new System.Drawing.Size(192, 29);
            this.exportAllBatchesCheckBox.TabIndex = 18;
            this.exportAllBatchesCheckBox.Text = "Export all batches";
            this.exportAllBatchesCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusLineLabel
            // 
            this.statusLineLabel.AutoSize = true;
            this.statusLineLabel.Location = new System.Drawing.Point(291, 824);
            this.statusLineLabel.Name = "statusLineLabel";
            this.statusLineLabel.Size = new System.Drawing.Size(0, 25);
            this.statusLineLabel.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 920);
            this.Controls.Add(this.statusLineLabel);
            this.Controls.Add(this.exportAllBatchesCheckBox);
            this.Controls.Add(this.insertBatchNumberLineCheckBox);
            this.Controls.Add(this.queryTopByLabel);
            this.Controls.Add(this.queryTopNumericBox);
            this.Controls.Add(this.queryTopLabel);
            this.Controls.Add(this.queryProjectLabel);
            this.Controls.Add(this.descriptionLinkLabel);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.logFilePathTextBox);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.logFilePathLabel);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.apiKeyTextBox);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.applicationIdLabel);
            this.Controls.Add(this.applicationIdTextBox);
            this.Name = "MainForm";
            this.Text = "AILogsExporter v0.3.1";
            ((System.ComponentModel.ISupportInitialize)(this.queryTopNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox applicationIdTextBox;
        private System.Windows.Forms.Label applicationIdLabel;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label logFilePathLabel;
        private System.Windows.Forms.TextBox logFilePathTextBox;
        private System.Windows.Forms.LinkLabel descriptionLinkLabel;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.Label queryProjectLabel;
        private System.Windows.Forms.Label queryTopLabel;
        private System.Windows.Forms.NumericUpDown queryTopNumericBox;
        private System.Windows.Forms.Label queryTopByLabel;
        private System.Windows.Forms.CheckBox insertBatchNumberLineCheckBox;
        private System.Windows.Forms.CheckBox exportAllBatchesCheckBox;
        private System.Windows.Forms.Label statusLineLabel;
    }
}

