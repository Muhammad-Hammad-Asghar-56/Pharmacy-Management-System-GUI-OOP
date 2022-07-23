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
namespace Phamracy_Mangement_GUI.Worker_Management
{
    public partial class ShowWorkersListForm : Form
    {
        List<worker> workerList;
        public ShowWorkersListForm(List<worker> workerList)
        {
            InitializeComponent();
            this.workerList = workerList;
        }

        private void ShowWorkersListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = workerList;
        }
    }
}
