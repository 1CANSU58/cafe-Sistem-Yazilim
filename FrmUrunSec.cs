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
	public partial class FrmUrunSec: DevExpress.XtraEditors.XtraForm
    {

        private CafeContext context = new CafeContext();
        private UrunDal urunDal = new UrunDal();
        public Urun urunModel;
        public bool secildi;

        public FrmUrunSec()
		{
            InitializeComponent();
            gridControl1.DataSource = urunDal.UrunListele(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int urunId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                urunModel = urunDal.GetByFilter(context, u => u.Id == urunId);
                secildi = true;
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}