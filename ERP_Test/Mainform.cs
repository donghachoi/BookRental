using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_Test.Plant;
using ERP_Test.Employee;

namespace ERP_Test
{
    public partial class Mainform : Form
    {
        private string Plant;

        public string _Plant{ get { return Plant; } set { Plant = _Plant; } }


        public Mainform(string _Plant)  //해당 공장에 로그인했을 경우
        {
            InitializeComponent();
            this.Plant = _Plant;
            panel1.Visible = false;
        }
        public Mainform()               //admin으로 로그인했을 경우
        {
            InitializeComponent();
            panel2.Visible =false;
            panel3.Visible =false;
        }

        private void plantInsert_Click(object sender, EventArgs e)
        {
            PlantInsert_from plantInsert = new PlantInsert_from();
            plantInsert.Show();
        }

        private void plantList_Click(object sender, EventArgs e)
        {
            PlantList plantList = new PlantList();
            plantList.Show();
        }

        private void employeeInsert_Click(object sender, EventArgs e)
        {
            EmployeeInsert eInsert = new EmployeeInsert();
            eInsert.Show();

        }

        private void employeeList_Click(object sender, EventArgs e)
        {

            EmployeeList employeeList = new EmployeeList(Plant);
            employeeList.Show();

        }
    }
}
