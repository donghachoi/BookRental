using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Test.Plant
{
    public partial class PlantList : Form
    {
        DBconnection db;
        public PlantList()
        {
            InitializeComponent();
            db = new DBconnection();
            db.DBConnection();
            string Query = "select plant from TEST_SYSTEM_CODE where plant != 'admin' group by plant";
            PlantListGrid.DataSource = db.QueryExeCute(Query);
        }
    }
}
