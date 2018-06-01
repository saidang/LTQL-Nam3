using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHGAGMIX
{
    public partial class frm_bc_NhapKho : Form
    {
        public frm_bc_NhapKho()
        {
            InitializeComponent();
        }

        private void frm_bc_NhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLLTDataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.QLLTDataSet1.DataTable2);

            this.reportViewer1.RefreshReport();
        }
    }
}
