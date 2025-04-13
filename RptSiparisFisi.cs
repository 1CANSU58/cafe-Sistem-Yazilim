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
	public partial class RptSiparisFisi : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context = new CafeContext();
        private MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();

		public RptSiparisFisi(string satisKodu,string bilgi,Entities.Models.Satislar satislar=null)
		{
			InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();
            xrLabelBilgi.Text = bilgi;
            source.DataSource = masaHareketleriDal.GetAll(context, m => m.SatisKodu == satisKodu);
            xrTableUrunAdi.DataBindings.Add("Text", DataSource, "Urun.UrunAdi");
            xrTableMiktari.DataBindings.Add("Text", DataSource, "Miktari");
            xrTableindirim.DataBindings.Add("Text", DataSource, "indirimTutari");
            xrTableFiyati.DataBindings.Add("Text", DataSource, "BirimFiyati");
            xrLabelKalan.Text = satislar.Kalan.ToString("C2");
            xrLabelOdenen.Text = satislar.Odenen.ToString("C2");

        }

	}
}
