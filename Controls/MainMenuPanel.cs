using DBSender.Classes;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DBSender.Controls
{
    public partial class MainMenuPanel : UserControl
    {
        private static readonly Settings Settings = JsonFile.Settings;

        public MainMenuPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Update the button status images, Visual set up guide
        /// </summary>
        /// <param name="dataLoaded"></param>
        public void UpdatePics(bool dataLoaded)
        {
            var excelFilePath = Settings.DataFile.Path;
            ShowLogPnl.Visible = Settings.EnableLog;

            SendEmailAlertPic.BackgroundImage = Properties.Resources.Checkmark_48px;
            SendEmailAlertLbl.Visible = false;
            if (Settings.EmailSettings.Server.User == "" || Settings.EmailSettings.Server.Password == "")
            {
                ServerAlertPic.BackgroundImage = Properties.Resources.box_important_48px;
                ServerAlertLbl.Visible = true;
                SendEmailAlertPic.BackgroundImage = Properties.Resources.box_important_48px;
                SendEmailAlertLbl.Visible = true;
            }
            else
            {
                ServerAlertPic.BackgroundImage = Properties.Resources.Checkmark_48px;
                ServerAlertLbl.Visible = false;
            }
            var addresses = Settings.Contacts.Address.Where(x => x.Enable).Select(s => s).ToList();
            if (addresses.Any())
            {
                NotebookAlertPic.BackgroundImage = Properties.Resources.Checkmark_48px;
                NotebookAlertLbl.Visible = false;
            }
            else
            {
                NotebookAlertPic.BackgroundImage = Properties.Resources.box_important_48px;
                NotebookAlertLbl.Visible = true;
                SendEmailAlertPic.BackgroundImage = Properties.Resources.box_important_48px;
                SendEmailAlertLbl.Visible = true;
            }
            if (File.Exists(excelFilePath))
            {
                if (dataLoaded)
                {
                    DataStatusLbl.Visible = false;
                    DBLoadedPic.BackgroundImage = Properties.Resources.Checkmark_48px;
                    ShowButton(Option.None);
                }
                else
                {
                    ShowButton(Option.Charge);
                }
            }
            else
            {
                ShowButton(Option.Import);
            }
        }

        /// <summary>
        /// Show status message for each pending application configuration
        /// </summary>
        /// <param name="loadOption"></param>
        public void ShowButton(Option loadOption)
        {
            switch (loadOption)
            {
                case Option.None:
                    ChargeBtn.Visible = false;
                    ImportFileBtn.Visible = true;
                    DBStatusLbl.Text = "Base de datos cargada";
                    break;

                case Option.Charge:
                    ChargeBtn.Visible = true;
                    DBStatusLbl.Text = "Cargar base de datos";
                    SendEmailAlertPic.BackgroundImage = Properties.Resources.box_important_48px;
                    SendEmailAlertLbl.Visible = true;
                    break;

                case Option.Import:
                    ImportFileBtn.Visible = true;
                    DBStatusLbl.Text = "Importar base de datos";
                    SendEmailAlertPic.BackgroundImage = Properties.Resources.box_important_48px;
                    SendEmailAlertLbl.Visible = true;
                    break;

                default:
                    ChargeBtn.Visible = false;
                    ImportFileBtn.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Calls the panel in main window to display the email set up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetUpEmailBtn_Click(object sender, EventArgs e)
        {
            Program.Form.ShowSetupEmail();
        }

        /// <summary>
        /// Calls the panel in main window to display the addressbook set up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressBookBtn_Click(object sender, EventArgs e)
        {
            Program.Form.ShowAddressBook();
        }

        /// <summary>
        /// Calls the function in main class to start email sending operation in background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void SendEmailBtn_Click(object sender, EventArgs e)
        {
            Program.Form.backgroundWorker1.RunWorkerAsync();
        }

        /// <summary>
        /// Calls the function in main class to open file dialog to import Excel file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void ImportFileBtn_Click(object sender, EventArgs e)
        {
            Program.Form.ImportData();
        }

        /// <summary>
        /// Calls the function in main class to import Excel file data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void ChargeBtn_Click(object sender, EventArgs e)
        {
            Program.Form.GetData(Settings.DataFile.Path);
        }

        /// <summary>
        /// Calls the panel in main window to display registry log
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