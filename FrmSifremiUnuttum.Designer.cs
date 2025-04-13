namespace CafeSistem.WinForms.Kullanicilar
{
    partial class FrmSifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifremiUnuttum));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDveyaMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoru = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCevap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifreTekrar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDveyaMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreTekrar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 216);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(356, 67);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(261, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(81, 37);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnGuncelle.Location = new System.Drawing.Point(10, 26);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(145, 37);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Şifremi Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtIDveyaMail
            // 
            this.txtIDveyaMail.Location = new System.Drawing.Point(118, 51);
            this.txtIDveyaMail.Name = "txtIDveyaMail";
            this.txtIDveyaMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIDveyaMail.Properties.Appearance.Options.UseFont = true;
            this.txtIDveyaMail.Properties.NullText = "ID veya E-Mail Gir";
            this.txtIDveyaMail.Properties.NullValuePrompt = "ID veya E-Mail Gir";
            this.txtIDveyaMail.Size = new System.Drawing.Size(221, 22);
            this.txtIDveyaMail.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(10, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 24);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "ID veya E-Mail : ";
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
            this.labelControl1.Size = new System.Drawing.Size(356, 42);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Şifremi Unuttum - Sıfırla";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(10, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 24);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Soru : ";
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(118, 81);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoru.Properties.Appearance.Options.UseFont = true;
            this.txtSoru.Properties.NullText = "Soruyu Gir";
            this.txtSoru.Properties.NullValuePrompt = "Soruyu Gir";
            this.txtSoru.Size = new System.Drawing.Size(221, 22);
            this.txtSoru.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(10, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(101, 24);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Cevap : ";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(118, 111);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCevap.Properties.Appearance.Options.UseFont = true;
            this.txtCevap.Properties.NullText = "Cevapı Gir";
            this.txtCevap.Properties.NullValuePrompt = "Cevapı Gir";
            this.txtCevap.Size = new System.Drawing.Size(221, 22);
            this.txtCevap.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl5.Appearance.Options.UseBorderColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl5.Location = new System.Drawing.Point(12, 138);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(101, 24);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Yeni Şifre : ";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(120, 141);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(221, 22);
            this.txtSifre.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(10, 168);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(101, 24);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Yeni Şifre Tekrarı : ";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(118, 171);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreTekrar.Properties.Appearance.Options.UseFont = true;
            this.txtSifreTekrar.Properties.UseSystemPasswordChar = true;
            this.txtSifreTekrar.Size = new System.Drawing.Size(221, 22);
            this.txtSifreTekrar.TabIndex = 13;
            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(356, 283);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.txtIDveyaMail);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIDveyaMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCevap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreTekrar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.TextEdit txtIDveyaMail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSoru;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCevap;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSifreTekrar;
    }
}