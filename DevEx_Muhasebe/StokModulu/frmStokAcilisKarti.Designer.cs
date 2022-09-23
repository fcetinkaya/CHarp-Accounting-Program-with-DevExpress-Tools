namespace Gelisim_Muhasebe.StokModulu
{
    partial class frmStokAcilisKarti
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
            this.dxErrorProvider4 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.btnCariSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.BakiyeRadio = new DevExpress.XtraEditors.RadioGroup();
            this.YeniBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.Kaydetbtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider3 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BakiyeRadio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dxErrorProvider4
            // 
            this.dxErrorProvider4.ContainerControl = this;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(89, 58);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(236, 20);
            this.txtTarih.TabIndex = 3;
            // 
            // btnCariSec
            // 
            this.btnCariSec.Image = global::Gelisim_Muhasebe.Properties.Resources.zoom_in;
            this.btnCariSec.Location = new System.Drawing.Point(492, 4);
            this.btnCariSec.Name = "btnCariSec";
            this.btnCariSec.Size = new System.Drawing.Size(31, 23);
            this.btnCariSec.TabIndex = 1;
            this.btnCariSec.Click += new System.EventHandler(this.btnCariSec_Click);
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(88, 32);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Properties.ReadOnly = true;
            this.txtStokAdi.Size = new System.Drawing.Size(435, 20);
            this.txtStokAdi.TabIndex = 2;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(88, 7);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.ReadOnly = true;
            this.txtStokKodu.Size = new System.Drawing.Size(392, 20);
            this.txtStokKodu.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Stok Adı";
            // 
            // dxErrorProvider2
            // 
            this.dxErrorProvider2.ContainerControl = this;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(90, 175);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(433, 164);
            this.txtAciklama.TabIndex = 7;
            // 
            // BakiyeRadio
            // 
            this.BakiyeRadio.Location = new System.Drawing.Point(90, 137);
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
            this.BakiyeRadio.TabIndex = 6;
            // 
            // YeniBtn
            // 
            this.YeniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YeniBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.YeniBtn.Appearance.Options.UseFont = true;
            this.YeniBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0009_Add;
            this.YeniBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.YeniBtn.Location = new System.Drawing.Point(10, 7);
            this.YeniBtn.Name = "YeniBtn";
            this.YeniBtn.Size = new System.Drawing.Size(127, 49);
            this.YeniBtn.TabIndex = 0;
            this.YeniBtn.Text = "Yeni";
            this.YeniBtn.Click += new System.EventHandler(this.YeniBtn_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.KapatBtn);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Controls.Add(this.Kaydetbtn);
            this.panelControl2.Controls.Add(this.YeniBtn);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 364);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(531, 66);
            this.panelControl2.TabIndex = 8;
            // 
            // KapatBtn
            // 
            this.KapatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KapatBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.KapatBtn.Appearance.Options.UseFont = true;
            this.KapatBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0006_Cross;
            this.KapatBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.KapatBtn.Location = new System.Drawing.Point(399, 7);
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
            this.btnSil.Location = new System.Drawing.Point(279, 7);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 49);
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
            this.Kaydetbtn.Location = new System.Drawing.Point(146, 7);
            this.Kaydetbtn.Name = "Kaydetbtn";
            this.Kaydetbtn.Size = new System.Drawing.Size(127, 49);
            this.Kaydetbtn.TabIndex = 1;
            this.Kaydetbtn.Text = "Kaydet";
            this.Kaydetbtn.Click += new System.EventHandler(this.Kaydetbtn_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Stok Kodu";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 178);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Açıklama";
            // 
            // dxErrorProvider3
            // 
            this.dxErrorProvider3.ContainerControl = this;
            // 
            // txtTutar
            // 
            this.txtTutar.EditValue = "";
            this.txtTutar.Location = new System.Drawing.Point(89, 84);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.Mask.EditMask = "c";
            this.txtTutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTutar.Size = new System.Drawing.Size(235, 20);
            this.txtTutar.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 87);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Tutar";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 146);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Bakiye";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 114);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Miktar";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(89, 111);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.Mask.EditMask = "d";
            this.txtMiktar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMiktar.Size = new System.Drawing.Size(235, 20);
            this.txtMiktar.TabIndex = 5;
            // 
            // frmStokAcilisKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 430);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.btnCariSec);
            this.Controls.Add(this.txtStokAdi);
            this.Controls.Add(this.txtStokKodu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.BakiyeRadio);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokAcilisKarti";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Açılış Kartı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStokAcilisKarti_FormClosed);
            this.Load += new System.EventHandler(this.frmStokAcilisKarti_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStokAcilisKarti_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BakiyeRadio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.SimpleButton btnCariSec;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.RadioGroup BakiyeRadio;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton KapatBtn;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton Kaydetbtn;
        private DevExpress.XtraEditors.SimpleButton YeniBtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider3;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}