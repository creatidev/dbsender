
namespace DBSender.Controls
{
    partial class SendEmailPanel
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailBannerPnl = new System.Windows.Forms.Panel();
            this.SaveSettingsBtn = new System.Windows.Forms.Button();
            this.WindowLogoPic = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseFilterWindowBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MessageRT = new System.Windows.Forms.RichTextBox();
            this.TLSChk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SMPTPortTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SMPTServerTxt = new System.Windows.Forms.TextBox();
            this.AutoLoadChk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowHidePassChk = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HtmlChk = new System.Windows.Forms.CheckBox();
            this.EnableLogChk = new System.Windows.Forms.CheckBox();
            this.EmailBannerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowLogoPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Asunto:";
            // 
            // SubjectTxt
            // 
            this.SubjectTxt.Location = new System.Drawing.Point(71, 20);
            this.SubjectTxt.Name = "SubjectTxt";
            this.SubjectTxt.Size = new System.Drawing.Size(200, 21);
            this.SubjectTxt.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mensaje:";
            // 
            // EmailBannerPnl
            // 
            this.EmailBannerPnl.BackColor = System.Drawing.Color.SteelBlue;
            this.EmailBannerPnl.Controls.Add(this.SaveSettingsBtn);
            this.EmailBannerPnl.Controls.Add(this.WindowLogoPic);
            this.EmailBannerPnl.Controls.Add(this.label7);
            this.EmailBannerPnl.Controls.Add(this.CloseFilterWindowBtn);
            this.EmailBannerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailBannerPnl.Location = new System.Drawing.Point(0, 0);
            this.EmailBannerPnl.Name = "EmailBannerPnl";
            this.EmailBannerPnl.Size = new System.Drawing.Size(800, 40);
            this.EmailBannerPnl.TabIndex = 37;
            // 
            // SaveSettingsBtn
            // 
            this.SaveSettingsBtn.BackgroundImage = global::DBSender.Properties.Resources.save_48px;
            this.SaveSettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveSettingsBtn.FlatAppearance.BorderSize = 0;
            this.SaveSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsBtn.Location = new System.Drawing.Point(728, 2);
            this.SaveSettingsBtn.Name = "SaveSettingsBtn";
            this.SaveSettingsBtn.Size = new System.Drawing.Size(36, 36);
            this.SaveSettingsBtn.TabIndex = 59;
            this.SaveSettingsBtn.UseVisualStyleBackColor = true;
            this.SaveSettingsBtn.Click += new System.EventHandler(this.SaveSettingsBtn_Click);
            // 
            // WindowLogoPic
            // 
            this.WindowLogoPic.BackgroundImage = global::DBSender.Properties.Resources.message_settings_48px;
            this.WindowLogoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WindowLogoPic.Location = new System.Drawing.Point(2, 2);
            this.WindowLogoPic.Name = "WindowLogoPic";
            this.WindowLogoPic.Size = new System.Drawing.Size(36, 36);
            this.WindowLogoPic.TabIndex = 27;
            this.WindowLogoPic.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(330, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Configuración general";
            // 
            // CloseFilterWindowBtn
            // 
            this.CloseFilterWindowBtn.BackgroundImage = global::DBSender.Properties.Resources.close_window_48px;
            this.CloseFilterWindowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseFilterWindowBtn.FlatAppearance.BorderSize = 0;
            this.CloseFilterWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFilterWindowBtn.Location = new System.Drawing.Point(764, 2);
            this.CloseFilterWindowBtn.Name = "CloseFilterWindowBtn";
            this.CloseFilterWindowBtn.Size = new System.Drawing.Size(36, 36);
            this.CloseFilterWindowBtn.TabIndex = 2;
            this.CloseFilterWindowBtn.UseVisualStyleBackColor = true;
            this.CloseFilterWindowBtn.Click += new System.EventHandler(this.CloseFilterWindowBtn_Click);
            // 
            // MessageRT
            // 
            this.MessageRT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageRT.Location = new System.Drawing.Point(71, 47);
            this.MessageRT.Name = "MessageRT";
            this.MessageRT.Size = new System.Drawing.Size(400, 218);
            this.MessageRT.TabIndex = 39;
            this.MessageRT.Text = "";
            // 
            // TLSChk
            // 
            this.TLSChk.AutoSize = true;
            this.TLSChk.Location = new System.Drawing.Point(15, 96);
            this.TLSChk.Name = "TLSChk";
            this.TLSChk.Size = new System.Drawing.Size(41, 17);
            this.TLSChk.TabIndex = 57;
            this.TLSChk.Text = "TLS";
            this.TLSChk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Contraseña:";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(343, 59);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(100, 21);
            this.PasswordTxt.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Puerto SMTP:";
            // 
            // SMPTPortTxt
            // 
            this.SMPTPortTxt.Location = new System.Drawing.Point(343, 33);
            this.SMPTPortTxt.Name = "SMPTPortTxt";
            this.SMPTPortTxt.Size = new System.Drawing.Size(100, 21);
            this.SMPTPortTxt.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Usuario:";
            // 
            // UserTxt
            // 
            this.UserTxt.Location = new System.Drawing.Point(101, 59);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(159, 21);
            this.UserTxt.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Servidor SMTP:";
            // 
            // SMPTServerTxt
            // 
            this.SMPTServerTxt.Location = new System.Drawing.Point(101, 33);
            this.SMPTServerTxt.Name = "SMPTServerTxt";
            this.SMPTServerTxt.Size = new System.Drawing.Size(159, 21);
            this.SMPTServerTxt.TabIndex = 49;
            // 
            // AutoLoadChk
            // 
            this.AutoLoadChk.AutoSize = true;
            this.AutoLoadChk.Location = new System.Drawing.Point(652, 515);
            this.AutoLoadChk.Name = "AutoLoadChk";
            this.AutoLoadChk.Size = new System.Drawing.Size(129, 17);
            this.AutoLoadChk.TabIndex = 48;
            this.AutoLoadChk.Text = "Cargar datos al iniciar";
            this.AutoLoadChk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowHidePassChk);
            this.groupBox1.Controls.Add(this.SMPTServerTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TLSChk);
            this.groupBox1.Controls.Add(this.UserTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PasswordTxt);
            this.groupBox1.Controls.Add(this.SMPTPortTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(160, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 130);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servidor";
            // 
            // ShowHidePassChk
            // 
            this.ShowHidePassChk.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShowHidePassChk.BackgroundImage = global::DBSender.Properties.Resources.show_password_36px;
            this.ShowHidePassChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowHidePassChk.FlatAppearance.BorderSize = 0;
            this.ShowHidePassChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowHidePassChk.Location = new System.Drawing.Point(446, 58);
            this.ShowHidePassChk.Name = "ShowHidePassChk";
            this.ShowHidePassChk.Size = new System.Drawing.Size(23, 23);
            this.ShowHidePassChk.TabIndex = 62;
            this.ShowHidePassChk.UseVisualStyleBackColor = true;
            this.ShowHidePassChk.CheckedChanged += new System.EventHandler(this.ShowHidePassChk_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HtmlChk);
            this.groupBox2.Controls.Add(this.SubjectTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MessageRT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(160, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 278);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuerpo de mensaje";
            // 
            // HtmlChk
            // 
            this.HtmlChk.AutoSize = true;
            this.HtmlChk.Location = new System.Drawing.Point(15, 248);
            this.HtmlChk.Name = "HtmlChk";
            this.HtmlChk.Size = new System.Drawing.Size(52, 17);
            this.HtmlChk.TabIndex = 63;
            this.HtmlChk.Text = "HTML";
            this.HtmlChk.UseVisualStyleBackColor = true;
            // 
            // EnableLogChk
            // 
            this.EnableLogChk.AutoSize = true;
            this.EnableLogChk.Location = new System.Drawing.Point(486, 515);
            this.EnableLogChk.Name = "EnableLogChk";
            this.EnableLogChk.Size = new System.Drawing.Size(145, 17);
            this.EnableLogChk.TabIndex = 61;
            this.EnableLogChk.Text = "Crear registro de eventos";
            this.EnableLogChk.UseVisualStyleBackColor = true;
            // 
            // SendEmailPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnableLogChk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AutoLoadChk);
            this.Controls.Add(this.EmailBannerPnl);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SendEmailPanel";
            this.Size = new System.Drawing.Size(800, 550);
            this.Load += new System.EventHandler(this.SendEmailPanel_Load);
            this.EmailBannerPnl.ResumeLayout(false);
            this.EmailBannerPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowLogoPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubjectTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel EmailBannerPnl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CloseFilterWindowBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox MessageRT;
        private System.Windows.Forms.PictureBox WindowLogoPic;
        private System.Windows.Forms.CheckBox TLSChk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SMPTPortTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SMPTServerTxt;
        private System.Windows.Forms.CheckBox AutoLoadChk;
        private System.Windows.Forms.Button SaveSettingsBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ShowHidePassChk;
        private System.Windows.Forms.CheckBox HtmlChk;
        private System.Windows.Forms.CheckBox EnableLogChk;
    }
}
