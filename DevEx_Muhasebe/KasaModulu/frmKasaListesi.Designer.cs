namespace Gelisim_Muhasebe.Kasa
{
    partial class frmKasaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaListesi));
            this.navigationBarItem2 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.KasaAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KASAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KASAKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.navigationBarItem1 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.AraBtn = new DevExpress.XtraEditors.SimpleButton();
            this.TemizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KasaAdiBox = new DevExpress.XtraEditors.TextEdit();
            this.KasaAciklamaBox = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.KasaKoduBox = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel97ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel2013ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimOlarakKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaAdiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaAciklamaBox.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KasaKoduBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationBarItem2
            // 
            this.navigationBarItem2.Name = "navigationBarItem2";
            this.navigationBarItem2.Text = "Item2";
            // 
            // KasaAciklama
            // 
            this.KasaAciklama.Caption = "KASA AÇIKLAMA";
            this.KasaAciklama.FieldName = "KasaAciklama";
            this.KasaAciklama.Name = "KasaAciklama";
            this.KasaAciklama.OptionsColumn.AllowEdit = false;
            this.KasaAciklama.OptionsColumn.AllowFocus = false;
            this.KasaAciklama.OptionsColumn.FixedWidth = true;
            this.KasaAciklama.OptionsColumn.ReadOnly = true;
            this.KasaAciklama.Visible = true;
            this.KasaAciklama.VisibleIndex = 2;
            this.KasaAciklama.Width = 383;
            // 
            // KASAADI
            // 
            this.KASAADI.Caption = "KASA ADI";
            this.KASAADI.FieldName = "KasaAdi";
            this.KASAADI.Name = "KASAADI";
            this.KASAADI.OptionsColumn.AllowEdit = false;
            this.KASAADI.OptionsColumn.AllowFocus = false;
            this.KASAADI.OptionsColumn.ReadOnly = true;
            this.KASAADI.Visible = true;
            this.KASAADI.VisibleIndex = 1;
            this.KASAADI.Width = 227;
            // 
            // KASAKODU
            // 
            this.KASAKODU.Caption = "KASA KODU";
            this.KASAKODU.FieldName = "KasaKodu";
            this.KASAKODU.Name = "KASAKODU";
            this.KASAKODU.OptionsColumn.AllowEdit = false;
            this.KASAKODU.OptionsColumn.AllowFocus = false;
            this.KASAKODU.OptionsColumn.FixedWidth = true;
            this.KASAKODU.OptionsColumn.ReadOnly = true;
            this.KASAKODU.Visible = true;
            this.KASAKODU.VisibleIndex = 0;
            this.KASAKODU.Width = 117;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "KasaID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.AllowShowHide = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KASAKODU,
            this.KASAADI,
            this.KasaAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(530, 671);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // navigationBarItem1
            // 
            this.navigationBarItem1.Name = "navigationBarItem1";
            this.navigationBarItem1.Text = "Item1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Kasa Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Açıklama";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Kasa Kodu";
            // 
            // AraBtn
            // 
            this.AraBtn.Image = ((System.Drawing.Image)(resources.GetObject("AraBtn.Image")));
            this.AraBtn.Location = new System.Drawing.Point(11, 189);
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.Size = new System.Drawing.Size(75, 23);
            this.AraBtn.TabIndex = 3;
            this.AraBtn.Text = "Ara";
            this.AraBtn.Click += new System.EventHandler(this.AraBtn_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.Image = ((System.Drawing.Image)(resources.GetObject("TemizleBtn.Image")));
            this.TemizleBtn.Location = new System.Drawing.Point(92, 189);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(75, 23);
            this.TemizleBtn.TabIndex = 4;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // KasaAdiBox
            // 
            this.KasaAdiBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KasaAdiBox.Location = new System.Drawing.Point(11, 86);
            this.KasaAdiBox.Name = "KasaAdiBox";
            this.KasaAdiBox.Size = new System.Drawing.Size(202, 20);
            this.KasaAdiBox.TabIndex = 1;
            // 
            // KasaAciklamaBox
            // 
            this.KasaAciklamaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KasaAciklamaBox.Location = new System.Drawing.Point(11, 142);
            this.KasaAciklamaBox.Name = "KasaAciklamaBox";
            this.KasaAciklamaBox.Size = new System.Drawing.Size(202, 20);
            this.KasaAciklamaBox.TabIndex = 2;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.AraBtn);
            this.xtraTabPage1.Controls.Add(this.TemizleBtn);
            this.xtraTabPage1.Controls.Add(this.KasaAdiBox);
            this.xtraTabPage1.Controls.Add(this.KasaAciklamaBox);
            this.xtraTabPage1.Controls.Add(this.KasaKoduBox);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPage1.Size = new System.Drawing.Size(213, 643);
            this.xtraTabPage1.Text = "Arama";
            // 
            // KasaKoduBox
            // 
            this.KasaKoduBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KasaKoduBox.Location = new System.Drawing.Point(11, 32);
            this.KasaKoduBox.Name = "KasaKoduBox";
            this.KasaKoduBox.Size = new System.Drawing.Size(202, 20);
            this.KasaKoduBox.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(219, 671);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
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
            this.splitContainerControl1.Size = new System.Drawing.Size(754, 671);
            this.splitContainerControl1.SplitterPosition = 219;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Gelisim_Muhasebe.Properties.Resources.KasaTanitimKarti;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem2.Text = "Yeni Kasa Ekle";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.yeniKasaEkleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::Gelisim_Muhasebe.Properties.Resources.edit;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem3.Text = "Düzenle";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::Gelisim_Muhasebe.Properties.Resources.KasaHareketKayitlari;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem4.Text = "Kasa Hareketleri";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            // frmKasaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 671);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmKasaListesi";
            this.ShowIcon = false;
            this.Text = "Kasa Listesi";
            this.Load += new System.EventHandler(this.frmKasaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaAdiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaAciklamaBox.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KasaKoduBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem2;
        private DevExpress.XtraGrid.Columns.GridColumn KasaAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn KASAADI;
        private DevExpress.XtraGrid.Columns.GridColumn KASAKODU;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton AraBtn;
        private DevExpress.XtraEditors.SimpleButton TemizleBtn;
        private DevExpress.XtraEditors.TextEdit KasaAdiBox;
        private DevExpress.XtraEditors.TextEdit KasaAciklamaBox;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit KasaKoduBox;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
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