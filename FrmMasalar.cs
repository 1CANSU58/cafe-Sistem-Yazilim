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

namespace CafeSistem.WinForms.Masalar
{
	public partial class FrmMasalar: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDal masalarDal = new MasalarDal();

        public FrmMasalar()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = masalarDal.MasalariListele(context);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            FrmMasaKaydet frm = new FrmMasaKaydet(new Entities.Models.Masalar());
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliid);
            FrmMasaKaydet frm = new FrmMasaKaydet(masalar);
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Seçili kayıt Silinecek. Onaylıyor Musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                masalarDal.Delete(context, m => m.Id == seciliid);
                masalarDal.Save(context);
                Listele();
            }
        }

        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliid);
                if (masalar.Durumu)
                {
                    masalar.Durumu = false;
                }
                else if (!masalar.Durumu)
                {
                    masalar.Durumu = true;
                }
                masalarDal.Save(context);
                Listele();
            }
        }

        private void btnRezerveDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliid);
                if (masalar.RezerveMi)
                {
                    masalar.RezerveMi = false;
                }
                else if (!masalar.RezerveMi)
                {
                    masalar.RezerveMi = true;
                }
                masalarDal.Save(context);
                Listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}