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

namespace ProjectIHRM.Home
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
            SqlCommand list_select = new SqlCommand("SELECT * FROM site_table;");
            Utils.MySql.myConn.Open();
            SqlDataReader lsitReader = list_select.ExecuteReader();
        }
    }
}
