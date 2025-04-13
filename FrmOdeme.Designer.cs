namespace CafeSistem.WinForms.Odemeler
{
    partial class FrmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdeme));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnOnay = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.calcOdenecekTutar = new DevExpress.XtraEditors.CalcEdit();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.dateEditTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lblVeresiyeAciklama = new DevExpress.XtraEditors.LabelControl();
            this.btn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcOdenecekTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(466, 42);
            this.lblBaslik.TabIndex = 9;
            this.lblBaslik.Text = "Ödeme Sayfası";
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Controls.Add(this.btnOnay);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 241);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(466, 74);
            this.groupIslemler.TabIndex = 10;
            this.groupIslemler.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(373, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(81, 41);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnOnay
            // 
            this.btnOnay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOnay.ImageOptions.SvgImage")));
            this.btnOnay.Location = new System.Drawing.Point(256, 28);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(92, 41);
            this.btnOnay.TabIndex = 1;
            this.btnOnay.Text = "Onay";
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(21, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(153, 26);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Ödenenecek Tutar : ";
            // 
            // calcOdenecekTutar
            // 
            this.calcOdenecekTutar.Location = new System.Drawing.Point(180, 50);
            this.calcOdenecekTutar.Name = "calcOdenecekTutar";
            this.calcOdenecekTutar.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.calcOdenecekTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcOdenecekTutar.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcOdenecekTutar.Properties.Appearance.Options.UseBackColor = true;
            this.calcOdenecekTutar.Properties.Appearance.Options.UseFont = true;
            this.calcOdenecekTutar.Properties.Appearance.Options.UseForeColor = true;
            this.calcOdenecekTutar.Properties.Appearance.Options.UseTextOptions = true;
            this.calcOdenecekTutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.calcOdenecekTutar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcOdenecekTutar.Properties.MaskSettings.Set("mask", "c");
            this.calcOdenecekTutar.Properties.NullText = "0,00 TL";
            this.calcOdenecekTutar.Properties.UseMaskAsDisplayFormat = true;
            this.calcOdenecekTutar.Size = new System.Drawing.Size(225, 22);
            this.calcOdenecekTutar.TabIndex = 12;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(180, 79);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(269, 85);
            this.txtAciklama.TabIndex = 22;
            // 
            // dateEditTarih
            // 
            this.dateEditTarih.EditValue = null;
            this.dateEditTarih.Location = new System.Drawing.Point(180, 172);
            this.dateEditTarih.Name = "dateEditTarih";
            this.dateEditTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEditTarih.Properties.Appearance.Options.UseFont = true;
            this.dateEditTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Size = new System.Drawing.Size(269, 22);
            this.dateEditTarih.TabIndex = 21;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(21, 80);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(153, 84);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Açıklama  : ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl9.Appearance.Options.UseBorderColor = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(21, 170);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(153, 24);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Tarih  : ";
            // 
            // lblVeresiyeAciklama
            // 
            this.lblVeresiyeAciklama.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblVeresiyeAciklama.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeresiyeAciklama.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblVeresiyeAciklama.Appearance.Options.UseBackColor = true;
            this.lblVeresiyeAciklama.Appearance.Options.UseFont = true;
            this.lblVeresiyeAciklama.Appearance.Options.UseForeColor = true;
            this.lblVeresiyeAciklama.Location = new System.Drawing.Point(44, 209);
            this.lblVeresiyeAciklama.Name = "lblVeresiyeAciklama";
            this.lblVeresiyeAciklama.Size = new System.Drawing.Size(381, 16);
            this.lblVeresiyeAciklama.TabIndex = 23;
            this.lblVeresiyeAciklama.Text = "UYARI ! : VERESİYE ÖDEMEDE AÇIKLAMA ALANINI BOŞ BIRAKMA ! ";
            this.lblVeresiyeAciklama.Visible = false;
            // 
            // btn
            // 
            this.btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn.ImageOptions.SvgImage")));
            this.btn.Location = new System.Drawing.Point(411, 49);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(38, 23);
            this.btn.TabIndex = 24;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // FrmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(466, 315);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblVeresiyeAciklama);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dateEditTarih);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.calcOdenecekTutar);
            this.Controls.Add(this.groupIslemler);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calcOdenecekTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnOnay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CalcEdit calcOdenecekTutar;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.DateEdit dateEditTarih;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lblVeresiyeAciklama;
        private DevExpress.XtraEditors.SimpleButton btn;
    }
}