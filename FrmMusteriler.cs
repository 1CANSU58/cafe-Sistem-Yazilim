﻿using System;
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

namespace CafeSistem.WinForms.Musteriler
{
	public partial class FrmMusteriler: DevExpress.XtraEditors.XtraForm
	{
        private CafeContext context = new CafeContext();

        public FrmMusteriler()
		{
            InitializeComponent();
			context.Musteriler.Load();
            gridControl1.DataSource = context.Musteriler.Local.ToBindingList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            if (MessageBox.Show("İlgili İşlem Başarıyla Gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
            {
                gridView1.RefreshData();
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Müşteri Silinsin Mi ? ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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