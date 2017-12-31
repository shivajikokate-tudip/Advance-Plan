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
    public partial class FrmAddEditCustomer : Form
    {
        public FrmAddEditCustomer()
        {
            InitializeComponent();
            toggleActive.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Iphone;
            toggleActive.Size = new Size(68, 22);
            toggleActive.OnText = "Yes";
            toggleActive.OnFont = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            toggleActive.OnForeColor = Color.White;
            toggleActive.OffText = "No";
            toggleActive.OffFont = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            toggleActive.OffForeColor = Color.FromArgb(92, 92, 92);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
