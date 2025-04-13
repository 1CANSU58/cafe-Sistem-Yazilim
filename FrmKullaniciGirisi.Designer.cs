namespace CafeSistem.WinForms.Kullanicilar
{
    partial class FrmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGirisi));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.btnSifremiUnuttum = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.lblKaydol = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.checkBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(492, 42);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Kullanıcı Girişi";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 42);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(113, 245);
            this.pictureEdit1.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSifremiUnuttum);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGirisYap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(113, 193);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 94);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(287, 34);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(79, 50);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnGirisYap.Location = new System.Drawing.Point(11, 34);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(96, 50);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(140, 34);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(97, 50);
            this.btnSifremiUnuttum.TabIndex = 3;
            this.btnSifremiUnuttum.Text = "Şifremi \r\nUnuttum ";
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(119, 48);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKullaniciAdi.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKullaniciAdi.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtKullaniciAdi.Properties.ContextImageOptions.SvgImage")));
            this.txtKullaniciAdi.Properties.NullText = "ID Giriniz";
            this.txtKullaniciAdi.Properties.NullValuePrompt = "ID Giriniz";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(361, 36);
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(118, 104);
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
            this.txtParola.TabIndex = 7;
            // 
            // lblKaydol
            // 
            this.lblKaydol.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaydol.Appearance.Options.UseFont = true;
            this.lblKaydol.Location = new System.Drawing.Point(436, 166);
            this.lblKaydol.Name = "lblKaydol";
            this.lblKaydol.Size = new System.Drawing.Size(43, 13);
            this.lblKaydol.TabIndex = 8;
            this.lblKaydol.Text = "Kayıt Ol";
            this.lblKaydol.Click += new System.EventHandler(this.lblKaydol_Click);
            // 
            // checkBeniHatirla
            // 
            this.checkBeniHatirla.Location = new System.Drawing.Point(118, 159);
            this.checkBeniHatirla.Name = "checkBeniHatirla";
            this.checkBeniHatirla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBeniHatirla.Properties.Appearance.Options.UseFont = true;
            this.checkBeniHatirla.Properties.Caption = "Beni Hatırla";
            this.checkBeniHatirla.Size = new System.Drawing.Size(96, 20);
            this.checkBeniHatirla.TabIndex = 9;
            // 
            // FrmKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(492, 287);
            this.Controls.Add(this.checkBeniHatirla);
            this.Controls.Add(this.lblKaydol);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKullaniciGirisi_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBeniHatirla.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSifremiUnuttum;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblKaydol;
        private DevExpress.XtraEditors.CheckEdit checkBeniHatirla;
    }
}