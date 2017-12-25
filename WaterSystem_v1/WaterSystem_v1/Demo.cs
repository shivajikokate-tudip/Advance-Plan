using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterSystem_v1
{
    public partial class Demo : Form
    {
        int count = 0;
        public Demo()
        {
            InitializeComponent();
            panel1.Visible = true;
           // panel2.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                panel2.SendToBack();
                panel1.BringToFront();
            }
            else {
                panel1.SendToBack();
                panel2.BringToFront();
            }
        }

        private void ovlMeasurement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
