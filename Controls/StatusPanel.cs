using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBSender.Classes;

namespace DBSender.Controls
{
    public partial class StatusPanel : UserControl
    {
        private static readonly Settings Settings = JsonFile.Settings;

        public StatusPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Send current view to back when pressing finish
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndBtn_Click(object sender, EventArgs e)
        {
            SendToBack();
            Finished(false);
        }

        /// <summary>
        /// Display end message
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="status"></param>
        public void ShowMessage(MessageType messageType, string status)
        {
            StatusLbl.Text = status;
            Logger.Add(messageType,status);
        }

        /// <summary>
        /// Finishing process display some extra buttons
        /// </summary>
        /// <param name="finish"></param>
        public void Finished(bool finish)
        {
            ButtonsActionPnl.Visible = finish;
            SplashPic.Image = finish ? Properties.Resources.test_passed_240px : Properties.Resources.loading;
            ViewLogBtn.Visible = Settings.EnableLog;
        }

        /// <summary>
        /// Calls log panel view and load available log files from the main class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewLogBtn_Click(object sender, EventArgs e)
        {
            Program.Form.ViewLogPanel.LoadLogs();
            Program.Form.ViewLogPanel.BringToFront();
        }
    }
}
