namespace Gelisim_Muhasebe.BankaModulu
{
    partial class frmBankaAcilisKarti
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtBankaAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider3 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.BakiyeRadio = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.Kaydetbtn = new DevExpress.XtraEditors.SimpleButton();
            this.YeniBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider4 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.btnCariSec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BakiyeRadio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(92, 63);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(236, 20);
            this.txtTarih.TabIndex = 23;
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Enabled = false;
            this.txtBankaAdi.Location = new System.Drawing.Point(92, 37);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Properties.ReadOnly = true;
            this.txtBankaAdi.Size = new System.Drawing.Size(410, 20);
            this.txtBankaAdi.TabIndex = 22;
            // 
            // txtBankaKodu
            // 
            this.txtBankaKodu.Enabled = false;
            this.txtBankaKodu.Location = new System.Drawing.Point(92, 12);
            this.txtBankaKodu.Name = "txtBankaKodu";
            this.txtBankaKodu.Properties.ReadOnly = true;
            this.txtBankaKodu.Size = new System.Drawing.Size(410, 20);
            this.txtBankaKodu.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Banka Adı";
            // 
            // dxErrorProvider3
            // 
            this.dxErrorProvider3.ContainerControl = this;
            // 
            // BakiyeRadio
            // 
            this.BakiyeRadio.Location = new System.Drawing.Point(92, 115);
            this.BakiyeRadio.Name = "BakiyeRadio";
            this.BakiyeRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.BakiyeRadio.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BakiyeRadio.Properties.Appearance.Options.UseBackColor = true;
            this.BakiyeRadio.Properties.Appearance.Options.UseForeColor = true;
            this.BakiyeRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BakiyeRadio.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.BakiyeRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Giriş"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Çıkış")});
            this.BakiyeRadio.Size = new System.Drawing.Size(236, 32);
            this.BakiyeRadio.TabIndex = 25;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.KapatBtn);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Controls.Add(this.Kaydetbtn);
            this.panelControl2.Controls.Add(this.YeniBtn);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 190);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(541, 66);
            this.panelControl2.TabIndex = 26;
            // 
            // KapatBtn
            // 
            this.KapatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KapatBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.KapatBtn.Appearance.Options.UseFont = true;
            this.KapatBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0006_Cross;
            this.KapatBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.KapatBtn.Location = new System.Drawing.Point(403, 7);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(127, 49);
            this.KapatBtn.TabIndex = 3;
            this.KapatBtn.Text = "Kapat [Esc]";
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Image = global::Gelisim_Muhasebe.Properties.Resources._0049_Trash;
            this.btnSil.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(270, 7);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 49);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Kaydetbtn
            // 
            this.Kaydetbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Kaydetbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Kaydetbtn.Appearance.Options.UseFont = true;
            this.Kaydetbtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0007_Tick;
            this.Kaydetbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Kaydetbtn.Location = new System.Drawing.Point(136, 7);
            this.Kaydetbtn.Name = "Kaydetbtn";
            this.Kaydetbtn.Size = new System.Drawing.Size(127, 49);
            this.Kaydetbtn.TabIndex = 1;
            this.Kaydetbtn.Text = "Kaydet";
            this.Kaydetbtn.Click += new System.EventHandler(this.Kaydetbtn_Click);
            // 
            // YeniBtn
            // 
            this.YeniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YeniBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.YeniBtn.Appearance.Options.UseFont = true;
            this.YeniBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0009_Add;
            this.YeniBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.YeniBtn.Location = new System.Drawing.Point(3, 7);
            this.YeniBtn.Name = "YeniBtn";
            this.YeniBtn.Size = new System.Drawing.Size(127, 49);
            this.YeniBtn.TabIndex = 0;
            this.YeniBtn.Text = "Yeni";
            this.YeniBtn.Click += new System.EventHandler(this.YeniBtn_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Banka Kodu";
            // 
            // dxErrorProvider2
            // 
            this.dxErrorProvider2.ContainerControl = this;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(93, 89);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Mask.EditMask = "c";
            this.txtTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTutar.Size = new System.Drawing.Size(235, 20);
            this.txtTutar.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 92);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Tutar";
            // 
            // dxErrorProvider4
            // 
            this.dxErrorProvider4.ContainerControl = this;
            // 
            // btnCariSec
            // 
            this.btnCariSec.Image = global::Gelisim_Muhasebe.Properties.Resources.zoom_in;
            this.btnCariSec.Location = new System.Drawing.Point(508, 10);
            this.btnCariSec.Name = "btnCariSec";
            this.btnCariSec.Size = new System.Drawing.Size(31, 23);
            this.btnCariSec.TabIndex = 21;
            this.btnCariSec.Click += new System.EventHandler(this.btnCariSec_Click);
            // 
            // frmBankaAcilisKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 256);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtBankaAdi);
            this.Controls.Add(this.txtBankaKodu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnCariSec);
            this.Controls.Add(this.BakiyeRadio);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.labelControl5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaAcilisKarti";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Açılış Kartı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBankaAcilisKarti_FormClosed);
            this.Load += new System.EventHandler(this.frmBankaAcilisKarti_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBankaAcilisKarti_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BakiyeRadio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtBankaAdi;
        private DevExpress.XtraEditors.TextEdit txtBankaKodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCariSec;
        private DevExpress.XtraEditors.RadioGroup BakiyeRadio;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton KapatBtn;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton Kaydetbtn;
        private DevExpress.XtraEditors.SimpleButton YeniBtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider3;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider4;
    }
}