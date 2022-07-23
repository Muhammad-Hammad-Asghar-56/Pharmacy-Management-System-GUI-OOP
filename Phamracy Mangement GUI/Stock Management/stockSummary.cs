using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phamracy_Mangement_GUI.Stock_Management
{
    public partial class stockSummary : Form
    {
        public stockSummary()
        {
            InitializeComponent();
        }

        private void stockSummary_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DL.medicineDL.getFullStockList();
            txtTotal.Text = DL.medicineDL.getPriceTotal().ToString();
        }
    }
}
