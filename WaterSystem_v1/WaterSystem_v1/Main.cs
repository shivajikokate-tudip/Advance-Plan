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

        private Color SelectedLeftPanelColor()
        {
            return Color.FromArgb(31,43,55);
        }

        private Color NormalLeftPanelColor()
        {
            return pnlLeftPanel.BackColor;
        }

        private void lblHome_MouseHover(object sender, EventArgs e)
        {
          lblHome.BackColor =  SelectedLeftPanelColor();
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
           lblHome.BackColor =   NormalLeftPanelColor();
        }

        private void lblTransaction_MouseHover(object sender, EventArgs e)
        {
            lblMaster.BackColor = SelectedLeftPanelColor();
        }

        private void lblTransaction_MouseLeave(object sender, EventArgs e)
        {
            lblMaster.BackColor = NormalLeftPanelColor();
        }

        private void lblTransaction_MouseHover_1(object sender, EventArgs e)
        {
            lblTransaction.BackColor = SelectedLeftPanelColor();
        }

        private void lblTransaction_MouseLeave_1(object sender, EventArgs e)
        {
            lblTransaction.BackColor = NormalLeftPanelColor();
        }

        private void lblInventory_MouseHover(object sender, EventArgs e)
        {
            lblInventory.BackColor = SelectedLeftPanelColor();
        }

        private void lblInventory_MouseLeave(object sender, EventArgs e)
        {
            lblInventory.BackColor = NormalLeftPanelColor();
        }

        private void lblReports_MouseHover(object sender, EventArgs e)
        {
            lblReports.BackColor = SelectedLeftPanelColor();
        }

        private void lblReports_MouseLeave(object sender, EventArgs e)
        {
            lblReports.BackColor = NormalLeftPanelColor();
        }

        private void lblTransaction_MouseMove(object sender, MouseEventArgs e)
        {
            lblTransaction.BackColor = SelectedLeftPanelColor();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            OpentDashboard();
        }

        private void OpentDashboard()
        {
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.TopLevel = false;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();
        }

        private void lblMaster_Click(object sender, EventArgs e)
        {
            OpenMaster();
        }

        private void OpenMaster()
        {
            FrmMasterContainer master = new FrmMasterContainer();
            master.TopLevel = false;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(master);
            master.Dock = DockStyle.Fill;
            master.Show();
        }
    }
}
