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
    public partial class PlantInsert_from : Form
    {
        DBconnection db;
        public PlantInsert_from()
        {
            InitializeComponent();
            db = new DBconnection();
            db.DBConnection();
        }

        private void PlantInsert_Click(object sender, EventArgs e)
        {
            string plantName = PlantName.Text;
            string plantDes = PlantDes.Text;
            if(string.IsNullOrWhiteSpace(plantName) && string.IsNullOrWhiteSpace(plantDes))
            {   //입력값이 없을떄
                MessageBox.Show("입력해주세요.");
            }
            else
            {   //입력값이 있을때
                string query = "insert into TEST_SYSTEM_CODE (PLANT,TABLE_NAME,DESCRIPTION,FORMAT_TYPE,DECIMAL_LENGTH,SIZE_LIMIT)"
                                                    + "values('" + plantName + "', '" + plantName + "ET', '" + plantDes + "', 'a', 0, 0)";
                db.InsertQuery(query);
                

                this.Hide();
                PlantList plantList = new PlantList();
                plantList.Show();
            }
        }
    }
}
