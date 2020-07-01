using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ERP_Test.Employee
{
    public partial class EmployeeList : Form
    {

        public EmployeeList(string plant)
        {
            InitializeComponent();
            DBconnection db = new DBconnection();
            db.DBConnection();
            EmployeeTreeView1.Nodes.Add("공장1");




            /** ListView에 값 뿌려주기
            *
            DataTable dt = db.GetEmployeeList(plant);
            employeeListView.BeginUpdate();
            foreach(DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                for(int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                employeeListView.Items.Add(item);
            }*/
        }
    }
}
