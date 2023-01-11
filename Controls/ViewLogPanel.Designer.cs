namespace DBSender.Controls
{
    partial class ViewLogPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.LogCbo = new System.Windows.Forms.ComboBox();
            this.FilterBannerPnl = new System.Windows.Forms.Panel();
            this.WindowLogoPic = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseFilterWindowBtn = new System.Windows.Forms.Button();
            this.FilterBannerPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowLogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(0, 40);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox1.Size = new System.Drawing.Size(800, 510);
            this.TextBox1.TabIndex = 7;
            // 
            // LogCbo
            // 
            this.LogCbo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogCbo.FormattingEnabled = true;
            this.LogCbo.Location = new System.Drawing.Point(618, 9);
            this.LogCbo.Name = "LogCbo";
            this.LogCbo.Size = new System.Drawing.Size(140, 24);
            this.LogCbo.TabIndex = 5;
            this.LogCbo.SelectedIndexChanged += new System.EventHandler(this.LogCbo_SelectedIndexChanged);
            // 
            // FilterBannerPnl
            // 
            this.FilterBannerPnl.BackColor = System.Drawing.Color.SteelBlue;
            this.FilterBannerPnl.Controls.Add(this.WindowLogoPic);
            this.FilterBannerPnl.Controls.Add(this.label7);
            this.FilterBannerPnl.Controls.Add(this.CloseFilterWindowBtn);
            this.FilterBannerPnl.Controls.Add(this.LogCbo);
            this.FilterBannerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterBannerPnl.Location = new System.Drawing.Point(0, 0);
            this.FilterBannerPnl.Name = "FilterBannerPnl";
            this.FilterBannerPnl.Size = new System.Drawing.Size(800, 40);
            this.FilterBannerPnl.TabIndex = 8;
            // 
            // WindowLogoPic
            // 
            this.WindowLogoPic.BackgroundImage = global::DBSender.Properties.Resources.test_passed_240px;
            this.WindowLogoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WindowLogoPic.Location = new System.Drawing.Point(2, 2);
            this.WindowLogoPic.Name = "WindowLogoPic";
            this.WindowLogoPic.Size = new System.Drawing.Size(36, 36);
            this.WindowLogoPic.TabIndex = 33;
            this.WindowLogoPic.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(487, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Registros disponibles:";
            // 
            // CloseFilterWindowBtn
            // 
            this.CloseFilterWindowBtn.BackgroundImage = global::DBSender.Properties.Resources.close_window_48px;
            this.CloseFilterWindowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseFilterWindowBtn.FlatAppearance.BorderSize = 0;
            this.CloseFilterWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFilterWindowBtn.Location = new System.Drawing.Point(762, 2);
            this.CloseFilterWindowBtn.Name = "CloseFilterWindowBtn";
            this.CloseFilterWindowBtn.Size = new System.Drawing.Size(36, 36);
            this.CloseFilterWindowBtn.TabIndex = 0;
            this.CloseFilterWindowBtn.UseVisualStyleBackColor = true;
            this.CloseFilterWindowBtn.Click += new System.EventHandler(this.CloseFilterWindowBtn_Click);
            // 
            // ViewLogPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.FilterBannerPnl);
            this.Name = "ViewLogPanel";
            this.Size = new System.Drawing.Size(800, 550);
            this.FilterBannerPnl.ResumeLayout(false);
            this.FilterBannerPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowLogoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.ComboBox LogCbo;
        private System.Windows.Forms.Panel FilterBannerPnl;
        private System.Windows.Forms.PictureBox WindowLogoPic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CloseFilterWindowBtn;
    }
}
