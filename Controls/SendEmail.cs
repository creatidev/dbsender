using DBSender.Classes;
using System;
using System.Windows.Forms;

namespace DBSender.Controls
{
    public partial class SendEmailPanel : UserControl
    {
        private static readonly Settings Settings = JsonFile.Settings;
        private bool _saved = true;
        public bool DataLoaded;

        public SendEmailPanel()
        {
            InitializeComponent();
        }

        #region "Banner"

        /// <summary>
        /// Closes email panel view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseFilterWindowBtn_Click(object sender, EventArgs e)
        {
            if (_saved == false)
            {
                var response = MessageBox.Show(@"¿Quiere guardar los cambios?", "DBSender", MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        SaveAllData();
                        Dispose();
                        break;

                    case DialogResult.No:
                        Dispose();
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                Dispose();
            }
            Program.Form.MainMenuPanel.UpdatePics(DataLoaded);
        }

        #endregion "Banner"

        /// <summary>
        /// Catch the event of any button in email panel view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendEmailPanel_Load(object sender, EventArgs e)
        {
            GetData();
            EnableLogChk.CheckStateChanged += GetChanged;
            AutoLoadChk.CheckStateChanged += GetChanged;
            SMPTServerTxt.TextChanged += GetChanged;
            UserTxt.TextChanged += GetChanged;
            PasswordTxt.TextChanged += GetChanged;
            SMPTPortTxt.TextChanged += GetChanged;
            TLSChk.CheckStateChanged += GetChanged;
            SubjectTxt.TextChanged += GetChanged;
            MessageRT.TextChanged += GetChanged;
            HtmlChk.CheckStateChanged += GetChanged;
        }

        /// <summary>
        /// Function to get json data to set up in email panel
        /// </summary>
        private void GetData()
        {
            EnableLogChk.Checked = Settings.EnableLog;
            AutoLoadChk.Checked = Settings.DataFile.Autoload;
            SMPTServerTxt.Text = Settings.EmailSettings.Server.SmptServer;
            SMPTPortTxt.Text = Settings.EmailSettings.Server.SmptPort.ToString();
            UserTxt.Text = Settings.EmailSettings.Server.User;
            PasswordTxt.Text = Settings.EmailSettings.Server.Password;
            TLSChk.Checked = Settings.EmailSettings.Server.TLS;
            SubjectTxt.Text = Settings.EmailSettings.Template.Subject;
            MessageRT.Text = Settings.EmailSettings.Template.Message;
            HtmlChk.Checked = Settings.EmailSettings.Template.Html;
        }

        /// <summary>
        /// Capture any event to determine data changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetChanged(object sender, EventArgs e)
        {
            _saved = false;
        }

        /// <summary>
        /// Event to save and load data from json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveSettingsBtn_Click(object sender, EventArgs e)
        {
            SaveAllData();
            GetData();
            _saved = true;
        }

        /// <summary>
        /// Save all email settings in Json file
        /// </summary>
        private void SaveAllData()
        {
            Settings.EnableLog = EnableLogChk.Checked;
            Settings.DataFile.Autoload = AutoLoadChk.Checked;
            Settings.EmailSettings.Server.SmptServer = SMPTServerTxt.Text;
            Settings.EmailSettings.Server.SmptPort = int.Parse(SMPTPortTxt.Text);
            Settings.EmailSettings.Server.User = UserTxt.Text;
            Settings.EmailSettings.Server.Password = PasswordTxt.Text;
            Settings.EmailSettings.Server.TLS = TLSChk.Checked;
            Settings.EmailSettings.Template.Subject = SubjectTxt.Text;
            Settings.EmailSettings.Template.Message = MessageRT.Text;
            Settings.EmailSettings.Template.Html = HtmlChk.Checked;
            JsonFile.Save(Settings.ToJson());
        }

        /// <summary>
        /// Show/hide password characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowHidePassChk_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTxt.PasswordChar = ShowHidePassChk.Checked ? '\0' : '*';
        }
    }
}