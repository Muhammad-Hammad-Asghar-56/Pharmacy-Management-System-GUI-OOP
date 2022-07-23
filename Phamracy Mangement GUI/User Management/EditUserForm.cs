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
namespace Phamracy_Mangement_GUI.User_Management
{
    public partial class EditUserForm : adminMainForm   
    {
        public EditUserForm(Muser Account): base (Account)
        {
            InitializeComponent();
        }
        private void EditUserForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MuserDL.getFullMuserList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Muser selectedAccount = (Muser)dataGridView1.CurrentRow.DataBoundItem;// retrive row from the grid
            if (dataGridView1.Columns["Edit"].Index == e.ColumnIndex)
            {
                editDetailsForm editSelectedAccount = new editDetailsForm(selectedAccount);
                editSelectedAccount.ShowDialog();
            }
            else if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {

                MuserDL.getFullMuserList().Remove(selectedAccount);
                storeAllDataBackup();
                DataBinding();
            }
            storeAllDataBackup();
        }
        private void DataBinding()
        {
            dataGridView1.DataSource = new object();
            dataGridView1.DataSource = MuserDL.usersList;
            dataGridView1.Refresh();
        }
    }
}
