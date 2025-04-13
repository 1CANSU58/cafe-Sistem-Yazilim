using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeSistem.Entities.DAL;
using CafeSistem.Entities.Models;
using DevExpress.XtraEditors;
using CafeSistem.Entities.Mapping;

namespace CafeSistem.WinForms.Kullanicilar
{
	public partial class FrmKaydol: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        private Entities.Models.Kullanicilar _entity;
        //public bool kaydet = false;
        private KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();

        public FrmKaydol(Entities.Models.Kullanicilar entity)
		{
            InitializeComponent();
            _entity = entity;

            toggleAktifMİ.DataBindings.Add("EditValue", _entity,"AktifMi");
            txtAdSoyad.DataBindings.Add("Text", _entity, "AdSoyad");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            txtMail.DataBindings.Add("Text", _entity, "Email");
            txtGorevi.DataBindings.Add("Text", _entity, "Gorevi");
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi");
            txtSifre.DataBindings.Add("Text", _entity, "Parola");
            txtSoru.DataBindings.Add("Text", _entity, "HatirlatmaSorusu");
            txtCevap.DataBindings.Add("Text", _entity, "Cevap");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                _entity.KayitTarihi = DateTime.Now;
                if (kullanicilarDal.AddorUpdate(context, _entity))
                {
                    kullanicilarDal.Save(context);
                    var model = context.Kullanicilar.Max(k => k.Id);
                    kullaniciHareketleri.KullaniciId = model;
                    string aciklama = "Yeni Kullanıcı Oluşturuldu";
                    kullaniciHareketleriDal.KullaniciHareketleriEkle(context,kullaniciHareketleri,aciklama);
                    //kaydet = true;
                    MessageBox.Show("İlgili İşlem Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor, Kontrol Et!", "BİLGİ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}