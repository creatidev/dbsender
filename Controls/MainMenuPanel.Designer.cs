
namespace DBSender.Controls
{
    partial class MainMenuPanel
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataStatusLbl = new System.Windows.Forms.Label();
            this.ServerAlertLbl = new System.Windows.Forms.Label();
            this.NotebookAlertLbl = new System.Windows.Forms.Label();
            this.SendEmailAlertLbl = new System.Windows.Forms.Label();
            this.DBStatusLbl = new System.Windows.Forms.Label();
            this.ChargeBtn = new System.Windows.Forms.Button();
            this.ImportFileBtn = new System.Windows.Forms.Button();
            this.DBLoadedPic = new System.Windows.Forms.PictureBox();
            this.SendEmailAlertPic = new System.Windows.Forms.PictureBox();
            this.NotebookAlertPic = new System.Windows.Forms.PictureBox();
            this.ServerAlertPic = new System.Windows.Forms.PictureBox();
            this.SendEmailBtn = new System.Windows.Forms.Button();
            this.AddressBookBtn = new System.Windows.Forms.Button();
            this.ConfigEmailBtn = new System.Windows.Forms.Button();
            this.ViewLogBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowLogPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DBLoadedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendEmailAlertPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotebookAlertPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerAlertPic)).BeginInit();
            this.ShowLogPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.StatusLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.StatusLbl.Location = new System.Drawing.Point(214, 370);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(168, 15);
            this.StatusLbl.TabIndex = 20;
            this.StatusLbl.Text = "Configurar servidor de correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(418, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Asociar proyectos a correos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(652, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Enviar correos";
            // 
            // DataStatusLbl
            // 
            this.DataStatusLbl.AutoSize = true;
            this.DataStatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.DataStatusLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataStatusLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.DataStatusLbl.Location = new System.Drawing.Point(32, 143);
            this.DataStatusLbl.Name = "DataStatusLbl";
            this.DataStatusLbl.Size = new System.Drawing.Size(136, 15);
            this.DataStatusLbl.TabIndex = 23;
            this.DataStatusLbl.Text = "Base de datos sin cargar";
            // 
            // ServerAlertLbl
            // 
            this.ServerAlertLbl.AutoSize = true;
            this.ServerAlertLbl.BackColor = System.Drawing.Color.Transparent;
            this.ServerAlertLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerAlertLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.ServerAlertLbl.Location = new System.Drawing.Point(234, 143);
            this.ServerAlertLbl.Name = "ServerAlertLbl";
            this.ServerAlertLbl.Size = new System.Drawing.Size(129, 15);
            this.ServerAlertLbl.TabIndex = 26;
            this.ServerAlertLbl.Text = "Revise la configuración";
            // 
            // NotebookAlertLbl
            // 
            this.NotebookAlertLbl.AutoSize = true;
            this.NotebookAlertLbl.BackColor = System.Drawing.Color.Transparent;
            this.NotebookAlertLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotebookAlertLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.NotebookAlertLbl.Location = new System.Drawing.Point(443, 143);
            this.NotebookAlertLbl.Name = "NotebookAlertLbl";
            this.NotebookAlertLbl.Size = new System.Drawing.Size(107, 15);
            this.NotebookAlertLbl.TabIndex = 27;
            this.NotebookAlertLbl.Text = "Registre contactos";
            // 
            // SendEmailAlertLbl
            // 
            this.SendEmailAlertLbl.AutoSize = true;
            this.SendEmailAlertLbl.BackColor = System.Drawing.Color.Transparent;
            this.SendEmailAlertLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendEmailAlertLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.SendEmailAlertLbl.Location = new System.Drawing.Point(645, 143);
            this.SendEmailAlertLbl.Name = "SendEmailAlertLbl";
            this.SendEmailAlertLbl.Size = new System.Drawing.Size(99, 15);
            this.SendEmailAlertLbl.TabIndex = 29;
            this.SendEmailAlertLbl.Text = "Revise las alertas";
            // 
            // DBStatusLbl
            // 
            this.DBStatusLbl.AutoSize = true;
            this.DBStatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.DBStatusLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBStatusLbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.DBStatusLbl.Location = new System.Drawing.Point(40, 370);
            this.DBStatusLbl.Name = "DBStatusLbl";
            this.DBStatusLbl.Size = new System.Drawing.Size(120, 15);
            this.DBStatusLbl.TabIndex = 32;
            this.DBStatusLbl.Text = "Cargar base de datos";
            // 
            // ChargeBtn
            // 
            this.ChargeBtn.BackgroundImage = global::DBSender.Properties.Resources.icons8_play_200px;
            this.ChargeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChargeBtn.FlatAppearance.BorderSize = 0;
            this.ChargeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChargeBtn.Location = new System.Drawing.Point(10, 161);
            this.ChargeBtn.Name = "ChargeBtn";
            this.ChargeBtn.Size = new System.Drawing.Size(180, 180);
            this.ChargeBtn.TabIndex = 33;
            this.ChargeBtn.UseVisualStyleBackColor = true;
            this.ChargeBtn.Visible = false;
            this.ChargeBtn.Click += new System.EventHandler(this.ChargeBtn_Click);
            // 
            // ImportFileBtn
            // 
            this.ImportFileBtn.BackgroundImage = global::DBSender.Properties.Resources.new_copy_200px;
            this.ImportFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImportFileBtn.FlatAppearance.BorderSize = 0;
            this.ImportFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportFileBtn.Location = new System.Drawing.Point(10, 161);
            this.ImportFileBtn.Name = "ImportFileBtn";
            this.ImportFileBtn.Size = new System.Drawing.Size(180, 180);
            this.ImportFileBtn.TabIndex = 31;
            this.ImportFileBtn.UseVisualStyleBackColor = true;
            this.ImportFileBtn.Click += new System.EventHandler(this.ImportFileBtn_Click);
            // 
            // DBLoadedPic
            // 
            this.DBLoadedPic.BackColor = System.Drawing.Color.Transparent;
            this.DBLoadedPic.BackgroundImage = global::DBSender.Properties.Resources.box_important_48px;
            this.DBLoadedPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DBLoadedPic.Location = new System.Drawing.Point(160, 110);
            this.DBLoadedPic.Name = "DBLoadedPic";
            this.DBLoadedPic.Size = new System.Drawing.Size(30, 30);
            this.DBLoadedPic.TabIndex = 30;
            this.DBLoadedPic.TabStop = false;
            // 
            // SendEmailAlertPic
            // 
            this.SendEmailAlertPic.BackColor = System.Drawing.Color.Transparent;
            this.SendEmailAlertPic.BackgroundImage = global::DBSender.Properties.Resources.box_important_48px;
            this.SendEmailAlertPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SendEmailAlertPic.Location = new System.Drawing.Point(754, 110);
            this.SendEmailAlertPic.Name = "SendEmailAlertPic";
            this.SendEmailAlertPic.Size = new System.Drawing.Size(30, 30);
            this.SendEmailAlertPic.TabIndex = 28;
            this.SendEmailAlertPic.TabStop = false;
            // 
            // NotebookAlertPic
            // 
            this.NotebookAlertPic.BackColor = System.Drawing.Color.Transparent;
            this.NotebookAlertPic.BackgroundImage = global::DBSender.Properties.Resources.box_important_48px;
            this.NotebookAlertPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NotebookAlertPic.Location = new System.Drawing.Point(556, 110);
            this.NotebookAlertPic.Name = "NotebookAlertPic";
            this.NotebookAlertPic.Size = new System.Drawing.Size(30, 30);
            this.NotebookAlertPic.TabIndex = 25;
            this.NotebookAlertPic.TabStop = false;
            // 
            // ServerAlertPic
            // 
            this.ServerAlertPic.BackColor = System.Drawing.Color.Transparent;
            this.ServerAlertPic.BackgroundImage = global::DBSender.Properties.Resources.box_important_48px;
            this.ServerAlertPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ServerAlertPic.Location = new System.Drawing.Point(358, 110);
            this.ServerAlertPic.Name = "ServerAlertPic";
            this.ServerAlertPic.Size = new System.Drawing.Size(30, 30);
            this.ServerAlertPic.TabIndex = 24;
            this.ServerAlertPic.TabStop = false;
            // 
            // SendEmailBtn
            // 
            this.SendEmailBtn.BackgroundImage = global::DBSender.Properties.Resources.send_email_240px;
            this.SendEmailBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SendEmailBtn.FlatAppearance.BorderSize = 0;
            this.SendEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendEmailBtn.Location = new System.Drawing.Point(604, 161);
            this.SendEmailBtn.Name = "SendEmailBtn";
            this.SendEmailBtn.Size = new System.Drawing.Size(180, 180);
            this.SendEmailBtn.TabIndex = 4;
            this.SendEmailBtn.UseVisualStyleBackColor = true;
            this.SendEmailBtn.Click += new System.EventHandler(this.SendEmailBtn_Click);
            // 
            // AddressBookBtn
            // 
            this.AddressBookBtn.BackgroundImage = global::DBSender.Properties.Resources.contacts_240px;
            this.AddressBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddressBookBtn.FlatAppearance.BorderSize = 0;
            this.AddressBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddressBookBtn.Location = new System.Drawing.Point(406, 161);
            this.AddressBookBtn.Name = "AddressBookBtn";
            this.AddressBookBtn.Size = new System.Drawing.Size(180, 180);
            this.AddressBookBtn.TabIndex = 3;
            this.AddressBookBtn.UseVisualStyleBackColor = true;
            this.AddressBookBtn.Click += new System.EventHandler(this.AddressBookBtn_Click);
            // 
            // ConfigEmailBtn
            // 
            this.ConfigEmailBtn.BackgroundImage = global::DBSender.Properties.Resources.message_settings_240px;
            this.ConfigEmailBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfigEmailBtn.FlatAppearance.BorderSize = 0;
            this.ConfigEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigEmailBtn.Location = new System.Drawing.Point(208, 161);
            this.ConfigEmailBtn.Name = "ConfigEmailBtn";
            this.ConfigEmailBtn.Size = new System.Drawing.Size(180, 180);
            this.ConfigEmailBtn.TabIndex = 2;
            this.ConfigEmailBtn.UseVisualStyleBackColor = true;
            this.ConfigEmailBtn.Click += new System.EventHandler(this.SetUpEmailBtn_Click);
            // 
            // ViewLogBtn
            // 
            this.ViewLogBtn.BackgroundImage = global::DBSender.Properties.Resources.test_passed_240px;
            this.ViewLogBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ViewLogBtn.FlatAppearance.BorderSize = 0;
            this.ViewLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewLogBtn.Location = new System.Drawing.Point(21, 12);
            this.ViewLogBtn.Name = "ViewLogBtn";
            this.ViewLogBtn.Size = new System.Drawing.Size(60, 60);
            this.ViewLogBtn.TabIndex = 34;
            this.ViewLogBtn.UseVisualStyleBackColor = true;
            this.ViewLogBtn.Click += new System.EventHandler(this.ViewLogBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ver registro";
            // 
            // ShowLogPnl
            // 
            this.ShowLogPnl.Controls.Add(this.ViewLogBtn);
            this.ShowLogPnl.Controls.Add(this.label3);
            this.ShowLogPnl.Location = new System.Drawing.Point(697, 447);
            this.ShowLogPnl.Name = "ShowLogPnl";
            this.ShowLogPnl.Size = new System.Drawing.Size(100, 100);
            this.ShowLogPnl.TabIndex = 36;
            this.ShowLogPnl.Visible = false;
            // 
            // MainMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.ShowLogPnl);
            this.Controls.Add(this.ChargeBtn);
            this.Controls.Add(this.DBStatusLbl);
            this.Controls.Add(this.ImportFileBtn);
            this.Controls.Add(this.DBLoadedPic);
            this.Controls.Add(this.SendEmailAlertPic);
            this.Controls.Add(this.NotebookAlertPic);
            this.Controls.Add(this.ServerAlertPic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.SendEmailBtn);
            this.Controls.Add(this.AddressBookBtn);
            this.Controls.Add(this.ConfigEmailBtn);
            this.Controls.Add(this.DataStatusLbl);
            this.Controls.Add(this.ServerAlertLbl);
            this.Controls.Add(this.NotebookAlertLbl);
            this.Controls.Add(this.SendEmailAlertLbl);
            this.Name = "MainMenuPanel";
            this.Size = new System.Drawing.Size(800, 550);
            ((System.ComponentModel.ISupportInitialize)(this.DBLoadedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendEmailAlertPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotebookAlertPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerAlertPic)).EndInit();
            this.ShowLogPnl.ResumeLayout(false);
            this.ShowLogPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfigEmailBtn;
        private System.Windows.Forms.Button AddressBookBtn;
        private System.Windows.Forms.Button SendEmailBtn;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DataStatusLbl;
        private System.Windows.Forms.PictureBox ServerAlertPic;
        private System.Windows.Forms.PictureBox NotebookAlertPic;
        private System.Windows.Forms.Label ServerAlertLbl;
        private System.Windows.Forms.Label NotebookAlertLbl;
        private System.Windows.Forms.PictureBox SendEmailAlertPic;
        private System.Windows.Forms.Label SendEmailAlertLbl;
        private System.Windows.Forms.PictureBox DBLoadedPic;
        private System.Windows.Forms.Button ImportFileBtn;
        private System.Windows.Forms.Label DBStatusLbl;
        private System.Windows.Forms.Button ChargeBtn;
        private System.Windows.Forms.Button ViewLogBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ShowLogPnl;
    }
}
