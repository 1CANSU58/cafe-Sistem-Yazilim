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

namespace CafeSistem.WinForms.Masalar
{
	public partial class FrmMasaRezerv: DevExpress.XtraEditors.XtraForm
    {

        private int _masaId;
        public bool islemyapildi;
        private Entities.Models.Masalar masalar;
        private MasalarDal masalarDal = new MasalarDal();
        private CafeContext context = new CafeContext();

        public FrmMasaRezerv(int masaId)
        {
            _masaId = masaId;
            InitializeComponent();
		}

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {

            masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
            masalar.Islem = txtislem.Text;
            masalar.SonIslemTarihi = Convert.ToDateTime(dateEditTarih.EditValue);
            masalar.KullaniciId = KullaniciAyarlari.kullaniciId;
            masalar.RezerveMi = true;
            masalarDal.Save(context);
            islemyapildi = true;
            
            if(MessageBox.Show("İlgili İşlem Başarıyla Gerçekleştirildi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Close();
            }

        }
    }
}