using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectIHRM.Sample
{
    public partial class Dynamic : Form
    {
        public Dynamic()
        {
            InitializeComponent();
        }

        private void Dynamic_Load(object sender, EventArgs e)
        {
            WFUserControl control = new WFUserControl();
            for (int i = 0; i < 5; i++) { 
                int a=0, b=0;
                tableLayoutPanel1.Controls.Add(control,a,b);
                a += 1;
                b += 1;
            }
        }
    }
}
