using DBSender.Classes;
using DBSender.Controls;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MiniExcelLibs.MiniExcel;

namespace DBSender
{
    public partial class Main : Form
    {
        private static readonly Settings Settings = JsonFile.Settings;
        private readonly ProcessPanel _splashPanel = new ProcessPanel();
        private readonly StatusPanel _statusPanel = new StatusPanel();
        public readonly MainMenuPanel MainMenuPanel = new MainMenuPanel();
        public readonly ViewLogPanel ViewLogPanel = new ViewLogPanel();
        private readonly string _jsonFilePath = JsonFile.AppDataPath;
        public List<Client> ClientList = new List<Client>();
        private DataTable _dataTable = new DataTable();
        public bool DataLoaded;
        private bool _dragable;
        private int _mouseX;
        private int _mouseY;

        [Obsolete]// It's obsolete but I need, Miniexcel deprecated function
        public Main()
        {
            InitializeComponent();
            if (!Directory.Exists(_jsonFilePath)) Directory.CreateDirectory(_jsonFilePath);
            var currentPath = _jsonFilePath + "\\LOGS";
            if (!Directory.Exists(currentPath)) Directory.CreateDirectory(currentPath);
        }

        #region Banner

        /// <summary>
        /// Mousedown event on the banner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BannerPnl_MouseDown(object sender, MouseEventArgs e)
        {
            _dragable = true;
            _mouseX = Cursor.Position.X - Left;
            _mouseY = Cursor.Position.Y - Top;
        }

        /// <summary>
        /// Mousemove event on the banner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BannerPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragable) return;
            Top = Cursor.Position.Y - _mouseY;
            Left = Cursor.Position.X - _mouseX;
        }

        /// <summary>
        /// Mouseup event on the banner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BannerPnl_MouseUp(object sender, MouseEventArgs e)
        {
            _dragable = false;
        }

        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Window minimize button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Enable/Disable automatic loading data from excel file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoLoadChk_CheckedChanged(object sender, EventArgs e)
        {
            AutoLoadChk.BackgroundImage = Settings.DataFile.Autoload
                ? Properties.Resources.toggle_off_48px
                : Properties.Resources.toggle_on_48px;
            Settings.DataFile.Autoload = AutoLoadChk.Checked;
            JsonFile.Save(Settings.ToJson());
        }

        /// <summary>
        /// Switch views of the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModeChk_CheckedChanged(object sender, EventArgs e)
        {
            switch (ModeChk.Checked)
            {
                case true:
                    MainMenuPanel.BringToFront();
                    MainMenuPanel.UpdatePics(DataLoaded);
                    break;

                default:
                    MainMenuPanel.SendToBack();
                    ShowData();
                    break;
            }
        }

        #endregion Banner

        #region "Actions"

        /// <summary>
        /// Main form function, defines user interface type and automatic data loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void Main_Load(object sender, EventArgs e)
        {
            var excelFilePath = Settings.DataFile.Path;
            AutoLoadChk.Checked = Settings.DataFile.Autoload;
            AutoLoadChk.BackgroundImage = !AutoLoadChk.Checked
                ? Properties.Resources.toggle_off_48px
                : Properties.Resources.toggle_on_48px;
            _splashPanel.Location = new Point(0, 50);
            _statusPanel.Location = new Point(0, 50);
            MainMenuPanel.Location = new Point(0, 50);
            ViewLogPanel.Location = new Point(0, 50);

            Controls.Add(MainMenuPanel);
            Controls.Add(ViewLogPanel);
            Controls.Add(_splashPanel);
            Controls.Add(_statusPanel);

            MainMenuPanel.BringToFront();
            PathExcelFileTxt.Text = excelFilePath;

            if (File.Exists(excelFilePath))
            {
                if (AutoLoadChk.Checked)
                {
                    GetData(excelFilePath);
                }
                else
                {
                    MainMenuPanel.UpdatePics(DataLoaded);
                }
            }
            else
            {
                MainMenuPanel.UpdatePics(DataLoaded);
                MainMenuPanel.ShowButton(Option.Import);
            }
        }

        /// <summary>
        /// Set o import data (Excel file filter)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void SetDataBtn_Click(object sender, EventArgs e)
        {
            ImportData();
        }

        /// <summary>
        /// Show email set up window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigEmailBtn_Click(object sender, EventArgs e)
        {
            ShowSetupEmail();
        }

        /// <summary>
        /// Show address book window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressBookBtn_Click(object sender, EventArgs e)
        {
            ShowAddressBook();
        }

