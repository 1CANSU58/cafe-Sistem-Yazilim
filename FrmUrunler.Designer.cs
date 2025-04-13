namespace CafeSistem.WinForms.Urunler
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(935, 42);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürünler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnYeni);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 438);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(935, 94);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenile.ImageOptions.SvgImage")));
            this.btnYenile.Location = new System.Drawing.Point(186, 34);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(109, 50);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile-Listele";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDuzenle.ImageOptions.SvgImage")));
            this.btnDuzenle.Location = new System.Drawing.Point(93, 34);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(87, 50);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(841, 34);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(81, 50);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(754, 34);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 50);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYeni.ImageOptions.SvgImage")));
            this.btnYeni.Location = new System.Drawing.Point(11, 34);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(76, 50);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(935, 396);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMenuId,
            this.colUrunKodu,
            this.colUrunAdi,
            this.colBirimFiyati1,
            this.colBirimFiyati2,
            this.colBirimFiyati3,
            this.colAciklama,
            this.colTarih,
            this.colResim,
            this.colMenu,
            this.colMenuAdi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 40;
            // 
            // colMenuId
            // 
            this.colMenuId.Caption = "Menü ID";
            this.colMenuId.FieldName = "MenuId";
            this.colMenuId.Name = "colMenuId";
            this.colMenuId.Visible = true;
            this.colMenuId.VisibleIndex = 2;
            this.colMenuId.Width = 56;
            // 
            // colUrunKodu
            // 
            this.colUrunKodu.Caption = "Ürün Kodu";
            this.colUrunKodu.FieldName = "UrunKodu";
            this.colUrunKodu.Name = "colUrunKodu";
            this.colUrunKodu.Visible = true;
            this.colUrunKodu.VisibleIndex = 3;
            this.colUrunKodu.Width = 72;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 4;
            this.colUrunAdi.Width = 121;
            // 
            // colBirimFiyati1
            // 
            this.colBirimFiyati1.Caption = "Birim Fiyatı 1";
            this.colBirimFiyati1.FieldName = "BirimFiyati1";
            this.colBirimFiyati1.Name = "colBirimFiyati1";
            this.colBirimFiyati1.Visible = true;
            this.colBirimFiyati1.VisibleIndex = 5;
            this.colBirimFiyati1.Width = 84;
            // 
            // colBirimFiyati2
            // 
            this.colBirimFiyati2.Caption = "Birim Fiyatı 2";
            this.colBirimFiyati2.FieldName = "BirimFiyati2";
            this.colBirimFiyati2.Name = "colBirimFiyati2";
            this.colBirimFiyati2.Visible = true;
            this.colBirimFiyati2.VisibleIndex = 6;
            this.colBirimFiyati2.Width = 78;
            // 
            // colBirimFiyati3
            // 
            this.colBirimFiyati3.Caption = "Birim Fiyatı 3";
            this.colBirimFiyati3.FieldName = "BirimFiyati3";
            this.colBirimFiyati3.Name = "colBirimFiyati3";
            this.colBirimFiyati3.Visible = true;
            this.colBirimFiyati3.VisibleIndex = 7;
            this.colBirimFiyati3.Width = 76;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 8;
            this.colAciklama.Width = 165;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 9;
            this.colTarih.Width = 118;
            // 
            // colResim
            // 
            this.colResim.Caption = "Resim";
            this.colResim.FieldName = "Resim";
            this.colResim.Name = "colResim";
            // 
            // colMenu
            // 
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            // 
            // colMenuAdi
            // 
            this.colMenuAdi.Caption = "Menü";
            this.colMenuAdi.FieldName = "Menu";
            this.colMenuAdi.Name = "colMenuAdi";
            this.colMenuAdi.Visible = true;
            this.colMenuAdi.VisibleIndex = 1;
            this.colMenuAdi.Width = 100;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(935, 532);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colResim;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAdi;
    }
}