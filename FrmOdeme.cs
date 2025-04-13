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
using DevExpress.XtraEditors;

namespace CafeSistem.WinForms.Odemeler
{
	public partial class FrmOdeme: DevExpress.XtraEditors.XtraForm
    {
        private string _satisKodu;
        private string _odemeTuru;
        public OdemeHareketleri odemeHareketleri;
        public bool kaydedildi;
        public decimal _kalan;

        public FrmOdeme(string odemeTuru,string satisKodu,decimal kalan)
		{
            InitializeComponent();
            _odemeTuru = odemeTuru;
            _satisKodu = satisKodu;
            _kalan = kalan;
            if (_odemeTuru == "Nakit")
            {
                lblBaslik.Text = "Nakit ile Ödeme";
            }
            else if (_odemeTuru == "kredi Kartı")
            {
                lblBaslik.Text = "Kredi Kartı ile Ödeme";
            } 
            else if (_odemeTuru == "Veresiye")
            {
                lblBaslik.Text = "Veresiye ile Ödeme";
                lblVeresiyeAciklama.Visible = true;
            }

        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            odemeHareketleri = new OdemeHareketleri()
            {
                SatisKodu = _satisKodu,
                OdemeTuru = _odemeTuru,
                Odenen = calcOdenecekTutar.Value,
                Aciklama = txtAciklama.Text,
                Tarih = Convert.ToDateTime(dateEditTarih.Text)
            };
            kaydedildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            calcOdenecekTutar.Value = _kalan;
        }
    }
}