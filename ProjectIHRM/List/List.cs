using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectIHRM.List
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void list_web_Click(object sender, EventArgs e)
        {
            //this.Hide();
            siteList siteForm = new siteList();
            siteForm.Show();
        }

        private void sample_Click(object sender, EventArgs e)
        {
            Sample.Dynamic dy = new Sample.Dynamic();
            dy.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void list_contractor_Click(object sender, EventArgs e)
        {
            contractorList contractorForm = new contractorList();
            contractorForm.Show();
        }

        private void list_employees_Click(object sender, EventArgs e)
        {
            employeeList employeeForm = new employeeList();
            employeeForm.Show();
        }

        private void list_super_req_Click(object sender, EventArgs e)
        {
            supervisourRequests requestForm = new supervisourRequests();
            requestForm.Show();
        }

        private void lsit_logout_Click(object sender, EventArgs e)
        {
            Utils.Session.setDetails(0, "");
            MessageBox.Show("Session :  " + Utils.Session.getId().ToString() + " - " + Utils.Session.getUsername().ToString() + ".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void list_supervisour_Click(object sender, EventArgs e)
        {
            supervisourList supervisourForm = new supervisourList();
            supervisourForm.Show();
        }
    }
}
