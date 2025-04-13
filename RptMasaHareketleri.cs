using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using CafeSistem.Entities.DAL;
using CafeSistem.Entities.Models;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;

namespace CafeSistem.WinForms.RaporDosyalari
{
	public partial class RptMasaHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context = new CafeContext();
        private MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();

		public RptMasaHareketleri()
		{
			InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();
            source.DataSource = masaHareketleriDal.GetAll(context);
            DataSource = source;
            xrTableId.DataBindings.Add("Text", DataSource, "Id");
            xrTableSatisKodu.DataBindings.Add("Text", DataSource, "SatisKodu");
            xrTableMasa.DataBindings.Add("Text", DataSource, "Masalar.MasaAdi");
            xrTableMenu.DataBindings.Add("Text", DataSource, "Urun.Menu.MenuAdi");
            xrTableUrunAdi.DataBindings.Add("Text", DataSource, "Urun.UrunAdi");
            xrTableMiktari.DataBindings.Add("Text", DataSource, "Miktari");
            xrTableFiyati.DataBindings.Add("Text", DataSource, "BirimFiyati");
            xrTableindirimTutari.DataBindings.Add("Text", DataSource, "indirimTutari");
            xrTableTarih.DataBindings.Add("Text", DataSource, "Tarih");
            xrTableAciklama.DataBindings.Add("Text", DataSource, "Aciklama");
        }

	}
}
