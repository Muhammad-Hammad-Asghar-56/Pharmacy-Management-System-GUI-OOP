using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phamracy_Mangement_GUI.bill_Management
{
    public partial class saleSummary : Form
    {
        public saleSummary()
        {
            InitializeComponent();
        }

        private void saleSummary_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DL.billsDL.getFullBillList();
            txtActualBill.Text = DL.billsDL.getTotalActualBills().ToString();
            txtDiscount.Text = DL.billsDL.getTotaldiscount().ToString();
            lblSaletotal.Text = DL.billsDL.getTotalPayBills().ToString();
        }
    }
}
