using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_Manager.Reciever;
using WaterSystem_Manager.Factory;

namespace WaterSystem_v1
{
    public partial class FrmMasterContainer : Form
    {

        public FrmMasterContainer()
        {
            InitializeComponent();
            OpenTab(0);
        }

        private void tabMasterContainer_Click(object sender, EventArgs e)
        {
            OpenTab(tabMasterContainer.SelectedIndex);
        }

        private void OpenTab(int tabIndex)
        {
            if (tabIndex == 0)
            {
                FrmMeasurementDetails measurement = new FrmMeasurementDetails();
                Helpers.FormHelper.OpenFormInContainer(tabMeasurement, measurement);
            }
        }

       
    }
}
