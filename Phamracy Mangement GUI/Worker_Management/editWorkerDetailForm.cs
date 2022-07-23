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
    public partial class editWorkerDetailForm : Form
    {
        worker selectedWorker;
        public editWorkerDetailForm(worker selected)
        {
            this.SelectedWorker = selected;
            InitializeComponent();
        }

        internal worker SelectedWorker { get => selectedWorker; set => selectedWorker = value; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            int age;
            int salary;
            if (int.TryParse(txtSalary.Text, out int result) && int.Parse(txtSalary.Text) > 0)
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
                                MessageBox.Show("Succively Added");
                                
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
            this.Hide();
        }

        private void editWorkerDetailForm_Load(object sender, EventArgs e)
        {
            txtAge.Text = selectedWorker.Age.ToString();
            txtName.Text = selectedWorker.PersonName.ToString();
            txtPost.Text = selectedWorker.Post.ToString();
            txtRelegion.Text = selectedWorker.Religion.ToString();
            txtSalary.Text = selectedWorker.Salary.ToString();
            
            txtAge.Show();
            txtName.Show();
            txtPost.Show();
            txtRelegion.Show();
            txtSalary.Show();
        }
    }
}
