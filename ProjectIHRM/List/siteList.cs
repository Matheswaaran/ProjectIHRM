using MySql.Data.MySqlClient;
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
    public partial class siteList : Form
    {
        public siteList()
        {
            InitializeComponent();
        }

        public object MysqlCommand { get; private set; }

        private void siteList_Load(object sender, EventArgs e)
        {
            MySqlCommand listSite = new MySqlCommand("SELECT * from hrm_database.site_table;", Utils.MySql.myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = listSite;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                GridView.DataSource = bSource;
                sda.Update(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Add a CheckBox Column to the DataGridView at the first position.
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "checkBoxColumn";
            GridView.Columns.Insert(0, checkBoxColumn);
        }

        private void site_display_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            foreach (DataGridViewRow row in GridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    message += Environment.NewLine;
                    message += row.Cells["Name"].Value.ToString();
                }
            }

            MessageBox.Show("Selected Values" + message);
        }
    }
}
