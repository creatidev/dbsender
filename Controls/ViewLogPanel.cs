using DBSender.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace DBSender.Controls
{
    public partial class ViewLogPanel : UserControl
    {
        private static readonly string LogsPath = JsonFile.AppDataPath + "\\LOGS";

        public ViewLogPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads all available log files from the folder to the combobox
        /// </summary>
        public void LoadLogs()
        {
            var folder = new DirectoryInfo(LogsPath);
            var files = folder.GetFiles("*.log");
            LogCbo.Items.Clear();
            foreach (var file in files)
            {
                LogCbo.Items.Add(file);
            }
        }

        /// <summary>
        /// Send to back Log panel view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseFilterWindowBtn_Click(object sender, EventArgs e)
        {
            SendToBack();
        }

        /// <summary>
        /// Reads the selected file and displays it in the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = File.ReadAllText(LogsPath + $"\\{LogCbo.Text}");
            TextBox1.ScrollToCaret();
        }
    }
}