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
using System.Configuration;
using OracleInternal.SqlAndPlsqlParser.LocalParsing;
using System.Data.Common;
using System.Data.SqlClient;
using ERP_Test.Plant;
using System.Collections;
namespace ERP_Test
{

    public partial class LoginForm : Form
    {

        DBconnection db;
        string plant;
        public LoginForm()
        {
            InitializeComponent();
            //form load시 db연결
            db = new DBconnection();
            db.DBConnection();
        }
        private void plantCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            plant = plantCbox.Text;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {

            plantPanel.Hide();
            
            string employeeName = EmployeeName.Text;
            string employeePassword = EmployeePassword.Text;
            
            if (employeeName.Equals("admin") && employeePassword.Equals("admin"))//admin로그인
            {
                Mainform mainform = new Mainform();
                mainform.Show();
            }
            else                                                                 //보통의 로그인
            {
                List<string> resultList = db.getPlantByCodeName(employeeName, employeePassword);
                
                if (resultList.Count >= 2)                                      //검색결과가 2이상일때는 콤보박스를 생성해서 로그인하게 한다.
                {
                    plantPanel.Show();
                    if (!string.IsNullOrEmpty(plant))                              //검색결과가 2이상인데 콤보박스가 선택이되었을때
                    {
                        bool result = db.CheckId(plant, employeeName, employeePassword);
                        if (result)
                        {
                            Mainform mainform = new Mainform(plant);
                            mainform.Show();
                        }
                        else
                        {
                            warningLabel.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("증복 회원이름이있습니다. 공장이름을 선택해주세요.");
                    }
                    plantCbox.Items.Clear();
                    for (int i = 0; i < resultList.Count; i++)
                    {
                        plantCbox.Items.Add(resultList[i]);
                    }
                    
                }
                else                                                            //검색결과가 1일 경우 바로 로그인하게한다.;
                {
                    plant = Convert.ToString(resultList[0]);
                    Console.WriteLine(plant);
                    bool result = db.CheckId(plant, employeeName, employeePassword);
                    if (result)
                    {
                        Mainform mainform = new Mainform(plant);
                        mainform.Show();
                    }
                    else
                    {
                        warningLabel.Show();
                    }
                }
            }


        }

        
    }
}
