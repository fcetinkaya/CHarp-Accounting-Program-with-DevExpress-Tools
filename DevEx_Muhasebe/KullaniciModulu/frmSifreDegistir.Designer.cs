namespace Gelisim_Muhasebe.KullaniciModulu
{
    partial class frmSifreDegistir
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
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.EskiParaloTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.YeniParolaTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.YeniTekrarParola = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Kaptbtn = new DevExpress.XtraEditors.SimpleButton();
            this.KaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider3 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EskiParaloTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YeniParolaTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YeniTekrarParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Eski Parolanız :";
            // 
            // EskiParaloTxt
            // 
            this.EskiParaloTxt.Location = new System.Drawing.Point(153, 25);
            this.EskiParaloTxt.Name = "EskiParaloTxt";
            this.EskiParaloTxt.Size = new System.Drawing.Size(156, 20);
            this.EskiParaloTxt.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(12, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Yeni Parolanız :";
            // 
            // YeniParolaTxt
            // 
            this.YeniParolaTxt.Location = new System.Drawing.Point(153, 51);
            this.YeniParolaTxt.Name = "YeniParolaTxt";
            this.YeniParolaTxt.Size = new System.Drawing.Size(156, 20);
            this.YeniParolaTxt.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(12, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Yeni Parolanız Tekrar :";
            // 
            // YeniTekrarParola
            // 
            this.YeniTekrarParola.Location = new System.Drawing.Point(153, 77);
            this.YeniTekrarParola.Name = "YeniTekrarParola";
            this.YeniTekrarParola.Size = new System.Drawing.Size(156, 20);
            this.YeniTekrarParola.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Kaptbtn);
            this.panelControl2.Controls.Add(this.KaydetBtn);
            this.panelControl2.Location = new System.Drawing.Point(13, 132);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(296, 66);
            this.panelControl2.TabIndex = 3;
            // 
            // Kaptbtn
            // 
            this.Kaptbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Kaptbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Kaptbtn.Appearance.Options.UseFont = true;
            this.Kaptbtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0006_Cross;
            this.Kaptbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Kaptbtn.Location = new System.Drawing.Point(161, 5);
            this.Kaptbtn.Name = "Kaptbtn";
            this.Kaptbtn.Size = new System.Drawing.Size(127, 49);
            this.Kaptbtn.TabIndex = 1;
            this.Kaptbtn.Text = "Kapat [Esc]";
            this.Kaptbtn.Click += new System.EventHandler(this.Kaptbtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KaydetBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.KaydetBtn.Appearance.Options.UseFont = true;
            this.KaydetBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0007_Tick;
            this.KaydetBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.KaydetBtn.Location = new System.Drawing.Point(15, 5);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(127, 49);
            this.KaydetBtn.TabIndex = 0;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // dxErrorProvider2
            // 
            this.dxErrorProvider2.ContainerControl = this;
            // 
            // dxErrorProvider3
            // 
            this.dxErrorProvider3.ContainerControl = this;
            // 
            // frmSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 203);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.YeniTekrarParola);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.YeniParolaTxt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.EskiParaloTxt);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSifreDegistir";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştir";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSifreDegistir_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.EskiParaloTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YeniParolaTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YeniTekrarParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit EskiParaloTxt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit YeniParolaTxt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit YeniTekrarParola;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton Kaptbtn;
        private DevExpress.XtraEditors.SimpleButton KaydetBtn;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider3;
    }
}