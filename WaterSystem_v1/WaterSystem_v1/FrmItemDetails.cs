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
    public partial class FrmItemDetails : Form
    {
        public FrmItemDetails()
        {
            InitializeComponent();
        }

        private void Configuration()
        {
            ovlItem.RowHeight = 25;
            ovlItem.EmptyListMsg = "Please start with item.";
            ovlItem.HeaderStyle = ColumnHeaderStyle.Nonclickable;

        }

        private void FillOlv()
        {
            try
            {
                ovlItem.Clear();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
