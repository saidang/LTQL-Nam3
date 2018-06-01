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
    public partial class frm_bcCTHD : Form
    {
        public frm_bcCTHD()
        {
            InitializeComponent();
        }

        private void frm_CTHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLLTDataSet1.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.QLLTDataSet1.DataTable3);
            // TODO: This line of code loads data into the 'QLLTDataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.QLLTDataSet1.DataTable2);
            // TODO: This line of code loads data into the 'QLLTDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.QLLTDataSet1.DataTable1);
            // TODO: This line of code loads data into the 'QLLTDataSet1.DataTable1' table. You can move, or remove it, as needed.
           // this.DataTable1TableAdapter.Fill(this.QLLTDataSet1.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
