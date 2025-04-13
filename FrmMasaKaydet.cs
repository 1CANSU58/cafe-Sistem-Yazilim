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

namespace CafeSistem.WinForms.Masalar
{
	public partial class FrmMasaKaydet: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDal masalarDal = new MasalarDal();
        private Entities.Models.Masalar _entity;

        public bool kaydet = false;

        public FrmMasaKaydet(Entities.Models.Masalar entity)
		{
            InitializeComponent();
            _entity = entity;
            txtMasaAdi.DataBindings.Add("Text", _entity, "MasaAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_entity.Id == 0)
            {
                _entity.Durumu = false;
                _entity.RezerveMi = false;
                _entity.EklenmeTarihi = DateTime.Now;
                _entity.SonIslemTarihi = DateTime.Now;
                _entity.Islem = "Yeni Masa Eklendi";
            }
            else if (_entity.Id!=0)
            {
                _entity.SonIslemTarihi = DateTime.Now;
                _entity.Islem = "Masa Güncellendi";
            }

            if (masalarDal.AddorUpdate(context, _entity))
            {
                masalarDal.Save(context);
                kaydet = true;
                if (MessageBox.Show("İlgili İşlem Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}