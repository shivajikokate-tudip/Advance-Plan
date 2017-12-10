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
    public partial class FrmMasterContainer : Form
    {
        public FrmMasterContainer()
        {
            InitializeComponent();
            if (tabMasterContainer.SelectedIndex == 0)
            {
                FrmMeasurementDetails measurement = new FrmMeasurementDetails();
                Helpers.FormHelper.OpenFormInContainer(tabMeasurement, measurement);
            }
        }

        private void tabMasterContainer_Click(object sender, EventArgs e)
        {
            if (tabMasterContainer.SelectedIndex == 0)
            {
                FrmMeasurementDetails measurement = new FrmMeasurementDetails();
                Helpers.FormHelper.OpenFormInContainer(tabMeasurement, measurement);
            }
        }
    }
}
