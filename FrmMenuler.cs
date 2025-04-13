using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeSistem.Entities.Models;
using DevExpress.XtraEditors;

namespace CafeSistem.WinForms.Menuler
{
	public partial class FrmMenuler: DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        public FrmMenuler()
		{
            InitializeComponent();
            context.Menu.Load();
            gridControl1.DataSource = context.Menu.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            gridView1.RefreshData();
            MessageBox.Show(" İlgili İşlem Başarılıyla Gerçekleştirildi ", "BİLGİ", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Menü Silinsin Mi ? ","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                context.SaveChanges();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}