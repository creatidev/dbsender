
namespace DBSender.Controls
{
    partial class ProcessPanel
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
            this.UpdateLbl = new System.Windows.Forms.Label();
            this.SplashPic = new System.Windows.Forms.PictureBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.DragDropPanel = new System.Windows.Forms.Panel();
            this.ImportFileBtn = new System.Windows.Forms.Button();
            this.ChargeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPic)).BeginInit();
            this.DragDropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateLbl
            // 
            this.UpdateLbl.BackColor = System.Drawing.Color.Transparent;
            this.UpdateLbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.UpdateLbl.Location = new System.Drawing.Point(200, 379);
            this.UpdateLbl.Name = "UpdateLbl";
            this.UpdateLbl.Size = new System.Drawing.Size(400, 13);
            this.UpdateLbl.TabIndex = 18;
            this.UpdateLbl.Text = "Cargando información, por favor espere...\r\n";
            this.UpdateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashPic
            // 
            this.SplashPic.Image = global::DBSender.Properties.Resources.loading;
            this.SplashPic.Location = new System.Drawing.Point(200, 125);
            this.SplashPic.Name = "SplashPic";
            this.SplashPic.Size = new System.Drawing.Size(400, 300);
            this.SplashPic.TabIndex = 2;
            this.SplashPic.TabStop = false;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.StatusLbl.ForeColor = System.Drawing.Color.SkyBlue;
            this.StatusLbl.Location = new System.Drawing.Point(149, 253);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(106, 13);
            this.StatusLbl.TabIndex = 19;
            this.StatusLbl.Text = "Cargar base de datos";
            // 
            // DragDropPanel
            // 
            this.DragDropPanel.AllowDrop = true;
            this.DragDropPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.DragDropPanel.Controls.Add(this.StatusLbl);
            this.DragDropPanel.Controls.Add(this.ChargeBtn);
            this.DragDropPanel.Controls.Add(this.ImportFileBtn);
            this.DragDropPanel.Location = new System.Drawing.Point(200, 125);
            this.DragDropPanel.Name = "DragDropPanel";
            this.DragDropPanel.Size = new System.Drawing.Size(400, 300);
            this.DragDropPanel.TabIndex = 19;
            // 
            // ImportFileBtn
            // 
            this.ImportFileBtn.BackgroundImage = global::DBSender.Properties.Resources.new_copy_200px;
            this.ImportFileBtn.FlatAppearance.BorderSize = 0;
            this.ImportFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportFileBtn.Location = new System.Drawing.Point(100, 50);
            this.ImportFileBtn.Name = "ImportFileBtn";
            this.ImportFileBtn.Size = new System.Drawing.Size(200, 200);
            this.ImportFileBtn.TabIndex = 0;
            this.ImportFileBtn.UseVisualStyleBackColor = true;
            this.ImportFileBtn.Visible = false;
            this.ImportFileBtn.Click += new System.EventHandler(this.ImportFileBtn_Click);
            // 
            // ChargeBtn
            // 
            this.ChargeBtn.BackgroundImage = global::DBSender.Properties.Resources.icons8_play_200px;
            this.ChargeBtn.FlatAppearance.BorderSize = 0;
            this.ChargeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChargeBtn.Location = new System.Drawing.Point(102, 50);
            this.ChargeBtn.Name = "ChargeBtn";
            this.ChargeBtn.Size = new System.Drawing.Size(200, 200);
            this.ChargeBtn.TabIndex = 1;
            this.ChargeBtn.UseVisualStyleBackColor = true;
            this.ChargeBtn.Visible = false;
            this.ChargeBtn.Click += new System.EventHandler(this.ChargeBtn_Click);
            // 
            // ProcessPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.DragDropPanel);
            this.Controls.Add(this.UpdateLbl);
            this.Controls.Add(this.SplashPic);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProcessPanel";
            this.Size = new System.Drawing.Size(800, 550);
            ((System.ComponentModel.ISupportInitialize)(this.SplashPic)).EndInit();
            this.DragDropPanel.ResumeLayout(false);
            this.DragDropPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label UpdateLbl;
        private System.Windows.Forms.PictureBox SplashPic;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Panel DragDropPanel;
        private System.Windows.Forms.Button ChargeBtn;
        private System.Windows.Forms.Button ImportFileBtn;
    }
}
