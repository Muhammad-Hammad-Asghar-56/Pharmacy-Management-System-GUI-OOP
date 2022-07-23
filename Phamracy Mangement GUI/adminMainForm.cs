using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phamracy_Mangement_GUI.bill_Management;
using Phamracy_Mangement_GUI.User_Management;
using Phamracy_Mangement_GUI.Worker_Management;
using Phamracy_Mangement_GUI.Stock_Management;
using Phamracy_Mangement_GUI.BL;
using Phamracy_Mangement_GUI.DL;
namespace Phamracy_Mangement_GUI
{
    public partial class adminMainForm : Form
    {
        private Muser existingAccount;

        public Muser ExistingAccount { get => existingAccount; set => existingAccount = value; }

        public adminMainForm(Muser existingAccount)
        {
            InitializeComponent();
            this.ExistingAccount = existingAccount;
        }
        private void billHistoryToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            BillHistoryForm billHistoryScreen = new BillHistoryForm(ExistingAccount);
            billHistoryScreen.StartPosition = FormStartPosition.Manual;
            billHistoryScreen.Location = this.Location;
            billHistoryScreen.Size = new Size();
            billHistoryScreen.Size = this.Size;
            billHistoryScreen.Show();
            this.Hide();
        }
        private void adminMainForm_Load(object sender, EventArgs e)
        {
        }
        private void billToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            billsForm BillingScreen = new billsForm(ExistingAccount);
            BillingScreen.StartPosition = FormStartPosition.Manual;//    Size 
            BillingScreen.Location = this.Location;                //         same 
            BillingScreen.Size = new Size();                       //               as 
            BillingScreen.Size = Size;                             //                  privous screen
            this.Hide();
            BillingScreen.Show();
           
        }
        private void minimumPriceBillToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            bills minimumBill = billsDL.getMinimiumBill();
            ShowBillForm minimumBillShowScreen = new ShowBillForm(minimumBill);
            minimumBillShowScreen.ShowDialog();
        }
        private void maximiumPriceBillToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            bills maximumBill = billsDL.getMaximiumBill();
            ShowBillForm maximumBillShowScreen = new ShowBillForm(maximumBill);
            maximumBillShowScreen.ShowDialog();
        }
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            userAddForm addUser = new userAddForm();
            addUser.ShowDialog();
            storeAllDataBackup();
        }
        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            EditUserForm editListView = new EditUserForm(ExistingAccount);
            editListView.StartPosition = FormStartPosition.Manual;
            editListView.Location = this.Location;
            editListView.Size = new Size();
            editListView.Size = this.Size;
            this.Hide();
            editListView.Show();
        }
        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*    Show  Muser DL only
             */
        }
        private void addNewWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            HireStaffForm hirinsgstaffScreen=new HireStaffForm(existingAccount);
            hirinsgstaffScreen.StartPosition = FormStartPosition.Manual;
            hirinsgstaffScreen.Location = this.Location;
            hirinsgstaffScreen.Size = new Size();
            hirinsgstaffScreen.Size = this.Size;
            this.Hide();
            hirinsgstaffScreen.Show();
        }
        private void viewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            this.Hide();
            EditWorkerListScreen editWorkerList = new EditWorkerListScreen(ExistingAccount);
            editWorkerList.Show();
        }
        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            ShowWorkersListForm workerListShowScreen = new ShowWorkersListForm(workerDL.getFullWorkerList().OrderByDescending(c => c.Age).ToList());
            workerListShowScreen.ShowDialog();
        }
        private void asscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            ShowWorkersListForm workerListShowScreen = new ShowWorkersListForm(workerDL.getFullWorkerList().OrderBy(c => c.Age).ToList());
            workerListShowScreen.ShowDialog();
        }
        private void searchByOtherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            billSearchForm billigSearchScreen = new billSearchForm();
            billigSearchScreen.ShowDialog();
        }
        private void enterInovoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void aDDStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            AddInvoiceForm AddStock = new AddInvoiceForm(ExistingAccount);
            AddStock.StartPosition = FormStartPosition.Manual;
            AddStock.Location = this.Location;
            AddStock.Size = new Size();
            AddStock.Size = this.Size;
            this.Hide();
            AddStock.Show();
        }
        private void thresholdStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            thresholdMedicineForm thresholdScreen = new thresholdMedicineForm(ExistingAccount);
            thresholdScreen.StartPosition = FormStartPosition.Manual;
            thresholdScreen.Location = this.Location;
            thresholdScreen.Size = new Size();
            thresholdScreen.Size = this.Size;
            this.Hide();
            thresholdScreen.Show();
        }
        private void stockSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockSummary stockSummaryScreen = new stockSummary();
            stockSummaryScreen.ShowDialog();
        }

        private void saleSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleSummary saleSummaryScreen = new saleSummary();
            saleSummaryScreen.ShowDialog();
        }
        public  void  storeAllDataBackup()
        {
            MuserDL.StoreAccounts(Path.MuserPath);
            workerDL.StoreWorkers(Path.WorkerPath);
            medicineDL.storeStock(Path.StockPath);
            billsDL.StoreBills(Path.BillsPath);
        }
        public  void LoadAllDataBackup()
        {
            MuserDL.Load(Path.MuserPath);
            workerDL.Load (Path.WorkerPath);
            medicineDL.loadStock(Path.StockPath);
            billsDL.Load(Path.BillsPath);
        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
            billsForm BillingScreen = new billsForm(ExistingAccount);
            BillingScreen.StartPosition = FormStartPosition.Manual;//    Size 
            BillingScreen.Location = this.Location;                //         same 
            BillingScreen.Size = new Size();                       //               as 
            BillingScreen.Size = Size;                             //                  privous screen
            this.Hide();
            BillingScreen.Show();

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAllDataBackup();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billsDL.Load(Path.BillsPath);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuserDL.Load(Path.MuserPath);
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicineDL.loadStock(Path.StockPath);
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workerDL.Load(Path.WorkerPath);
        }
    }
}
 