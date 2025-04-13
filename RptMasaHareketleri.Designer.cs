namespace CafeSistem.WinForms.RaporDosyalari
{
    partial class RptMasaHareketleri
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableId = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableSatisKodu = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableMasa = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableMenu = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableUrunAdi = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableMiktari = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableFiyati = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableindirimTutari = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableAciklama = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableTarih = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrLabel1});
            this.TopMargin.HeightF = 25F;
            this.TopMargin.Name = "TopMargin";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(433.3334F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(324.5832F, 23F);
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrPageInfo2.TextFormatString = "{0:d MMMM yyyy dddd HH:mm:ss}";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(300F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Masa Hareketleri Raporu ";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
            this.BottomMargin.HeightF = 31.25002F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(481.2501F, 8.250014F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(1137F, 25F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableId,
            this.xrTableSatisKodu,
            this.xrTableMasa,
            this.xrTableMenu,
            this.xrTableUrunAdi,
            this.xrTableMiktari,
            this.xrTableFiyati,
            this.xrTableindirimTutari,
            this.xrTableAciklama,
            this.xrTableTarih});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableId
            // 
            this.xrTableId.Multiline = true;
            this.xrTableId.Name = "xrTableId";
            this.xrTableId.Text = "ID";
            this.xrTableId.Weight = 0.72916664123535158D;
            // 
            // xrTableSatisKodu
            // 
            this.xrTableSatisKodu.Multiline = true;
            this.xrTableSatisKodu.Name = "xrTableSatisKodu";
            this.xrTableSatisKodu.Text = "Satış Kodu";
            this.xrTableSatisKodu.Weight = 1.0312500762939452D;
            // 
            // xrTableMasa
            // 
            this.xrTableMasa.Multiline = true;
            this.xrTableMasa.Name = "xrTableMasa";
            this.xrTableMasa.Text = "Masa";
            this.xrTableMasa.Weight = 1.2395832824707032D;
            // 
            // xrTableMenu
            // 
            this.xrTableMenu.Multiline = true;
            this.xrTableMenu.Name = "xrTableMenu";
            this.xrTableMenu.Text = "Menü";
            this.xrTableMenu.Weight = 1.333333339349887D;
            // 
            // xrTableUrunAdi
            // 
            this.xrTableUrunAdi.Multiline = true;
            this.xrTableUrunAdi.Name = "xrTableUrunAdi";
            this.xrTableUrunAdi.Text = "Ürün Adı";
            this.xrTableUrunAdi.Weight = 1.4791671068862329D;
            // 
            // xrTableMiktari
            // 
            this.xrTableMiktari.Multiline = true;
            this.xrTableMiktari.Name = "xrTableMiktari";
            this.xrTableMiktari.Text = "Miktarı";
            this.xrTableMiktari.Weight = 0.55208268364669288D;
            // 
            // xrTableFiyati
            // 
            this.xrTableFiyati.Multiline = true;
            this.xrTableFiyati.Name = "xrTableFiyati";
            this.xrTableFiyati.Text = "Fiyatı";
            this.xrTableFiyati.TextFormatString = "{0:C2}";
            this.xrTableFiyati.Weight = 0.864583740234375D;
            // 
            // xrTableindirimTutari
            // 
            this.xrTableindirimTutari.Multiline = true;
            this.xrTableindirimTutari.Name = "xrTableindirimTutari";
            this.xrTableindirimTutari.Text = "İnd. Tutarı";
            this.xrTableindirimTutari.TextFormatString = "{0:C2}";
            this.xrTableindirimTutari.Weight = 0.9895831298828125D;
            // 
            // xrTableAciklama
            // 
            this.xrTableAciklama.Multiline = true;
            this.xrTableAciklama.Name = "xrTableAciklama";
            this.xrTableAciklama.Text = "Açıklama";
            this.xrTableAciklama.Weight = 1.6354173169600301D;
            // 
            // xrTableTarih
            // 
            this.xrTableTarih.Multiline = true;
            this.xrTableTarih.Name = "xrTableTarih";
            this.xrTableTarih.Text = "Tarih";
            this.xrTableTarih.Weight = 1.5158320208025089D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.HeightF = 0F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1137F, 25F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell10,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "ID";
            this.xrTableCell1.Weight = 0.72916664123535158D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "Satış Kodu";
            this.xrTableCell2.Weight = 1.0312500762939452D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Text = "Masa Adı";
            this.xrTableCell10.Weight = 1.2395832824707032D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Menü";
            this.xrTableCell3.Weight = 1.333333339349887D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Ürün Adı";
            this.xrTableCell4.Weight = 1.4791671068862329D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Miktarı";
            this.xrTableCell5.Weight = 0.55208268364669288D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "Fiyatı";
            this.xrTableCell6.Weight = 0.864583740234375D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "İnd. Tutarı";
            this.xrTableCell7.Weight = 0.9895831298828125D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Açıklama";
            this.xrTableCell8.Weight = 1.6354167066085032D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "Tarih";
            this.xrTableCell9.Weight = 1.5158326311540358D;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.HeightF = 25F;
            this.PageHeader.Name = "PageHeader";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("satisKodu", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 23.68421F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Black;
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.White;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(1137F, 23F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "[satisKodu]";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // RptMasaHareketleri
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader,
            this.GroupHeader1});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(14F, 18F, 25F, 31.25002F);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
            this.Version = "24.2";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.AddRange(new DevExpress.XtraPrinting.Drawing.Watermark[] {
            xrWatermark1});
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableId;
        private DevExpress.XtraReports.UI.XRTableCell xrTableSatisKodu;
        private DevExpress.XtraReports.UI.XRTableCell xrTableMasa;
        private DevExpress.XtraReports.UI.XRTableCell xrTableMenu;
        private DevExpress.XtraReports.UI.XRTableCell xrTableUrunAdi;
        private DevExpress.XtraReports.UI.XRTableCell xrTableMiktari;
        private DevExpress.XtraReports.UI.XRTableCell xrTableFiyati;
        private DevExpress.XtraReports.UI.XRTableCell xrTableindirimTutari;
        private DevExpress.XtraReports.UI.XRTableCell xrTableAciklama;
        private DevExpress.XtraReports.UI.XRTableCell xrTableTarih;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}
