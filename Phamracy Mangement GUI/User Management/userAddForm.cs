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
namespace Phamracy_Mangement_GUI.User_Management
{
    public partial class userAddForm : Form
    {
        public userAddForm()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MuserDL.getMuser(txtUserNmae.Text) != null)
            {
                lblIsAlreadyPresent.Text = "Already Present";
                lblIsAlreadyPresent.Show();
            }
            else
            {
                if (Muser.passwordvalidation(txtPasword.Text))
                {
                    if (checkBoxIsAdmin.Checked)
                    {
                        MuserDL.addInMuserList(new Muser(txtUserNmae.Text, txtPasword.Text, txtHint.Text, "Admin"));
                    }
                    if (!checkBoxIsAdmin.Checked)
                    {
                        MuserDL.addInMuserList(new Muser(txtUserNmae.Text, txtPasword.Text, txtHint.Text, "User"));
                    }
                    MessageBox.Show("Succcively Added");
                }
            }
            this.Hide();
        }
    }
}
