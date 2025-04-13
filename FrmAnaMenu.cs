using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeSistem.Entities.Models;
using CafeSistem.WinForms.Kullanicilar;
using CafeSistem.WinForms.Masalar;
using CafeSistem.WinForms.Menuler;
using CafeSistem.WinForms.Musteriler;
using CafeSistem.WinForms.Odemeler;
using CafeSistem.WinForms.RaporDosyalari;
using CafeSistem.WinForms.RaporFormlari;
using CafeSistem.WinForms.Satislar;
using CafeSistem.WinForms.Urunler;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace CafeSistem.WinForms.AnaMenu
{
	public partial class FrmAnaMenu: DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CafeContext context = new CafeContext();
        public bool yetki = false;

        void FormGetir(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        public FrmAnaMenu()
		{
            InitializeComponent();
            FrmKullaniciGirisi frm = new FrmKullaniciGirisi();
            frm.ShowDialog();
        }

        private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FrmUrunler();
            FormGetir(frm);
        }

        private void btnMenuler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FrmMenuler();
            frm.ShowDialog();
        }

        private void btnMasalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FrmMasalar();
            FormGetir(frm);
        }

        private void btnMasaSiparis_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FrmMasaDurumlari();
            FormGetir(frm);
        }

        private void btnMusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FrmMusteriler();
            FormGetir(frm);
        }

        private void btnSatislar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FrmSatislar();
            FormGetir(frm);
        }

        private void btnOdemeHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new FrmOdemeHareketleri();
            FormGetir(frm);
        }

        private void btnPaketSiparisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Paket Sipariş İşlemini Onaylıyor Musunuz ?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                var model = context.SatisKodu.First();
                string satisKodu = model.SatisTanimi + model.Sayi;
                model.Sayi++;
                context.SaveChanges();
                XtraForm frm = new FrmMasaSiparisleri(satisKodu: satisKodu,paketSiparis:true);
                frm.ShowDialog();

            }

        }

        private void btnMasaHareketleriRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            RptMasaHareketleri report = new RptMasaHareketleri();
            FrmRaporGoruntule2 frm = new FrmRaporGoruntule2(report);
            frm.ShowDialog();
        }

        private void btnOzelRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmOzelRaporOlustur frm = new FrmOzelRaporOlustur();
            frm.ShowDialog();
        }

        private void btnMasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            RptMasaHareketleri report = new RptMasaHareketleri();
            FrmRaporGoruntule2 frm = new FrmRaporGoruntule2(report);
            frm.ShowDialog();
        }

        private void btnMenuHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            RptMenuHareketleri report = new RptMenuHareketleri();
            FrmRaporGoruntule2 frm = new FrmRaporGoruntule2(report);
            frm.ShowDialog();
        }

        private void btnUrunHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            RptUrunHareketleri report = new RptUrunHareketleri();
            FrmRaporGoruntule2 frm = new FrmRaporGoruntule2(report);
            frm.ShowDialog();
        }

        private void btnKullaniciHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            RptKullaniciHareketleri report = new RptKullaniciHareketleri();
            FrmRaporGoruntule2 frm = new FrmRaporGoruntule2(report);
            frm.ShowDialog();
        }

        private void btnKullanicilar_ItemClick(object sender, ItemClickEventArgs e)
        {
            RptKullanicilar report = new RptKullanicilar();
            FrmRaporGoruntule2 frm = new FrmRaporGoruntule2(report);
            frm.ShowDialog();
        }

        private void btnRoller_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmRoller frm = new FrmRoller(yetki);
            frm.ShowDialog();
        }
    }
}