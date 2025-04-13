using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeSistem.Entities.DAL;
using CafeSistem.Entities.Models;
using DevExpress.XtraEditors;

namespace CafeSistem.WinForms.Urunler
{
	public partial class FrmUrunKaydet: DevExpress.XtraEditors.XtraForm
    {
        private MenuDal menuDal = new MenuDal();
        private UrunDal urunDal = new UrunDal();
        private Urun _entity;
        private CafeContext context = new CafeContext();
        public bool kaydet = false;

        public FrmUrunKaydet(Urun entity)
        {
            _entity = entity;
            InitializeComponent();
            lookUpMenu.Properties.DataSource = menuDal.GetAll(context);
            lookUpMenu.DataBindings.Add("EditValue", _entity,"MenuId");
            txtUrunAdi.DataBindings.Add("Text", _entity, "UrunAdi");
            txtUrunKodu.DataBindings.Add("Text", _entity, "UrunKodu");
            calcBirimFiyati1.DataBindings.Add("Text", _entity, "BirimFiyati1",true);
            calcBirimFiyati2.DataBindings.Add("Text", _entity, "BirimFiyati2",true);
            calcBirimFiyati3.DataBindings.Add("Text", _entity, "BirimFiyati3",true);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
            dateEdit1.DataBindings.Add("Text", _entity, "Tarih",true);
            if (_entity.Id != 0)
            {
                if (_entity.Resim!=null)
                {
                    pictureEdit1.Image = Image.FromFile(_entity.Resim);
                }
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.GetLoadedImageLocation()!="")
            {
                string hedefyol = $"{Application.StartupPath}\\Image\\{txtUrunAdi.Text}--{txtUrunKodu.Text}.png";
                File.Copy(pictureEdit1.GetLoadedImageLocation(), hedefyol);
                _entity.Resim = $"Image\\{txtUrunAdi.Text}--{txtUrunKodu.Text}.png";
            }

            if (urunDal.AddorUpdate(context,_entity))
            {
                urunDal.Save(context);
                kaydet = true;
                if (MessageBox.Show("İlgili İşlem Başarıyla Gerçekleştirildi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Question) == DialogResult.OK)
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