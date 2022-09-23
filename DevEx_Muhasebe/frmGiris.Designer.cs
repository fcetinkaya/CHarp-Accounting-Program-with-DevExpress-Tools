namespace Gelisim_Muhasebe{
    partial class frmGiris
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.SifreCheck = new DevExpress.XtraEditors.CheckEdit();
            this.KulAdiBox = new DevExpress.XtraEditors.TextEdit();
            this.GirisBtn = new DevExpress.XtraEditors.SimpleButton();
            this.Sifrebox = new DevExpress.XtraEditors.TextEdit();
            this.ServerBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.SifreCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KulAdiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sifrebox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SifreCheck
            // 
            this.SifreCheck.Location = new System.Drawing.Point(167, 178);
            this.SifreCheck.Name = "SifreCheck";
            this.SifreCheck.Properties.Caption = "Şifreyi Hatırla";
            this.SifreCheck.Size = new System.Drawing.Size(92, 19);
            this.SifreCheck.TabIndex = 2;
            // 
            // KulAdiBox
            // 
            this.KulAdiBox.Location = new System.Drawing.Point(201, 128);
            this.KulAdiBox.Name = "KulAdiBox";
            this.KulAdiBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.KulAdiBox.Size = new System.Drawing.Size(143, 18);
            this.KulAdiBox.TabIndex = 0;
            // 
            // GirisBtn
            // 
            this.GirisBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GirisBtn.Location = new System.Drawing.Point(358, 255);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(86, 31);
            this.GirisBtn.TabIndex = 3;
            this.GirisBtn.Text = "Giriş Yapın";
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // Sifrebox
            // 
            this.Sifrebox.Location = new System.Drawing.Point(201, 154);
            this.Sifrebox.Name = "Sifrebox";
            this.Sifrebox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Sifrebox.Properties.PasswordChar = '*';
            this.Sifrebox.Size = new System.Drawing.Size(143, 18);
            this.Sifrebox.TabIndex = 1;
            // 
            // ServerBtn
            // 
            this.ServerBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ServerBtn.Image = global::Gelisim_Muhasebe.Properties.Resources.computer;
            this.ServerBtn.Location = new System.Drawing.Point(326, 255);
            this.ServerBtn.Name = "ServerBtn";
            this.ServerBtn.Size = new System.Drawing.Size(26, 31);
            this.ServerBtn.TabIndex = 3;
            this.ServerBtn.ToolTip = "Server Bağlantısı";
            this.ServerBtn.Click += new System.EventHandler(this.ServerBtn_Click);
            // 
            // frmGiris
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Gelisim_Muhasebe.Properties.Resources.Giris;
            this.ClientSize = new System.Drawing.Size(470, 301);
            this.Controls.Add(this.ServerBtn);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.Sifrebox);
            this.Controls.Add(this.KulAdiBox);
            this.Controls.Add(this.SifreCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGiris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SifreCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KulAdiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sifrebox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit SifreCheck;
        private DevExpress.XtraEditors.TextEdit KulAdiBox;
        private DevExpress.XtraEditors.SimpleButton GirisBtn;
        private DevExpress.XtraEditors.TextEdit Sifrebox;
        private DevExpress.XtraEditors.SimpleButton ServerBtn;
    }
}