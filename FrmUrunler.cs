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


namespace CafeSistem.WinForms.Urunler
{
	public partial class FrmUrunler: DevExpress.XtraEditors.XtraForm
    {

        private CafeContext context = new CafeContext();
        private UrunDal urunDal = new UrunDal();
        

        public FrmUrunler()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = urunDal.UrunListele(context);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            FrmUrunKaydet frm = new FrmUrunKaydet(new Urun());
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
            
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            FrmUrunKaydet frm = new FrmUrunKaydet(urunDal.GetByFilter(context,u=>u.Id==seciliid));
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Seçili kayıt Silinecek. Onaylıyor Musunuz?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                urunDal.Delete(context,u=>u.Id==seciliid);
                urunDal.Save(context);
                Listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}