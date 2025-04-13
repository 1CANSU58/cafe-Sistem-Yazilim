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
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization.Controls;

namespace CafeSistem.WinForms.Masalar
{
	public partial class FrmMasaDurumlari: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private CheckButton btnsender;
        private SatisKodu modelSatisKodu;
        private string _satisKodu;
        private int _masaId;
        private Entities.Models.Masalar masalar;
        private MasalarDal masalarDal = new MasalarDal();


        public FrmMasaDurumlari()
		{
            InitializeComponent();
            modelSatisKodu = context.SatisKodu.First();
            MasalariGetir();
		}

            public void MasalariGetir()
            {
                flowLayoutPanel1.Controls.Clear();
                context = new CafeContext();
                var model = context.Masalar.ToList();
                for (int i = 0; i < model.Count; i++)
                {
                    var btn = new CheckButton();
                    btn.Text = model[i].MasaAdi;
                    btn.Name = model[i].Id.ToString();
                    btn.Tag = model[i].SatisKodu;
                    btn.Height = 100;
                    btn.Width = 80;
                    flowLayoutPanel1.Controls.Add(btn);
                    if (model[i].RezerveMi && !model[i].Durumu)
                    {
                        btn.Appearance.BackColor = Color.Yellow;
                    }
                    else if (model[i].Durumu)
                    {
                        btn.Appearance.BackColor = Color.Red;
                    }
                    else if (!model[i].Durumu)
                    {
                        btn.Appearance.BackColor = Color.Green;
                    }
                    btn.Click += Btn_Click;
                }
            }

            public void DurumlariYenile()
            {
                btnSiparisEkle.Enabled = false;
                btnMasaAc.Enabled = false;
                btnRezerveYap.Enabled = false;
            }

            private void Btn_Click(object sender, EventArgs e)
            {
                /*
                var btn = sender as CheckButton;
                MessageBox.Show("Masa Adı : " + btn.Text + " " + " Masa ID : " + btn.Name);
                */

                btnsender = sender as CheckButton;
                //CheckButton btn = sender as CheckButton;
                _masaId = Convert.ToInt32(btnsender.Name);
                
            //MessageBox.Show(tiklananbtn.Text);

            DurumlariYenile();

                if (btnsender.Appearance.BackColor == Color.Yellow)
                {
                    btnMasaAc.Enabled = true;
                }
                else if (btnsender.Appearance.BackColor == Color.Green)
                {
                    btnMasaAc.Enabled = true;
                    btnRezerveYap.Enabled = true;
                }
                else if (btnsender.Appearance.BackColor == Color.Red)
                {
                    btnSiparisEkle.Enabled = true;
                }
            }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            _satisKodu = btnsender.Tag.ToString();
            FrmMasaSiparisleri frm = new FrmMasaSiparisleri(masaId: _masaId, masaAdi: btnsender.Text, satisKodu: _satisKodu);
            frm.ShowDialog();
            btnsender = null;
            DurumlariYenile();
            MasalariGetir();
        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnsender.Text +" Açılsın Mı? ","BİLGİ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
                masalar.SatisKodu = modelSatisKodu.SatisTanimi + modelSatisKodu.Sayi;
                masalar.Durumu = true;
                masalar.RezerveMi = false;
                //modelSatisKodu.Sayi++;
                var sayiarttir = context.SatisKodu.First();
                sayiarttir.Sayi++;
                masalarDal.Save(context);
                btnsender = null;
                MessageBox.Show("İlgili İşlem Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                DurumlariYenile();
                MasalariGetir();
                modelSatisKodu = context.SatisKodu.First();
            }
        }

        private void btnRezerveYap_Click(object sender, EventArgs e)
        {
            FrmMasaRezerv frm = new FrmMasaRezerv(_masaId);
            frm.ShowDialog();
            DurumlariYenile();
            if (frm.islemyapildi)
            {
                MasalariGetir();
            }

            btnsender = null;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            MasalariGetir();
        }
    }
}