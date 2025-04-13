using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeSistem.Entities.DAL;
using CafeSistem.Entities.Models;
using CafeSistem.WinForms.Odemeler;
using CafeSistem.WinForms.RaporDosyalari;
using CafeSistem.WinForms.RaporFormlari;
using CafeSistem.WinForms.Urunler;
using DevExpress.XtraEditors;
using MusterilerDal = CafeSistem.Entities.DAL.MusterilerDal;

namespace CafeSistem.WinForms.Masalar
{
	public partial class FrmMasaSiparisleri: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MusterilerDal museterilerDal = new MusterilerDal();
        private MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();
        private int? _masaId = null;
        private string _satisKodu = null;
        private OdemeHareketleriDal odemeHareketleriDal = new OdemeHareketleriDal();
        //private Satislar satislar;
        private Entities.Models.Satislar satislar;
        private SatislarDal satislarDal = new SatislarDal();
        private Entities.Models.Masalar masalar;
        private MasalarDal masalarDal = new MasalarDal();
        private UrunDal urunDal = new UrunDal();
        private bool _paketSiparis = false;
        private bool yazdir;


        public FrmMasaSiparisleri(int? masaId=null,string masaAdi=null,string satisKodu=null,bool paketSiparis=false)
		{
            InitializeComponent();
            //_masaId = 1;
            _masaId = masaId;
            _satisKodu = satisKodu;
            _paketSiparis = paketSiparis;
            context.MasaHareketleri.Where(m=>m.SatisKodu==_satisKodu).Load();
            context.OdemeHareketleri.Where(o=>o.SatisKodu==_satisKodu).Load();
            
            gridControlSiparisler.DataSource = context.MasaHareketleri.Local.ToBindingList();
            gridControlOdemeler.DataSource = context.OdemeHareketleri.Local.ToBindingList();
            context.Urun.Load();
            
            lookUpMusteri.Properties.DataSource = museterilerDal.GetAll(context);
            if (_masaId != null)
            {
                lblBaslik.Text = masaAdi + " Siparişleri ";
                masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
            }
            else if (_masaId == null)
            {
                lblBaslik.Text = "Paket Siparişi veya Veresiye İşlemleri";
            }

                satislar = satislarDal.GetByFilter(context, s => s.SatisKodu == _satisKodu);
            if (satislar != null)
            {
                lookUpMusteri.EditValue = satislar.MusteriId;
                txtSatisAciklama.Text = satislar.Aciklama;
                dateEditTarih.Text = satislar.SonIslemTarihi.ToString("dd.MM.yyyy");
            }

        }



        void Hesapla()
        {
            calcIndirimToplami.Value = Convert.ToDecimal(colindirimTutari.SummaryItem.SummaryValue);
            calcIndirimliToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            calcOdenen.Value = Convert.ToDecimal(colOdenen.SummaryItem.SummaryValue);
            calcToplam.Value = calcIndirimToplami.Value + calcIndirimliToplam.Value;
            calcKalan.Value = calcIndirimliToplam.Value - calcOdenen.Value;

            /////////DIGER ISLEMLER///////DEVAMIDIR///////

            if (calcToplam.Value != 0)
            {
                calcIndirimOrani.Value = 100 * Convert.ToDecimal(colindirimTutari.SummaryItem.SummaryValue) / 
                                         (Convert.ToDecimal(colTutar.SummaryItem.SummaryValue) + 
                                          Convert.ToDecimal(colindirimTutari.SummaryItem.SummaryValue));
                /*
                100 * Convert.ToDecimal(colindirimTutari.SummaryItem.SummaryValue) /
                                     (Convert.ToDecimal(colTutar.SummaryItem.SummaryValue) +
                                      Convert.ToDecimal(colindirimTutari.SummaryItem.SummaryValue));
                */
            }
            else if (calcToplam.Value == 0)
            {
                calcIndirimOrani.Value = 0;
            }
        }


        private void btnMusteriResetle_Click(object sender, EventArgs e)
        {
            lookUpMusteri.EditValue = null;
        }

