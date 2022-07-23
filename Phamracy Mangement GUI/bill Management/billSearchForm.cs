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
namespace Phamracy_Mangement_GUI.bill_Management
{
    public partial class billSearchForm : Form
    {
        public billSearchForm()
        {
            InitializeComponent();
        }

        private void checkBoxIsMedineName_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxIsMedineName.Checked)
            {
                checkBoxIsBiller.Checked = false;
            }
            if (!checkBoxIsMedineName.Checked)
            {
                checkBoxIsBiller.Checked = true;
            }
        }

        private void billSearchForm_Load(object sender, EventArgs e)
        {
            checkBoxIsMedineName.Checked = true;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkBoxIsBiller.Checked)
            {
                dataGridView1.DataSource = billsDL.getMedinceByBiller(txtInput.Text);
            } 
            if(checkBoxIsMedineName.Checked)
            {
                dataGridView1.DataSource = billsDL.getMedinceByMedicine(txtInput.Text);
            }
        }

        private void checkBoxIsBiller_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsBiller.Checked)
            {
                checkBoxIsMedineName.Checked = false;
            }
            if (!checkBoxIsBiller.Checked)
            {
                checkBoxIsMedineName.Checked = true;
            }
        }
    }
}