        /// <summary>
        /// Initialize email sending in backgroundWorker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void SendEmailBtn_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        /// <summary>
        /// It is responsible for starting the operation in the background to avoid window freezing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SendEmails();
        }

        #endregion "Actions"

        #region "Methods"

        /// <summary>
        /// Display Open File Dialog to load an Excel file
        /// </summary>
        [Obsolete]
        public void ImportData()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = @"Libro de Excel|*.xls;*.xlsx;*.xlsm";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PathExcelFileTxt.Text = ofd.FileName;
                    Settings.DataFile.Path = ofd.FileName;
                    JsonFile.Save(Settings.ToJson());
                    GetData(ofd.FileName);
                }
            }
        }

        /// <summary>
        /// Get data from Excel file to load into memory
        /// </summary>
        /// <param name="excelPath"></param>
        [Obsolete]
        public async void GetData(string excelPath)
        {
            await Task.Run(() => GetExcelData(excelPath));
        }

        /// <summary>
        /// Convert excel file into manipulable database through MiniExcel
        /// </summary>
        /// <param name="excelPath"></param>
        [Obsolete]
        public async void GetExcelData(string excelPath)
        {
            _splashPanel.Invoke(s => s.BringToFront());
            _splashPanel.Invoke(s => s.ShowButton(Option.None));
            var count = GetColumns(excelPath).Count;
            ColumnCountLbl.Invoke(l => l.Text = count.ToString());
            _splashPanel.Invoke(s => s.SetUpdate("Cargando información, por favor espere...\r\n"));
            _dataTable = null;
            _dataTable = await QueryAsDataTableAsync(excelPath, useHeaderRow: true);
            DataLoaded = true;

            var clients = _dataTable.AsEnumerable().Select(x => x.Field<string>("Nombre_Cliente")).Distinct();
            _splashPanel.Invoke(s => s.SetUpdate("Agrupando información, un momento más...\r\n"));
            foreach (var name in clients)
            {
                var projects = _dataTable.AsEnumerable().Where(x => x.Field<string>("Nombre_Cliente") == name).Select(x => x.Field<string>("Proyecto")).Distinct().ToList();

                var client = new Client
                {
                    Name = name,
                    Projects = projects
                };
                ClientList.Add(client);
            }

            if (ModeChk.Checked) //Añadir la opción en Settings.
            {
                MainMenuPanel.Invoke(s => s.BringToFront());
                MainMenuPanel.Invoke(s => s.UpdatePics(DataLoaded));
            }
            else
            {
                dataGridView1.Invoke(s => s.DataSource = _dataTable);
                dataGridView1.Invoke(s => s.RowHeadersVisible = false);
            }
            dataGridView1.Invoke(s => s.DataSource = _dataTable);
            _splashPanel.Invoke(s => s.SendToBack());
            ModeChk.Invoke(s => s.Visible = true);
        }

        /// <summary>
        /// Start the procedure for sending massive emails with previously processed attachments
        /// </summary>
        [Obsolete]
        public async void SendEmails()
        {
            var option = MessageBox.Show(@"Esta acción iniciará el procesamiento de datos y posterior envío a los contactos registrados ¿Quiere continuar?", "DBSender", MessageBoxButtons.YesNo);
            var addresses = Settings.Contacts.Address.Where(x => x.Enable).Select(s => s).ToList();
            switch (option)
            {
                case DialogResult.Yes:
                    if (DataLoaded == false)
                    {
                        MessageBox.Show("Base de datos sin cargar");
                    }
                    else if (Settings.EmailSettings.Server.User == "" || Settings.EmailSettings.Server.Password == "")
                    {
                        MessageBox.Show(@"Servidor de correo no configurado. Por favor ingrese los datos requeridos.", "DBSender");
                    }
                    else if (addresses.Count == 0)
                    {
                        MessageBox.Show(@"No se encuentran contactos registrados/habilitados para iniciar el proceso. Por favor registre/habilite contactos.", "DBSender");
                    }
                    else
                    {
                        var attachments = new List<string>();
                        var totalProjectList = 0;
                        _statusPanel.Invoke(s => s.BringToFront());
                        foreach (var address in addresses)
                        {
                            var projectList = Settings.Contacts.Address.Where(x => x.Email == address.Email).SelectMany(s => s.Clients.SelectMany(x => x.Projects)).ToList();

                            UpdateMessage(MessageType.Info, $"Contactos registrados {addresses.Count} para {projectList.Count} proyectos", 1000);
                            UpdateMessage(MessageType.Info, $"Se generarán {projectList.Count} archivos para {address.Email}", 1000);
                            attachments.Clear();

                            foreach (var project in projectList)
                            {
                                totalProjectList++;
                                var data = new DataView(_dataTable) { RowFilter = "Proyecto = " + project };
                                var moddedDataTable = data.ToTable();
                                if (moddedDataTable.Rows.Count != 0)
                                {
                                    var path = Path.GetTempPath() + project + ".xlsx";
                                    await SaveAsAsync(path, moddedDataTable, excelType: ExcelType.XLSX, overwriteFile: true);
                                    attachments.Add(path);
                                    UpdateMessage(MessageType.Info, $"Generando [{project}.xlsx] {attachments.Count} de {projectList.Count} archivos para {address.Email}", 0);
                                    moddedDataTable.Clear();
                                    moddedDataTable.Dispose();
                                    GC.Collect();
                                }
                                else
                                {
                                    UpdateMessage(MessageType.Error, $"La consulta de {project} no arrojó resultados para {address.Email}", 3000);
                                }
                            }

                            if (attachments.Any())
                            {
                                SendFileByEmail(attachments, address);
                            }
                            else
                            {
                                UpdateMessage(MessageType.Error, $"No se encontraron archivos adjuntos, no se enviará correo a {address.Email}", 3000);
                            }
                        }
                        UpdateMessage(MessageType.Info, $"Procedimiento finalizado.\n Se enviaron {totalProjectList} archivos adjuntos a {addresses.Count} contactos registrados.", 3000);
                        _statusPanel.Invoke(s => s.Finished(true));
                    }
                    break;

                case DialogResult.No:
                    break;
            }
        }

        /// <summary>
        /// Display messages according to the status of the operation
        /// </summary>
        /// <param name="messageType"></param>
        /// <param name="message"></param>
        /// <param name="wait"></param>
        private void UpdateMessage(MessageType messageType, string message, int wait)
        {
            _statusPanel.Invoke(s => s.ShowMessage(messageType, message));
            Thread.Sleep(wait);
        }

        /// <summary>
        /// Send attachments for each email registered in the notebook
        /// </summary>
        /// <param name="attachments"></param>
        /// <param name="address"></param>
        private void SendFileByEmail(List<string> attachments, Address address)
        {
            var template = Settings.EmailSettings.Template;
            var html = Settings.EmailSettings.Template.Html;
            var mailboxAddresses = new MailboxAddress(address.Name, address.Email);
            UpdateMessage(MessageType.Info, $"Enviando {attachments.Count} archivos adjuntos para {address.Email}", 1000);
            var message = new MimeMessage();
            var builder = new BodyBuilder();

            switch (html)
            {
                case true:
                    builder.HtmlBody = template.Message;
                    break;

                default:
                    builder.TextBody = template.Message;
                    break;
            }

            attachments.ForEach(x => builder.Attachments.Add(x));
            message.From.Add(InternetAddress.Parse(Settings.EmailSettings.Server.User));
            message.To.Add(mailboxAddresses);
            message.Subject = template.Subject;
            message.Body = builder.ToMessageBody();
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect(Settings.EmailSettings.Server.SmptServer, Settings.EmailSettings.Server.SmptPort, SecureSocketOptions.StartTls); //It is required to validate TLS from the configuration
                smtpClient.Authenticate(Settings.EmailSettings.Server.User, Settings.EmailSettings.Server.Password); //It is required to validate mail data before saving configuration
                smtpClient.MessageSent += OnMessageSent;
                smtpClient.Send(message);
                smtpClient.Disconnect(true);
            }
        }

        /// <summary>
        /// Display a finalization message for each registered email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMessageSent(object sender, MessageSentEventArgs e)
        {
            UpdateMessage(MessageType.Info, $"Mensaje enviado correctamente a {e.Message.To}", 2000);
        }

        /// <summary>
        /// Show address book to set up email and data attachment
        /// </summary>
        public void ShowAddressBook()
        {
            if (DataLoaded)
            {
                var addressBookPanel = new AddressBookPanel
                {
                    ClientList = ClientList,
                    Location = new Point(0, 50),
                    DataLoaded = DataLoaded
                };

                Controls.Add(addressBookPanel);
                addressBookPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("Primero debe cargar la base de datos", "DBSender");
            }
        }

        /// <summary>
        /// Display email setup
        /// </summary>
        public void ShowSetupEmail()
        {
            var sendEmailPanel = new SendEmailPanel
            {
                Location = new Point(0, 50),
                DataLoaded = DataLoaded
            };

            Controls.Add(sendEmailPanel);
            sendEmailPanel.BringToFront();
        }

        /// <summary>
        /// Data is charged from memory to datagridview, just visualize data
        /// </summary>
        private void ShowData()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = !ModeChk.Checked ? _dataTable : null;
        }

        #endregion "Methods"

        /// <summary>
        /// Display log window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewLogBtn_Click(object sender, EventArgs e)
        {
            ViewLogPanel.LoadLogs();
            ViewLogPanel.BringToFront();
        }

        /// <summary>
        /// Starting event for Excel file data collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void ChargeBtn_Click(object sender, EventArgs e)
        {
            GetData(Settings.DataFile.Path);
        }
    }
}