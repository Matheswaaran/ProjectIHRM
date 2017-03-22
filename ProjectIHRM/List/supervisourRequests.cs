﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectIHRM.List
{
    public partial class supervisourRequests : Form
    {
        public supervisourRequests()
        {
            InitializeComponent();
        }

        private void supervisourRequests_Load(object sender, EventArgs e)
        {
            MySqlCommand listSite = new MySqlCommand("SELECT * from hrm_database.super_req_table;", Utils.MySql.myConn);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
