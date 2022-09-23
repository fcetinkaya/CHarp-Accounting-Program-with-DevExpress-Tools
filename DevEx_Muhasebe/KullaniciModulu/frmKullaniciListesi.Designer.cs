namespace Gelisim_Muhasebe.KullaniciModulu
{
    partial class frmKullaniciListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciListesi));
            this.KULLANICIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOYADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EPOSTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SIFRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DURUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.navigationBarItem1 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.AraBtn = new DevExpress.XtraEditors.SimpleButton();
            this.TemizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.SoyadiBox = new DevExpress.XtraEditors.TextEdit();
            this.EPostaBox = new DevExpress.XtraEditors.TextEdit();
            this.TelefonBox = new DevExpress.XtraEditors.TextEdit();
            this.AdiBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.navigationBarItem2 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniKullaniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KullaniciTooltipDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.KullaniciIzizinleriToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel97ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2013ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimOlarakKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoyadiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPostaBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdiBox.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KULLANICIADI
            // 
            this.KULLANICIADI.Caption = "KULLANICIADI";
            this.KULLANICIADI.FieldName = "KullaniciAdi";
            this.KULLANICIADI.Name = "KULLANICIADI";
            this.KULLANICIADI.OptionsColumn.AllowEdit = false;
            this.KULLANICIADI.OptionsColumn.AllowFocus = false;
            this.KULLANICIADI.OptionsColumn.FixedWidth = true;
            this.KULLANICIADI.OptionsColumn.ReadOnly = true;
            this.KULLANICIADI.Visible = true;
            this.KULLANICIADI.VisibleIndex = 4;
            this.KULLANICIADI.Width = 120;
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
            this.ACIKLAMA.VisibleIndex = 6;
            this.ACIKLAMA.Width = 300;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl1.Size = new System.Drawing.Size(654, 568);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.AD,
            this.SOYADI,
            this.EPOSTA,
            this.TELEFON,
            this.KULLANICIADI,
            this.SIFRE,
            this.ACIKLAMA,
            this.DURUM});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldNameSortGroup = "KullaniciID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.AllowShowHide = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            // 
            // AD
            // 
            this.AD.Caption = "ADI";
            this.AD.FieldName = "Ad";
            this.AD.Name = "AD";
            this.AD.OptionsColumn.AllowEdit = false;
            this.AD.OptionsColumn.AllowFocus = false;
            this.AD.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.AD.OptionsColumn.FixedWidth = true;
            this.AD.OptionsColumn.ReadOnly = true;
            this.AD.Visible = true;
            this.AD.VisibleIndex = 0;
            this.AD.Width = 150;
            // 
            // SOYADI
            // 
            this.SOYADI.Caption = "SOYADI";
            this.SOYADI.FieldName = "Soyad";
            this.SOYADI.Name = "SOYADI";
            this.SOYADI.OptionsColumn.AllowEdit = false;
            this.SOYADI.OptionsColumn.AllowFocus = false;
            this.SOYADI.OptionsColumn.FixedWidth = true;
            this.SOYADI.OptionsColumn.ReadOnly = true;
            this.SOYADI.Visible = true;
            this.SOYADI.VisibleIndex = 1;
            this.SOYADI.Width = 120;
            // 
            // EPOSTA
            // 
            this.EPOSTA.Caption = "EPOSTA";
            this.EPOSTA.FieldName = "Eposta";
            this.EPOSTA.Name = "EPOSTA";
            this.EPOSTA.OptionsColumn.AllowEdit = false;
            this.EPOSTA.OptionsColumn.AllowFocus = false;
            this.EPOSTA.OptionsColumn.FixedWidth = true;
            this.EPOSTA.OptionsColumn.ReadOnly = true;
            this.EPOSTA.Visible = true;
            this.EPOSTA.VisibleIndex = 2;
            this.EPOSTA.Width = 120;
            // 
            // TELEFON
            // 
            this.TELEFON.Caption = "TELEFON";
            this.TELEFON.FieldName = "Telefon";
            this.TELEFON.Name = "TELEFON";
            this.TELEFON.OptionsColumn.AllowEdit = false;
            this.TELEFON.OptionsColumn.AllowFocus = false;
            this.TELEFON.OptionsColumn.FixedWidth = true;
            this.TELEFON.OptionsColumn.ReadOnly = true;
            this.TELEFON.Visible = true;
            this.TELEFON.VisibleIndex = 3;
            this.TELEFON.Width = 120;
            // 
            // SIFRE
            // 
            this.SIFRE.Caption = "ŞİFRE";
            this.SIFRE.FieldName = "Sifre";
            this.SIFRE.Name = "SIFRE";
            this.SIFRE.OptionsColumn.AllowEdit = false;
            this.SIFRE.OptionsColumn.AllowFocus = false;
            this.SIFRE.OptionsColumn.FixedWidth = true;
            this.SIFRE.OptionsColumn.ReadOnly = true;
            this.SIFRE.Visible = true;
            this.SIFRE.VisibleIndex = 5;
            this.SIFRE.Width = 120;
            // 
            // DURUM
            // 
            this.DURUM.Caption = "DURUM";
            this.DURUM.ColumnEdit = this.repositoryItemImageComboBox1;
            this.DURUM.FieldName = "Admin";
            this.DURUM.Name = "DURUM";
            this.DURUM.OptionsColumn.AllowEdit = false;
            this.DURUM.OptionsColumn.AllowFocus = false;
            this.DURUM.OptionsColumn.ReadOnly = true;
            this.DURUM.Visible = true;
            this.DURUM.VisibleIndex = 7;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yönetici", true, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yönetici Değil", false, -1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // navigationBarItem1
            // 
            this.navigationBarItem1.Name = "navigationBarItem1";
            this.navigationBarItem1.Text = "Item1";
            // 
            // AraBtn
            // 
            this.AraBtn.Image = ((System.Drawing.Image)(resources.GetObject("AraBtn.Image")));
            this.AraBtn.Location = new System.Drawing.Point(3, 227);
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.Size = new System.Drawing.Size(75, 23);
            this.AraBtn.TabIndex = 2;
            this.AraBtn.Text = "Ara";
            this.AraBtn.Click += new System.EventHandler(this.AraBtn_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.Image = ((System.Drawing.Image)(resources.GetObject("TemizleBtn.Image")));
            this.TemizleBtn.Location = new System.Drawing.Point(84, 227);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(75, 23);
            this.TemizleBtn.TabIndex = 1;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(878, 568);
            this.splitContainerControl1.SplitterPosition = 219;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(219, 568);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.SoyadiBox);
            this.xtraTabPage1.Controls.Add(this.EPostaBox);
            this.xtraTabPage1.Controls.Add(this.TelefonBox);
            this.xtraTabPage1.Controls.Add(this.AdiBox);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.AraBtn);
            this.xtraTabPage1.Controls.Add(this.TemizleBtn);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPage1.Size = new System.Drawing.Size(213, 540);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Soyadı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 171);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "E-Posta";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Telefon";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(3, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(15, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Adı";
            // 
            // SoyadiBox
            // 
            this.SoyadiBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoyadiBox.Location = new System.Drawing.Point(3, 86);
            this.SoyadiBox.Name = "SoyadiBox";
            this.SoyadiBox.Size = new System.Drawing.Size(199, 20);
            this.SoyadiBox.TabIndex = 4;
            // 
            // EPostaBox
            // 
            this.EPostaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EPostaBox.Location = new System.Drawing.Point(3, 190);
            this.EPostaBox.Name = "EPostaBox";
            this.EPostaBox.Size = new System.Drawing.Size(199, 20);
            this.EPostaBox.TabIndex = 5;
            // 
            // TelefonBox
            // 
            this.TelefonBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TelefonBox.Location = new System.Drawing.Point(3, 142);
            this.TelefonBox.Name = "TelefonBox";
            this.TelefonBox.Size = new System.Drawing.Size(199, 20);
            this.TelefonBox.TabIndex = 6;
            // 
            // AdiBox
            // 
            this.AdiBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdiBox.Location = new System.Drawing.Point(3, 32);
            this.AdiBox.Name = "AdiBox";
            this.AdiBox.Size = new System.Drawing.Size(199, 20);
            this.AdiBox.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 171);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(17, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "İlçe";
            // 
            // navigationBarItem2
            // 
            this.navigationBarItem2.Name = "navigationBarItem2";
            this.navigationBarItem2.Text = "Item2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKullaniciToolStripMenuItem,
            this.KullaniciTooltipDuzenle,
            this.KullaniciIzizinleriToolTip,
            this.seçToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.excelAktarToolStripMenuItem,
            this.pdfAktarToolStripMenuItem,
            this.csvAktarToolStripMenuItem,
            this.htmlAktarToolStripMenuItem,
            this.resimOlarakKaydetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 224);
            // 
            // yeniKullaniciToolStripMenuItem
            // 
            this.yeniKullaniciToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.KullanıcıEkle;
            this.yeniKullaniciToolStripMenuItem.Name = "yeniKullaniciToolStripMenuItem";
            this.yeniKullaniciToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.yeniKullaniciToolStripMenuItem.Text = "Yeni Kullanıcı Ekle";
            this.yeniKullaniciToolStripMenuItem.Click += new System.EventHandler(this.yeniKullaniciEkleToolStripMenuItem_Click);
            // 
            // KullaniciTooltipDuzenle
            // 
            this.KullaniciTooltipDuzenle.Image = global::Gelisim_Muhasebe.Properties.Resources.edit;
            this.KullaniciTooltipDuzenle.Name = "KullaniciTooltipDuzenle";
            this.KullaniciTooltipDuzenle.Size = new System.Drawing.Size(182, 22);
            this.KullaniciTooltipDuzenle.Text = "Düzenle";
            this.KullaniciTooltipDuzenle.Click += new System.EventHandler(this.yeniKullaniciEkleToolStripMenuItem_Click);
            // 
            // KullaniciIzizinleriToolTip
            // 
            this.KullaniciIzizinleriToolTip.Image = global::Gelisim_Muhasebe.Properties.Resources.Kullanıcıİzinleri;
            this.KullaniciIzizinleriToolTip.Name = "KullaniciIzizinleriToolTip";
            this.KullaniciIzizinleriToolTip.Size = new System.Drawing.Size(182, 22);
            this.KullaniciIzizinleriToolTip.Text = "Kullanıcı İzinleri";
            this.KullaniciIzizinleriToolTip.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // seçToolStripMenuItem
            // 
            this.seçToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources._0007_Tick;
            this.seçToolStripMenuItem.Name = "seçToolStripMenuItem";
            this.seçToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.seçToolStripMenuItem.Text = "Seç";
            this.seçToolStripMenuItem.Click += new System.EventHandler(this.seçToolStripMenuItem_Click);
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
            this.excel97ToolStripMenuItem,
            this.excel2013ToolStripMenuItem});
            this.excelAktarToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.excel_viewer;
            this.excelAktarToolStripMenuItem.Name = "excelAktarToolStripMenuItem";
            this.excelAktarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.excelAktarToolStripMenuItem.Text = "Excel Aktar";
            // 
            // excel97ToolStripMenuItem
            // 
            this.excel97ToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources.excel_viewer;
            this.excel97ToolStripMenuItem.Name = "excel97ToolStripMenuItem";
            this.excel97ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.excel97ToolStripMenuItem.Text = "Excel 97 - 2003";
            this.excel97ToolStripMenuItem.Click += new System.EventHandler(this.excel97ToolStripMenuItem_Click);
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
            // frmKullaniciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 568);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmKullaniciListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar Listesi";
            this.Load += new System.EventHandler(this.frmKullaniciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoyadiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPostaBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelefonBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdiBox.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn KULLANICIADI;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn AD;
        private DevExpress.XtraGrid.Columns.GridColumn SOYADI;
        private DevExpress.XtraGrid.Columns.GridColumn EPOSTA;
        private DevExpress.XtraGrid.Columns.GridColumn TELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn SIFRE;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem1;
        private DevExpress.XtraEditors.SimpleButton AraBtn;
        private DevExpress.XtraEditors.SimpleButton TemizleBtn;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit SoyadiBox;
        private DevExpress.XtraEditors.TextEdit EPostaBox;
        private DevExpress.XtraEditors.TextEdit TelefonBox;
        private DevExpress.XtraEditors.TextEdit AdiBox;
        private DevExpress.XtraGrid.Columns.GridColumn DURUM;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniKullaniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KullaniciTooltipDuzenle;
        private System.Windows.Forms.ToolStripMenuItem KullaniciIzizinleriToolTip;
        private System.Windows.Forms.ToolStripMenuItem seçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel97ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel2013ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimOlarakKaydetToolStripMenuItem;
    }
}