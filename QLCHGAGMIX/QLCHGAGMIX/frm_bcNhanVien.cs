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
    public partial class frm_bcNhanVien : Form
    {
        public frm_bcNhanVien()
        {
            InitializeComponent();
        }

        private void frm_bcCTHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLLTDataSet1.DataTable1' table. You can move, or remove it, as needed.
         //   this.DataTable1TableAdapter.Fill(this.QLLTDataSet1.DataTable1);
            // TODO: This line of code loads data into the 'QLLTDataSet1.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.QLLTDataSet1.nhanvien);
            // TODO: This line of code loads data into the 'QLLTDataSet1.nhanvien' table. You can move, or remove it, as needed.
           // this.nhanvienTableAdapter.Fill(this.QLLTDataSet1.nhanvien);
            // TODO: This line of code loads data into the 'QLLTDataSet.DataTable1' table. You can move, or remove it, as needed.
           // this.DataTable1TableAdapter.Fill(this.QLLTDataSet.DataTable1);
            // TODO: This line of code loads data into the 'QLLTDataSet.cthd' table. You can move, or remove it, as needed.
           // this.cthdTableAdapter.Fill(this.QLLTDataSet.cthd);
            // TODO: This line of code loads data into the 'QLLTDataSet1.cthd' table. You can move, or remove it, as needed.
           // this.cthdTableAdapter.Fill(this.QLLTDataSet1.cthd);
            // TODO: This line of code loads data into the 'QLLTDataSet.DataTable1' table. You can move, or remove it, as needed.
         //   this.DataTable1TableAdapter.Fill(this.QLLTDataSet.DataTable1);
            // TODO: This line of code loads data into the 'QLLTDataSet1.DataTable1' table. You can move, or remove it, as needed.
          //  this.DataTable1TableAdapter.Fill(this.QLLTDataSet1.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
