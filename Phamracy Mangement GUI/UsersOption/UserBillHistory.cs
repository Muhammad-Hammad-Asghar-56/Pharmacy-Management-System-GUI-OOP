using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phamracy_Mangement_GUI.UsersOption
{
    public partial class UserBillHistory : Form
    {
        public UserBillHistory()
        {
            InitializeComponent();
        }

        private void UserBillHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DL.billsDL.getFullBillList();
        }
    }
}
