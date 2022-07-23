using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phamracy_Mangement_GUI.DL;
using Phamracy_Mangement_GUI.BL;
namespace Phamracy_Mangement_GUI.bill_Management
{
    public partial class BillHistoryForm : adminMainForm
    {
        public BillHistoryForm(Muser existingaccount):base(existingaccount)
        {
            InitializeComponent();
        }

        private void BillHistoryGVD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bills selesctedBill = (bills) BillHistoryGVD.CurrentRow.DataBoundItem;// retrive row from the grid
            if(BillHistoryGVD.Columns[" "].Index == e.ColumnIndex )
            {
                ShowBillForm showMedicine = new ShowBillForm(selesctedBill);
            }

        }

        private void BillHistoryForm_Load(object sender, EventArgs e)
        {
            BillHistoryGVD.DataSource = null;
            BillHistoryGVD.DataSource = billsDL.getFullBillList().Select(c => new { c.InvoiceNo, c.ActualBill, c.DiscPercent, c.PayableBill, c.get_billerObject().UserName}).ToList();
            // usersGV.DataSource = MUserDL.UsersList.Select(c => new { c.UserName, c.UserPassword, c.UserRole, c.DateTime.Hours, c.DateTime.Minutes, c.DateTime.Seconds }).ToList()
                BillHistoryGVD.DataSource = billsDL.getFullBillList();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtInvoiceNo.Text,out int result))
            {
                if(int.Parse(txtInvoiceNo.Text) <= billsDL.get_BillListCount())
                {
                    ShowBillForm DisplaySelectedBill=new ShowBillForm(billsDL.get_BillListItem(int.Parse(txtInvoiceNo.Text)));
                    DisplaySelectedBill.ShowDialog();

                }

            }
            else
            {
                MessageBox.Show("Not in Correct Format");
            }
        }
    }
}
