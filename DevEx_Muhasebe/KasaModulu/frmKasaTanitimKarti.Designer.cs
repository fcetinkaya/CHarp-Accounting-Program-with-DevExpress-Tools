namespace Gelisim_Muhasebe.Kasa
{
    partial class frmKasaTanitimKarti
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.KasaKoduBtn = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.KasaAdiBox = new DevExpress.XtraEditors.TextEdit();
            this.KasaAciklamaBox = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.Kaptbtn = new DevExpress.XtraEditors.SimpleButton();
            this.KaydetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SilBtn = new DevExpress.XtraEditors.SimpleButton();
            this.YeniBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorProvider3 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KasaKoduBtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaAdiBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaAciklamaBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 100);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu";
            // 
            // KasaKoduBtn
            // 
            this.KasaKoduBtn.Location = new System.Drawing.Point(93, 97);
            this.KasaKoduBtn.Name = "KasaKoduBtn";
            this.KasaKoduBtn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.KasaKoduBtn.Size = new System.Drawing.Size(257, 20);
            this.KasaKoduBtn.TabIndex = 0;
            this.KasaKoduBtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.KasaKoduBtn_ButtonClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 129);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kasa Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 159);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Açıklama";
            // 
            // KasaAdiBox
            // 
            this.KasaAdiBox.Location = new System.Drawing.Point(93, 126);
            this.KasaAdiBox.Name = "KasaAdiBox";
            this.KasaAdiBox.Size = new System.Drawing.Size(257, 20);
            this.KasaAdiBox.TabIndex = 1;
            // 
            // KasaAciklamaBox
            // 
            this.KasaAciklamaBox.Location = new System.Drawing.Point(93, 156);
            this.KasaAciklamaBox.Name = "KasaAciklamaBox";
            this.KasaAciklamaBox.Size = new System.Drawing.Size(440, 159);
            this.KasaAciklamaBox.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 321);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(521, 152);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Kasa Bakiyesi";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(517, 124);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GIRIS,
            this.CIKIS,
            this.BAKIYE,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "TOPLAM GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.OptionsColumn.ReadOnly = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 0;
            this.GIRIS.Width = 150;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "TOPLAM ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.OptionsColumn.ReadOnly = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 1;
            this.CIKIS.Width = 150;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKİYE";
            this.BAKIYE.FieldName = "BAKIYE";
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.OptionsColumn.AllowEdit = false;
            this.BAKIYE.OptionsColumn.AllowFocus = false;
            this.BAKIYE.OptionsColumn.FixedWidth = true;
            this.BAKIYE.OptionsColumn.ReadOnly = true;
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 2;
            this.BAKIYE.Width = 150;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 49;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.Kaptbtn);
            this.panelControl2.Controls.Add(this.KaydetBtn);
            this.panelControl2.Controls.Add(this.SilBtn);
            this.panelControl2.Controls.Add(this.YeniBtn);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 485);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(539, 66);
            this.panelControl2.TabIndex = 4;
            // 
            // Kaptbtn
            // 
            this.Kaptbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Kaptbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Kaptbtn.Appearance.Options.UseFont = true;
            this.Kaptbtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0006_Cross;
            this.Kaptbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.Kaptbtn.Location = new System.Drawing.Point(407, 5);
            this.Kaptbtn.Name = "Kaptbtn";
            this.Kaptbtn.Size = new System.Drawing.Size(127, 49);
            this.Kaptbtn.TabIndex = 3;
            this.Kaptbtn.Text = "Kapat [Esc]";
            this.Kaptbtn.Click += new System.EventHandler(this.Kaptbtn_Click);
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KaydetBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.KaydetBtn.Appearance.Options.UseFont = true;
            this.KaydetBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0007_Tick;
            this.KaydetBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.KaydetBtn.Location = new System.Drawing.Point(141, 5);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(127, 49);
            this.KaydetBtn.TabIndex = 1;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SilBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SilBtn.Appearance.Options.UseFont = true;
            this.SilBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0049_Trash;
            this.SilBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.SilBtn.Location = new System.Drawing.Point(274, 5);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(127, 49);
            this.SilBtn.TabIndex = 2;
            this.SilBtn.Text = "Sil";
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // YeniBtn
            // 
            this.YeniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YeniBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.YeniBtn.Appearance.Options.UseFont = true;
            this.YeniBtn.Image = global::Gelisim_Muhasebe.Properties.Resources._0009_Add;
            this.YeniBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.YeniBtn.Location = new System.Drawing.Point(5, 5);
            this.YeniBtn.Name = "YeniBtn";
            this.YeniBtn.Size = new System.Drawing.Size(127, 49);
            this.YeniBtn.TabIndex = 0;
            this.YeniBtn.Text = "Yeni";
            this.YeniBtn.Click += new System.EventHandler(this.YeniBtn_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = global::Gelisim_Muhasebe.Properties.Resources.Kasa;
            this.panelControl1.Controls.Add(this.labelControl17);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(539, 68);
            this.panelControl1.TabIndex = 15;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl17.Location = new System.Drawing.Point(5, 25);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(176, 23);
            this.labelControl17.TabIndex = 0;
            this.labelControl17.Text = "Kasa Tanıtım Kartı";
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
            // frmKasaTanitimKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 551);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.KasaAdiBox);
            this.Controls.Add(this.KasaKoduBtn);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.KasaAciklamaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmKasaTanitimKarti";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Tanıtım Kartı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKasaTanitimKarti_FormClosed);
            this.Load += new System.EventHandler(this.frmKasaTanitimKarti_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKasaTanitimKarti_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.KasaKoduBtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaAdiBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaAciklamaBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit KasaKoduBtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit KasaAdiBox;
        private DevExpress.XtraEditors.MemoEdit KasaAciklamaBox;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton Kaptbtn;
        private DevExpress.XtraEditors.SimpleButton KaydetBtn;
        private DevExpress.XtraEditors.SimpleButton SilBtn;
        private DevExpress.XtraEditors.SimpleButton YeniBtn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider3;
    }
}