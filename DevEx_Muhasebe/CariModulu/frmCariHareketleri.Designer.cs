namespace Gelisim_Muhasebe.CariModulu
{
    partial class frmCariHareketleri
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
            this.btnCariSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtCariIsmi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
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
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BORC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ALACAK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VADETARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtBorc = new DevExpress.XtraEditors.TextEdit();
            this.txtAlacak = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
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
            this.groupControl1.Controls.Add(this.btnCariSec);
            this.groupControl1.Controls.Add(this.txtCariIsmi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCariKodu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(891, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Cari Bilgileri";
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
            // txtCariIsmi
            // 
            this.txtCariIsmi.Location = new System.Drawing.Point(93, 55);
            this.txtCariIsmi.Name = "txtCariIsmi";
            this.txtCariIsmi.Properties.ReadOnly = true;
            this.txtCariIsmi.Size = new System.Drawing.Size(690, 20);
            this.txtCariIsmi.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Cari İsmi";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(93, 29);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Properties.ReadOnly = true;
            this.txtCariKodu.Size = new System.Drawing.Size(359, 20);
            this.txtCariKodu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cari Kodu";
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
            this.gridControl1.Location = new System.Drawing.Point(0, 77);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(891, 600);
            this.gridControl1.TabIndex = 0;
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
            this.ID,
            this.CARIKODU,
            this.FATURANO,
            this.BELGENO,
            this.TARIH,
            this.BORC,
            this.ALACAK,
            this.VADETARIHI,
            this.TIPI,
            this.BAKIYE,
            this.ACIKLAMA});
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
            this.CARIKODU.Width = 200;
            // 
            // FATURANO
            // 
            this.FATURANO.Caption = "FATURANO";
            this.FATURANO.FieldName = "FaturaNo";
            this.FATURANO.Name = "FATURANO";
            this.FATURANO.OptionsColumn.AllowEdit = false;
            this.FATURANO.OptionsColumn.AllowFocus = false;
            this.FATURANO.OptionsColumn.FixedWidth = true;
            this.FATURANO.OptionsColumn.ReadOnly = true;
            this.FATURANO.Visible = true;
            this.FATURANO.VisibleIndex = 1;
            this.FATURANO.Width = 125;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGENO";
            this.BELGENO.FieldName = "BelgeNo";
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.OptionsColumn.ReadOnly = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 2;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "Tarih";
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.OptionsColumn.ReadOnly = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 3;
            // 
            // BORC
            // 
            this.BORC.Caption = "BORÇ";
            this.BORC.DisplayFormat.FormatString = "N2";
            this.BORC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BORC.FieldName = "Borc";
            this.BORC.Name = "BORC";
            this.BORC.OptionsColumn.AllowEdit = false;
            this.BORC.OptionsColumn.AllowFocus = false;
            this.BORC.OptionsColumn.FixedWidth = true;
            this.BORC.OptionsColumn.ReadOnly = true;
            this.BORC.Visible = true;
            this.BORC.VisibleIndex = 5;
            this.BORC.Width = 90;
            // 
            // ALACAK
            // 
            this.ALACAK.Caption = "ALACAK";
            this.ALACAK.DisplayFormat.FormatString = "N2";
            this.ALACAK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ALACAK.FieldName = "Alacak";
            this.ALACAK.Name = "ALACAK";
            this.ALACAK.OptionsColumn.AllowEdit = false;
            this.ALACAK.OptionsColumn.AllowFocus = false;
            this.ALACAK.OptionsColumn.FixedWidth = true;
            this.ALACAK.OptionsColumn.ReadOnly = true;
            this.ALACAK.Visible = true;
            this.ALACAK.VisibleIndex = 6;
            this.ALACAK.Width = 90;
            // 
            // VADETARIHI
            // 
            this.VADETARIHI.Caption = "VADE TARİHİ";
            this.VADETARIHI.FieldName = "VadeTarihi";
            this.VADETARIHI.Name = "VADETARIHI";
            this.VADETARIHI.OptionsColumn.AllowEdit = false;
            this.VADETARIHI.OptionsColumn.AllowFocus = false;
            this.VADETARIHI.OptionsColumn.FixedWidth = true;
            this.VADETARIHI.OptionsColumn.ReadOnly = true;
            this.VADETARIHI.Visible = true;
            this.VADETARIHI.VisibleIndex = 4;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "TİPİ";
            this.TIPI.FieldName = "Tipi";
            this.TIPI.Name = "TIPI";
            this.TIPI.OptionsColumn.AllowEdit = false;
            this.TIPI.OptionsColumn.AllowFocus = false;
            this.TIPI.OptionsColumn.FixedWidth = true;
            this.TIPI.OptionsColumn.ReadOnly = true;
            this.TIPI.Visible = true;
            this.TIPI.VisibleIndex = 8;
            this.TIPI.Width = 120;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKİYE";
            this.BAKIYE.DisplayFormat.FormatString = "N2";
            this.BAKIYE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BAKIYE.FieldName = "Bakiye";
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.OptionsColumn.AllowEdit = false;
            this.BAKIYE.OptionsColumn.AllowFocus = false;
            this.BAKIYE.OptionsColumn.FixedWidth = true;
            this.BAKIYE.OptionsColumn.ReadOnly = true;
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 7;
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
            this.ACIKLAMA.VisibleIndex = 9;
            this.ACIKLAMA.Width = 250;
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
            this.panelControl1.Location = new System.Drawing.Point(0, 677);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(891, 50);
            this.panelControl1.TabIndex = 2;
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
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(272, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Toplam Borç";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Toplam Alacak";
            // 
            // frmCariHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 723);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCariHareketleri";
            this.ShowIcon = false;
            this.Text = "Cari Hareket Kayıtları";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCariHareketleri_FormClosed);
            this.Load += new System.EventHandler(this.frmCariHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnCariSec;
        private DevExpress.XtraEditors.TextEdit txtCariIsmi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCariKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn FATURANO;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn BORC;
        private DevExpress.XtraGrid.Columns.GridColumn ALACAK;
        private DevExpress.XtraGrid.Columns.GridColumn VADETARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.TextEdit txtBorc;
        private DevExpress.XtraEditors.TextEdit txtAlacak;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
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
    }
}