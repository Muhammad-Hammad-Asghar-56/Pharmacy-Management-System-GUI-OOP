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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MuserDL.Load(Path.MuserPath);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Muser account = MuserDL.getMuser(txtName.Text);
            if(account!=null)
            {
                if(account.getUserPassword() == txtPassword.Text)
                {
                    if(account.getUserRole() == "Admin")
                    {
                        this.Hide();
                        adminMainForm adminoptions = new adminMainForm(account);
                        adminoptions.Show();
                    }
                    if (account.getUserRole() == "User")
                    {
                        this.Hide();
                        usersMenuForm userScreen = new usersMenuForm(account);
                        userScreen.Show();   
                    }
                }
            }
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUP signUpScreen = new SignUP();
            signUpScreen.Show();
        }
    }
}
