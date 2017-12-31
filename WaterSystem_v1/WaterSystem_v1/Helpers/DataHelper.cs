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

        public void filllvw(System.Windows.Forms.ListView lvw1, DataSet ds, List<String> col, List<String> col_name, ColumnHeaderStyle headerstyle, int? tableno)
        {
            ListViewItem lstitem = new ListViewItem();
            lvw1.Columns.Clear();
            lvw1.Items.Clear();
            lvw1.View = View.Details;
            lvw1.FullRowSelect = true;
            lvw1.GridLines = true;

            lvw1.HeaderStyle = headerstyle;

            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.Decimal") == 0)
                            lvw1.Columns.Add(col_name[i], 100);

                        if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.String") == 0)
                            lvw1.Columns.Add(col_name[i], 500);
                    }
                    for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
                    {
                        lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                        for (int j = 1; j < col.Count; j++)
                            lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {

                        lvw1.Columns.Add(col_name[i], 100);

                    }
                }
        }
        public void filllvw(System.Windows.Forms.ListView lvw1, DataSet ds, List<String> col, List<String> col_name, ColumnHeaderStyle headerstyle, int? tableno, int? tag_col_no)
        {
            ListViewItem lstitem = new ListViewItem();
            lvw1.Columns.Clear();
            lvw1.Items.Clear();
            lvw1.View = View.Details;
            lvw1.FullRowSelect = true;
            lvw1.GridLines = true;
            lvw1.HeaderStyle = headerstyle;
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.Decimal") == 0)
                            lvw1.Columns.Add(col_name[i], 100);

                        if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.String") == 0)
                            lvw1.Columns.Add(col_name[i], 500);
                    }
                    for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
                    {
                        lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                        if (tag_col_no.HasValue)
                            lstitem.Tag = ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse("" + tag_col_no)].ToString();

                        for (int j = 1; j < col.Count; j++)
                            lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {

                        lvw1.Columns.Add(col_name[i], 100);

                    }
                }
        }
        public void filllvw(System.Windows.Forms.ListView lvw1, DataSet ds, List<String> col, List<String> col_name, ColumnHeaderStyle headerstyle, int? tableno, int? tag_col_no, bool? items_clearYN)
        {
            ListViewItem lstitem = new ListViewItem();
            if (items_clearYN == true)
            {
                lvw1.Columns.Clear();
                lvw1.Items.Clear();
            }
            lvw1.View = View.Details;
            lvw1.FullRowSelect = true;
            lvw1.GridLines = true;
            lvw1.HeaderStyle = headerstyle;
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.Decimal") == 0)
                            lvw1.Columns.Add(col_name[i], 100);

                        if (ds.Tables[Int32.Parse(tableno.ToString())].Columns[Int32.Parse(col[i])].DataType.ToString().CompareTo("System.String") == 0)
                            lvw1.Columns.Add(col_name[i], 500);
                    }
                    for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
                    {
                        lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                        if (tag_col_no.HasValue)
                            lstitem.Tag = ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse("" + tag_col_no)].ToString();

                        for (int j = 1; j < col.Count; j++)
                            lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        lvw1.Columns.Add(col_name[i], 100);
                    }
                }
        }

        public void filllvw(System.Windows.Forms.ListView lvw1, DataSet ds, List<String> col, List<String> col_name, List<String> col_size, ColumnHeaderStyle headerstyle, int? tableno)
        {
            ListViewItem lstitem = new ListViewItem();
            lvw1.Columns.Clear();
            lvw1.Items.Clear();
            lvw1.View = View.Details;
            lvw1.FullRowSelect = true;
            lvw1.GridLines = true;
            lvw1.HeaderStyle = headerstyle;
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                    }

                    for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
                    {
                        lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                        for (int j = 1; j < col.Count; j++)
                            lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                    }
                }
        }
        public void filllvw(System.Windows.Forms.ListView lvw1, DataSet ds, List<String> col, List<String> col_name, List<String> col_size, ColumnHeaderStyle headerstyle, int? tableno, int? tag_col_no)
        {
            ListViewItem lstitem = new ListViewItem();
            lvw1.Columns.Clear();
            lvw1.Items.Clear();
            lvw1.View = View.Details;
            lvw1.FullRowSelect = true;
            lvw1.GridLines = true;
            lvw1.HeaderStyle = headerstyle;
            if (ds.Tables.Count > 0)
                if (ds.Tables[(int)tableno].Rows.Count > 0)
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                    }

                    for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
                    {
                        lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                        if (tag_col_no.HasValue)
                            lstitem.Tag = ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse("" + tag_col_no)].ToString();
                        for (int j = 1; j < col.Count; j++)
                            lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                    }
                }
        }
        public void filllvw(System.Windows.Forms.ListView lvw1, DataSet ds, List<String> col, List<String> col_name, List<String> col_size, ColumnHeaderStyle headerstyle, int? tableno, int? tag_col_no, bool? items_clearYN)
        {
            ListViewItem lstitem = new ListViewItem();
            if (items_clearYN == true)
            {
                lvw1.Columns.Clear();
                lvw1.Items.Clear();
            }
            lvw1.View = View.Details;
            lvw1.FullRowSelect = true;
            lvw1.GridLines = true;
            lvw1.HeaderStyle = headerstyle;
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                    }

                    for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
                    {
                        lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                        if (tag_col_no.HasValue)
                            lstitem.Tag = ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse("" + tag_col_no)].ToString();
                        for (int j = 1; j < col.Count; j++)
                            lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                    }
                }
        }

        public void filllvw(System.Windows.Forms.ListView lvw1, DataSet ds, List<ListViewColumnsInfo> columns, ColumnHeaderStyle headerstyle, int? tableno)
        {
            ListViewItem lstitem = new ListViewItem();
            lvw1.View = View.Details;
            lvw1.FullRowSelect = true;
            lvw1.GridLines = true;
            lvw1.HeaderStyle = headerstyle;
           
            if (ds.Tables.Count > 0)
            {
                foreach (ListViewColumnsInfo column in columns)
                {
                    lvw1.Columns.Add(column.Header, column.Visible ? column.ColumnSize : 0);
                }
                lvw1.Columns.Add("Action", 100);
                if (ds.Tables[Convert.ToInt32(tableno)].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[Convert.ToInt32(tableno)].Rows)
                    {
                        lstitem = lvw1.Items.Add(dr[columns[0].ColNumber].ToString());
                        for (int j = 1; j < columns.Count; j++)
                        {
                            lstitem.SubItems.Add(dr[columns[j].ColNumber].ToString());
                        }
                        Button btn = new Button();
                        btn.Text = "Click me";
                        btn.BackColor = SystemColors.ButtonFace;
                        Point p = lvw1.Items[2].Position;
                        p.X -= 21;
                        btn.Location = p;
                        btn.Size = lvw1.Items[2].Bounds.Size;
                        lvw1.Controls.Add(btn);
                    }
                }
            }
        }
        public void filllvw(System.Windows.Forms.ListView lvw1, DataSet ds, List<ListViewColumnsInfo> columns, ColumnHeaderStyle headerstyle, int? tableno, int? tag_col_no)
        {
            ListViewItem lstitem = new ListViewItem();
            lvw1.View = View.Details;
            lvw1.FullRowSelect = true;
            lvw1.GridLines = true;
            lvw1.HeaderStyle = headerstyle;
            
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[Convert.ToInt32(tableno)].Rows.Count > 0)
                {
                    foreach (ListViewColumnsInfo column in columns)
                    {
                        lvw1.Columns.Add(column.Header, column.Visible ? column.ColumnSize : 0);
                    }
                    int index = 0;
                    foreach (DataRow dr in ds.Tables[Convert.ToInt32(tableno)].Rows)
                    {
                        lstitem = lvw1.Items.Add(dr[columns[0].ColNumber].ToString());
                        if (tag_col_no.HasValue)
                            lstitem.Tag = dr[Int32.Parse(tag_col_no.ToString())].ToString();
                        for (int j = 1; j < columns.Count; j++)
                        {
                            lstitem.SubItems.Add(dr[columns[j].ColNumber].ToString());
                          
                        }
                        index++;
                    }
                }
                else
                {
                    foreach (ListViewColumnsInfo item in columns)
                    {
                        lvw1.Columns.Add(item.Header.ToString(), item.Visible ? item.ColumnSize : 0);
                    }
                }
               

            }
        }
        public void filllvw(System.Windows.Forms.ListView lvw1, DataSet ds, List<ListViewColumnsInfo> columns, ColumnHeaderStyle headerstyle, int? tableno, int? tag_col_no, bool? items_clearYN)
        {
            ListViewItem lstitem = new ListViewItem();
            if (items_clearYN == true)
            {
                lvw1.Columns.Clear();
                lvw1.Items.Clear();
            }
            lvw1.View = View.Details;
            lvw1.FullRowSelect = true;
            lvw1.GridLines = true;
            lvw1.HeaderStyle = headerstyle;
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[Convert.ToInt32(tableno)].Rows.Count > 0)
                {
                    foreach (ListViewColumnsInfo column in columns)
                    {
                        lvw1.Columns.Add(column.Header, column.Visible ? column.ColumnSize : 0);
                    }
                    foreach (DataRow dr in ds.Tables[Convert.ToInt32(tableno)].Rows)
                    {
                        lstitem = lvw1.Items.Add(dr[columns[0].ColNumber].ToString());
                        if (tag_col_no.HasValue)
                            lstitem.Tag = dr[Int32.Parse(tag_col_no.ToString())].ToString();
                        for (int j = 1; j < columns.Count; j++)
                            lstitem.SubItems.Add(dr[columns[j].ColNumber].ToString());
                    }
                }
                else
                {
                    foreach (ListViewColumnsInfo item in columns)
                    {
                        lvw1.Columns.Add(item.Header.ToString(), item.Visible ? item.ColumnSize : 0);
                    }
                }
            }
        }


        public bool SearchTextInListView_on_column_bool(System.Windows.Forms.ListView lst, int column, string Search, bool exact)
        {
            bool vr = false;
            try
            {
                foreach (ListViewItem item in lst.Items)
                {
                    item.Selected = false;
                }
                string iSearch = Search.ToLower();
                for (int colAll = 0; colAll <= lst.Columns.Count - 1; colAll++)
                    foreach (ListViewItem item in lst.Items)
                    {
                        if (item.SubItems[colAll].Text.Trim() == iSearch.Trim() |
                            item.SubItems[colAll].Text.ToUpper().Trim() == (iSearch.ToUpper().Trim()))
                        {
                            vr = true;
                            break;
                        }
                    }
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
            return vr;
        }

        public bool SearchTextInListView_bool(System.Windows.Forms.ListView lst, string Search)
        {
            bool vr = false;
            try
            {
                foreach (ListViewItem item in lst.Items)
                {
                    item.Selected = false;
                }
                string iSearch = Search.ToLower();
                for (int colAll = 0; colAll <= lst.Columns.Count - 1; colAll++)
                    foreach (ListViewItem item in lst.Items)
                    {
                        if (item.SubItems[colAll].Text.IndexOf(iSearch.Trim()) > -1 |
                            item.SubItems[colAll].Text.ToUpper().IndexOf(iSearch.ToUpper().Trim()) > -1)
                        {
                            vr = true;
                            break;
                        }
                    }
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
            return vr;
        }
        public delegate void SearchTextInListViewDelegate(System.Windows.Forms.ListView lst, string Search);
        public void SearchTextInListView(System.Windows.Forms.ListView lst, string Search)
        {
            try
            {
                if (lst.InvokeRequired)
                {
                    lst.Invoke(new SearchTextInListViewDelegate(SearchTextInListView), new object[] { lst, Search });
                }
                else
                {
                    foreach (ListViewItem item in lst.Items)
                    {
                        item.Selected = false;
                    }
                    string iSearch = Search.ToLower();
                    for (int colAll = 0; colAll < lst.Columns.Count - 1; colAll++)
                        foreach (ListViewItem item in lst.Items)
                        {
                            if (item.SubItems[colAll].Text.IndexOf(iSearch.Trim()) > -1 |
                                item.SubItems[colAll].Text.ToUpper().IndexOf(iSearch.ToUpper().Trim()) > -1)
                            {
                                item.Selected = true;
                            }
                        }
                    RemoveUnselected(lst);
                }
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
        }
        public void SearchTextInListView_on_column(System.Windows.Forms.ListView lst, int column, string Search)
        {
            try
            {
                foreach (ListViewItem item in lst.Items)
                {
                    item.Selected = false;
                }
                string iSearch = Search.ToLower();
                foreach (ListViewItem item in lst.Items)
                {
                    if (item.SubItems[column].Text.IndexOf(iSearch.Trim()) > -1 |
                        item.SubItems[column].Text.ToUpper().IndexOf(iSearch.ToUpper().Trim()) > -1)
                    {
                        item.Selected = true;
                    }
                }
                RemoveUnselected(lst);
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
        }
        public void SearchTextInListView_on_column(System.Windows.Forms.ListView lst, int column, string Search, bool exact)
        {
            try
            {
                foreach (ListViewItem item in lst.Items)
                {
                    item.Selected = false;
                }
                string iSearch = Search.ToLower();
                foreach (ListViewItem item in lst.Items)
                {
                    if (exact == true)
                        if (item.SubItems[column].Text == (iSearch.Trim()) |
                            item.SubItems[column].Text.ToUpper() == iSearch.ToUpper().Trim())
                        {
                            item.Selected = true;
                        }
                }
                RemoveUnselected(lst);
            }
            catch (Exception ex)
            { ex.Message.ToString(); }
        }

        // remove unselected items
        private void RemoveUnselected(System.Windows.Forms.ListView lst)
        {
            int i = 0;
            while (true)
            {
                if (i >= lst.Items.Count)
                {
                    break;
                }
                if (lst.Items[i].Selected == false)
                {
                    lst.Items[i].Remove();
                    i--;
                }
                i++;
            }
        }

        public void filllvw(System.Windows.Forms.ListView lvw1, DataSet ds, List<String> col, List<String> col_name, List<String> col_size, int? headerstyle, int? tableno, int? tag_col_no, bool? items_clearYN)
        {
            ListViewItem lstitem = new ListViewItem();
            if (items_clearYN == true)
            {
                lvw1.Columns.Clear();
                lvw1.Items.Clear();
            }
            lvw1.View = View.Details;
            lvw1.FullRowSelect = true;
            lvw1.GridLines = true;
            if (headerstyle == 0)
                lvw1.HeaderStyle = ColumnHeaderStyle.Clickable;
            if (headerstyle == 1)
                lvw1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            if (headerstyle == 2)
                lvw1.HeaderStyle = ColumnHeaderStyle.None;
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                    }

                    for (int i = 0; i <= ds.Tables[Int32.Parse(tableno.ToString())].Rows.Count - 1; i++)
                    {
                        lstitem = lvw1.Items.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[0])].ToString());
                        if (tag_col_no.HasValue)
                            lstitem.Tag = ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse("" + tag_col_no)].ToString();
                        for (int j = 1; j < col.Count; j++)
                            lstitem.SubItems.Add(ds.Tables[Int32.Parse(tableno.ToString())].Rows[i][Int32.Parse(col[j])].ToString());
                    }
                }
                else
                {
                    for (int i = 0; i <= col.Count - 1; i++)
                    {
                        lvw1.Columns.Add(col_name[i], Int32.Parse(col_size[i].ToString()));
                    }
                }
        }
        
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
