using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectIHRM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void home_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(home_txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                home_txtUsername.Focus();
                return;
            }
            try
            {
                string pass = home_txtPassword.Text;
                string md5pass = Utils.Global.CreateMD5(pass);
                MySqlCommand select = new MySqlCommand("Select * FROM hrm_database.user_table where name = '" + home_txtUsername.Text + "' and password = '" + md5pass + "';" ,Utils.MySql.myConn);
                Utils.MySql.myConn.Open();
                MySqlDataReader loginReader = select.ExecuteReader();
                int count = 0;
                while (loginReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    Utils.Session.setDetails(int.Parse(loginReader["uid"].ToString()), loginReader["name"].ToString());
                    MessageBox.Show("Login successful as " + Utils.Session.getId().ToString() + " - " + Utils.Session.getUsername().ToString() + ".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    List.List listForm = new List.List();
                    listForm.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a valid credentials.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Utils.MySql.myConn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
