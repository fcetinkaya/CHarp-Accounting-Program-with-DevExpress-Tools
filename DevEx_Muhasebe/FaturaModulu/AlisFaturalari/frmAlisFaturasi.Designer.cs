using Gelisim_Muhasebe;
using Gelisim_Muhasebe.FaturaModulu.DataSet;
using Gelisim_Muhasebe.FaturaModulu.DataSet.DataSet_StFtTableAdapters;

namespace Gelisim_Muhasebe.FaturaModulu.AlisFaturalari
{
    partial class frmAlisFaturasi
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
            this.SatisFtListesiSecBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cariKodBtn = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariIsim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtBelgeNumarasi = new DevExpress.XtraEditors.TextEdit();
            this.txtFtNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtVadeTarihi = new DevExpress.XtraEditors.DateEdit();
            this.comboFtTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.satisFtStokSecimTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_StFt = new Gelisim_Muhasebe.FaturaModulu.DataSet.DataSet_StFt();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokSecBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GridStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridIsk1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridIsk2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridBitti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.FtKapama_Grop = new DevExpress.XtraEditors.GroupControl();
            this.FtKapama_Label = new DevExpress.XtraEditors.LabelControl();
            this.FtKapama_EditBtn = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.OdemeturuCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtGenelToplam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtKDV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txttoplam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtIskonton = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtAraToplam = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.KapatBtn = new DevExpress.XtraEditors.SimpleButton();
            this.Kaydetbtn = new DevExpress.XtraEditors.SimpleButton();
            this.YazdirBtn = new DevExpress.XtraEditors.SimpleButton();
            this.FtSilBtn = new DevExpress.XtraEditors.SimpleButton();
            this.YeniBtn = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider3 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider4 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider5 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.satisFt_StokSecim_TestTableAdapter = new Gelisim_Muhasebe.FaturaModulu.DataSet.DataSet_StFtTableAdapters.SatisFt_StokSecim_TestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariKodBtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboFtTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisFtStokSecimTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_StFt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokSecBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FtKapama_Grop)).BeginInit();
            this.FtKapama_Grop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FtKapama_EditBtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeturuCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenelToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAraToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.SatisFtListesiSecBtn);
            this.groupControl1.Controls.Add(this.cariKodBtn);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtCariIsim);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtBelgeNumarasi);
            this.groupControl1.Controls.Add(this.txtFtNo);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.txtVadeTarihi);
            this.groupControl1.Controls.Add(this.comboFtTuru);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(944, 127);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cari Bilgileri";
            // 
            // SatisFtListesiSecBtn
            // 
            this.SatisFtListesiSecBtn.Image = global::Gelisim_Muhasebe.Properties.Resources.zoom_in;
            this.SatisFtListesiSecBtn.Location = new System.Drawing.Point(259, 28);
            this.SatisFtListesiSecBtn.Name = "SatisFtListesiSecBtn";
            this.SatisFtListesiSecBtn.Size = new System.Drawing.Size(25, 23);
            this.SatisFtListesiSecBtn.TabIndex = 7;
            this.SatisFtListesiSecBtn.Click += new System.EventHandler(this.SatisFtListesiSecBtn_Click);
            // 
            // cariKodBtn
            // 
            this.cariKodBtn.Location = new System.Drawing.Point(105, 56);
            this.cariKodBtn.Name = "cariKodBtn";
            this.cariKodBtn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cariKodBtn.Properties.ReadOnly = true;
            this.cariKodBtn.Size = new System.Drawing.Size(390, 20);
            this.cariKodBtn.TabIndex = 2;
            this.cariKodBtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cariKodBtn_ButtonClick);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Location = new System.Drawing.Point(713, 85);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(22, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Türü";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(713, 59);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Vade Tarihi";
            // 
            // txtCariIsim
            // 
            this.txtCariIsim.Location = new System.Drawing.Point(105, 82);
            this.txtCariIsim.Name = "txtCariIsim";
            this.txtCariIsim.Properties.ReadOnly = true;
            this.txtCariIsim.Size = new System.Drawing.Size(390, 20);
            this.txtCariIsim.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(713, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Tarih";
            // 
            // txtBelgeNumarasi
            // 
            this.txtBelgeNumarasi.Location = new System.Drawing.Point(379, 30);
            this.txtBelgeNumarasi.Name = "txtBelgeNumarasi";
            this.txtBelgeNumarasi.Size = new System.Drawing.Size(116, 20);
            this.txtBelgeNumarasi.TabIndex = 1;
            // 
            // txtFtNo
            // 
            this.txtFtNo.Location = new System.Drawing.Point(105, 30);
            this.txtFtNo.Name = "txtFtNo";
            this.txtFtNo.Size = new System.Drawing.Size(148, 20);
            this.txtFtNo.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Cari İsim";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Cari Kodu";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(300, 33);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(73, 13);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "Belge Numarası";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Fatura Numarası";
            // 
            // txtTarih
            // 
            this.txtTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(790, 30);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(149, 20);
            this.txtTarih.TabIndex = 4;
            // 
            // txtVadeTarihi
            // 
            this.txtVadeTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVadeTarihi.EditValue = null;
            this.txtVadeTarihi.Location = new System.Drawing.Point(790, 56);
            this.txtVadeTarihi.Name = "txtVadeTarihi";
            this.txtVadeTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVadeTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVadeTarihi.Properties.Mask.EditMask = "";
            this.txtVadeTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtVadeTarihi.Size = new System.Drawing.Size(149, 20);
            this.txtVadeTarihi.TabIndex = 5;
            // 
            // comboFtTuru
            // 
            this.comboFtTuru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFtTuru.EditValue = "Fatura Türü";
            this.comboFtTuru.Location = new System.Drawing.Point(790, 82);
            this.comboFtTuru.Name = "comboFtTuru";
            this.comboFtTuru.Properties.AutoComplete = false;
            this.comboFtTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboFtTuru.Properties.Items.AddRange(new object[] {
            "Açık Fatura",
            "Kapalı Fatura"});
            this.comboFtTuru.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboFtTuru.Size = new System.Drawing.Size(149, 20);
            this.comboFtTuru.TabIndex = 6;
            this.comboFtTuru.SelectedIndexChanged += new System.EventHandler(this.comboFtTuru_SelectedIndexChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.satisFtStokSecimTestBindingSource;
            this.gridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridControl1.Location = new System.Drawing.Point(0, 130);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.StokSecBtn});
            this.gridControl1.Size = new System.Drawing.Size(944, 273);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // satisFtStokSecimTestBindingSource
            // 
            this.satisFtStokSecimTestBindingSource.DataMember = "SatisFt_StokSecim_Test";
            this.satisFtStokSecimTestBindingSource.DataSource = this.dataSet_StFt;
            // 
            // dataSet_StFt
            // 
            this.dataSet_StFt.DataSetName = "DataSet_StFt";
            this.dataSet_StFt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GridBarkod,
            this.GridStokKodu,
            this.GridStokAdi,
            this.GridMiktar,
            this.GridBirim,
            this.GridFiyat,
            this.GridIsk1,
            this.GridIsk2,
            this.GridKdv,
            this.GridToplam,
            this.GridBitti});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Yeni Stok Kartı Eklemek İçin Tıklayın";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // GridBarkod
            // 
            this.GridBarkod.Caption = "BARKOD";
            this.GridBarkod.FieldName = "Barkod";
            this.GridBarkod.Name = "GridBarkod";
            this.GridBarkod.OptionsColumn.FixedWidth = true;
            this.GridBarkod.Visible = true;
            this.GridBarkod.VisibleIndex = 0;
            // 
            // GridStokKodu
            // 
            this.GridStokKodu.Caption = "STOK KODU";
            this.GridStokKodu.ColumnEdit = this.StokSecBtn;
            this.GridStokKodu.FieldName = "StokKodu";
            this.GridStokKodu.Name = "GridStokKodu";
            this.GridStokKodu.OptionsColumn.FixedWidth = true;
            this.GridStokKodu.OptionsColumn.ReadOnly = true;
            this.GridStokKodu.Visible = true;
            this.GridStokKodu.VisibleIndex = 1;
            // 
            // StokSecBtn
            // 
            this.StokSecBtn.AutoHeight = false;
            this.StokSecBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.StokSecBtn.Name = "StokSecBtn";
            this.StokSecBtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnStokSec_ButtonClick);
            // 
            // GridStokAdi
            // 
            this.GridStokAdi.Caption = "STOK ADI";
            this.GridStokAdi.ColumnEdit = this.StokSecBtn;
            this.GridStokAdi.FieldName = "StokAdi";
            this.GridStokAdi.Name = "GridStokAdi";
            this.GridStokAdi.OptionsColumn.ReadOnly = true;
            this.GridStokAdi.Visible = true;
            this.GridStokAdi.VisibleIndex = 2;
            this.GridStokAdi.Width = 209;
            // 
            // GridMiktar
            // 
            this.GridMiktar.Caption = "MİKTAR";
            this.GridMiktar.FieldName = "Miktar";
            this.GridMiktar.Name = "GridMiktar";
            this.GridMiktar.OptionsColumn.FixedWidth = true;
            this.GridMiktar.Visible = true;
            this.GridMiktar.VisibleIndex = 3;
            // 
            // GridBirim
            // 
            this.GridBirim.Caption = "BİRİM";
            this.GridBirim.FieldName = "Birim";
            this.GridBirim.Name = "GridBirim";
            this.GridBirim.OptionsColumn.FixedWidth = true;
            this.GridBirim.Visible = true;
            this.GridBirim.VisibleIndex = 4;
            // 
            // GridFiyat
            // 
            this.GridFiyat.Caption = "BİRİM FİYAT";
            this.GridFiyat.FieldName = "Fiyat";
            this.GridFiyat.Name = "GridFiyat";
            this.GridFiyat.OptionsColumn.FixedWidth = true;
            this.GridFiyat.Visible = true;
            this.GridFiyat.VisibleIndex = 5;
            // 
            // GridIsk1
            // 
            this.GridIsk1.Caption = "İSK1(%)";
            this.GridIsk1.FieldName = "Isk1";
            this.GridIsk1.Name = "GridIsk1";
            this.GridIsk1.OptionsColumn.FixedWidth = true;
            this.GridIsk1.Visible = true;
            this.GridIsk1.VisibleIndex = 6;
            // 
            // GridIsk2
            // 
            this.GridIsk2.Caption = "İSK2(%)";
            this.GridIsk2.FieldName = "Isk2";
            this.GridIsk2.Name = "GridIsk2";
            this.GridIsk2.OptionsColumn.FixedWidth = true;
            this.GridIsk2.Visible = true;
            this.GridIsk2.VisibleIndex = 7;
            // 
            // GridKdv
            // 
            this.GridKdv.Caption = "KDV(%)";
            this.GridKdv.FieldName = "Kdv";
            this.GridKdv.Name = "GridKdv";
            this.GridKdv.OptionsColumn.FixedWidth = true;
            this.GridKdv.OptionsColumn.ReadOnly = true;
            this.GridKdv.Visible = true;
            this.GridKdv.VisibleIndex = 8;
            // 
            // GridToplam
            // 
            this.GridToplam.Caption = "TOPLAM";
            this.GridToplam.DisplayFormat.FormatString = "N2";
            this.GridToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GridToplam.FieldName = "Toplam";
            this.GridToplam.Name = "GridToplam";
            this.GridToplam.OptionsColumn.FixedWidth = true;
            this.GridToplam.OptionsColumn.ReadOnly = true;
            this.GridToplam.Visible = true;
            this.GridToplam.VisibleIndex = 9;
            // 
            // GridBitti
            // 
            this.GridBitti.Caption = "IsActive";
            this.GridBitti.FieldName = "IsActive";
            this.GridBitti.Name = "GridBitti";
            this.GridBitti.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.GridBitti.Width = 20;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.FtKapama_Grop);
            this.panelControl1.Controls.Add(this.txtAciklama);
            this.panelControl1.Controls.Add(this.txtGenelToplam);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.txtKDV);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.txttoplam);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.txtIskonton);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.txtAraToplam);
            this.panelControl1.Controls.Add(this.labelControl16);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 403);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(944, 146);
            this.panelControl1.TabIndex = 2;
            // 
            // FtKapama_Grop
            // 
            this.FtKapama_Grop.Controls.Add(this.FtKapama_Label);
            this.FtKapama_Grop.Controls.Add(this.FtKapama_EditBtn);
            this.FtKapama_Grop.Controls.Add(this.labelControl13);
            this.FtKapama_Grop.Controls.Add(this.OdemeturuCombo);
            this.FtKapama_Grop.Location = new System.Drawing.Point(359, 13);
            this.FtKapama_Grop.Name = "FtKapama_Grop";
            this.FtKapama_Grop.Size = new System.Drawing.Size(308, 122);
            this.FtKapama_Grop.TabIndex = 6;
            this.FtKapama_Grop.Text = "Fatura Kapatma";
            this.FtKapama_Grop.Visible = false;
            // 
            // FtKapama_Label
            // 
            this.FtKapama_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FtKapama_Label.Location = new System.Drawing.Point(20, 66);
            this.FtKapama_Label.Name = "FtKapama_Label";
            this.FtKapama_Label.Size = new System.Drawing.Size(55, 13);
            this.FtKapama_Label.TabIndex = 1;
            this.FtKapama_Label.Text = "Kasa Seçimi";
            this.FtKapama_Label.Visible = false;
            // 
            // FtKapama_EditBtn
            // 
            this.FtKapama_EditBtn.Location = new System.Drawing.Point(97, 63);
            this.FtKapama_EditBtn.Name = "FtKapama_EditBtn";
            this.FtKapama_EditBtn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.FtKapama_EditBtn.Properties.ReadOnly = true;
            this.FtKapama_EditBtn.Size = new System.Drawing.Size(199, 20);
            this.FtKapama_EditBtn.TabIndex = 2;
            this.FtKapama_EditBtn.Visible = false;
            this.FtKapama_EditBtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.FtKapama_EditBtn_ButtonClick);
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Location = new System.Drawing.Point(20, 37);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(59, 13);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "Ödeme Türü";
            // 
            // OdemeturuCombo
            // 
            this.OdemeturuCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OdemeturuCombo.Location = new System.Drawing.Point(97, 34);
            this.OdemeturuCombo.Name = "OdemeturuCombo";
            this.OdemeturuCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OdemeturuCombo.Properties.Items.AddRange(new object[] {
            "Kasa",
            "Banka"});
            this.OdemeturuCombo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.OdemeturuCombo.Size = new System.Drawing.Size(199, 20);
            this.OdemeturuCombo.TabIndex = 4;
            this.OdemeturuCombo.SelectedIndexChanged += new System.EventHandler(this.OdemeturuCombo_SelectedIndexChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAciklama.Location = new System.Drawing.Point(111, 11);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(232, 124);
            this.txtAciklama.TabIndex = 0;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenelToplam.EditValue = 0D;
            this.txtGenelToplam.Location = new System.Drawing.Point(766, 111);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGenelToplam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtGenelToplam.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtGenelToplam.Properties.Mask.EditMask = "c";
            this.txtGenelToplam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGenelToplam.Size = new System.Drawing.Size(173, 20);
            this.txtGenelToplam.TabIndex = 5;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Location = new System.Drawing.Point(673, 114);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(64, 13);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "Genel Toplam";
            // 
            // txtKDV
            // 
            this.txtKDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKDV.EditValue = 0D;
            this.txtKDV.Location = new System.Drawing.Point(766, 85);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKDV.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtKDV.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtKDV.Properties.Mask.EditMask = "c";
            this.txtKDV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKDV.Size = new System.Drawing.Size(173, 20);
            this.txtKDV.TabIndex = 4;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Location = new System.Drawing.Point(673, 88);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(18, 13);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "Kdv";
            // 
            // txttoplam
            // 
            this.txttoplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttoplam.EditValue = 0D;
            this.txttoplam.Location = new System.Drawing.Point(766, 59);
            this.txttoplam.Name = "txttoplam";
            this.txttoplam.Properties.Appearance.Options.UseTextOptions = true;
            this.txttoplam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txttoplam.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txttoplam.Properties.Mask.EditMask = "c";
            this.txttoplam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txttoplam.Size = new System.Drawing.Size(173, 20);
            this.txttoplam.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Location = new System.Drawing.Point(673, 62);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(34, 13);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Toplam";
            // 
            // txtIskonton
            // 
            this.txtIskonton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIskonton.EditValue = 0D;
            this.txtIskonton.Location = new System.Drawing.Point(766, 33);
            this.txtIskonton.Name = "txtIskonton";
            this.txtIskonton.Properties.Appearance.Options.UseTextOptions = true;
            this.txtIskonton.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtIskonton.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtIskonton.Properties.Mask.EditMask = "c";
            this.txtIskonton.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIskonton.Size = new System.Drawing.Size(173, 20);
            this.txtIskonton.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Location = new System.Drawing.Point(673, 36);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "İskonto";
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAraToplam.EditValue = 0D;
            this.txtAraToplam.Location = new System.Drawing.Point(766, 7);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAraToplam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAraToplam.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtAraToplam.Properties.Mask.EditMask = "c";
            this.txtAraToplam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAraToplam.Size = new System.Drawing.Size(173, 20);
            this.txtAraToplam.TabIndex = 1;
            // 
            // labelControl16
            // 
            this.labelControl16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl16.Location = new System.Drawing.Point(12, 14);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(83, 13);
            this.labelControl16.TabIndex = 1;
            this.labelControl16.Text = "Fatura Açıklaması";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(673, 10);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Ara Toplam";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.KapatBtn);
            this.panelControl2.Controls.Add(this.Kaydetbtn);
            this.panelControl2.Controls.Add(this.YazdirBtn);
            this.panelControl2.Controls.Add(this.FtSilBtn);
            this.panelControl2.Controls.Add(this.YeniBtn);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 549);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(944, 66);
            this.panelControl2.TabIndex = 3;
            // 
            // KapatBtn
            // 
            this.KapatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KapatBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.KapatBtn.Appearance.Options.UseFont = true;
            this.KapatBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0006_Cross;
            this.KapatBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.KapatBtn.Location = new System.Drawing.Point(806, 7);
            this.KapatBtn.Name = "KapatBtn";
            this.KapatBtn.Size = new System.Drawing.Size(127, 49);
            this.KapatBtn.TabIndex = 2;
            this.KapatBtn.Text = "Kapat [Esc]";
            this.KapatBtn.Click += new System.EventHandler(this.KapatBtn_Click);
            // 
            // Kaydetbtn
            // 
            this.Kaydetbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Kaydetbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Kaydetbtn.Appearance.Options.UseFont = true;
            this.Kaydetbtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0007_Tick;
            this.Kaydetbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Kaydetbtn.Location = new System.Drawing.Point(540, 7);
            this.Kaydetbtn.Name = "Kaydetbtn";
            this.Kaydetbtn.Size = new System.Drawing.Size(127, 49);
            this.Kaydetbtn.TabIndex = 1;
            this.Kaydetbtn.Text = "Kaydet";
            this.Kaydetbtn.Click += new System.EventHandler(this.Kaydetbtn_Click);
            // 
            // YazdirBtn
            // 
            this.YazdirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YazdirBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.YazdirBtn.Appearance.Options.UseFont = true;
            this.YazdirBtn.Image = global::Gelisim_Muhasebe.Properties.Resources.Print;
            this.YazdirBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.YazdirBtn.Location = new System.Drawing.Point(274, 7);
            this.YazdirBtn.Name = "YazdirBtn";
            this.YazdirBtn.Size = new System.Drawing.Size(127, 49);
            this.YazdirBtn.TabIndex = 0;
            this.YazdirBtn.Text = "Yazdır";
            this.YazdirBtn.Click += new System.EventHandler(this.YazdirBtn_Click);
            // 
            // FtSilBtn
            // 
            this.FtSilBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FtSilBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.FtSilBtn.Appearance.Options.UseFont = true;
            this.FtSilBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0049_Trash;
            this.FtSilBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.FtSilBtn.Location = new System.Drawing.Point(673, 7);
            this.FtSilBtn.Name = "FtSilBtn";
            this.FtSilBtn.Size = new System.Drawing.Size(127, 49);
            this.FtSilBtn.TabIndex = 0;
            this.FtSilBtn.Text = "Sil";
            this.FtSilBtn.Click += new System.EventHandler(this.FtSilBtn_Click);
            // 
            // YeniBtn
            // 
            this.YeniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YeniBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.YeniBtn.Appearance.Options.UseFont = true;
            this.YeniBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0009_Add;
            this.YeniBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.YeniBtn.Location = new System.Drawing.Point(407, 7);
            this.YeniBtn.Name = "YeniBtn";
            this.YeniBtn.Size = new System.Drawing.Size(127, 49);
            this.YeniBtn.TabIndex = 0;
            this.YeniBtn.Text = "Yeni";
            this.YeniBtn.Click += new System.EventHandler(this.YeniBtn_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // dxErrorProvider2
            // 
            this.dxErrorProvider2.ContainerControl = this;
            // 
            // dxErrorProvider3
            // 
            this.dxErrorProvider3.ContainerControl = this;
            // 
            // dxErrorProvider4
            // 
            this.dxErrorProvider4.ContainerControl = this;
            // 
            // dxErrorProvider5
            // 
            this.dxErrorProvider5.ContainerControl = this;
            // 
            // satisFt_StokSecim_TestTableAdapter
            // 
            this.satisFt_StokSecim_TestTableAdapter.ClearBeforeFill = true;
            // 
            // frmAlisFaturasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 615);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmAlisFaturasi";
            this.ShowIcon = false;
            this.Text = "Alış Faturası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSatisFaturasi_FormClosed);
            this.Load += new System.EventHandler(this.frmSatisFaturasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariKodBtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboFtTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisFtStokSecimTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_StFt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokSecBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FtKapama_Grop)).EndInit();
            this.FtKapama_Grop.ResumeLayout(false);
            this.FtKapama_Grop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FtKapama_EditBtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdemeturuCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenelToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskonton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAraToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit cariKodBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFtNo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCariIsim;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.DateEdit txtVadeTarihi;
        private DevExpress.XtraEditors.ComboBoxEdit comboFtTuru;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GridBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn STOKKODU;
        private DevExpress.XtraGrid.Columns.GridColumn STOKADI;
        private DevExpress.XtraGrid.Columns.GridColumn GridMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn GridBirim;
        private DevExpress.XtraGrid.Columns.GridColumn GridFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn GridIsk1;
        private DevExpress.XtraGrid.Columns.GridColumn GridIsk2;
        private DevExpress.XtraGrid.Columns.GridColumn GridKdv;
        private DevExpress.XtraGrid.Columns.GridColumn GridToplam;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtGenelToplam;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtKDV;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txttoplam;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtIskonton;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtAraToplam;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton KapatBtn;
        private DevExpress.XtraEditors.SimpleButton Kaydetbtn;
        private DevExpress.XtraEditors.SimpleButton YeniBtn;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraGrid.Columns.GridColumn GridStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn GridStokAdi;
        private DevExpress.XtraEditors.TextEdit txtBelgeNumarasi;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider3;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider4;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider5;
        private DevExpress.XtraEditors.SimpleButton SatisFtListesiSecBtn;
        private DataSet_StFt dataSet_StFt;
        private System.Windows.Forms.BindingSource satisFtStokSecimTestBindingSource;
        private SatisFt_StokSecim_TestTableAdapter satisFt_StokSecim_TestTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn GridBitti;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit StokSecBtn;
        private DevExpress.XtraEditors.GroupControl FtKapama_Grop;
        private DevExpress.XtraEditors.LabelControl FtKapama_Label;
        private DevExpress.XtraEditors.ButtonEdit FtKapama_EditBtn;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.ComboBoxEdit OdemeturuCombo;
        private DevExpress.XtraEditors.SimpleButton FtSilBtn;
        private DevExpress.XtraEditors.SimpleButton YazdirBtn;
    }
}