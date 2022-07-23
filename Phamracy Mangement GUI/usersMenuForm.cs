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
using Phamracy_Mangement_GUI.UsersOption;
namespace Phamracy_Mangement_GUI
{
    public partial class usersMenuForm : Form
    {
        protected Muser existingaccount = new Muser();
        public Muser Existingaccount { get => existingaccount; set => existingaccount = value; }
        public usersMenuForm(Muser account)
        {
            InitializeComponent();
            this.Existingaccount = account;
        }
        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }
        private void billIngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            userBilling userBillingScreen = new userBilling(existingaccount);
            userBillingScreen.Show();
        }

        private void billHIstoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserBillHistory bills = new UserBillHistory();
            bills.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
