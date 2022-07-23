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
namespace Phamracy_Mangement_GUI
{
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            if (Muser.passwordvalidation(txtPassword.Text))
            {
                if (checkboxAdmin.Checked)
                {
                    MuserDL.addInMuserList(new Muser(txtUserName.Text, txtPassword.Text, txtHint.Text, "Admin"));
                }
                else
                {
                    MuserDL.addInMuserList(new Muser(txtUserName.Text, txtPassword.Text, txtHint.Text, "User"));
                }
               MessageBox.Show("Succecfully Add");
            }
            else
            {
                MessageBox.Show("Passsord should be Strong");
            }
            this.Hide();
            MuserDL.StoreAccounts(Path.MuserPath);
            LoginForm loginScreen = new LoginForm();
            loginScreen.Show();
        }

        private void SignUP_Load(object sender, EventArgs e)
        {

        }
    }
}
