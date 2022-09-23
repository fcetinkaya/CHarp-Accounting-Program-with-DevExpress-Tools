namespace Gelisim_Muhasebe.StokModulu
{
    partial class frmStokHareketKayitlari
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCariSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtStokIsmi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniStokEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StokHareketRaporutoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariHareketKayıtlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2007ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2013ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimOlarakKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRUTFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISK2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NETFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtCikis = new DevExpress.XtraEditors.TextEdit();
            this.txtGiris = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.CARIID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokIsmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.DisplayFormat.FormatString = "N2";
            this.GIRIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIRIS.FieldName = "Giris";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.ReadOnly = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 6;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.DisplayFormat.FormatString = "N2";
            this.CIKIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CIKIS.FieldName = "Cikis";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.ReadOnly = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCariSec);
            this.groupControl1.Controls.Add(this.txtStokIsmi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtStokKodu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(891, 100);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Stok Bilgileri";
            // 
            // btnCariSec
            // 
            this.btnCariSec.Image = global::Gelisim_Muhasebe.Properties.Resources.zoom_in;
            this.btnCariSec.Location = new System.Drawing.Point(458, 27);
            this.btnCariSec.Name = "btnCariSec";
            this.btnCariSec.Size = new System.Drawing.Size(31, 23);
            this.btnCariSec.TabIndex = 1;
            this.btnCariSec.Click += new System.EventHandler(this.btnCariSec_Click);
            // 
            // txtStokIsmi
            // 
            this.txtStokIsmi.Location = new System.Drawing.Point(93, 55);
            this.txtStokIsmi.Name = "txtStokIsmi";
            this.txtStokIsmi.Size = new System.Drawing.Size(396, 20);
            this.txtStokIsmi.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Stok İsmi";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(93, 29);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(359, 20);
            this.txtStokKodu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
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
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(891, 565);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniStokEkleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.StokHareketRaporutoolStripMenuItem,
            this.cariHareketKayıtlarıToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.excelAktarToolStripMenuItem,
            this.pdfAktarToolStripMenuItem,
            this.csvAktarToolStripMenuItem,
            this.htmlAktarToolStripMenuItem,
            this.resimOlarakKaydetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 224);
            // 
            // yeniStokEkleToolStripMenuItem
            // 
            this.yeniStokEkleToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.BankaTanitimKarti;
            this.yeniStokEkleToolStripMenuItem.Name = "yeniStokEkleToolStripMenuItem";
            this.yeniStokEkleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.yeniStokEkleToolStripMenuItem.Text = "Yeni Stok Ekle";
            this.yeniStokEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniStokEkleToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.edit;
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // StokHareketRaporutoolStripMenuItem
            // 
            this.StokHareketRaporutoolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.BankaCekCikisi;
            this.StokHareketRaporutoolStripMenuItem.Name = "StokHareketRaporutoolStripMenuItem";
            this.StokHareketRaporutoolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.StokHareketRaporutoolStripMenuItem.Text = "Stok Hareket Raporu";
            this.StokHareketRaporutoolStripMenuItem.Click += new System.EventHandler(this.StokHareketRaporutoolStripMenuItem_Click);
            // 
            // cariHareketKayıtlarıToolStripMenuItem
            // 
            this.cariHareketKayıtlarıToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.CariHareketRaporu;
            this.cariHareketKayıtlarıToolStripMenuItem.Name = "cariHareketKayıtlarıToolStripMenuItem";
            this.cariHareketKayıtlarıToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cariHareketKayıtlarıToolStripMenuItem.Text = "Cari Hareket Kayıtları";
            this.cariHareketKayıtlarıToolStripMenuItem.Click += new System.EventHandler(this.cariHareketKayıtlarıToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.Print;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // excelAktarToolStripMenuItem
            // 
            this.excelAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excel2007ToolStripMenuItem,
            this.excel2013ToolStripMenuItem});
            this.excelAktarToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.excel_viewer;
            this.excelAktarToolStripMenuItem.Name = "excelAktarToolStripMenuItem";
            this.excelAktarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.excelAktarToolStripMenuItem.Text = "Excel Aktar";
            // 
            // excel2007ToolStripMenuItem
            // 
            this.excel2007ToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.excel_viewer;
            this.excel2007ToolStripMenuItem.Name = "excel2007ToolStripMenuItem";
            this.excel2007ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.excel2007ToolStripMenuItem.Text = "Excel 97 - 2003";
            this.excel2007ToolStripMenuItem.Click += new System.EventHandler(this.excel2007ToolStripMenuItem_Click);
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
            this.pdfAktarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.pdfAktarToolStripMenuItem.Text = "Pdf Aktar";
            this.pdfAktarToolStripMenuItem.Click += new System.EventHandler(this.pdfAktarToolStripMenuItem_Click);
            // 
            // csvAktarToolStripMenuItem
            // 
            this.csvAktarToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.csv_icon;
            this.csvAktarToolStripMenuItem.Name = "csvAktarToolStripMenuItem";
            this.csvAktarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.csvAktarToolStripMenuItem.Text = "Csv Aktar";
            this.csvAktarToolStripMenuItem.Click += new System.EventHandler(this.csvAktarToolStripMenuItem_Click);
            // 
            // htmlAktarToolStripMenuItem
            // 
            this.htmlAktarToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.html_icon;
            this.htmlAktarToolStripMenuItem.Name = "htmlAktarToolStripMenuItem";
            this.htmlAktarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.htmlAktarToolStripMenuItem.Text = "Html Aktar";
            this.htmlAktarToolStripMenuItem.Click += new System.EventHandler(this.htmlAktarToolStripMenuItem_Click);
            // 
            // resimOlarakKaydetToolStripMenuItem
            // 
            this.resimOlarakKaydetToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.jpg;
            this.resimOlarakKaydetToolStripMenuItem.Name = "resimOlarakKaydetToolStripMenuItem";
            this.resimOlarakKaydetToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.resimOlarakKaydetToolStripMenuItem.Text = "Resim Olarak Kaydet";
            this.resimOlarakKaydetToolStripMenuItem.Click += new System.EventHandler(this.resimOlarakKaydetToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CARIKODU,
            this.CARIISIM,
            this.FATURANO,
            this.BELGENO,
            this.TARIH,
            this.GCKODU,
            this.GIRIS,
            this.CIKIS,
            this.BRUTFIYAT,
            this.ISK1,
            this.ISK2,
            this.NETFIYAT,
            this.TIPI,
            this.ACIKLAMA,
            this.STOKID,
            this.CARIID});
            gridFormatRule1.Column = this.GIRIS;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue1.Value1 = "0";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.Column = this.CIKIS;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue2.Appearance.Options.UseFont = true;
            formatConditionRuleValue2.Value1 = "0";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "CariHareketID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.AllowShowHide = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARİKODU";
            this.CARIKODU.FieldName = "CariKodu";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.ReadOnly = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 0;
            this.CARIKODU.Width = 100;
            // 
            // CARIISIM
            // 
            this.CARIISIM.Caption = "CARIADI";
            this.CARIISIM.FieldName = "CariIsim";
            this.CARIISIM.Name = "CARIISIM";
            this.CARIISIM.OptionsColumn.AllowEdit = false;
            this.CARIISIM.OptionsColumn.AllowFocus = false;
            this.CARIISIM.OptionsColumn.ReadOnly = true;
            this.CARIISIM.Visible = true;
            this.CARIISIM.VisibleIndex = 1;
            this.CARIISIM.Width = 150;
            // 
            // FATURANO
            // 
            this.FATURANO.Caption = "FATURANO";
            this.FATURANO.FieldName = "FaturaNo";
            this.FATURANO.Name = "FATURANO";
            this.FATURANO.OptionsColumn.AllowEdit = false;
            this.FATURANO.OptionsColumn.AllowFocus = false;
            this.FATURANO.OptionsColumn.ReadOnly = true;
            this.FATURANO.Visible = true;
            this.FATURANO.VisibleIndex = 2;
            this.FATURANO.Width = 100;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGENO";
            this.BELGENO.FieldName = "BelgeNo";
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.ReadOnly = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 3;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "Tarih";
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.ReadOnly = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 4;
            // 
            // GCKODU
            // 
            this.GCKODU.Caption = "GCKODU";
            this.GCKODU.FieldName = "GCKod";
            this.GCKODU.Name = "GCKODU";
            this.GCKODU.OptionsColumn.AllowEdit = false;
            this.GCKODU.OptionsColumn.AllowFocus = false;
            this.GCKODU.OptionsColumn.ReadOnly = true;
            this.GCKODU.Visible = true;
            this.GCKODU.VisibleIndex = 5;
            this.GCKODU.Width = 50;
            // 
            // BRUTFIYAT
            // 
            this.BRUTFIYAT.Caption = "BRÜT FİYAT";
            this.BRUTFIYAT.DisplayFormat.FormatString = "N2";
            this.BRUTFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BRUTFIYAT.FieldName = "BrutFiyat";
            this.BRUTFIYAT.Name = "BRUTFIYAT";
            this.BRUTFIYAT.OptionsColumn.AllowEdit = false;
            this.BRUTFIYAT.OptionsColumn.AllowFocus = false;
            this.BRUTFIYAT.OptionsColumn.ReadOnly = true;
            this.BRUTFIYAT.Visible = true;
            this.BRUTFIYAT.VisibleIndex = 8;
            // 
            // ISK1
            // 
            this.ISK1.Caption = "ISK1 (%)";
            this.ISK1.DisplayFormat.FormatString = "N2";
            this.ISK1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ISK1.FieldName = "Isk1";
            this.ISK1.Name = "ISK1";
            this.ISK1.OptionsColumn.AllowEdit = false;
            this.ISK1.OptionsColumn.AllowFocus = false;
            this.ISK1.OptionsColumn.ReadOnly = true;
            this.ISK1.Visible = true;
            this.ISK1.VisibleIndex = 9;
            // 
            // ISK2
            // 
            this.ISK2.Caption = "İSK2 (%)";
            this.ISK2.DisplayFormat.FormatString = "N2";
            this.ISK2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ISK2.FieldName = "Isk2";
            this.ISK2.Name = "ISK2";
            this.ISK2.OptionsColumn.AllowEdit = false;
            this.ISK2.OptionsColumn.AllowFocus = false;
            this.ISK2.OptionsColumn.ReadOnly = true;
            this.ISK2.Visible = true;
            this.ISK2.VisibleIndex = 10;
            // 
            // NETFIYAT
            // 
            this.NETFIYAT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NETFIYAT.AppearanceCell.Options.UseBackColor = true;
            this.NETFIYAT.Caption = "NET FİYAT";
            this.NETFIYAT.DisplayFormat.FormatString = "N2";
            this.NETFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NETFIYAT.FieldName = "NetFiyat";
            this.NETFIYAT.Name = "NETFIYAT";
            this.NETFIYAT.OptionsColumn.AllowEdit = false;
            this.NETFIYAT.OptionsColumn.AllowFocus = false;
            this.NETFIYAT.OptionsColumn.ReadOnly = true;
            this.NETFIYAT.Visible = true;
            this.NETFIYAT.VisibleIndex = 11;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "TİPİ";
            this.TIPI.FieldName = "Tipi";
            this.TIPI.Name = "TIPI";
            this.TIPI.OptionsColumn.AllowEdit = false;
            this.TIPI.OptionsColumn.AllowFocus = false;
            this.TIPI.OptionsColumn.ReadOnly = true;
            this.TIPI.Visible = true;
            this.TIPI.VisibleIndex = 12;
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
            this.ACIKLAMA.VisibleIndex = 13;
            this.ACIKLAMA.Width = 250;
            // 
            // STOKID
            // 
            this.STOKID.Caption = "STOKID";
            this.STOKID.FieldName = "StokID";
            this.STOKID.Name = "STOKID";
            this.STOKID.OptionsColumn.AllowEdit = false;
            this.STOKID.OptionsColumn.AllowFocus = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtBakiye);
            this.panelControl1.Controls.Add(this.txtCikis);
            this.panelControl1.Controls.Add(this.txtGiris);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(0, 662);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(891, 50);
            this.panelControl1.TabIndex = 4;
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
            // txtCikis
            // 
            this.txtCikis.Location = new System.Drawing.Point(363, 16);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Properties.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(139, 20);
            this.txtCikis.TabIndex = 1;
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(108, 16);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Properties.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(139, 20);
            this.txtGiris.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(543, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Bakiye";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(272, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Toplam Çıkış";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Toplam Giriş";
            // 
            // CARIID
            // 
            this.CARIID.Caption = "CARIID";
            this.CARIID.FieldName = "CariID";
            this.CARIID.Name = "CARIID";
            // 
            // frmStokHareketKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 712);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmStokHareketKayitlari";
            this.ShowIcon = false;
            this.Text = "Stok Hareket Kayıtları";
            this.Load += new System.EventHandler(this.frmStokHareketKayitlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokIsmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCariSec;
        private DevExpress.XtraEditors.TextEdit txtStokIsmi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn FATURANO;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn CARIISIM;
        private DevExpress.XtraGrid.Columns.GridColumn GCKODU;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn BRUTFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn ISK1;
        private DevExpress.XtraGrid.Columns.GridColumn ISK2;
        private DevExpress.XtraGrid.Columns.GridColumn NETFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.TextEdit txtCikis;
        private DevExpress.XtraEditors.TextEdit txtGiris;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniStokEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StokHareketRaporutoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel2007ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel2013ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimOlarakKaydetToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn STOKID;
        private System.Windows.Forms.ToolStripMenuItem cariHareketKayıtlarıToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn CARIID;
    }
}