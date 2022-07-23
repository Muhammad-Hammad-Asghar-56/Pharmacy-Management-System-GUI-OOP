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
namespace Phamracy_Mangement_GUI.User_Management
{
    public partial class editDetailsForm : Form
    {
        private Muser editAccount;
        public Muser EditAccount { get => editAccount; set => editAccount = value; }
        public editDetailsForm(Muser editAccount)
        {
            this.editAccount = editAccount;
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            EditAccount.UserName = txtUserNmae.Text;
            EditAccount.UserPassword = txtPasword.Text;
            EditAccount.PasswordHint = txtHint.Text;
            if(checkBoxIsAdmin.Checked) EditAccount.UserRole = "Admin";
            if(!checkBoxIsAdmin.Checked)EditAccount.UserRole = "User";
            MessageBox.Show("Succecively Edit");
            this.Hide();
        }

        private void editDetailsForm_Load(object sender, EventArgs e)
        {
            txtUserNmae.Text = editAccount.UserName;
            txtPasword.Text = editAccount.UserPassword;
            txtHint.Text = editAccount.PasswordHint;
            txtPasword.Show();
            txtHint.Show();
            txtUserNmae.Show();
        }
    }
}
