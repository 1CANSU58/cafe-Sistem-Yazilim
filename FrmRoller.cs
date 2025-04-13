using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.Remoting.Contexts;
using CafeSistem.Entities.Models;
using System.Data.Entity;
using CafeSistem.WinForms.yetki;

namespace CafeSistem.WinForms.Kullanicilar
{
	public partial class FrmRoller: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        

        public FrmRoller(bool yetki)
		{
            InitializeComponent();
            if (yetki == false)
            {
                FrmYetkiKontrol frm = new FrmYetkiKontrol();
                frm.ShowDialog();
            }
            else if (yetki == true)
            {
                context.Kullanicilar.Load();
                gridControl1.DataSource = context.Kullanicilar.Local.ToBindingList();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Kullanıcı Silinsin Mi ? , TEKRAR İŞLEM GERÇEKLEŞTİRMEK İÇİN YETKİ GEREKTİRİR !", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();
                bool yetki = false;
                this.Close();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();
            MessageBox.Show(" İlgili İşlem Başarılıyla Gerçekleştirildi, TEKRAR İŞLEM İÇİN YETKİ GEREKTİRİR ! ", "BİLGİ", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            bool yetki = false;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            bool yetki = false;
            this.Close();

        }
    }
}