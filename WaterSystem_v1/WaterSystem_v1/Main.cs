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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            OpentDashboard();
        }       

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            var control = (Control)sender;
            control.BackColor = NormalLeftPanelColor();
        }

        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            var control = (Control)sender;
            control.BackColor = SelectedLeftPanelColor();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            OpentDashboard();
        }      

        private void lblMaster_Click(object sender, EventArgs e)
        {
            OpenMaster();
        }        

        private void lblInventory_Click(object sender, EventArgs e)
        {
            OpenInventory();
        }  

        #region Manual
        // Left Panel Color
        private Color SelectedLeftPanelColor()
        {
            return Color.FromArgb(31, 43, 55);
        }

        private Color NormalLeftPanelColor()
        {
            return pnlLeftPanel.BackColor;
        }
        
        // Open Dashboard tab
        private void OpentDashboard()
        {
            FrmDashboard dashboard = new FrmDashboard();
            Helpers.FormHelper.OpenForm(pnlContainer, dashboard);
        }

        //Open Master Tab
        private void OpenMaster()
        {
            FrmMasterContainer master = new FrmMasterContainer();
            Helpers.FormHelper.OpenForm(pnlContainer, master);
        }

        // Open Invetory Tab
        private void OpenInventory()
        {
            FrmInventoryContainer inventory = new FrmInventoryContainer();
            Helpers.FormHelper.OpenForm(pnlContainer, inventory);
        }

        #endregion

    }
}
