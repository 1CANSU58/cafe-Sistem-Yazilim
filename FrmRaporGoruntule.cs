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
using DevExpress.XtraReports.UI;

namespace CafeSistem.WinForms.RaporFormlari
{
	public partial class FrmRaporGoruntule: DevExpress.XtraEditors.XtraForm
	{
        public FrmRaporGoruntule(XtraReport report)
		{
            InitializeComponent();
            documentViewer1.DocumentSource = report;
        }
	}
}