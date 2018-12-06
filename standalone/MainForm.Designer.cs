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
            this.queryExtendLabel = new System.Windows.Forms.Label();
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
            this.exportButton.Location = new System.Drawing.Point(38, 643);
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
            this.queryTextBox.Size = new System.Drawing.Size(1075, 121);
            this.queryTextBox.TabIndex = 10;
            this.queryTextBox.Text = "traces \r\n| where timestamp > ago(1d) \r\n| extend line = message";
            // 
            // queryExtendLabel
            // 
            this.queryExtendLabel.AutoSize = true;
            this.queryExtendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryExtendLabel.Location = new System.Drawing.Point(32, 538);
            this.queryExtendLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.queryExtendLabel.Name = "queryExtendLabel";
            this.queryExtendLabel.Size = new System.Drawing.Size(321, 64);
            this.queryExtendLabel.TabIndex = 13;
            this.queryExtendLabel.Text = "| order by timestamp asc\r\n| project line";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 777);
            this.Controls.Add(this.queryExtendLabel);
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
            this.Text = "AILogsExporter v0.2";
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
        private System.Windows.Forms.Label queryExtendLabel;
    }
}

