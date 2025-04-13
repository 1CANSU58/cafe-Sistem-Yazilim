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
using CafeSistem.WinForms.WinTools;
using DevExpress.XtraEditors;

namespace CafeSistem.WinForms.Kullanicilar
{
	public partial class FrmKullaniciGirisi: DevExpress.XtraEditors.XtraForm
    {
        private bool giris;
        private CafeContext context = new CafeContext();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        private KullaniciHareketleri entity = new KullaniciHareketleri();

        void BilgileriGetir()
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                txtParola.Text = Properties.Settings.Default.Parola;
                checkBeniHatirla.Checked = true;
            }
            else
            {
                txtKullaniciAdi.Text = null;
                txtParola.Text = null;
                checkBeniHatirla.Checked = false;
            }
        }

        void BilgileriKaydet()
        {
            if (checkBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                Properties.Settings.Default.Parola = txtParola.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }

        public FrmKullaniciGirisi()
		{
            InitializeComponent();
            BilgileriGetir();
		}

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void FrmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var model = context.Kullanicilar.FirstOrDefault(k =>
                k.KullaniciAdi == txtKullaniciAdi.Text && k.Parola == txtParola.Text);
            if (model != null)
            {
                giris = true;
                BilgileriKaydet();
                KullaniciAyarlari.kullaniciId = model.Id;
                entity.KullaniciId = model.Id;
                string aciklama = model.KullaniciAdi + " Adlı Kullanıcı Sisteme Giriş Yaptı";
                  
                kullaniciHareketleriDal.KullaniciHareketleriEkle(context,entity,aciklama);
                this.Close();
                
            } else if (txtKullaniciAdi.Text == "" || txtParola.Text == "")
            {
                MessageBox.Show("ID veya PASSWORD Alanı Boş Bırakıldı!", "BİLGİ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                txtKullaniciAdi.Text = "";
                txtParola.Text = "";
                checkBeniHatirla.Checked = false;
                MessageBox.Show("Yetkiniz Yok veya Böyle Bir Kullanıcı Yok", "UYARI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblKaydol_Click(object sender, EventArgs e)
        {
            FrmKaydol frm = new FrmKaydol(new Entities.Models.Kullanicilar());
            frm.ShowDialog();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttum frm = new FrmSifremiUnuttum();
            frm.ShowDialog();
        }
    }
}