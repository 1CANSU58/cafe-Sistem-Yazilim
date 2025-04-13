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
using CafeSistem.WinForms.Masalar;
using CafeSistem.WinForms.Odemeler;
using DevExpress.XtraEditors;

namespace CafeSistem.WinForms.Satislar
{
	public partial class FrmSatislar: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private SatislarDal satislarDal = new SatislarDal();


        public FrmSatislar()
		{
            InitializeComponent();
            gridControl1.DataSource = satislarDal.GetAll(context);
        }

        private void btnSiparisDetaylari_Click(object sender, EventArgs e)
        {
            string satiskodu = gridView1.GetFocusedRowCellValue(colSatisKodu).ToString();
            bool paketSiparis = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(colPaketSiparisMi));
            FrmMasaSiparisleri frm = new FrmMasaSiparisleri(satisKodu:satiskodu,paketSiparis:paketSiparis);
            frm.ShowDialog();
        }

        private void btnOdemeHareketleri_Click(object sender, EventArgs e)
        {
            string satiskodu = gridView1.GetFocusedRowCellValue(colSatisKodu).ToString();
            FrmOdemeHareketleri frm = new FrmOdemeHareketleri(satiskodu:satiskodu);
            frm.ShowDialog();
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

        private void Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = e.Item.Tag.ToString();
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                if (e.Item==btnExcelExport)
                {
                    gridView1.ExportToXlsx(dialog.FileName);
                }
                else if (e.Item == btnWordExport)
                {
                    gridView1.ExportToDocx(dialog.FileName);
                }
                else if (e.Item == btnPdfExport)
                {
                    gridView1.ExportToPdf(dialog.FileName);
                }
            }
        }
    }
}