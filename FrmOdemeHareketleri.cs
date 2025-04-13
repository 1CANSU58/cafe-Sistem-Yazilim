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

namespace CafeSistem.WinForms.Odemeler
{
	public partial class FrmOdemeHareketleri: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private OdemeHareketleriDal odemeHareketleriDal = new OdemeHareketleriDal();

        public FrmOdemeHareketleri(string satiskodu=null)
		{
            InitializeComponent();
            if (satiskodu==null)
            {
                gridControl1.DataSource = odemeHareketleriDal.GetAll(context);
            }
            else if (satiskodu != null)
            {
                gridControl1.DataSource = odemeHareketleriDal.GetAll(context,o=>o.SatisKodu==satiskodu);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYenileListele_Click(object sender, EventArgs e)
        {
            //?
            gridControl1.RefreshDataSource();
        }
    }
}