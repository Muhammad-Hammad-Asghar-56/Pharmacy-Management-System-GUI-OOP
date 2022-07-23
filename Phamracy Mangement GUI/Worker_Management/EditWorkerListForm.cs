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
using Phamracy_Mangement_GUI.DL;
using Phamracy_Mangement_GUI;
namespace Phamracy_Mangement_GUI.Worker_Management
{
    public partial class EditWorkerListScreen : adminMainForm
    {
        public EditWorkerListScreen(Muser account): base(account)
        {
            InitializeComponent();
        }

        private void EditWorkerListScreen_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = workerDL.getFullWorkerList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            worker selectedWorker = (worker) dataGridView1.CurrentRow.DataBoundItem;
            if(dataGridView1.Columns["Edit"].Index == e.ColumnIndex)
            {
                editWorkerDetailForm editSeletedWorker = new editWorkerDetailForm(selectedWorker);
                editSeletedWorker.ShowDialog();
            }
            if(dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                workerDL.getFullWorkerList().Remove(selectedWorker);
            }
            storeAllDataBackup();
        }
    }
}
