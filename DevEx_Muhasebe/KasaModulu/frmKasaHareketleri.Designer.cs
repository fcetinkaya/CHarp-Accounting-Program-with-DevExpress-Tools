namespace Gelisim_Muhasebe.Kasa
{
    partial class frmKasaHareketleri
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
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtBorc = new DevExpress.XtraEditors.TextEdit();
            this.txtAlacak = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KASAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FISNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnKasaSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtKasaIsmi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBorc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlacak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaIsmi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.panelControl1.Location = new System.Drawing.Point(0, 681);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(802, 50);
            this.panelControl1.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(272, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Toplam Borç";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KASAID,
            this.FISNO,
            this.TARIH,
            this.GIRIS,
            this.CIKIS,
            this.CARIKODU,
            this.CARIADI,
            this.TIPI});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // KASAID
            // 
            this.KASAID.Caption = "KASAID";
            this.KASAID.FieldName = "KasaID";
            this.KASAID.Name = "KASAID";
            this.KASAID.OptionsColumn.AllowEdit = false;
            this.KASAID.OptionsColumn.AllowFocus = false;
            this.KASAID.OptionsColumn.AllowShowHide = false;
            this.KASAID.OptionsColumn.FixedWidth = true;
            this.KASAID.OptionsColumn.ReadOnly = true;
            // 
            // FISNO
            // 
            this.FISNO.Caption = "FİŞ NO";
            this.FISNO.FieldName = "FisNo";
            this.FISNO.Name = "FISNO";
            this.FISNO.OptionsColumn.AllowEdit = false;
            this.FISNO.OptionsColumn.AllowFocus = false;
            this.FISNO.OptionsColumn.AllowShowHide = false;
            this.FISNO.OptionsColumn.FixedWidth = true;
            this.FISNO.OptionsColumn.ReadOnly = true;
            this.FISNO.Visible = true;
            this.FISNO.VisibleIndex = 0;
            this.FISNO.Width = 101;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "Tarih";
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.AllowShowHide = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.OptionsColumn.ReadOnly = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 1;
            this.TARIH.Width = 142;
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ TUTARI";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.AllowShowHide = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.OptionsColumn.ReadOnly = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 2;
            this.GIRIS.Width = 127;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ TUTARI";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.AllowShowHide = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.OptionsColumn.ReadOnly = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 3;
            this.CIKIS.Width = 128;
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARİ KODU";
            this.CARIKODU.FieldName = "CariKodu";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.AllowShowHide = false;
            this.CARIKODU.OptionsColumn.FixedWidth = true;
            this.CARIKODU.OptionsColumn.ReadOnly = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 4;
            this.CARIKODU.Width = 164;
            // 
            // CARIADI
            // 
            this.CARIADI.Caption = "CARİ ADI";
            this.CARIADI.FieldName = "CariIsim";
            this.CARIADI.Name = "CARIADI";
            this.CARIADI.OptionsColumn.AllowEdit = false;
            this.CARIADI.OptionsColumn.AllowFocus = false;
            this.CARIADI.OptionsColumn.AllowShowHide = false;
            this.CARIADI.OptionsColumn.FixedWidth = true;
            this.CARIADI.OptionsColumn.ReadOnly = true;
            this.CARIADI.Visible = true;
            this.CARIADI.VisibleIndex = 5;
            this.CARIADI.Width = 208;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "TİPİ";
            this.TIPI.FieldName = "Tipi";
            this.TIPI.Name = "TIPI";
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
            this.gridControl1.Location = new System.Drawing.Point(0, 81);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(802, 600);
            this.gridControl1.TabIndex = 3;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 180);
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
            // btnKasaSec
            // 
            this.btnKasaSec.Image = global::Gelisim_Muhasebe.Properties.Resources.zoom_in;
            this.btnKasaSec.Location = new System.Drawing.Point(458, 27);
            this.btnKasaSec.Name = "btnKasaSec";
            this.btnKasaSec.Size = new System.Drawing.Size(31, 23);
            this.btnKasaSec.TabIndex = 1;
            this.btnKasaSec.Click += new System.EventHandler(this.btnKasaSec_Click);
            // 
            // txtKasaIsmi
            // 
            this.txtKasaIsmi.Location = new System.Drawing.Point(93, 55);
            this.txtKasaIsmi.Name = "txtKasaIsmi";
            this.txtKasaIsmi.Size = new System.Drawing.Size(690, 20);
            this.txtKasaIsmi.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kasa İsmi";
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(93, 29);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Size = new System.Drawing.Size(359, 20);
            this.txtKasaKodu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKasaSec);
            this.groupControl1.Controls.Add(this.txtKasaIsmi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(802, 100);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Kasa Bilgileri";
            // 
            // frmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 729);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKasaHareketleri";
            this.Text = "Kasa Hareket Kayıtları";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKasaHareketleri_FormClosed);
            this.Load += new System.EventHandler(this.frmKasaHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBorc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlacak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaIsmi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.TextEdit txtBorc;
        private DevExpress.XtraEditors.TextEdit txtAlacak;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnKasaSec;
        private DevExpress.XtraEditors.TextEdit txtKasaIsmi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKasaKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn KASAID;
        private DevExpress.XtraGrid.Columns.GridColumn FISNO;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIADI;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
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