        private void repositorySiparisSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Siparişin Silinmesini Onaylıyor Musunuz ?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                gridViewSiparisler.DeleteSelectedRows();
                Hesapla();
            }
        }

        private void repositoryOdemeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili Ödemenin Silinmesini Onaylıyor Musunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridViewOdemeler.DeleteSelectedRows();
                Hesapla();
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            FrmUrunSec frm = new FrmUrunSec();
            frm.ShowDialog();
            if (frm.secildi)
            {
                MasaHareketleri entity = new MasaHareketleri
                {
                    SatisKodu = _satisKodu,
                    //MasaıD = Convert.ToInt32(_masaId),
                    MasaID = _masaId,
                    UrunID = frm.urunModel.Id,
                    Miktari = 1,
                    BirimFiyati = frm.urunModel.BirimFiyati1,
                    indirimTutari = 0,
                    Aciklama = "",
                    Tarih = DateTime.Now
                };
                masaHareketleriDal.AddorUpdate(context,entity);
            }
        }

        private void gridViewSiparisler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (gridViewSiparisler.RowCount > 0)
            {
                if (dateEditTarih.EditValue != null)
                {
                    if (satislar == null)
                    {
                        satislar = new Entities.Models.Satislar();
                        satislar.SatisKodu = _satisKodu;
                    }

                    satislar.MusteriId = (int?)lookUpMusteri.EditValue;
                    satislar.Aciklama = txtSatisAciklama.Text;
                    satislar.SonIslemTarihi = Convert.ToDateTime(dateEditTarih.EditValue);
                    satislar.Kalan = calcKalan.Value;
                    satislar.Odenen = calcOdenen.Value;
                    satislar.Tutar = calcToplam.Value;
                    satislar.indirimToplami = calcIndirimToplami.Value;
                    satislar.PaketSiparisMi = _paketSiparis;
                    satislarDal.AddorUpdate(context, satislar);
                    context.SaveChanges();
                    yazdir = true;
                }
                else
                {
                    MessageBox.Show("Tarih Girilmesi Gerekmektedir !", "BILGI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Herhangi Bir Kayıt Bulunamadı !", "BILGI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }


        private void Odemeler_Click(object sender, EventArgs e)
        {
            if (gridViewSiparisler.RowCount > 0)
            {
                var btn = sender as SimpleButton;
                FrmOdeme frm = new FrmOdeme(btn.Text, _satisKodu, calcKalan.Value);
                frm.ShowDialog();
                if (frm.kaydedildi)
                {
                    if (odemeHareketleriDal.AddorUpdate(context, frm.odemeHareketleri))
                    {
                        gridViewOdemeler.RefreshData();
                        Hesapla();
                    }
                }
            }
        }

        private void gridViewOdemeler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            
            Hesapla();
        }

        private void btnSonuclandir_Click(object sender, EventArgs e)
        {
            if (gridViewSiparisler.RowCount > 0)
            {
                if (_masaId != null)
                {
                    if (calcKalan.Value > 0)
                    {

                        if (MessageBox.Show("Bu İşlemi Onaylarsanız Müşteriye Borç İşlemi Olarak Kayıt Edilecektir !", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            if (satislar != null)
                            {
                                if (satislar.MusteriId == null)
                                {
                                    MessageBox.Show("Önce Müşterimi Seçimi Yap !", "UYARI", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                                else
                                {
                                    Sonuclandir();
                                    this.Close();
                                }

                            }
                        }


                    }
                    else if (calcKalan.Value == 0)
                    {
                        Sonuclandir();
                        this.Close();
                    }
                }
            }
        }

        private void Sonuclandir()
        {
            masalar.SatisKodu = null;
            masalar.Durumu = false;
            masalar.Islem = null;
            masalar.KullaniciId = null;
            masalarDal.AddorUpdate(context, masalar);
            masalarDal.Save(context);
        }

        private void repositoryFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int urunId = Convert.ToInt32(gridViewSiparisler.GetFocusedRowCellValue(colUrunID));
            var model = urunDal.GetByFilter(context, u => u.Id == urunId);
            barFiyat1.Caption = model.BirimFiyati1.ToString();
            barFiyat2.Caption = model.BirimFiyati2.ToString();
            barFiyat3.Caption = model.BirimFiyati3.ToString();


            radialMenu1.ShowPopup(MousePosition);
        }

        private void Fiyatlar(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewSiparisler.SetFocusedRowCellValue(colBirimFiyati,e.Item.Caption);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            btnKaydet.PerformClick();
            if (yazdir)
            {
                if (_masaId != null)
                {
                    RptSiparisFisi rpt = new RptSiparisFisi(_satisKodu, masalar.MasaAdi, satislar);
                    FrmRaporGoruntule frm = new FrmRaporGoruntule(rpt);
                    frm.ShowDialog();
                }
                else if (_masaId == null)
                {
                    if (satislar.MusteriId == null)
                    {
                        RptSiparisFisi rpt = new RptSiparisFisi(_satisKodu, _satisKodu, satislar);
                        FrmRaporGoruntule frm = new FrmRaporGoruntule(rpt);
                        frm.ShowDialog();
                    }
                    else if (satislar.MusteriId != null)
                    {
                        //RptSiparisFisi rpt = new RptSiparisFisi(_satisKodu, _satisKodu+" "+satislar.Musteriler.AdiSoyadi, satislar);
                        RptSiparisFisi rpt = new RptSiparisFisi(_satisKodu, satislar.Musteriler.AdiSoyadi, satislar);
                        FrmRaporGoruntule frm = new FrmRaporGoruntule(rpt);
                        frm.ShowDialog();
                    }

                }
            }
        }
    }
}