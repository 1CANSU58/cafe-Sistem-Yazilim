namespace CafeSistem.WinForms.Masalar
{
    partial class FrmMasalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasalar));
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
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRezerveMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEklenmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonIslemTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRezerveDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.btnDurumDegistir = new DevExpress.XtraEditors.SimpleButton();
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
            this.labelControl1.Size = new System.Drawing.Size(1046, 42);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Masalar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDurumDegistir);
            this.groupControl1.Controls.Add(this.btnRezerveDegistir);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnYeni);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 402);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1046, 94);
            this.groupControl1.TabIndex = 3;
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
            this.btnKapat.Location = new System.Drawing.Point(952, 34);
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
            this.btnSil.Location = new System.Drawing.Point(865, 34);
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
            this.gridControl1.Size = new System.Drawing.Size(1046, 360);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMasaAdi,
            this.colAciklama,
            this.colDurumu,
            this.colRezerveMi,
            this.colEklenmeTarihi,
            this.colSonIslemTarihi,
            this.colIslem,
            this.colKullaniciId,
            this.colMasaHareketleri});
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
            this.colId.Width = 79;
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masa";
            this.colMasaAdi.FieldName = "MasaAdi";
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 1;
            this.colMasaAdi.Width = 116;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 209;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 3;
            this.colDurumu.Width = 82;
            // 
            // colRezerveMi
            // 
            this.colRezerveMi.FieldName = "RezerveMi";
            this.colRezerveMi.Name = "colRezerveMi";
            this.colRezerveMi.Visible = true;
            this.colRezerveMi.VisibleIndex = 4;
            this.colRezerveMi.Width = 84;
            // 
            // colEklenmeTarihi
            // 
            this.colEklenmeTarihi.FieldName = "EklenmeTarihi";
            this.colEklenmeTarihi.Name = "colEklenmeTarihi";
            this.colEklenmeTarihi.Visible = true;
            this.colEklenmeTarihi.VisibleIndex = 5;
            this.colEklenmeTarihi.Width = 106;
            // 
            // colSonIslemTarihi
            // 
            this.colSonIslemTarihi.FieldName = "SonIslemTarihi";
            this.colSonIslemTarihi.Name = "colSonIslemTarihi";
            this.colSonIslemTarihi.Visible = true;
            this.colSonIslemTarihi.VisibleIndex = 6;
            this.colSonIslemTarihi.Width = 106;
            // 
            // colIslem
            // 
            this.colIslem.Caption = "İşlem";
            this.colIslem.FieldName = "Islem";
            this.colIslem.Name = "colIslem";
            this.colIslem.Visible = true;
            this.colIslem.VisibleIndex = 8;
            this.colIslem.Width = 131;
            // 
            // colKullaniciId
            // 
            this.colKullaniciId.Caption = "Kullanıcı Ad";
            this.colKullaniciId.FieldName = "kullanici";
            this.colKullaniciId.Name = "colKullaniciId";
            this.colKullaniciId.Visible = true;
            this.colKullaniciId.VisibleIndex = 7;
            this.colKullaniciId.Width = 108;
            // 
            // colMasaHareketleri
            // 
            this.colMasaHareketleri.FieldName = "MasaHareketleri";
            this.colMasaHareketleri.Name = "colMasaHareketleri";
            this.colMasaHareketleri.Width = 98;
            // 
            // btnRezerveDegistir
            // 
            this.btnRezerveDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRezerveDegistir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnRezerveDegistir.Location = new System.Drawing.Point(604, 34);
            this.btnRezerveDegistir.Name = "btnRezerveDegistir";
            this.btnRezerveDegistir.Size = new System.Drawing.Size(147, 50);
            this.btnRezerveDegistir.TabIndex = 5;
            this.btnRezerveDegistir.Text = "Rezerve Değiştir";
            this.btnRezerveDegistir.Click += new System.EventHandler(this.btnRezerveDegistir_Click);
            // 
            // btnDurumDegistir
            // 
            this.btnDurumDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDurumDegistir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btnDurumDegistir.Location = new System.Drawing.Point(438, 34);
            this.btnDurumDegistir.Name = "btnDurumDegistir";
            this.btnDurumDegistir.Size = new System.Drawing.Size(147, 50);
            this.btnDurumDegistir.TabIndex = 6;
            this.btnDurumDegistir.Text = "Durum Değiştir";
            this.btnDurumDegistir.Click += new System.EventHandler(this.btnDurumDegistir_Click);
            // 
            // FrmMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1046, 496);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMasalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masalar";
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
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colRezerveMi;
        private DevExpress.XtraGrid.Columns.GridColumn colEklenmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciId;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaHareketleri;
        private DevExpress.XtraEditors.SimpleButton btnRezerveDegistir;
        private DevExpress.XtraEditors.SimpleButton btnDurumDegistir;
    }
}