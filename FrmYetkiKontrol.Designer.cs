namespace CafeSistem.WinForms.yetki
{
    partial class FrmYetkiKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYetkiKontrol));
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(55, 186);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Properties.Appearance.Options.UseFont = true;
            this.txtParola.Properties.Appearance.Options.UseTextOptions = true;
            this.txtParola.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtParola.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtParola.Properties.ContextImageOptions.SvgImage")));
            this.txtParola.Properties.NullText = "Password Giriniz";
            this.txtParola.Properties.NullValuePrompt = "Password Giriniz";
            this.txtParola.Properties.UseSystemPasswordChar = true;
            this.txtParola.Size = new System.Drawing.Size(361, 36);
            this.txtParola.TabIndex = 12;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(56, 130);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKullaniciAdi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKullaniciAdi.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtKullaniciAdi.Properties.ContextImageOptions.SvgImage")));
            this.txtKullaniciAdi.Properties.NullText = "ID Giriniz";
            this.txtKullaniciAdi.Properties.NullValuePrompt = "ID Giriniz";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(361, 36);
            this.txtKullaniciAdi.TabIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGirisYap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 270);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(466, 94);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(374, 34);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(79, 50);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGirisYap.ImageOptions.SvgImage")));
            this.btnGirisYap.Location = new System.Drawing.Point(11, 34);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(96, 50);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
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
            this.labelControl1.Size = new System.Drawing.Size(466, 42);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Kullanıcı Girişi";
            // 
            // FrmYetkiKontrol
            // 
            this.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(466, 364);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FrmYetkiKontrol.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYetkiKontrol";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetki Kontrol sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}