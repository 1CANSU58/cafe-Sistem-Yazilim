namespace CafeSistem.WinForms.Kullanicilar
{
    partial class FrmRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoller));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParola = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHatirlatmaSorusu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCevap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkullaniciHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasalar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 447);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1220, 94);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSifremiUnuttum.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(113, 34);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(76, 50);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(1128, 34);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(79, 50);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGirisYap.ImageOptions.SvgImage")));
            this.btnDuzenle.Location = new System.Drawing.Point(11, 34);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(96, 50);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
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
            this.labelControl1.Size = new System.Drawing.Size(1220, 42);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Kullanıcı Görev Düzenleme Sayfası";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kullanicilarBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1220, 405);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAdSoyad,
            this.colTelefon,
            this.colAdres,
            this.colEmail,
            this.colGorevi,
            this.colKullaniciAdi,
            this.colParola,
            this.colHatirlatmaSorusu,
            this.colCevap,
            this.colAciklama,
            this.colKayitTarihi,
            this.colAktifMi,
            this.colkullaniciHareketleri,
            this.colMasalar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataSource = typeof(CafeSistem.Entities.Models.Kullanicilar);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 55;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.FieldName = "AdSoyad";
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 1;
            this.colAdSoyad.Width = 80;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 2;
            this.colTelefon.Width = 80;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 3;
            this.colAdres.Width = 80;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 80;
            // 
            // colGorevi
            // 
            this.colGorevi.FieldName = "Gorevi";
            this.colGorevi.Name = "colGorevi";
            this.colGorevi.Visible = true;
            this.colGorevi.VisibleIndex = 5;
            this.colGorevi.Width = 80;
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 6;
            this.colKullaniciAdi.Width = 80;
            // 
            // colParola
            // 
            this.colParola.FieldName = "Parola";
            this.colParola.Name = "colParola";
            this.colParola.Visible = true;
            this.colParola.VisibleIndex = 7;
            this.colParola.Width = 80;
            // 
            // colHatirlatmaSorusu
            // 
            this.colHatirlatmaSorusu.FieldName = "HatirlatmaSorusu";
            this.colHatirlatmaSorusu.Name = "colHatirlatmaSorusu";
            this.colHatirlatmaSorusu.Visible = true;
            this.colHatirlatmaSorusu.VisibleIndex = 8;
            this.colHatirlatmaSorusu.Width = 87;
            // 
            // colCevap
            // 
            this.colCevap.FieldName = "Cevap";
            this.colCevap.Name = "colCevap";
            this.colCevap.Visible = true;
            this.colCevap.VisibleIndex = 9;
            this.colCevap.Width = 78;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 10;
            this.colAciklama.Width = 78;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 11;
            this.colKayitTarihi.Width = 78;
            // 
            // colAktifMi
            // 
            this.colAktifMi.FieldName = "AktifMi";
            this.colAktifMi.Name = "colAktifMi";
            this.colAktifMi.Visible = true;
            this.colAktifMi.VisibleIndex = 12;
            this.colAktifMi.Width = 78;
            // 
            // colkullaniciHareketleri
            // 
            this.colkullaniciHareketleri.FieldName = "kullaniciHareketleri";
            this.colkullaniciHareketleri.Name = "colkullaniciHareketleri";
            this.colkullaniciHareketleri.Visible = true;
            this.colkullaniciHareketleri.VisibleIndex = 13;
            this.colkullaniciHareketleri.Width = 78;
            // 
            // colMasalar
            // 
            this.colMasalar.FieldName = "Masalar";
            this.colMasalar.Name = "colMasalar";
            this.colMasalar.Visible = true;
            this.colMasalar.VisibleIndex = 14;
            this.colMasalar.Width = 103;
            // 
            // FrmRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1220, 541);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoller";
            this.Text = "Kullanıcı Roller";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevi;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colParola;
        private DevExpress.XtraGrid.Columns.GridColumn colHatirlatmaSorusu;
        private DevExpress.XtraGrid.Columns.GridColumn colCevap;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colAktifMi;
        private DevExpress.XtraGrid.Columns.GridColumn colkullaniciHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colMasalar;
    }
}