using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phamracy_Mangement_GUI.BL;
namespace Phamracy_Mangement_GUI.bill_Management
{
    public partial class ShowBillForm : Form
    {
        bills showBill;
        public ShowBillForm(bills showBill)
        {
            InitializeComponent();
            this.showBill = showBill;
        }

        private void ShowBillForm_Load(object sender, EventArgs e)
        {
            txtAcutalBill.Text = showBill.ActualBill.ToString();
            txtPay.Text = showBill.PayableBill.ToString();
             txtBiller.Text=showBill.get_Biller();
            txtInvoiceNo.Text = showBill.InvoiceNo.ToString();
            txtDiscount.Text = showBill.DiscPercent.ToString();
            ShowBIlGVD.DataSource = showBill.Medicines;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
