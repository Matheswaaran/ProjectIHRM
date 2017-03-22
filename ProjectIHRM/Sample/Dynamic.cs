using ProjectIHRM.Utils;
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
        }

        private void list_web_Click(object sender, EventArgs e)
        {
            var n = 5;
            for (int i = 0; i < n; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("Label {0}", i);
                //Position label on screen
                label.Left = 10;
                label.Top = (i + 1) * 20;
                //Create textbox
                TextBox textBox = new TextBox();
                //Position textbox on screen
                textBox.Left = 120;
                textBox.Top = (i + 1) * 20;
                //Add controls to form
                this.Controls.Add(label);
                this.Controls.Add(textBox);
            }

        }
    }
}
