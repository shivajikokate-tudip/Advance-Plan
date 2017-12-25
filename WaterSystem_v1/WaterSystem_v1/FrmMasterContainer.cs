using System;
using System.Windows.Forms;

namespace WaterSystem_v1
{
    public partial class FrmMasterContainer : Form
    {
        FrmMeasurementDetails measurement = null;
        FrmItemDetails item = null;
        FrmCustomerDetails customer = null;
        FrmSupplierDetails supplier = null;
        FrmEmployeeDetails employee = null;
        FrmAccountDetails account = null;
        FrmSubAccountDetails subAccount = null;
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
            switch (tabIndex)
            {
                case Tabs.Measurement:
                    if (measurement == null)
                    {
                        measurement = new FrmMeasurementDetails();
                        Helpers.FormHelper.OpenForm(tabMeasurement, measurement);
                    }
                    break;
                case Tabs.Item:
                    if (item == null)
                    {
                        item = new FrmItemDetails();
                        Helpers.FormHelper.OpenForm(tabItem, item);
                    }
                    break;
                case Tabs.Customer:
                    if (customer == null)
                    {
                        customer = new FrmCustomerDetails();
                        Helpers.FormHelper.OpenForm(tabCustomer, customer);
                    }
                    break;
                case Tabs.Supplier:
                    if (supplier == null)
                    {
                        supplier = new FrmSupplierDetails();
                        Helpers.FormHelper.OpenForm(tabSupplier, supplier);
                    }
                    break;
                case Tabs.Employee:
                    if (employee == null)
                    {
                        employee = new FrmEmployeeDetails();
                        Helpers.FormHelper.OpenForm(tabEmployee, employee);
                    }
                    break;
                case Tabs.Account:
                    if (account == null)
                    {
                        account = new FrmAccountDetails();
                        Helpers.FormHelper.OpenForm(tabAccount, account);
                    }
                    break;
                case Tabs.SubAccount:
                    if (subAccount == null)
                    {
                        subAccount = new FrmSubAccountDetails();
                        Helpers.FormHelper.OpenForm(tabSubAccount, subAccount);
                    }
                    break;
            }
        }

        public static class Tabs
        {
            public const int Measurement = 0;
            public const int Item = 1;
            public const int Customer = 2;
            public const int Supplier = 3;
            public const int Employee = 4;
            public const int Transportation = 5;
            public const int Account = 6;
            public const int SubAccount = 7;
                
        }

       
    }
}
