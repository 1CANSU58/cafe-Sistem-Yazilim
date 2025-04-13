namespace CafeSistem.WinForms.Masalar
{
    partial class FrmMasaHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasaHareketleri));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.masaHareketleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindirimTuari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasalar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrun = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masaHareketleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 428);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(927, 94);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYenile.ImageOptions.SvgImage")));
            this.btnYenile.Location = new System.Drawing.Point(12, 32);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(109, 50);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile-Listele";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(834, 32);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(81, 50);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
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
            this.labelControl1.Size = new System.Drawing.Size(927, 42);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Masa Hareketleri";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.masaHareketleriBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(927, 386);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSatisKodu,
            this.colMasaID,
            this.colUrunID,
            this.colMiktari,
            this.colBirimFiyati,
            this.colindirimTuari,
            this.colAciklama,
            this.colTarih,
            this.colMasalar,
            this.colUrun});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // masaHareketleriBindingSource
            // 
            this.masaHareketleriBindingSource.DataSource = typeof(CafeSistem.Entities.Models.MasaHareketleri);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colSatisKodu
            // 
            this.colSatisKodu.FieldName = "SatisKodu";
            this.colSatisKodu.Name = "colSatisKodu";
            this.colSatisKodu.Visible = true;
            this.colSatisKodu.VisibleIndex = 1;
            // 
            // colMasaID
            // 
            this.colMasaID.FieldName = "MasaID";
            this.colMasaID.Name = "colMasaID";
            this.colMasaID.Visible = true;
            this.colMasaID.VisibleIndex = 2;
            // 
            // colUrunID
            // 
            this.colUrunID.FieldName = "UrunID";
            this.colUrunID.Name = "colUrunID";
            this.colUrunID.Visible = true;
            this.colUrunID.VisibleIndex = 3;
            // 
            // colMiktari
            // 
            this.colMiktari.FieldName = "Miktari";
            this.colMiktari.Name = "colMiktari";
            this.colMiktari.Visible = true;
            this.colMiktari.VisibleIndex = 4;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 5;
            // 
            // colindirimTuari
            // 
            this.colindirimTuari.FieldName = "indirimTuari";
            this.colindirimTuari.Name = "colindirimTuari";
            this.colindirimTuari.Visible = true;
            this.colindirimTuari.VisibleIndex = 6;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 8;
            // 
            // colMasalar
            // 
            this.colMasalar.FieldName = "Masalar";
            this.colMasalar.Name = "colMasalar";
            this.colMasalar.Visible = true;
            this.colMasalar.VisibleIndex = 9;
            // 
            // colUrun
            // 
            this.colUrun.FieldName = "Urun";
            this.colUrun.Name = "colUrun";
            this.colUrun.Visible = true;
            this.colUrun.VisibleIndex = 10;
            // 
            // FrmMasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(927, 522);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masaHareketleriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource masaHareketleriBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaID;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunID;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colindirimTuari;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colMasalar;
        private DevExpress.XtraGrid.Columns.GridColumn colUrun;
    }
}