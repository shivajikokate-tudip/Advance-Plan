using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_Manager;
using WaterSystem_Manager.Factory;
using WaterSystem_Manager.Reciever;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmMeasurementDetails : Form
    {
        MeasurementReciever reciever = null;

        public FrmMeasurementDetails()
        {
            reciever = new MeasurementReciever();
            InitializeComponent();
            MeasurementList list = new MeasurementList(reciever);
            FillLVW(list.Execute());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void FillLVW(DataSet ds)
        {
            try
            {
                DataHelper helper = new DataHelper();
                listView1.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColNumber = 1, ColumnSize = 150, Header = "Measurement Name", Visible = true });
                list.Add(new ListViewColumnsInfo() { ColNumber = 0, ColumnSize = 100, Header = "Measurement Id", Visible = true });
                helper.filllvw(listView1, ds, list, ColumnHeaderStyle.Nonclickable, 0, 0);
            }
            catch (Exception err) { err.GetBaseException(); }
        }
    }
}
