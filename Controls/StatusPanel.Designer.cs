
namespace DBSender.Controls
{
    partial class StatusPanel
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
            this.ButtonsActionPnl = new System.Windows.Forms.Panel();
            this.EndBtn = new System.Windows.Forms.Button();
            this.ViewLogBtn = new System.Windows.Forms.Button();
            this.SplashPic = new System.Windows.Forms.PictureBox();
            this.ButtonsActionPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPic)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLbl
            // 
            this.StatusLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.StatusLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.StatusLbl.Location = new System.Drawing.Point(211, 391);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(374, 48);
            this.StatusLbl.TabIndex = 20;
            this.StatusLbl.Text = "Generando archivos...";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonsActionPnl
            // 
            this.ButtonsActionPnl.Controls.Add(this.EndBtn);
            this.ButtonsActionPnl.Controls.Add(this.ViewLogBtn);
            this.ButtonsActionPnl.Location = new System.Drawing.Point(557, 494);
            this.ButtonsActionPnl.Name = "ButtonsActionPnl";
            this.ButtonsActionPnl.Size = new System.Drawing.Size(230, 40);
            this.ButtonsActionPnl.TabIndex = 23;
            this.ButtonsActionPnl.Visible = false;
            // 
            // EndBtn
            // 
            this.EndBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.EndBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EndBtn.FlatAppearance.BorderSize = 0;
            this.EndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndBtn.ForeColor = System.Drawing.Color.LightBlue;
            this.EndBtn.Image = global::DBSender.Properties.Resources.cancel_36px;
            this.EndBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EndBtn.Location = new System.Drawing.Point(129, 1);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(96, 36);
            this.EndBtn.TabIndex = 21;
            this.EndBtn.Text = "Finalizar";
            this.EndBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EndBtn.UseVisualStyleBackColor = false;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // ViewLogBtn
            // 
            this.ViewLogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ViewLogBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ViewLogBtn.FlatAppearance.BorderSize = 0;
            this.ViewLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewLogBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLogBtn.ForeColor = System.Drawing.Color.LightBlue;
            this.ViewLogBtn.Image = global::DBSender.Properties.Resources.event_log_36px;
            this.ViewLogBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewLogBtn.Location = new System.Drawing.Point(3, 1);
            this.ViewLogBtn.Name = "ViewLogBtn";
            this.ViewLogBtn.Size = new System.Drawing.Size(120, 36);
            this.ViewLogBtn.TabIndex = 22;
            this.ViewLogBtn.Text = "Ver registro";
            this.ViewLogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewLogBtn.UseVisualStyleBackColor = false;
            this.ViewLogBtn.Click += new System.EventHandler(this.ViewLogBtn_Click);
            // 
            // SplashPic
            // 
            this.SplashPic.Image = global::DBSender.Properties.Resources.loading;
            this.SplashPic.Location = new System.Drawing.Point(198, 86);
            this.SplashPic.Name = "SplashPic";
            this.SplashPic.Size = new System.Drawing.Size(400, 300);
            this.SplashPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SplashPic.TabIndex = 3;
            this.SplashPic.TabStop = false;
            // 
            // StatusPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.ButtonsActionPnl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.SplashPic);
            this.Name = "StatusPanel";
            this.Size = new System.Drawing.Size(800, 550);
            this.ButtonsActionPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplashPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Button ViewLogBtn;
        public System.Windows.Forms.Panel ButtonsActionPnl;
        public System.Windows.Forms.PictureBox SplashPic;
    }
}
