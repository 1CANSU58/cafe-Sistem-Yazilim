﻿namespace CafeSistem.WinForms.Musteriler
{
    partial class FrmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriler));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatislar = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.labelControl1.Size = new System.Drawing.Size(869, 42);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Müşteriler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 419);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(869, 93);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(776, 32);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(81, 50);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(133, 35);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 50);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKaydet.ImageOptions.SvgImage")));
            this.btnKaydet.Location = new System.Drawing.Point(12, 35);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 50);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(869, 377);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAdiSoyadi,
            this.colTelefon,
            this.colAdres,
            this.colEmail,
            this.colAciklama,
            this.colTarih,
            this.colSatislar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 74;
            // 
            // colAdiSoyadi
            // 
            this.colAdiSoyadi.Caption = "Adı Soyadı";
            this.colAdiSoyadi.FieldName = "AdiSoyadi";
            this.colAdiSoyadi.Name = "colAdiSoyadi";
            this.colAdiSoyadi.Visible = true;
            this.colAdiSoyadi.VisibleIndex = 1;
            this.colAdiSoyadi.Width = 147;
            // 
            // colTelefon
            // 
            this.colTelefon.Caption = "Telefon";
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 2;
            this.colTelefon.Width = 124;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 3;
            this.colAdres.Width = 124;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 124;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 5;
            this.colAciklama.Width = 137;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 6;
            this.colTarih.Width = 114;
            // 
            // colSatislar
            // 
            this.colSatislar.FieldName = "Satislar";
            this.colSatislar.Name = "colSatislar";
            this.colSatislar.Width = 118;
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(869, 512);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSatislar;
    }
}