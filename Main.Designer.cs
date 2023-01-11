
namespace DBSender
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BannerPnl = new System.Windows.Forms.Panel();
            this.ModeChk = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AutoLoadChk = new System.Windows.Forms.CheckBox();
            this.PathExcelFileTxt = new System.Windows.Forms.TextBox();
            this.ActionPnl = new System.Windows.Forms.Panel();
            this.ChargeBtn = new System.Windows.Forms.Button();
            this.DataActionPnl = new System.Windows.Forms.Panel();
            this.SendEmailBtn = new System.Windows.Forms.Button();
            this.AddressBookBtn = new System.Windows.Forms.Button();
            this.ConfigEmailBtn = new System.Windows.Forms.Button();
            this.ImportDataBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CounterLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.RegCountLbl = new System.Windows.Forms.Label();
            this.ColumnCountLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FooterPnl = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.DataGridPnl = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ViewLogBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BannerPnl.SuspendLayout();
            this.ActionPnl.SuspendLayout();
            this.DataActionPnl.SuspendLayout();
            this.FooterPnl.SuspendLayout();
            this.DataGridPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 470);
            this.dataGridView1.TabIndex = 3;
            // 
            // BannerPnl
            // 
            this.BannerPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.BannerPnl.Controls.Add(this.ModeChk);
            this.BannerPnl.Controls.Add(this.label7);
            this.BannerPnl.Controls.Add(this.MinimizeBtn);
            this.BannerPnl.Controls.Add(this.CloseBtn);
            this.BannerPnl.Controls.Add(this.AutoLoadChk);
            this.BannerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BannerPnl.Location = new System.Drawing.Point(0, 0);
            this.BannerPnl.Name = "BannerPnl";
            this.BannerPnl.Size = new System.Drawing.Size(800, 50);
            this.BannerPnl.TabIndex = 5;
            this.BannerPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BannerPnl_MouseDown);
            this.BannerPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BannerPnl_MouseMove);
            this.BannerPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BannerPnl_MouseUp);
            // 
            // ModeChk
            // 
            this.ModeChk.Appearance = System.Windows.Forms.Appearance.Button;
            this.ModeChk.BackgroundImage = global::DBSender.Properties.Resources.shortcuts_36px;
            this.ModeChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ModeChk.Checked = true;
            this.ModeChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ModeChk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ModeChk.FlatAppearance.BorderSize = 0;
            this.ModeChk.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModeChk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ModeChk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ModeChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeChk.ForeColor = System.Drawing.Color.LightBlue;
            this.ModeChk.Location = new System.Drawing.Point(756, 7);
            this.ModeChk.Name = "ModeChk";
            this.ModeChk.Size = new System.Drawing.Size(36, 36);
            this.ModeChk.TabIndex = 17;
            this.ModeChk.UseVisualStyleBackColor = true;
            this.ModeChk.CheckedChanged += new System.EventHandler(this.ModeChk_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightBlue;
            this.label7.Location = new System.Drawing.Point(372, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "DBSender";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackgroundImage = global::DBSender.Properties.Resources.minimize_window_48px;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(50, 7);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(36, 36);
            this.MinimizeBtn.TabIndex = 14;
            this.toolTip1.SetToolTip(this.MinimizeBtn, "Minimizar");
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImage = global::DBSender.Properties.Resources.close_window_48px;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(7, 7);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(36, 36);
            this.CloseBtn.TabIndex = 6;
            this.toolTip1.SetToolTip(this.CloseBtn, "Cerrar");
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AutoLoadChk
            // 
            this.AutoLoadChk.Appearance = System.Windows.Forms.Appearance.Button;
            this.AutoLoadChk.BackgroundImage = global::DBSender.Properties.Resources.toggle_off_48px;
            this.AutoLoadChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AutoLoadChk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoLoadChk.Checked = true;
            this.AutoLoadChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoLoadChk.FlatAppearance.BorderSize = 0;
            this.AutoLoadChk.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.AutoLoadChk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.AutoLoadChk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.AutoLoadChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoLoadChk.ForeColor = System.Drawing.Color.LightBlue;
            this.AutoLoadChk.Location = new System.Drawing.Point(3, 11);
            this.AutoLoadChk.Name = "AutoLoadChk";
            this.AutoLoadChk.Size = new System.Drawing.Size(212, 28);
            this.AutoLoadChk.TabIndex = 13;
            this.AutoLoadChk.Text = "Cargar al iniciar";
            this.AutoLoadChk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoLoadChk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.AutoLoadChk, "Cargar datos al iniciar");
            this.AutoLoadChk.UseVisualStyleBackColor = true;
            this.AutoLoadChk.CheckedChanged += new System.EventHandler(this.AutoLoadChk_CheckedChanged);
            // 
            // PathExcelFileTxt
            // 
            this.PathExcelFileTxt.Location = new System.Drawing.Point(7, 16);
            this.PathExcelFileTxt.Name = "PathExcelFileTxt";
            this.PathExcelFileTxt.Size = new System.Drawing.Size(287, 21);
            this.PathExcelFileTxt.TabIndex = 7;
            // 
            // ActionPnl
            // 
            this.ActionPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.ActionPnl.Controls.Add(this.ChargeBtn);
            this.ActionPnl.Controls.Add(this.DataActionPnl);
            this.ActionPnl.Controls.Add(this.PathExcelFileTxt);
            this.ActionPnl.Controls.Add(this.ImportDataBtn);
            this.ActionPnl.Controls.Add(this.label2);
            this.ActionPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActionPnl.Location = new System.Drawing.Point(0, 0);
            this.ActionPnl.Name = "ActionPnl";
            this.ActionPnl.Size = new System.Drawing.Size(800, 40);
            this.ActionPnl.TabIndex = 9;
            // 
            // ChargeBtn
            // 
            this.ChargeBtn.BackgroundImage = global::DBSender.Properties.Resources.icons8_play_200px;
            this.ChargeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChargeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ChargeBtn.FlatAppearance.BorderSize = 0;
            this.ChargeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChargeBtn.Location = new System.Drawing.Point(334, 2);
            this.ChargeBtn.Name = "ChargeBtn";
            this.ChargeBtn.Size = new System.Drawing.Size(36, 36);
            this.ChargeBtn.TabIndex = 47;
            this.ChargeBtn.UseVisualStyleBackColor = true;
            this.ChargeBtn.Click += new System.EventHandler(this.ChargeBtn_Click);
            // 
            // DataActionPnl
            // 
            this.DataActionPnl.Controls.Add(this.ViewLogBtn);
            this.DataActionPnl.Controls.Add(this.SendEmailBtn);
            this.DataActionPnl.Controls.Add(this.AddressBookBtn);
            this.DataActionPnl.Controls.Add(this.ConfigEmailBtn);
            this.DataActionPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.DataActionPnl.Location = new System.Drawing.Point(375, 0);
            this.DataActionPnl.Name = "DataActionPnl";
            this.DataActionPnl.Size = new System.Drawing.Size(425, 40);
            this.DataActionPnl.TabIndex = 14;
            // 
            // SendEmailBtn
            // 
            this.SendEmailBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SendEmailBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendEmailBtn.FlatAppearance.BorderSize = 0;
            this.SendEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendEmailBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.SendEmailBtn.ForeColor = System.Drawing.Color.LightBlue;
            this.SendEmailBtn.Image = global::DBSender.Properties.Resources.send_email_36px;
            this.SendEmailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SendEmailBtn.Location = new System.Drawing.Point(320, 2);
            this.SendEmailBtn.Name = "SendEmailBtn";
            this.SendEmailBtn.Size = new System.Drawing.Size(100, 36);
            this.SendEmailBtn.TabIndex = 0;
            this.SendEmailBtn.Text = "Enviar";
            this.SendEmailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.SendEmailBtn, "Iniciar envío de correos");
            this.SendEmailBtn.UseVisualStyleBackColor = false;
            this.SendEmailBtn.Click += new System.EventHandler(this.SendEmailBtn_Click);
            // 
            // AddressBookBtn
            // 
            this.AddressBookBtn.BackColor = System.Drawing.Color.DarkRed;
            this.AddressBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddressBookBtn.FlatAppearance.BorderSize = 0;
            this.AddressBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddressBookBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddressBookBtn.ForeColor = System.Drawing.Color.LightBlue;
            this.AddressBookBtn.Image = global::DBSender.Properties.Resources.contacts_36px;
            this.AddressBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddressBookBtn.Location = new System.Drawing.Point(209, 2);
            this.AddressBookBtn.Name = "AddressBookBtn";
            this.AddressBookBtn.Size = new System.Drawing.Size(108, 36);
            this.AddressBookBtn.TabIndex = 46;
            this.AddressBookBtn.Text = "Admintrar";
            this.AddressBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.AddressBookBtn, "Administre contactos y asigne proyectos");
            this.AddressBookBtn.UseVisualStyleBackColor = false;
            this.AddressBookBtn.Click += new System.EventHandler(this.AddressBookBtn_Click);
            // 
            // ConfigEmailBtn
            // 
            this.ConfigEmailBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ConfigEmailBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfigEmailBtn.FlatAppearance.BorderSize = 0;
            this.ConfigEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigEmailBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigEmailBtn.ForeColor = System.Drawing.Color.LightBlue;
            this.ConfigEmailBtn.Image = global::DBSender.Properties.Resources.message_settings_36px;
            this.ConfigEmailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfigEmailBtn.Location = new System.Drawing.Point(106, 2);
            this.ConfigEmailBtn.Name = "ConfigEmailBtn";
            this.ConfigEmailBtn.Size = new System.Drawing.Size(100, 36);
            this.ConfigEmailBtn.TabIndex = 10;
            this.ConfigEmailBtn.Text = "Correo";
            this.ConfigEmailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.ConfigEmailBtn, "Configurar servidor de correo y cuerpo de mensaje");
            this.ConfigEmailBtn.UseVisualStyleBackColor = false;
            this.ConfigEmailBtn.Click += new System.EventHandler(this.ConfigEmailBtn_Click);
            // 
            // ImportDataBtn
            // 
            this.ImportDataBtn.BackgroundImage = global::DBSender.Properties.Resources.google_sheets_48px;
            this.ImportDataBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImportDataBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ImportDataBtn.FlatAppearance.BorderSize = 0;
            this.ImportDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportDataBtn.Location = new System.Drawing.Point(298, 2);
            this.ImportDataBtn.Name = "ImportDataBtn";
            this.ImportDataBtn.Size = new System.Drawing.Size(36, 36);
            this.ImportDataBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.ImportDataBtn, "Cargar archivo Excel");
            this.ImportDataBtn.UseVisualStyleBackColor = true;
            this.ImportDataBtn.Click += new System.EventHandler(this.SetDataBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Archivo:";
            // 
            // CounterLbl
            // 
            this.CounterLbl.AutoSize = true;
            this.CounterLbl.ForeColor = System.Drawing.Color.LightBlue;
            this.CounterLbl.Location = new System.Drawing.Point(63, 5);
            this.CounterLbl.Name = "CounterLbl";
            this.CounterLbl.Size = new System.Drawing.Size(19, 13);
            this.CounterLbl.TabIndex = 13;
            this.CounterLbl.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightBlue;
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filas:";
            // 
            // RegCountLbl
            // 
            this.RegCountLbl.AutoSize = true;
            this.RegCountLbl.ForeColor = System.Drawing.Color.LightBlue;
            this.RegCountLbl.Location = new System.Drawing.Point(33, 23);
            this.RegCountLbl.Name = "RegCountLbl";
            this.RegCountLbl.Size = new System.Drawing.Size(25, 13);
            this.RegCountLbl.TabIndex = 14;
            this.RegCountLbl.Text = "000";
            // 
            // ColumnCountLbl
            // 
            this.ColumnCountLbl.AutoSize = true;
            this.ColumnCountLbl.ForeColor = System.Drawing.Color.LightBlue;
            this.ColumnCountLbl.Location = new System.Drawing.Point(172, 23);
            this.ColumnCountLbl.Name = "ColumnCountLbl";
            this.ColumnCountLbl.Size = new System.Drawing.Size(25, 13);
            this.ColumnCountLbl.TabIndex = 16;
            this.ColumnCountLbl.Text = "000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightBlue;
            this.label5.Location = new System.Drawing.Point(119, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Columnas:";
            // 
            // FooterPnl
            // 
            this.FooterPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.FooterPnl.Controls.Add(this.ColumnCountLbl);
            this.FooterPnl.Controls.Add(this.RegCountLbl);
            this.FooterPnl.Controls.Add(this.label6);
            this.FooterPnl.Controls.Add(this.label3);
            this.FooterPnl.Controls.Add(this.label5);
            this.FooterPnl.Controls.Add(this.CounterLbl);
            this.FooterPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPnl.Location = new System.Drawing.Point(0, 560);
            this.FooterPnl.Name = "FooterPnl";
            this.FooterPnl.Size = new System.Drawing.Size(800, 40);
            this.FooterPnl.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightBlue;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Proyectos:";
            // 
            // DataGridPnl
            // 
            this.DataGridPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.DataGridPnl.Controls.Add(this.dataGridView1);
            this.DataGridPnl.Controls.Add(this.ActionPnl);
            this.DataGridPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridPnl.Location = new System.Drawing.Point(0, 50);
            this.DataGridPnl.Name = "DataGridPnl";
            this.DataGridPnl.Size = new System.Drawing.Size(800, 510);
            this.DataGridPnl.TabIndex = 19;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ViewLogBtn
            // 
            this.ViewLogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(56)))));
            this.ViewLogBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ViewLogBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewLogBtn.FlatAppearance.BorderSize = 0;
            this.ViewLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewLogBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLogBtn.ForeColor = System.Drawing.Color.LightBlue;
            this.ViewLogBtn.Image = global::DBSender.Properties.Resources.event_log_36px;
            this.ViewLogBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewLogBtn.Location = new System.Drawing.Point(3, 2);
            this.ViewLogBtn.Name = "ViewLogBtn";
            this.ViewLogBtn.Size = new System.Drawing.Size(100, 36);
            this.ViewLogBtn.TabIndex = 47;
            this.ViewLogBtn.Text = "Registro";
            this.ViewLogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewLogBtn.UseVisualStyleBackColor = false;
            this.ViewLogBtn.Click += new System.EventHandler(this.ViewLogBtn_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.DataGridPnl);
            this.Controls.Add(this.BannerPnl);
            this.Controls.Add(this.FooterPnl);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BannerPnl.ResumeLayout(false);
            this.BannerPnl.PerformLayout();
            this.ActionPnl.ResumeLayout(false);
            this.ActionPnl.PerformLayout();
            this.DataActionPnl.ResumeLayout(false);
            this.FooterPnl.ResumeLayout(false);
            this.FooterPnl.PerformLayout();
            this.DataGridPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SendEmailBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ImportDataBtn;
        private System.Windows.Forms.Panel BannerPnl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox PathExcelFileTxt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel ActionPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfigEmailBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RegCountLbl;
        private System.Windows.Forms.Label ColumnCountLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel FooterPnl;
        private System.Windows.Forms.CheckBox AutoLoadChk;
        private System.Windows.Forms.Label CounterLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel DataGridPnl;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel DataActionPnl;
        private System.Windows.Forms.Button AddressBookBtn;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox ModeChk;
        private System.Windows.Forms.Button ChargeBtn;
        private System.Windows.Forms.Button ViewLogBtn;
    }
}

