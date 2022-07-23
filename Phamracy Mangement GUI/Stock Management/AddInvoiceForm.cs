using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phamracy_Mangement_GUI.BL;
using Phamracy_Mangement_GUI.DL;
namespace Phamracy_Mangement_GUI.Stock_Management
{
    public partial class AddInvoiceForm : adminMainForm
    {
        List<medicine> StockList = new List<medicine>();
        public AddInvoiceForm(Muser account):base(account)
        {
            InitializeComponent();
            resetAttributes();
        }
        private void AddInvoiceForm_Load(object sender, EventArgs e)
        {
            medicineDVG.DataSource = StockList;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }
        private void storeStockInList()
        {
            foreach(var i in StockList)
            {
                medicine updatesMedicine = medicineDL.getInMedicineList(i.MedicineName);
                if(updatesMedicine!=null)
                {
                    updatesMedicine.UpdateMedicine(i);
                }
                else
                {
                    medicineDL.StockList.Add(i);
                }
            }
            storeAllDataBackup();
            MessageBox.Show("Susscively Added");
        }
        private void btnRomoveLast_Click(object sender, EventArgs e)
        {
            medicineDVG = null;
            if (StockList.Count > 0)
            {
                StockList.RemoveAt(StockList.Count - 1);
            }
            medicineDVG.DataSource = StockList;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            medicineDVG.DataSource = null;
            if(int.TryParse(txtPrice.Text,out int result) && int.TryParse(txtTotalPack.Text, out int resultPrice) && int.TryParse(txtPackSize.Text,out int resultPackQuantity))
            {
                if(int.Parse(txtPrice.Text)>0 && int.Parse(txtTotalPack.Text)>0 && int.Parse(txtPackSize.Text)>0)
                {
                    medicine addNew = new medicine(txtName.Text, int.Parse(txtPackSize.Text), int.Parse(txtPrice.Text), (int.Parse(txtPackSize.Text) * int.Parse(txtTotalPack.Text)));
                    StockList.Add(addNew);
                }
                else
                {
                    MessageBox.Show("Negative Input is not acceptable");
                }
            }
            else
            {
                MessageBox.Show("Wrong input Format");
            }
            medicineDVG.DataSource = StockList;
            resetAttributes();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            storeStockInList();
            medicineDVG.DataSource = null;
            StockList = null;
            resetAttributes();
        }
        private void resetAttributes()
        {
            txtName.Text = " ";
            txtPrice.Text="0";
            txtTotalPack.Text="0";
            txtPackSize.Text="0";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
