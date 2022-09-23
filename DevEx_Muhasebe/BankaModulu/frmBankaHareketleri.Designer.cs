namespace Gelisim_Muhasebe.BankaModulu
{
    partial class frmBankaHareketleri
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKasaSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtBankaIsmi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2003ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2013ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimOlarakKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BankaHareketID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKAKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESAPADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESAPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FISNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKBUZNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtBorc = new DevExpress.XtraEditors.TextEdit();
            this.txtAlacak = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaIsmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBorc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlacak.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKasaSec);
            this.groupControl1.Controls.Add(this.txtBankaIsmi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtBankaKodu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1350, 100);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Kasa Bilgileri";
            // 
            // btnKasaSec
            // 
            this.btnKasaSec.Image = global::Gelisim_Muhasebe.Properties.Resources.zoom_in;
            this.btnKasaSec.Location = new System.Drawing.Point(458, 27);
            this.btnKasaSec.Name = "btnKasaSec";
            this.btnKasaSec.Size = new System.Drawing.Size(31, 23);
            this.btnKasaSec.TabIndex = 1;
            this.btnKasaSec.Click += new System.EventHandler(this.btnBankaSec_Click);
            // 
            // txtBankaIsmi
            // 
            this.txtBankaIsmi.Location = new System.Drawing.Point(93, 55);
            this.txtBankaIsmi.Name = "txtBankaIsmi";
            this.txtBankaIsmi.Properties.ReadOnly = true;
            this.txtBankaIsmi.Size = new System.Drawing.Size(690, 20);
            this.txtBankaIsmi.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Banka İsmi";
            // 
            // txtBankaKodu
            // 
            this.txtBankaKodu.Location = new System.Drawing.Point(93, 29);
            this.txtBankaKodu.Name = "txtBankaKodu";
            this.txtBankaKodu.Properties.ReadOnly = true;
            this.txtBankaKodu.Size = new System.Drawing.Size(359, 20);
            this.txtBankaKodu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Banka Kodu";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridControl1.Location = new System.Drawing.Point(0, 97);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1350, 665);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.excelAktarToolStripMenuItem,
            this.pdfAktarToolStripMenuItem,
            this.csvAktarToolStripMenuItem,
            this.htmlAktarToolStripMenuItem,
            this.resimOlarakKaydetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 158);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.edit;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.Print;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // excelAktarToolStripMenuItem
            // 
            this.excelAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excel2003ToolStripMenuItem,
            this.excel2013ToolStripMenuItem});
            this.excelAktarToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.excel_viewer;
            this.excelAktarToolStripMenuItem.Name = "excelAktarToolStripMenuItem";
            this.excelAktarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.excelAktarToolStripMenuItem.Text = "Excel Aktar";
            // 
            // excel2003ToolStripMenuItem
            // 
            this.excel2003ToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.excel_viewer;
            this.excel2003ToolStripMenuItem.Name = "excel2003ToolStripMenuItem";
            this.excel2003ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.excel2003ToolStripMenuItem.Text = "Excel 97 - 2003";
            this.excel2003ToolStripMenuItem.Click += new System.EventHandler(this.excel2007ToolStripMenuItem_Click);
            // 
            // excel2013ToolStripMenuItem
            // 
            this.excel2013ToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.excel_viewer;
            this.excel2013ToolStripMenuItem.Name = "excel2013ToolStripMenuItem";
            this.excel2013ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.excel2013ToolStripMenuItem.Text = "Excel 2007 - 2010 - 2015 ";
            this.excel2013ToolStripMenuItem.Click += new System.EventHandler(this.excel2013ToolStripMenuItem_Click);
            // 
            // pdfAktarToolStripMenuItem
            // 
            this.pdfAktarToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.pdfIcon;
            this.pdfAktarToolStripMenuItem.Name = "pdfAktarToolStripMenuItem";
            this.pdfAktarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pdfAktarToolStripMenuItem.Text = "Pdf Aktar";
            this.pdfAktarToolStripMenuItem.Click += new System.EventHandler(this.pdfAktarToolStripMenuItem_Click);
            // 
            // csvAktarToolStripMenuItem
            // 
            this.csvAktarToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.csv_icon;
            this.csvAktarToolStripMenuItem.Name = "csvAktarToolStripMenuItem";
            this.csvAktarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.csvAktarToolStripMenuItem.Text = "Csv Aktar";
            this.csvAktarToolStripMenuItem.Click += new System.EventHandler(this.csvAktarToolStripMenuItem_Click);
            // 
            // htmlAktarToolStripMenuItem
            // 
            this.htmlAktarToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.html_icon;
            this.htmlAktarToolStripMenuItem.Name = "htmlAktarToolStripMenuItem";
            this.htmlAktarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.htmlAktarToolStripMenuItem.Text = "Html Aktar";
            this.htmlAktarToolStripMenuItem.Click += new System.EventHandler(this.htmlAktarToolStripMenuItem_Click);
            // 
            // resimOlarakKaydetToolStripMenuItem
            // 
            this.resimOlarakKaydetToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.jpg;
            this.resimOlarakKaydetToolStripMenuItem.Name = "resimOlarakKaydetToolStripMenuItem";
            this.resimOlarakKaydetToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.resimOlarakKaydetToolStripMenuItem.Text = "Resim Olarak Kaydet";
            this.resimOlarakKaydetToolStripMenuItem.Click += new System.EventHandler(this.resimOlarakKaydetToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BankaHareketID,
            this.BANKAID,
            this.BANKAKODU,
            this.BANKAADI,
            this.HESAPADI,
            this.HESAPNO,
            this.TARIH,
            this.FISNO,
            this.MAKBUZNO,
            this.GIRIS,
            this.CIKIS,
            this.BAKIYE,
            this.CARIKODU,
            this.CARIADI,
            this.ACIKLAMA,
            this.TIPI});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BankaHareketID
            // 
            this.BankaHareketID.Caption = "BankaHareketID";
            this.BankaHareketID.FieldName = "BankaHareketID";
            this.BankaHareketID.Name = "BankaHareketID";
            // 
            // BANKAID
            // 
            this.BANKAID.Caption = "BANKAID";
            this.BANKAID.FieldName = "BankaID";
            this.BANKAID.Name = "BANKAID";
            this.BANKAID.OptionsColumn.AllowEdit = false;
            this.BANKAID.OptionsColumn.AllowFocus = false;
            this.BANKAID.OptionsColumn.AllowShowHide = false;
            this.BANKAID.OptionsColumn.ReadOnly = true;
            // 
            // BANKAKODU
            // 
            this.BANKAKODU.Caption = "BANKAKODU";
            this.BANKAKODU.FieldName = "BankaKodu";
            this.BANKAKODU.Name = "BANKAKODU";
            this.BANKAKODU.OptionsColumn.AllowEdit = false;
            this.BANKAKODU.OptionsColumn.AllowFocus = false;
            this.BANKAKODU.OptionsColumn.ReadOnly = true;
            this.BANKAKODU.Visible = true;
            this.BANKAKODU.VisibleIndex = 0;
            // 
            // BANKAADI
            // 
            this.BANKAADI.Caption = "BANKA ADI";
            this.BANKAADI.FieldName = "BankaAdi";
            this.BANKAADI.Name = "BANKAADI";
            this.BANKAADI.OptionsColumn.AllowEdit = false;
            this.BANKAADI.OptionsColumn.AllowFocus = false;
            this.BANKAADI.OptionsColumn.ReadOnly = true;
            this.BANKAADI.Visible = true;
            this.BANKAADI.VisibleIndex = 1;
            this.BANKAADI.Width = 150;
            // 
            // HESAPADI
            // 
            this.HESAPADI.Caption = "HESAP ADI";
            this.HESAPADI.FieldName = "HesapAdi";
            this.HESAPADI.Name = "HESAPADI";
            this.HESAPADI.OptionsColumn.AllowEdit = false;
            this.HESAPADI.OptionsColumn.AllowFocus = false;
            this.HESAPADI.OptionsColumn.ReadOnly = true;
            this.HESAPADI.Visible = true;
            this.HESAPADI.VisibleIndex = 2;
            this.HESAPADI.Width = 150;
            // 
            // HESAPNO
            // 
            this.HESAPNO.Caption = "HESAP NO";
            this.HESAPNO.FieldName = "HesapNo";
            this.HESAPNO.Name = "HESAPNO";
            this.HESAPNO.OptionsColumn.AllowEdit = false;
            this.HESAPNO.OptionsColumn.AllowFocus = false;
            this.HESAPNO.OptionsColumn.ReadOnly = true;
            this.HESAPNO.Visible = true;
            this.HESAPNO.VisibleIndex = 3;
            this.HESAPNO.Width = 150;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "Tarih";
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.AllowShowHide = false;
            this.TARIH.OptionsColumn.ReadOnly = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 4;
            this.TARIH.Width = 100;
            // 
            // FISNO
            // 
            this.FISNO.Caption = "FİŞ NO";
            this.FISNO.FieldName = "FisNo";
            this.FISNO.Name = "FISNO";
            this.FISNO.OptionsColumn.AllowEdit = false;
            this.FISNO.OptionsColumn.AllowFocus = false;
            this.FISNO.OptionsColumn.AllowShowHide = false;
            this.FISNO.OptionsColumn.ReadOnly = true;
            this.FISNO.Visible = true;
            this.FISNO.VisibleIndex = 5;
            this.FISNO.Width = 100;
            // 
            // MAKBUZNO
            // 
            this.MAKBUZNO.Caption = "MAKBUZ NO";
            this.MAKBUZNO.FieldName = "MakbuzNo";
            this.MAKBUZNO.Name = "MAKBUZNO";
            this.MAKBUZNO.OptionsColumn.AllowEdit = false;
            this.MAKBUZNO.OptionsColumn.AllowFocus = false;
            this.MAKBUZNO.OptionsColumn.ReadOnly = true;
            this.MAKBUZNO.Visible = true;
            this.MAKBUZNO.VisibleIndex = 6;
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ TUTARI";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.AllowShowHide = false;
            this.GIRIS.OptionsColumn.ReadOnly = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 7;
            this.GIRIS.Width = 125;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ TUTARI";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.AllowShowHide = false;
            this.CIKIS.OptionsColumn.ReadOnly = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 8;
            this.CIKIS.Width = 125;
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARİ KODU";
            this.CARIKODU.FieldName = "CariKodu";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.AllowShowHide = false;
            this.CARIKODU.OptionsColumn.ReadOnly = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 10;
            this.CARIKODU.Width = 125;
            // 
            // CARIADI
            // 
            this.CARIADI.Caption = "CARİ ADI";
            this.CARIADI.FieldName = "CariIsim";
            this.CARIADI.Name = "CARIADI";
            this.CARIADI.OptionsColumn.AllowEdit = false;
            this.CARIADI.OptionsColumn.AllowFocus = false;
            this.CARIADI.OptionsColumn.AllowShowHide = false;
            this.CARIADI.OptionsColumn.ReadOnly = true;
            this.CARIADI.Visible = true;
            this.CARIADI.VisibleIndex = 11;
            this.CARIADI.Width = 200;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "Aciklama";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.OptionsColumn.ReadOnly = true;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 12;
            this.ACIKLAMA.Width = 200;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "TİPİ";
            this.TIPI.FieldName = "Tipi";
            this.TIPI.Name = "TIPI";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(272, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Toplam Borç";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtBakiye);
            this.panelControl1.Controls.Add(this.txtBorc);
            this.panelControl1.Controls.Add(this.txtAlacak);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(0, 762);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1350, 50);
            this.panelControl1.TabIndex = 8;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(611, 16);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBakiye.Properties.Appearance.Options.UseBackColor = true;
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(139, 20);
            this.txtBakiye.TabIndex = 1;
            // 
            // txtBorc
            // 
            this.txtBorc.Location = new System.Drawing.Point(363, 16);
            this.txtBorc.Name = "txtBorc";
            this.txtBorc.Properties.ReadOnly = true;
            this.txtBorc.Size = new System.Drawing.Size(139, 20);
            this.txtBorc.TabIndex = 1;
            // 
            // txtAlacak
            // 
            this.txtAlacak.Location = new System.Drawing.Point(108, 16);
            this.txtAlacak.Name = "txtAlacak";
            this.txtAlacak.Properties.ReadOnly = true;
            this.txtAlacak.Size = new System.Drawing.Size(139, 20);
            this.txtAlacak.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(543, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Bakiye";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Toplam Alacak";
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKİYE";
            this.BAKIYE.FieldName = "Bakiye";
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.OptionsColumn.AllowEdit = false;
            this.BAKIYE.OptionsColumn.AllowFocus = false;
            this.BAKIYE.OptionsColumn.AllowShowHide = false;
            this.BAKIYE.OptionsColumn.ReadOnly = true;
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 9;
            this.BAKIYE.Width = 125;
            // 
            // frmBankaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 812);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "frmBankaHareketleri";
            this.Text = "Banka Hareketleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBankaHareketleri_FormClosed);
            this.Load += new System.EventHandler(this.frmBankaHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaIsmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBorc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlacak.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKasaSec;
        private DevExpress.XtraEditors.TextEdit txtBankaIsmi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBankaKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BANKAID;
        private DevExpress.XtraGrid.Columns.GridColumn FISNO;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIADI;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.TextEdit txtBorc;
        private DevExpress.XtraEditors.TextEdit txtAlacak;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn BankaHareketID;
        private DevExpress.XtraGrid.Columns.GridColumn MAKBUZNO;
        private DevExpress.XtraGrid.Columns.GridColumn HESAPADI;
        private DevExpress.XtraGrid.Columns.GridColumn BANKAADI;
        private DevExpress.XtraGrid.Columns.GridColumn BANKAKODU;
        private DevExpress.XtraGrid.Columns.GridColumn HESAPNO;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel2003ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel2013ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimOlarakKaydetToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
    }
}