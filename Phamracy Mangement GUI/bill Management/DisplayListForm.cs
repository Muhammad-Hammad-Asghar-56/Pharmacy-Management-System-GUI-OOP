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
    public partial class DisplayListForm : adminMainForm
    {
        private List<bills> BillsList;
        public  DisplayListForm(Muser account,List<bills> BillsList): base(account)
        {
            this.BillsList = BillsList;
            InitializeComponent();
        }

        private void DisplayListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BillsList;
        }
    }
}