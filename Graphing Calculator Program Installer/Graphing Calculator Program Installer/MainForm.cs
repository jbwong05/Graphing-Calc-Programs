using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Windows;
using System.Net;

namespace Graphing_Calculator_Program_Installer
{
    public partial class MainForm : Form
    {
        private Panel activePanel;
        private bool installTISendToFound;

        public MainForm()
        {
            installTISendToFound = false;
            InitializeComponent();
            SetActivePanel();
        }

        private void SetActivePanel()
        {
            activePanel = welcomePanel;
            //set other panels visibility to false
            initializationPanel.Visible = false;
            fileSelectionPanel.Visible = false;
        }

        private void SwitchPanel(Panel newPanel)
        {
            activePanel.Visible = false;
            activePanel = newPanel;
            activePanel.Visible = true;
        }

        private bool BeginInitialization()
        {
            string install = @"C:\Program Files (x86)\TI Education\TI Connect\TISendTo.exe";
            string local = @"TISendTo.exe";
            if (File.Exists(install))
            {
                initializationTaskLabel.Text = "Status: Checking for install of TI Connect Software";
                installTISendToFound = true;
                initializationProgressBar.Value = initializationProgressBar.Value+2;
                return true;
            }
            else if (File.Exists(local))
            {
                initializationTaskLabel.Text = "Staus: Checking for local instance of TISendTo.exe";
                initializationProgressBar.Value = initializationProgressBar.Value + 2;
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetStartArguements(ListBox.ObjectCollection items)
        {
            string toReturn = "";
            foreach(string file in items)
            {
                toReturn += " \"" + file + "\"";
            }
            return toReturn;
        }

        private void WelcomeNextButton_Click(object sender, EventArgs e)
        {
            SwitchPanel(initializationPanel);
            AttemptInitialization();
        }

        private void AttemptInitialization()
        {
            if (BeginInitialization())
            {
                initializationTaskLabel.Text = "Finished";
                //switch to next panel
                SwitchPanel(fileSelectionPanel);
            }
            else
            {
                //open error dialogue box
                MessageBox();
            }
        }

        private void MessageBox()
        {
            string messageBoxText = "TI Connect Software is not installed and the TiSendTo.exe cannot be found. Do you want to download and install the software?";
            string caption = "Ti Connect Software Not Found";
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Error;
            MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    initializationProgressBar.Value = 0;
                    initializationTaskLabel.Text = "Status: Downloading TI Connect Software...Please Wait";
                    DownloadInstaller();
                    RunInstaller();
                    retryButton.Visible = true;
                    break;
                case MessageBoxResult.No:
                    Close();
                    break;
            }
        }

        private void DownloadInstaller()
        {
            string remoteUri = "https://education.ti.com/download/en/ed-tech/B59F6C83468C4574ABFEE93D2BC3F807/A885DD53BEC14496971FE5A42F1014CF/TI-Connect-4.0.0.218.exe";
            string fileName = "TI-Connect-4.0.0.218.exe", myStringWebResource = null;
            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();
            // Concatenate the domain with the Web resource filename.
            myStringWebResource = remoteUri + fileName;
            //Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
            // Download the Web resource and save it into the current filesystem folder.
            myWebClient.DownloadFile(myStringWebResource, fileName);
        }

        private void RunInstaller()
        {
            Process installer = new Process();
            installer.StartInfo.FileName = "TI-Connect-4.0.0.218.exe";
            installer.Start();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //openFileDialog1.InitialDirectory = "c:\\";
                Filter = "Program (*.8xp)|*.8xp|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                Multiselect = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFilesList.Items.AddRange(openFileDialog1.FileNames);
            }
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            if (selectedFilesList.Items.Count > 0)
            {
                Process tiSendTo = new Process();
                if (installTISendToFound)
                {
                    tiSendTo.StartInfo.FileName = @"C:\Program Files (x86)\Ti Education\Ti Connect\TiSendTo.exe";
                }
                else
                {
                    tiSendTo.StartInfo.FileName = "TiSendTo.exe";
                }
                tiSendTo.StartInfo.Arguments = GetStartArguements(selectedFilesList.Items);
                tiSendTo.Start();
                Close();
            }  
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (selectedFilesList.SelectedIndices.Count > 0)
            {
                /*var tempSelectedItems = selectedFilesList.SelectedItems;
                for(int i=0; i<tempSelectedItems.Count; i++)
                {
                    selectedFilesList.Items.Remove(tempSelectedItems[i]);
                }*/
                selectedFilesList.Items.Remove(selectedFilesList.SelectedItem);
            }
        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            initializationTaskLabel.Text = "Status: Initializing";
            AttemptInitialization();
        }
    }
}
