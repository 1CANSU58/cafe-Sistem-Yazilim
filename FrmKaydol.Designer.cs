namespace CafeSistem.WinForms.Kullanicilar
{
    partial class FrmKaydol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKaydol));
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toggleAktifMİ = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtGorevi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifreTekrar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtCevap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtAdres = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleAktifMİ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(126, 106);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(221, 22);
            this.txtAdSoyad.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(18, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 24);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Ad Soyad : ";
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
            this.labelControl1.Size = new System.Drawing.Size(360, 42);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Yeni Kullanıcı Oluştur";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 527);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(360, 67);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(265, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(81, 37);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(10, 26);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 37);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kayıt Et";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(17, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 24);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Durumu : ";
            // 
            // toggleAktifMİ
            // 
            this.toggleAktifMİ.Location = new System.Drawing.Point(125, 76);
            this.toggleAktifMİ.Name = "toggleAktifMİ";
            this.toggleAktifMİ.Properties.OffText = "Pasif";
            this.toggleAktifMİ.Properties.OnText = "Aktif";
            this.toggleAktifMİ.Size = new System.Drawing.Size(222, 18);
            this.toggleAktifMİ.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(17, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 24);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Telefon : ";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(125, 134);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Properties.Appearance.Options.UseFont = true;
            this.txtTelefon.Size = new System.Drawing.Size(221, 22);
            this.txtTelefon.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(17, 159);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 80);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Adres : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(17, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(101, 24);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Mail : ";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(125, 248);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Size = new System.Drawing.Size(221, 22);
            this.txtMail.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl7.Appearance.Options.UseBorderColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(18, 275);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(101, 24);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Görevi : ";
            // 
            // txtGorevi
            // 
            this.txtGorevi.Location = new System.Drawing.Point(126, 278);
            this.txtGorevi.Name = "txtGorevi";
            this.txtGorevi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGorevi.Properties.Appearance.Options.UseFont = true;
            this.txtGorevi.Size = new System.Drawing.Size(221, 22);
            this.txtGorevi.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl8.Appearance.Options.UseBorderColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(18, 305);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(101, 24);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Kullanıcı Adı : ";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(126, 308);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(221, 22);
            this.txtKullaniciAdi.TabIndex = 9;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl9.Appearance.Options.UseBorderColor = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(17, 335);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(101, 24);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Şifre : ";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(125, 338);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(221, 22);
            this.txtSifre.TabIndex = 9;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(17, 365);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(101, 24);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Şifre Tekrarı : ";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(125, 368);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreTekrar.Properties.Appearance.Options.UseFont = true;
            this.txtSifreTekrar.Properties.UseSystemPasswordChar = true;
            this.txtSifreTekrar.Size = new System.Drawing.Size(221, 22);
            this.txtSifreTekrar.TabIndex = 9;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl11.Appearance.Options.UseBorderColor = true;
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl11.Location = new System.Drawing.Point(18, 395);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(101, 24);
            this.labelControl11.TabIndex = 8;
            this.labelControl11.Text = "Soru : ";
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(126, 398);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoru.Properties.Appearance.Options.UseFont = true;
            this.txtSoru.Size = new System.Drawing.Size(221, 22);
            this.txtSoru.TabIndex = 9;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl12.Appearance.Options.UseBorderColor = true;
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl12.Location = new System.Drawing.Point(18, 425);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(101, 24);
            this.labelControl12.TabIndex = 8;
            this.labelControl12.Text = "Cevap : ";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(126, 428);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCevap.Properties.Appearance.Options.UseFont = true;
            this.txtCevap.Size = new System.Drawing.Size(221, 22);
            this.txtCevap.TabIndex = 9;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl13.Appearance.Options.UseBorderColor = true;
            this.labelControl13.Appearance.Options.UseTextOptions = true;
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl13.Location = new System.Drawing.Point(18, 455);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(101, 64);
            this.labelControl13.TabIndex = 8;
            this.labelControl13.Text = "Açıklama : ";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(125, 454);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(221, 65);
            this.txtAciklama.TabIndex = 13;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(126, 163);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(220, 79);
            this.txtAdres.TabIndex = 14;
            // 
            // FrmKaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(360, 594);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.toggleAktifMİ);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtGorevi);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKaydol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleAktifMİ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch toggleAktifMİ;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtGorevi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtSifreTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtSoru;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtCevap;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.MemoEdit txtAdres;
    }
}