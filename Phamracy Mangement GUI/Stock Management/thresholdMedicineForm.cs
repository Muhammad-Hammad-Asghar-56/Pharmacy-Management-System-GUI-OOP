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
namespace Phamracy_Mangement_GUI.Stock_Management
{
    public partial class thresholdMedicineForm : adminMainForm
    {
        public thresholdMedicineForm(Muser Account): base(Account)
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtQty.Text,out int resultQTY) && int.Parse(txtQty.Text) > 0)
            {
                dataGridView1.DataSource = medicineDL.getThresholdQuantity(int.Parse(txtQty.Text));
            }
            else
            {
                MessageBox.Show("Wrong Input");
            }
        }
    }
}
