using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_Model;

namespace WaterSystem_v1.Helpers
{
    public class DataHelper
    {
        public static string strfont = "Tahoma";
        public static string strfont_Unicode = "Arial Unicode MS";
        public static string strheaderfont = "Castellar";
        public static string glb_font = strfont;
        public static string rpt_name = "";
        public static bool is_rpt = false;
        public static string Groupid = "";
        public static string SlaoName = "";
        public static string SlaoNo = "";
        public static string UserName = "";
        public static SortedList<string, string> glb = new SortedList<string, string>();

        public DataTable EnumToDataTable(Type enumType)
        {
            DataTable table = new DataTable();
            //Get the type of ENUM for DataColumn
            table.Columns.Add("Id", Enum.GetUnderlyingType(enumType));
            //Column that contains the Captions/Keys of Enum        
            table.Columns.Add("Desc", typeof(string));

            //Add the items from the enum:
            foreach (string name in Enum.GetNames(enumType))
            {
                //Replace underscores with space from caption/key and add item to collection:
                table.Rows.Add(Enum.Parse(enumType, name), name.Replace('_', ' '));
            }

            return table;
        }

        public bool CheckExistsDs(DataSet ds, bool ForAllTable)
        {
            if (ds.Tables.Count <= 0) return false;
            if (ForAllTable)
            {
                foreach (DataTable dt in ds.Tables)
                {
                    if (dt.Rows.Count <= 0) return false;
                }
            }
            return true;
        }
        public bool CheckExistsDs(DataSet ds, int Tableno)
        {
            if (ds.Tables.Count <= 0) return false;
            if (ds.Tables[Tableno].Rows.Count <= 0) return false;
            return true;
        }

        public string WriteErrorLog(string Error)
        {
            string filename = "";
            string txtline = "";
            try
            {
                if (File.Exists(Application.StartupPath.ToString() + "\\ErrorLog.txt"))
                {
                    filename = Application.StartupPath.ToString() + "\\ErrorLog.txt";

                    System.IO.StreamWriter objWriter;
                    objWriter = new System.IO.StreamWriter(filename, true);
                    objWriter.Write("---------------------------------------------");
                    objWriter.Write(DateTime.Now.ToString("dd-MMM-yyyy") + "\n");
                    objWriter.Write(Error.ToString());
                    objWriter.Write("---------------------------------------------");
                    objWriter.Close();
                }
                else
                {
                    StreamWriter sw = System.IO.File.CreateText(Application.StartupPath.ToString() + "\\ErrorLog.txt");
                    sw.Write("---------------------------------------------");
                    sw.Write(DateTime.Now.ToString("dd-MMM-yyyy") + "\n");
                    sw.Write(Error.ToString());
                    sw.Write("---------------------------------------------");
                    sw.Close();
                }


                return txtline;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return string.IsNullOrEmpty(txtline) ? "Office2010Blue" : txtline;
            }
        }

        public void GenerateListView(ObjectListView varListView, List<ListViewColumnsInfo> nameSizeList)
        {

            List<OLVColumn> columnsList = new List<OLVColumn>();
            foreach (ListViewColumnsInfo nameSize in nameSizeList)
            {
                OLVColumn columnHeader = new BrightIdeasSoftware.OLVColumn();
                columnHeader.Width = nameSize.ColumnSize;
                columnHeader.Text = nameSize.Header;
                columnHeader.IsVisible = nameSize.Visible;
                columnHeader.AspectName = nameSize.Header;
                if (nameSize.IsButton)
                {
                    columnHeader.IsButton = nameSize.IsButton;
                    columnHeader.TextAlign = HorizontalAlignment.Center;
                    columnHeader.ButtonSizing = OLVColumn.ButtonSizingMode.FixedBounds;
                    columnHeader.ButtonSize = new Size(15, 15);
                }
                columnsList.Add(columnHeader);
                varListView.AllColumns.Add(columnHeader);
            }
            varListView.Columns.AddRange(columnsList.Cast<System.Windows.Forms.ColumnHeader>().ToArray());
        }

        public string GetMemberName<T, TValue>(Expression<Func<T, TValue>> memberAccess)
        {
            return ((MemberExpression)memberAccess.Body).Member.Name;
        }

        public void FillCombo(ComboBox cmb, IEnumerable<DropDown> dataList)
        {
            cmb.Items.Clear();
            cmb.DisplayMember = GetMemberName((DropDown c) => c.Name);
            cmb.ValueMember = GetMemberName((DropDown c) => c.Value);
            foreach (var data in dataList)
            {
                cmb.Items.Add(new DropDown() { Name = data.Name, Value = data.Value });
            }
        }

        #region Datatable to Object
        public static List<T> CreateListFromTable<T>(DataTable tbl) where T : new()
        {
            // define return list
            List<T> lst = new List<T>();

            // go through each row
            foreach (DataRow r in tbl.Rows)
            {
                // add to the list
                lst.Add(CreateItemFromRow<T>(r));
            }

            // return the list
            return lst;
        }

        // function that creates an object from the given data row
        public static T CreateItemFromRow<T>(DataRow row) where T : new()
        {
            // create a new object
            T item = new T();

            // set the item
            SetItemFromRow(item, row);

            // return 
            return item;
        }

        public static void SetItemFromRow<T>(T item, DataRow row) where T : new()
        {
            // go through each column
            foreach (DataColumn c in row.Table.Columns)
            {
                // find the property for the column
                PropertyInfo p = item.GetType().GetProperty(c.ColumnName);

                // if exists, set the value
                if (p != null && row[c] != DBNull.Value)
                {
                    p.SetValue(item, row[c], null);
                }
            }
        }

        #endregion
    }



    public class ListViewColumnsInfo
    {
        public int ColNumber { get; set; }
        public string Header { get; set; }
        public int ColumnSize { get; set; }
        public bool Visible { get; set; }

        public bool IsButton { get; set; }
    }
}
