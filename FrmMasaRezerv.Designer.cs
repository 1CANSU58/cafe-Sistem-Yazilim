namespace CafeSistem.WinForms.Masalar
{
    partial class FrmMasaRezerv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasaRezerv));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditTarih = new DevExpress.XtraEditors.DateEdit();
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.txtislem = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtislem.Properties)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(498, 42);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Masa Rezervi";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl8.Appearance.Options.UseBorderColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(12, 58);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(101, 24);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Tarih  : ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.DarkGray;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(12, 99);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(101, 109);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "İşlem   : ";
            // 
            // dateEditTarih
            // 
            this.dateEditTarih.EditValue = null;
            this.dateEditTarih.Location = new System.Drawing.Point(119, 60);
            this.dateEditTarih.Name = "dateEditTarih";
            this.dateEditTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateEditTarih.Properties.Appearance.Options.UseFont = true;
            this.dateEditTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Size = new System.Drawing.Size(351, 22);
            this.dateEditTarih.TabIndex = 21;
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Controls.Add(this.btnOnayla);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 225);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(498, 82);
            this.groupIslemler.TabIndex = 22;
            this.groupIslemler.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(405, 33);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(81, 41);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSiparisEkle.ImageOptions.SvgImage")));
            this.btnOnayla.Location = new System.Drawing.Point(12, 33);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(105, 41);
            this.btnOnayla.TabIndex = 0;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtislem
            // 
            this.txtislem.Location = new System.Drawing.Point(119, 99);
            this.txtislem.Name = "txtislem";
            this.txtislem.Size = new System.Drawing.Size(351, 109);
            this.txtislem.TabIndex = 23;
            // 
            // FrmMasaRezerv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(498, 307);
            this.Controls.Add(this.txtislem);
            this.Controls.Add(this.groupIslemler);
            this.Controls.Add(this.dateEditTarih);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMasaRezerv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Rezerve";
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtislem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit dateEditTarih;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private DevExpress.XtraEditors.MemoEdit txtislem;
    }
}