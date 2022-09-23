using Gelisim_Muhasebe.KullaniciModulu;

namespace Gelisim_Muhasebe.KullaniciModulu
{
    partial class frmKullaniciYetkileri
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
            base.Dispose(disposing);}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciYetkileri));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKullaniciSec = new DevExpress.XtraEditors.SimpleButton();
            this.SoyadiBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.AdiBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.muhasebeTBLKullanicilarYetkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsYetkiler = new Gelisim_Muhasebe.KullaniciModulu.dsYetkiler();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYetkiID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIzin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.muhasebe_TBL_Kullanicilar_YetkiTableAdapter = new Gelisim_Muhasebe.KullaniciModulu.dsYetkilerTableAdapters.Muhasebe_TBL_Kullanicilar_YetkiTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barKullaniciSecBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barKaydetBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barYetkileriVer = new DevExpress.XtraBars.BarButtonItem();
            this.barYetkileriKaldir = new DevExpress.XtraBars.BarButtonItem();
            this.barKapatbtn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoyadiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeTBLKullanicilarYetkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYetkiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKullaniciSec);
            this.groupControl1.Controls.Add(this.SoyadiBox);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.AdiBox);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 31);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(657, 100);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kullanıcı Bilgileri";
            // 
            // btnKullaniciSec
            // 
            this.btnKullaniciSec.Image = global::Gelisim_Muhasebe.Properties.Resources.zoom_in;
            this.btnKullaniciSec.Location = new System.Drawing.Point(458, 27);
            this.btnKullaniciSec.Name = "btnKullaniciSec";
            this.btnKullaniciSec.Size = new System.Drawing.Size(31, 23);
            this.btnKullaniciSec.TabIndex = 1;
            this.btnKullaniciSec.Click += new System.EventHandler(this.btnKullaniciSec_Click);
            // 
            // SoyadiBox
            // 
            this.SoyadiBox.Enabled = false;
            this.SoyadiBox.Location = new System.Drawing.Point(93, 55);
            this.SoyadiBox.Name = "SoyadiBox";
            this.SoyadiBox.Size = new System.Drawing.Size(396, 20);
            this.SoyadiBox.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Soyadı";
            // 
            // AdiBox
            // 
            this.AdiBox.Enabled = false;
            this.AdiBox.Location = new System.Drawing.Point(93, 29);
            this.AdiBox.Name = "AdiBox";
            this.AdiBox.Size = new System.Drawing.Size(359, 20);
            this.AdiBox.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adı";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.muhasebeTBLKullanicilarYetkiBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 131);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(657, 308);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // muhasebeTBLKullanicilarYetkiBindingSource
            // 
            this.muhasebeTBLKullanicilarYetkiBindingSource.DataMember = "Muhasebe_TBL_Kullanicilar_Yetki";
            this.muhasebeTBLKullanicilarYetkiBindingSource.DataSource = this.dsYetkiler;
            // 
            // dsYetkiler
            // 
            this.dsYetkiler.DataSetName = "dsYetkiler";
            this.dsYetkiler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // muhasebe_TBL_Kullanicilar_YetkiTableAdapter
            // 
            this.muhasebe_TBL_Kullanicilar_YetkiTableAdapter.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYetkiID,
            this.colModul,
            this.colYetki,
            this.colAciklama,
            this.colIzin});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colYetkiID
            // 
            this.colYetkiID.FieldName = "YetkiID";
            this.colYetkiID.Name = "colYetkiID";
            this.colYetkiID.OptionsColumn.AllowShowHide = false;
            // 
            // colModul
            // 
            this.colModul.FieldName = "Modul";
            this.colModul.Name = "colModul";
            this.colModul.OptionsColumn.AllowEdit = false;
            this.colModul.OptionsColumn.AllowFocus = false;
            this.colModul.OptionsColumn.FixedWidth = true;
            this.colModul.Visible = true;
            this.colModul.VisibleIndex = 1;
            this.colModul.Width = 120;
            // 
            // colYetki
            // 
            this.colYetki.FieldName = "Yetki";
            this.colYetki.Name = "colYetki";
            this.colYetki.OptionsColumn.AllowEdit = false;
            this.colYetki.OptionsColumn.AllowFocus = false;
            this.colYetki.OptionsColumn.FixedWidth = true;
            this.colYetki.Visible = true;
            this.colYetki.VisibleIndex = 2;
            this.colYetki.Width = 200;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.AllowFocus = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 3;
            this.colAciklama.Width = 340;
            // 
            // colIzin
            // 
            this.colIzin.FieldName = "Izin";
            this.colIzin.Name = "colIzin";
            this.colIzin.OptionsColumn.FixedWidth = true;
            this.colIzin.Visible = true;
            this.colIzin.VisibleIndex = 0;
            this.colIzin.Width = 50;
           
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barKullaniciSecBtn,
            this.barKaydetBtn,
            this.barKapatbtn,
            this.barYetkileriVer,
            this.barYetkileriKaldir});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barKullaniciSecBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barKaydetBtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barYetkileriVer, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barYetkileriKaldir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barKapatbtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Tools";
            // 
            // barKullaniciSecBtn
            // 
            this.barKullaniciSecBtn.Caption = "Kullanıcı Seç";
            this.barKullaniciSecBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barKullaniciSecBtn.Glyph")));
            this.barKullaniciSecBtn.Id = 0;
            this.barKullaniciSecBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barKullaniciSecBtn.LargeGlyph")));
            this.barKullaniciSecBtn.Name = "barKullaniciSecBtn";
            this.barKullaniciSecBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKullaniciSecBtn_ItemClick);
            // 
            // barKaydetBtn
            // 
            this.barKaydetBtn.Caption = "Yetkileri Kaydet";
            this.barKaydetBtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barKaydetBtn.Glyph")));
            this.barKaydetBtn.Id = 1;
            this.barKaydetBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barKaydetBtn.LargeGlyph")));
            this.barKaydetBtn.Name = "barKaydetBtn";
            this.barKaydetBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKaydetBtn_ItemClick);
            // 
            // barYetkileriVer
            // 
            this.barYetkileriVer.Caption = "Tüm Yetkileri Ver";
            this.barYetkileriVer.Glyph = ((System.Drawing.Image)(resources.GetObject("barYetkileriVer.Glyph")));
            this.barYetkileriVer.Id = 3;
            this.barYetkileriVer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barYetkileriVer.LargeGlyph")));
            this.barYetkileriVer.Name = "barYetkileriVer";
            this.barYetkileriVer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barYetkileriVer_ItemClick);
            // 
            // barYetkileriKaldir
            // 
            this.barYetkileriKaldir.Caption = "Tüm Yetkileri Kaldır";
            this.barYetkileriKaldir.Glyph = ((System.Drawing.Image)(resources.GetObject("barYetkileriKaldir.Glyph")));
            this.barYetkileriKaldir.Id = 4;
            this.barYetkileriKaldir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barYetkileriKaldir.LargeGlyph")));
            this.barYetkileriKaldir.Name = "barYetkileriKaldir";
            this.barYetkileriKaldir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barYetkileriKaldir_ItemClick);
            // 
            // barKapatbtn
            // 
            this.barKapatbtn.Caption = "Kapat";
            this.barKapatbtn.Glyph = ((System.Drawing.Image)(resources.GetObject("barKapatbtn.Glyph")));
            this.barKapatbtn.Id = 2;
            this.barKapatbtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barKapatbtn.LargeGlyph")));
            this.barKapatbtn.Name = "barKapatbtn";
            this.barKapatbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKapatbtn_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(657, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 439);
            this.barDockControlBottom.Size = new System.Drawing.Size(657, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 408);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(657, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 408);
            // 
            // frmKullaniciYetkileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 462);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKullaniciYetkileri";
            this.Text = "Kullanıcı İzinleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKullaniciYetkileri_FormClosed);
            this.Load += new System.EventHandler(this.frmKullaniciYetkileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoyadiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muhasebeTBLKullanicilarYetkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYetkiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciSec;
        private DevExpress.XtraEditors.TextEdit SoyadiBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit AdiBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsYetkiler dsYetkiler;
        private System.Windows.Forms.BindingSource muhasebeTBLKullanicilarYetkiBindingSource;
        private Gelisim_Muhasebe.KullaniciModulu.dsYetkilerTableAdapters.Muhasebe_TBL_Kullanicilar_YetkiTableAdapter muhasebe_TBL_Kullanicilar_YetkiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiID;
        private DevExpress.XtraGrid.Columns.GridColumn colModul;
        private DevExpress.XtraGrid.Columns.GridColumn colYetki;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colIzin;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barKullaniciSecBtn;
        private DevExpress.XtraBars.BarButtonItem barKaydetBtn;
        private DevExpress.XtraBars.BarButtonItem barKapatbtn;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barYetkileriVer;
        private DevExpress.XtraBars.BarButtonItem barYetkileriKaldir;
    }
}