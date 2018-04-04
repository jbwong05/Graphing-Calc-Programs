namespace Graphing_Calculator_Program_Installer
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
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomeNextButton = new System.Windows.Forms.Button();
            this.initializationPanel = new System.Windows.Forms.Panel();
            this.retryButton = new System.Windows.Forms.Button();
            this.initializationProgressBar = new System.Windows.Forms.ProgressBar();
            this.initializationTaskLabel = new System.Windows.Forms.Label();
            this.fileSelectionPanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.selectedFilesLabel = new System.Windows.Forms.Label();
            this.selectedFilesList = new System.Windows.Forms.ListBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.welcomePanel.SuspendLayout();
            this.initializationPanel.SuspendLayout();
            this.fileSelectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.welcomePanel.Controls.Add(this.welcomeLabel);
            this.welcomePanel.Controls.Add(this.welcomeNextButton);
            this.welcomePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(800, 543);
            this.welcomePanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(16, 22);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(754, 20);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Texas Instrument calculator program installer that utilizes the TiSendTo.exe from" +
    " the TI Connect Software.";
            // 
            // welcomeNextButton
            // 
            this.welcomeNextButton.Location = new System.Drawing.Point(688, 499);
            this.welcomeNextButton.Name = "welcomeNextButton";
            this.welcomeNextButton.Size = new System.Drawing.Size(96, 31);
            this.welcomeNextButton.TabIndex = 0;
            this.welcomeNextButton.Text = "Next";
            this.welcomeNextButton.UseVisualStyleBackColor = true;
            this.welcomeNextButton.Click += new System.EventHandler(this.WelcomeNextButton_Click);
            // 
            // initializationPanel
            // 
            this.initializationPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.initializationPanel.Controls.Add(this.retryButton);
            this.initializationPanel.Controls.Add(this.initializationProgressBar);
            this.initializationPanel.Controls.Add(this.initializationTaskLabel);
            this.initializationPanel.Location = new System.Drawing.Point(0, 0);
            this.initializationPanel.Name = "initializationPanel";
            this.initializationPanel.Size = new System.Drawing.Size(800, 543);
            this.initializationPanel.TabIndex = 1;
            // 
            // retryButton
            // 
            this.retryButton.Location = new System.Drawing.Point(692, 499);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(96, 31);
            this.retryButton.TabIndex = 2;
            this.retryButton.Text = "Retry";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Visible = false;
            this.retryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // initializationProgressBar
            // 
            this.initializationProgressBar.Location = new System.Drawing.Point(24, 55);
            this.initializationProgressBar.Maximum = 2;
            this.initializationProgressBar.Name = "initializationProgressBar";
            this.initializationProgressBar.Size = new System.Drawing.Size(751, 23);
            this.initializationProgressBar.Step = 1;
            this.initializationProgressBar.TabIndex = 1;
            // 
            // initializationTaskLabel
            // 
            this.initializationTaskLabel.AutoSize = true;
            this.initializationTaskLabel.Location = new System.Drawing.Point(20, 20);
            this.initializationTaskLabel.Name = "initializationTaskLabel";
            this.initializationTaskLabel.Size = new System.Drawing.Size(133, 20);
            this.initializationTaskLabel.TabIndex = 0;
            this.initializationTaskLabel.Text = "Status: Initializing";
            // 
            // fileSelectionPanel
            // 
            this.fileSelectionPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fileSelectionPanel.Controls.Add(this.removeButton);
            this.fileSelectionPanel.Controls.Add(this.selectedFilesLabel);
            this.fileSelectionPanel.Controls.Add(this.selectedFilesList);
            this.fileSelectionPanel.Controls.Add(this.browseButton);
            this.fileSelectionPanel.Controls.Add(this.installButton);
            this.fileSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.fileSelectionPanel.Name = "fileSelectionPanel";
            this.fileSelectionPanel.Size = new System.Drawing.Size(800, 543);
            this.fileSelectionPanel.TabIndex = 2;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(26, 499);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(96, 31);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // selectedFilesLabel
            // 
            this.selectedFilesLabel.AutoSize = true;
            this.selectedFilesLabel.Location = new System.Drawing.Point(22, 52);
            this.selectedFilesLabel.Name = "selectedFilesLabel";
            this.selectedFilesLabel.Size = new System.Drawing.Size(203, 20);
            this.selectedFilesLabel.TabIndex = 5;
            this.selectedFilesLabel.Text = "Files to Install to Calculator:";
            // 
            // selectedFilesList
            // 
            this.selectedFilesList.FormattingEnabled = true;
            this.selectedFilesList.HorizontalScrollbar = true;
            this.selectedFilesList.ItemHeight = 20;
            this.selectedFilesList.Location = new System.Drawing.Point(26, 89);
            this.selectedFilesList.Name = "selectedFilesList";
            this.selectedFilesList.ScrollAlwaysVisible = true;
            this.selectedFilesList.Size = new System.Drawing.Size(758, 404);
            this.selectedFilesList.TabIndex = 4;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(688, 47);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(96, 31);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(688, 499);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(96, 31);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.initializationPanel);
            this.Controls.Add(this.fileSelectionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Graphing Calculator Program Installer";
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.initializationPanel.ResumeLayout(false);
            this.initializationPanel.PerformLayout();
            this.fileSelectionPanel.ResumeLayout(false);
            this.fileSelectionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Button welcomeNextButton;
        private System.Windows.Forms.Panel initializationPanel;
        private System.Windows.Forms.ProgressBar initializationProgressBar;
        private System.Windows.Forms.Label initializationTaskLabel;
        private System.Windows.Forms.Panel fileSelectionPanel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.ListBox selectedFilesList;
        private System.Windows.Forms.Label selectedFilesLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button retryButton;
    }
}

