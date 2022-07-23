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
namespace Phamracy_Mangement_GUI.UsersOption
{
    public partial class userBilling : usersMenuForm
    {
        bills billed = new bills();
        public userBilling(Muser account) : base(account)
        {
            InitializeComponent();
            billed.set_Biller(existingaccount);
        }

        private void userBilling_Load(object sender, EventArgs e)
        {
            this.txtBillID.Text = (billsDL.get_BillListCount() + 1).ToString();
            this.txtUserAccount.Text = Existingaccount.UserName;
            billed.set_Biller(Existingaccount);
            medicineDL.loadStock(Path.StockPath);
            //               data Grid View
            medicineListGVD.DataSource = billed.get_medicinesList();

            //               Combobox Data Source
            medicineDropComboBox.DataSource = medicineDL.getFullStockList();
            medicineDropComboBox.DisplayMember = "medicineName";
        }

        private void medicineDropComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            medicineListGVD.DataSource = null;
            int errorNumber = 0;
            medicine newMedicine = (medicine)medicineDropComboBox.SelectedItem;
            if (int.TryParse(txtQuantity.Text, out int result) && int.Parse(txtQuantity.Text) > 0)
            {
                if (int.Parse(txtQuantity.Text) <= int.Parse(txtLimitedStock.Text))
                {
                    newMedicine.sellMedicineAmount(int.Parse(txtQuantity.Text));// reduce in the original quantity
                    billed.addInBill(newMedicine, int.Parse(txtQuantity.Text));  // add in bill list 
                    txtLimitedStock.Text = newMedicine.get_totalQuantity().ToString();
                    txtQuantity.Text = "0";
                }
                else
                {
                    errorNumber = 1;
                }
                Databinding();
            }
            else
            {
                errorNumber = 2;
            }
            if (errorNumber == 1) MessageBox.Show("Stock is not Sufficient");
            if (errorNumber == 2) MessageBox.Show("Wrong Input !!");
            medicineListGVD.DataSource = billed.get_medicinesList();
        }
        private void Databinding()
        {
            medicineListGVD.DataSource = null;
            medicineListGVD.DataSource = billed.get_medicinesList();
            medicineListGVD.Refresh();
        }

        private void medicineDropComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            medicine selectedMedicine = (medicine)medicineDropComboBox.SelectedItem;
            txtLimitedStock.Text = selectedMedicine.get_totalQuantity().ToString();
        }

        private void btnFinalBill_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtDiscount.Text, out float result))
            {


                float n = billed.get_totalbill(float.Parse(txtDiscount.Text));
                billed.InvoiceNo = int.Parse(txtBillID.Text);
                billsDL.addInBillList(billed);
                /*
                              set as default for new form
                */
                medicineListGVD.DataSource = null;
                txtDiscount.Text = "0";
                txtLimitedStock.Text = "0";
                txtQuantity.Text = "0";
                DL.billsDL.StoreBills(Path.BillsPath);
                MessageBox.Show("Bill Added");
                billed = new bills();
            }
            else
            {
                MessageBox.Show("Wrong Discount !!!");
            }
        }
    }
}
