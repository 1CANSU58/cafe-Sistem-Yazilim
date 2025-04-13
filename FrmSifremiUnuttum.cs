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

namespace CafeSistem.WinForms.Kullanicilar
{
	public partial class FrmSifremiUnuttum: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        private KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();

        public FrmSifremiUnuttum()
		{
            InitializeComponent();
		}

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var entity = kullanicilarDal.GetByFilter(context,
                k => k.KullaniciAdi == txtIDveyaMail.Text || k.Email == txtIDveyaMail.Text);
            if (entity!=null)
            {
                if (entity.HatirlatmaSorusu == txtSoru.Text && entity.Cevap == txtCevap.Text)
                {
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {

                        entity.Parola = txtSifre.Text;

                        if (kullanicilarDal.AddorUpdate(context,entity))
                        {
                            kullanicilarDal.Save(context);
                            kullaniciHareketleri.KullaniciId = entity.Id;
                            string aciklama = entity.KullaniciAdi + " Adlı Kullanıcının Şifresi Güncellendi";
                            kullaniciHareketleriDal.KullaniciHareketleriEkle(context,kullaniciHareketleri,aciklama);
                            MessageBox.Show("İlgili İşlem Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Birbirleri İle Uyuşmuyor, Kontrol Et!", "UYARI", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Doğrulanamadı, Kontrol Et!", "UYARI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Böyle Bir Kullanıcı Yok, Kontrol Et!", "UYARI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}