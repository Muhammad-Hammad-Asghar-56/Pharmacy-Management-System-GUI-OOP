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
namespace Phamracy_Mangement_GUI.Worker_Management
{
    public partial class HireStaffForm : adminMainForm
    {
        public HireStaffForm(Muser account) : base(account)
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int age;
            int salary;
            if (int.TryParse(txtSalary.Text,out int result) && int .Parse(txtSalary.Text) > 0)
            {
                if (int.TryParse(txtAge.Text, out int resultAge) && int.Parse(txtAge.Text) > 18)
                {
                    age = int.Parse(txtAge.Text);
                    salary = int.Parse(txtSalary.Text);
                    if (txtName.Text != null && txtName.Text != " ")
                    {
                        if (txtPost.Text != null && txtPost.Text != " ")
                        {
                            if (txtRelegion.Text != null && txtRelegion.Text != " ")
                            {
                                workerDL.addInWorkerList(new worker(salary, age, txtName.Text, txtRelegion.Text, txtPost.Text));
                                storeAllDataBackup();
                                MessageBox.Show("Succively Added");
                                resetAttributes();
                            }
                            else
                            {
                                MessageBox.Show("Religion is Empty");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Post is Empty");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name is Empty");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Age Enterd");
                }
            }
            else
            {
                MessageBox.Show("Salary is Non negative");
            }
        }

        private void resetAttributes()
        {
            txtAge.Text = "0";
            txtName.Text = " ";
            txtPost.Text = " ";
            txtRelegion.Text = " ";
            txtSalary.Text = "0";

            txtAge.Show();
            txtName.Show();
            txtPost.Show();
            txtRelegion.Show();
            txtSalary.Show();
        }

        private void HireStaffForm_Load(object sender, EventArgs e)
        {
            resetAttributes();
        }
    } 
}
