namespace Gelisim_Muhasebe.BankaModulu
{
    partial class frmBankaIslemi
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.YeniBtn = new DevExpress.XtraEditors.SimpleButton();
            this.Kaydetbtn = new DevExpress.XtraEditors.SimpleButton();
            this.TxtMakbuzNo = new DevExpress.XtraEditors.TextEdit();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.btnBankaSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtBankaAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtBankaKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider3 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider4 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.BakiyeRadio = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMakbuzNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BakiyeRadio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.KapatBtn);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Controls.Add(this.YeniBtn);
            this.panelControl2.Controls.Add(this.Kaydetbtn);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 408);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(482, 66);
            this.panelControl2.TabIndex = 9;
            // 
            // KapatBtn
            // 
            this.KapatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KapatBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.KapatBtn.Appearance.Options.UseFont = true;
            this.KapatBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0006_Cross;
            this.KapatBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.KapatBtn.Location = new System.Drawing.Point(343, 12);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(134, 49);
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
            this.btnSil.Location = new System.Drawing.Point(232, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 49);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // YeniBtn
            // 
            this.YeniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YeniBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.YeniBtn.Appearance.Options.UseFont = true;
            this.YeniBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0009_Add;
            this.YeniBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.YeniBtn.Location = new System.Drawing.Point(10, 12);
            this.YeniBtn.Name = "YeniBtn";
            this.YeniBtn.Size = new System.Drawing.Size(105, 49);
            this.YeniBtn.TabIndex = 0;
            this.YeniBtn.Text = "Yeni";
            this.YeniBtn.Click += new System.EventHandler(this.YeniBtn_Click);
            // 
            // Kaydetbtn
            // 
            this.Kaydetbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Kaydetbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Kaydetbtn.Appearance.Options.UseFont = true;
            this.Kaydetbtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0007_Tick;
            this.Kaydetbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Kaydetbtn.Location = new System.Drawing.Point(121, 12);
            this.Kaydetbtn.Name = "Kaydetbtn";
            this.Kaydetbtn.Size = new System.Drawing.Size(105, 49);
            this.Kaydetbtn.TabIndex = 1;
            this.Kaydetbtn.Text = "Kaydet";
            this.Kaydetbtn.Click += new System.EventHandler(this.Kaydetbtn_Click);
            // 
            // TxtMakbuzNo
            // 
            this.TxtMakbuzNo.Location = new System.Drawing.Point(92, 29);
            this.TxtMakbuzNo.Name = "TxtMakbuzNo";
            this.TxtMakbuzNo.Size = new System.Drawing.Size(138, 20);
            this.TxtMakbuzNo.TabIndex = 1;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(92, 3);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(138, 20);
            this.txtBelgeNo.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 70;
            this.labelControl4.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(92, 108);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(138, 20);
            this.txtTarih.TabIndex = 5;
            // 
            // btnBankaSec
            // 
            this.btnBankaSec.Image = global::Gelisim_Muhasebe.Properties.Resources.zoom_in;
            this.btnBankaSec.Location = new System.Drawing.Point(447, 55);
            this.btnBankaSec.Name = "btnBankaSec";
            this.btnBankaSec.Size = new System.Drawing.Size(31, 23);
            this.btnBankaSec.TabIndex = 3;
            this.btnBankaSec.Click += new System.EventHandler(this.btnBankaSec_Click);
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.Enabled = false;
            this.txtBankaAdi.Location = new System.Drawing.Point(92, 82);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Properties.ReadOnly = true;
            this.txtBankaAdi.Size = new System.Drawing.Size(386, 20);
            this.txtBankaAdi.TabIndex = 4;
            // 
            // txtBankaKodu
            // 
            this.txtBankaKodu.Enabled = false;
            this.txtBankaKodu.Location = new System.Drawing.Point(92, 57);
            this.txtBankaKodu.Name = "txtBankaKodu";
            this.txtBankaKodu.Properties.ReadOnly = true;
            this.txtBankaKodu.Size = new System.Drawing.Size(349, 20);
            this.txtBankaKodu.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 85);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 64;
            this.labelControl8.Text = "Banka Adı";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 60);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 13);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Text = "Banka Kodu";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 13);
            this.labelControl6.TabIndex = 61;
            this.labelControl6.Text = "Makbuz No";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(93, 134);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTutar.Properties.Appearance.Options.UseBackColor = true;
            this.txtTutar.Properties.Mask.EditMask = "c";
            this.txtTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTutar.Size = new System.Drawing.Size(137, 20);
            this.txtTutar.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 198);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 13);
            this.labelControl9.TabIndex = 62;
            this.labelControl9.Text = "Açıklama";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 63;
            this.labelControl1.Text = "Belge No";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 137);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 60;
            this.labelControl5.Text = "Tutar";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(93, 195);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(385, 210);
            this.txtAciklama.TabIndex = 8;
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
            // dxErrorProvider4
            // 
            this.dxErrorProvider4.ContainerControl = this;
            // 
            // BakiyeRadio
            // 
            this.BakiyeRadio.Location = new System.Drawing.Point(92, 157);
            this.BakiyeRadio.Name = "BakiyeRadio";
            this.BakiyeRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.BakiyeRadio.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BakiyeRadio.Properties.Appearance.Options.UseBackColor = true;
            this.BakiyeRadio.Properties.Appearance.Options.UseForeColor = true;
            this.BakiyeRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BakiyeRadio.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.BakiyeRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Giriş Miktarı"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Çıkış Miktarı")});
            this.BakiyeRadio.Size = new System.Drawing.Size(236, 32);
            this.BakiyeRadio.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 166);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 72;
            this.labelControl2.Text = "Bakiye";
            // 
            // frmBankaIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 474);
            this.Controls.Add(this.BakiyeRadio);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.TxtMakbuzNo);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.btnBankaSec);
            this.Controls.Add(this.txtBankaAdi);
            this.Controls.Add(this.txtBankaKodu);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtAciklama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaIslemi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka İşlemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBankaIslemi_FormClosed);
            this.Load += new System.EventHandler(this.frmBankaIslemi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBankaIslemi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtMakbuzNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BakiyeRadio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton KapatBtn;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton YeniBtn;
        private DevExpress.XtraEditors.SimpleButton Kaydetbtn;
        private DevExpress.XtraEditors.TextEdit TxtMakbuzNo;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.SimpleButton btnBankaSec;
        private DevExpress.XtraEditors.TextEdit txtBankaAdi;
        private DevExpress.XtraEditors.TextEdit txtBankaKodu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider3;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider4;
        private DevExpress.XtraEditors.RadioGroup BakiyeRadio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}