using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CafeSistem.Entities.Models;
using CafeSistem.Entities.DAL;
using CafeSistem.WinForms.Kullanicilar;

namespace CafeSistem.WinForms.yetki
{
	public partial class FrmYetkiKontrol: DevExpress.XtraEditors.XtraForm
	{

        private CafeContext context = new CafeContext();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        private KullaniciHareketleri entity = new KullaniciHareketleri();

        public FrmYetkiKontrol()
		{
            InitializeComponent();
		}

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var model = context.Kullanicilar.FirstOrDefault(k =>
                k.KullaniciAdi == txtKullaniciAdi.Text && k.Parola == txtParola.Text && k.Gorevi == "Admin");
            if (model != null)
            {
                entity.KullaniciId = model.Id;
                string aciklama = model.KullaniciAdi + " Adlı Kullanıcı Rol Değiştirme Sayfasına Giriş Yaptı veya İşlem Uyguladı";

                kullaniciHareketleriDal.KullaniciHareketleriEkle(context, entity, aciklama);
                bool yetki = true;
                txtKullaniciAdi.Text = "";
                txtParola.Text = "";
                FrmRoller frm = new FrmRoller(yetki:yetki);
                frm.ShowDialog();
                this.Close();

            }
            else if (txtKullaniciAdi.Text == "" || txtParola.Text == "")
            {
                MessageBox.Show("ID veya PASSWORD Alanı Boş Bırakıldı!", "BİLGİ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                txtKullaniciAdi.Text = "";
                txtParola.Text = "";
                MessageBox.Show("Yetkiniz Yok veya Böyle Bir Kullanıcı Yok", "UYARI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}