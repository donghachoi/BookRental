using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Test.Employee
{
    public partial class EmployeeInsert : Form
    {
        DBconnection db;
        public EmployeeInsert()
        {
            InitializeComponent();
            db = new DBconnection();
            db.DBConnection();
            string Query = "select plant from TEST_SYSTEM_CODE where plant != 'admin' group by plant";

            DataTable dt = db.QueryExeCute(Query);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    var cell = dt.Rows[i][j];
                    plantcombox.Items.Add(cell);
                }
            }
        }

        private void employeeInsertBtn_Click(object sender, EventArgs e)
        {
            //직원 정보 변수에 담기.
            string emName = employeeName.Text;
            string empDep = employeeDepartment.Text;
            string empDesc = employeeDESC.Text;
            string empLevel = employeeLevel.Text;
            string empplant = plantcombox.Text;
            int result = db.GetEmployeeCount(empplant);

            string query = "insert into TEST_SYSTEM_CODE_DATA (PLANT,TABLE_NAME,CODE_NAME,CODE_SEQ,DESCRIPTION,CODE_GROUP1,CODE_GROUP2,CODE_GROUP3)"
                                                    + "values('" + empplant + "','" + empplant + "ET','" + emName + "',"+ (result + 1) + ",'" + empDesc + "','" + empLevel + "','" + empDep + "','1234')";
            db.InsertQuery(query);

        }
    }
}
