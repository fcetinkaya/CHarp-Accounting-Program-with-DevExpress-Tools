namespace Gelisim_Muhasebe.BankaModulu
{
    partial class frmBankaListesiSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaListesiSec));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.AraBtn = new DevExpress.XtraEditors.SimpleButton();
            this.TemizleBtn = new DevExpress.XtraEditors.SimpleButton();
            this.HesapNoBox = new DevExpress.XtraEditors.TextEdit();
            this.HesapAdiBox = new DevExpress.XtraEditors.TextEdit();
            this.BankaAdiBox = new DevExpress.XtraEditors.TextEdit();
            this.BankaAciklamaBox = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKAKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BANKAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESAPADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESAPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUBE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ILGILI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankaAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navigationBarItem1 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem2 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HesapNoBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HesapAdiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankaAdiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankaAciklamaBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(889, 638);
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
            this.xtraTabControl1.Size = new System.Drawing.Size(219, 638);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.AraBtn);
            this.xtraTabPage1.Controls.Add(this.TemizleBtn);
            this.xtraTabPage1.Controls.Add(this.HesapNoBox);
            this.xtraTabPage1.Controls.Add(this.HesapAdiBox);
            this.xtraTabPage1.Controls.Add(this.BankaAdiBox);
            this.xtraTabPage1.Controls.Add(this.BankaAciklamaBox);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPage1.Size = new System.Drawing.Size(213, 610);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 120);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Hesap No";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Hesap Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Banka Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 175);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Açıklama";
            // 
            // AraBtn
            // 
            this.AraBtn.Image = ((System.Drawing.Image)(resources.GetObject("AraBtn.Image")));
            this.AraBtn.Location = new System.Drawing.Point(11, 241);
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.Size = new System.Drawing.Size(75, 23);
            this.AraBtn.TabIndex = 3;
            this.AraBtn.Text = "Ara";
            this.AraBtn.Click += new System.EventHandler(this.AraBtn_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.Image = ((System.Drawing.Image)(resources.GetObject("TemizleBtn.Image")));
            this.TemizleBtn.Location = new System.Drawing.Point(92, 241);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(75, 23);
            this.TemizleBtn.TabIndex = 4;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // HesapNoBox
            // 
            this.HesapNoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HesapNoBox.Location = new System.Drawing.Point(11, 139);
            this.HesapNoBox.Name = "HesapNoBox";
            this.HesapNoBox.Size = new System.Drawing.Size(199, 20);
            this.HesapNoBox.TabIndex = 1;
            // 
            // HesapAdiBox
            // 
            this.HesapAdiBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HesapAdiBox.Location = new System.Drawing.Point(11, 88);
            this.HesapAdiBox.Name = "HesapAdiBox";
            this.HesapAdiBox.Size = new System.Drawing.Size(199, 20);
            this.HesapAdiBox.TabIndex = 1;
            // 
            // BankaAdiBox
            // 
            this.BankaAdiBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankaAdiBox.Location = new System.Drawing.Point(11, 34);
            this.BankaAdiBox.Name = "BankaAdiBox";
            this.BankaAdiBox.Size = new System.Drawing.Size(199, 20);
            this.BankaAdiBox.TabIndex = 1;
            // 
            // BankaAciklamaBox
            // 
            this.BankaAciklamaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BankaAciklamaBox.Location = new System.Drawing.Point(11, 194);
            this.BankaAciklamaBox.Name = "BankaAciklamaBox";
            this.BankaAciklamaBox.Size = new System.Drawing.Size(199, 20);
            this.BankaAciklamaBox.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(665, 638);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // seçToolStripMenuItem
            // 
            this.seçToolStripMenuItem.Image = global::Gelisim_Muhasebe.Properties.Resources._0007_Tick;
            this.seçToolStripMenuItem.Name = "seçToolStripMenuItem";
            this.seçToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.seçToolStripMenuItem.Text = "Seç";
            this.seçToolStripMenuItem.Click += new System.EventHandler(this.seçToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BANKAKODU,
            this.BANKAADI,
            this.HESAPADI,
            this.HESAPNO,
            this.IBAN,
            this.SUBE,
            this.TELEFON,
            this.ILGILI,
            this.BankaAciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "BankaID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.AllowShowHide = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Width = 20;
            // 
            // BANKAKODU
            // 
            this.BANKAKODU.Caption = "BANKA KODU";
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
            this.HESAPNO.Width = 100;
            // 
            // IBAN
            // 
            this.IBAN.Caption = "IBAN";
            this.IBAN.FieldName = "Iban";
            this.IBAN.Name = "IBAN";
            this.IBAN.OptionsColumn.AllowEdit = false;
            this.IBAN.OptionsColumn.AllowFocus = false;
            this.IBAN.OptionsColumn.ReadOnly = true;
            this.IBAN.Visible = true;
            this.IBAN.VisibleIndex = 4;
            this.IBAN.Width = 175;
            // 
            // SUBE
            // 
            this.SUBE.Caption = "ŞUBE";
            this.SUBE.FieldName = "Sube";
            this.SUBE.Name = "SUBE";
            this.SUBE.OptionsColumn.AllowEdit = false;
            this.SUBE.OptionsColumn.AllowFocus = false;
            this.SUBE.OptionsColumn.ReadOnly = true;
            this.SUBE.Visible = true;
            this.SUBE.VisibleIndex = 5;
            this.SUBE.Width = 125;
            // 
            // TELEFON
            // 
            this.TELEFON.Caption = "TELEFON";
            this.TELEFON.FieldName = "Tlf";
            this.TELEFON.Name = "TELEFON";
            this.TELEFON.OptionsColumn.AllowEdit = false;
            this.TELEFON.OptionsColumn.AllowFocus = false;
            this.TELEFON.OptionsColumn.ReadOnly = true;
            this.TELEFON.Visible = true;
            this.TELEFON.VisibleIndex = 6;
            this.TELEFON.Width = 125;
            // 
            // ILGILI
            // 
            this.ILGILI.Caption = "İLGİLİ";
            this.ILGILI.FieldName = "Ilgili";
            this.ILGILI.Name = "ILGILI";
            this.ILGILI.OptionsColumn.AllowEdit = false;
            this.ILGILI.OptionsColumn.AllowFocus = false;
            this.ILGILI.OptionsColumn.ReadOnly = true;
            this.ILGILI.Visible = true;
            this.ILGILI.VisibleIndex = 7;
            this.ILGILI.Width = 125;
            // 
            // BankaAciklama
            // 
            this.BankaAciklama.Caption = "BANKA AÇIKLAMA";
            this.BankaAciklama.FieldName = "BankaAciklama";
            this.BankaAciklama.Name = "BankaAciklama";
            this.BankaAciklama.OptionsColumn.AllowEdit = false;
            this.BankaAciklama.OptionsColumn.AllowFocus = false;
            this.BankaAciklama.OptionsColumn.ReadOnly = true;
            this.BankaAciklama.Visible = true;
            this.BankaAciklama.VisibleIndex = 8;
            this.BankaAciklama.Width = 200;
            // 
            // navigationBarItem1
            // 
            this.navigationBarItem1.Name = "navigationBarItem1";
            this.navigationBarItem1.Text = "Item1";
            // 
            // navigationBarItem2
            // 
            this.navigationBarItem2.Name = "navigationBarItem2";
            this.navigationBarItem2.Text = "Item2";
            // 
            // frmBankaListesiSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 638);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmBankaListesiSec";
            this.Text = "Banka Listesi";
            this.Load += new System.EventHandler(this.frmBankaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HesapNoBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HesapAdiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankaAdiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankaAciklamaBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton AraBtn;
        private DevExpress.XtraEditors.SimpleButton TemizleBtn;
        private DevExpress.XtraEditors.TextEdit BankaAdiBox;
        private DevExpress.XtraEditors.TextEdit BankaAciklamaBox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BANKAKODU;
        private DevExpress.XtraGrid.Columns.GridColumn BANKAADI;
        private DevExpress.XtraGrid.Columns.GridColumn BankaAciklama;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem2;
        private DevExpress.XtraGrid.Columns.GridColumn HESAPADI;
        private DevExpress.XtraGrid.Columns.GridColumn HESAPNO;
        private DevExpress.XtraGrid.Columns.GridColumn IBAN;
        private DevExpress.XtraGrid.Columns.GridColumn SUBE;
        private DevExpress.XtraGrid.Columns.GridColumn TELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn ILGILI;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit HesapNoBox;
        private DevExpress.XtraEditors.TextEdit HesapAdiBox;
        private System.Windows.Forms.ToolStripMenuItem seçToolStripMenuItem;
    }
}