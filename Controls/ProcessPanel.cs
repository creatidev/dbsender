using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBSender.Classes;

namespace DBSender.Controls
{
    public partial class ProcessPanel : UserControl
    {
        private static readonly Settings Settings = JsonFile.Settings;

        public ProcessPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show Open File Dialog from main class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void ImportFileBtn_Click(object sender, EventArgs e)
        {
            Program.Form.ImportData();
        }

        /// <summary>
        /// Start getting excel data if excel file found
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void ChargeBtn_Click(object sender, EventArgs e)
        {
            Program.Form.GetData(Settings.DataFile.Path);
        }

        /// <summary>
        /// Sets update text on the label
        /// </summary>
        /// <param name="text"></param>
        public void SetUpdate(string text) => UpdateLbl.Text = text;

        /// <summary>
        /// Shows the button depending on whether the Excel data was loaded into memory
        /// </summary>
        /// <param name="loadOption"></param>
        public void ShowButton(Option loadOption)
        {
            if (loadOption > 0) DragDropPanel.Visible = true;
            switch (loadOption)
            {
                case Option.None:
                    DragDropPanel.Visible = false;
                    ChargeBtn.Visible = false;
                    ImportFileBtn.Visible = false;
                    break;
                case Option.Charge:
                    ChargeBtn.Visible = true;
                    StatusLbl.Text = "Cargar base de datos";
                    break;
                case Option.Import:
                    ImportFileBtn.Visible = true;
                    StatusLbl.Text = "Importar base de datos";
                    break;
                default:
                    DragDropPanel.Visible = false;
                    ChargeBtn.Visible = false;
                    ImportFileBtn.Visible = false;
                    break;
            }
        }
    }

    /// <summary>
    /// Enumeration to set options in the main process panel
    /// </summary>
    public enum Option
    {
        None,
        Charge,
        Import
    }
}
