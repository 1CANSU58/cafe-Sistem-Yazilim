namespace CafeSistem.WinForms.Masalar
{
    partial class FrmMasaDurumlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasaDurumlari));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnRezerveYap = new DevExpress.XtraEditors.SimpleButton();
            this.btnMasaAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisEkle = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
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
            this.labelControl1.Size = new System.Drawing.Size(810, 42);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Masa Durumları";
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.btnRezerveYap);
            this.groupIslemler.Controls.Add(this.btnMasaAc);
            this.groupIslemler.Controls.Add(this.btnYenile);
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Controls.Add(this.btnSiparisEkle);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 402);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(810, 82);
            this.groupIslemler.TabIndex = 8;
            this.groupIslemler.Text = "İşlemler";
            // 
            // btnRezerveYap
            // 
            this.btnRezerveYap.Enabled = false;
            this.btnRezerveYap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRezerveYap.ImageOptions.SvgImage")));
            this.btnRezerveYap.Location = new System.Drawing.Point(238, 34);
            this.btnRezerveYap.Name = "btnRezerveYap";
            this.btnRezerveYap.Size = new System.Drawing.Size(109, 41);
            this.btnRezerveYap.TabIndex = 4;
            this.btnRezerveYap.Text = "Rezerve Et";
            this.btnRezerveYap.Click += new System.EventHandler(this.btnRezerveYap_Click);
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Enabled = false;
            this.btnMasaAc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMasaAc.ImageOptions.SvgImage")));
            this.btnMasaAc.Location = new System.Drawing.Point(123, 33);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(109, 41);
            this.btnMasaAc.TabIndex = 4;
            this.btnMasaAc.Text = "Masa Aç";
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenile.ImageOptions.SvgImage")));
            this.btnYenile.Location = new System.Drawing.Point(353, 34);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(109, 41);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile-Listele";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(717, 33);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(81, 41);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Enabled = false;
            this.btnSiparisEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSiparisEkle.ImageOptions.SvgImage")));
            this.btnSiparisEkle.Location = new System.Drawing.Point(12, 33);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(105, 41);
            this.btnSiparisEkle.TabIndex = 0;
            this.btnSiparisEkle.Text = "Siparişler";
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(810, 360);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // FrmMasaDurumlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(810, 484);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupIslemler);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMasaDurumlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Durumları";
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnRezerveYap;
        private DevExpress.XtraEditors.SimpleButton btnMasaAc;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSiparisEkle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}