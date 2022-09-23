namespace Gelisim_Muhasebe.StokModulu
{
    partial class frmStokKod1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokKod1));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.KaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.YeniBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.KodBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Aciklamabox = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Kod1ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kod1Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.SagMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KodBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aciklamabox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SagMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.KapatBtn);
            this.panelControl2.Controls.Add(this.KaydetBtn);
            this.panelControl2.Controls.Add(this.YeniBtn);
            this.panelControl2.Location = new System.Drawing.Point(2, 77);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(550, 66);
            this.panelControl2.TabIndex = 2;
            // 
            // KapatBtn
            // 
            this.KapatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KapatBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.KapatBtn.Appearance.Options.UseFont = true;
            this.KapatBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0006_Cross;
            this.KapatBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.KapatBtn.Location = new System.Drawing.Point(412, 7);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(127, 49);
            this.KapatBtn.TabIndex = 3;
            this.KapatBtn.Text = "Kapat [Esc]";
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KaydetBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.KaydetBtn.Appearance.Options.UseFont = true;
            this.KaydetBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0007_Tick;
            this.KaydetBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.KaydetBtn.Location = new System.Drawing.Point(279, 7);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(127, 49);
            this.KaydetBtn.TabIndex = 1;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // YeniBtn
            // 
            this.YeniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YeniBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.YeniBtn.Appearance.Options.UseFont = true;
            this.YeniBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0009_Add;
            this.YeniBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.YeniBtn.Location = new System.Drawing.Point(146, 7);
            this.YeniBtn.Name = "YeniBtn";
            this.YeniBtn.Size = new System.Drawing.Size(127, 49);
            this.YeniBtn.TabIndex = 0;
            this.YeniBtn.Text = "Yeni";
            this.YeniBtn.Click += new System.EventHandler(this.YeniBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Kod 1";
            // 
            // KodBox
            // 
            this.KodBox.Location = new System.Drawing.Point(109, 9);
            this.KodBox.Name = "KodBox";
            this.KodBox.Size = new System.Drawing.Size(422, 20);
            this.KodBox.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Açıklama";
            // 
            // Aciklamabox
            // 
            this.Aciklamabox.Location = new System.Drawing.Point(109, 40);
            this.Aciklamabox.Name = "Aciklamabox";
            this.Aciklamabox.Size = new System.Drawing.Size(422, 20);
            this.Aciklamabox.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(0, 149);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(544, 483);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Kod1ID,
            this.KOD1,
            this.Kod1Aciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Kod1ID
            // 
            this.Kod1ID.Caption = "ID";
            this.Kod1ID.FieldName = "Kod1ID";
            this.Kod1ID.Name = "Kod1ID";
            this.Kod1ID.OptionsColumn.AllowEdit = false;
            this.Kod1ID.OptionsColumn.AllowFocus = false;
            this.Kod1ID.OptionsColumn.AllowShowHide = false;
            this.Kod1ID.OptionsColumn.FixedWidth = true;
            this.Kod1ID.OptionsColumn.ReadOnly = true;
            // 
            // KOD1
            // 
            this.KOD1.Caption = "Kod1";
            this.KOD1.FieldName = "Kod1";
            this.KOD1.Name = "KOD1";
            this.KOD1.OptionsColumn.AllowEdit = false;
            this.KOD1.OptionsColumn.AllowFocus = false;
            this.KOD1.OptionsColumn.FixedWidth = true;
            this.KOD1.OptionsColumn.ReadOnly = true;
            this.KOD1.Visible = true;
            this.KOD1.VisibleIndex = 0;
            // 
            // Kod1Aciklama
            // 
            this.Kod1Aciklama.Caption = "Açıklama";
            this.Kod1Aciklama.FieldName = "Kod1Aciklama";
            this.Kod1Aciklama.Name = "Kod1Aciklama";
            this.Kod1Aciklama.OptionsColumn.AllowEdit = false;
            this.Kod1Aciklama.OptionsColumn.AllowFocus = false;
            this.Kod1Aciklama.OptionsColumn.ReadOnly = true;
            this.Kod1Aciklama.Visible = true;
            this.Kod1Aciklama.VisibleIndex = 1;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(544, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 632);
            this.barDockControlBottom.Size = new System.Drawing.Size(544, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 632);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(544, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 632);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Düzenle";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageIndex = 0;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sil";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageIndex = 1;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // SagMenu
            // 
            this.SagMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.SagMenu.Manager = this.barManager1;
            this.SagMenu.Name = "SagMenu";
            // 
            // frmStokKod1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 632);
            this.Controls.Add(this.Aciklamabox);
            this.Controls.Add(this.KodBox);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokKod1";
            this.ShowIcon = false;
            this.Text = "Stok Kodu 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStokKod1_FormClosed);
            this.Load += new System.EventHandler(this.frmStokKod1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStokKod1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KodBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aciklamabox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SagMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton KapatBtn;
        private DevExpress.XtraEditors.SimpleButton KaydetBtn;
        private DevExpress.XtraEditors.SimpleButton YeniBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit KodBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Aciklamabox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Kod1ID;
        private DevExpress.XtraGrid.Columns.GridColumn KOD1;
        private DevExpress.XtraGrid.Columns.GridColumn Kod1Aciklama;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.PopupMenu SagMenu;
    }
}