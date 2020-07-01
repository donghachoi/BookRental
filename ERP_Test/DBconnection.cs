using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Drawing;
using System.Collections;

namespace ERP_Test
{
    public class DBconnection
    {
        OracleConnection _con;
        public bool DBConnection()
        {
            bool retValue = false;
            try
            {
                _con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                _con.Open();
                retValue = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                retValue = false;
            }
            return retValue;
        }
        /**
         * 쿼리를 넣으면 DataTable로 바꿔주는 메서드
         */
        public DataTable QueryExeCute(string Query)
        {
            try
            {
                OracleDataAdapter adp = new OracleDataAdapter(Query, _con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show($"데이터 가져오기.\n {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        /**
         * 등록하는 쿼리 넣으면 등록해주는 메서드
         */
        public void InsertQuery(string Query)
        {
            OracleCommand command = new OracleCommand(Query,_con);
            command.ExecuteNonQuery();
        }
        /**
         * 순번 increase를 위한 한공장에 모든 인원수 구하기
         */
        public int GetEmployeeCount(string plant)
        {
            int result;
            string Query = "select Max(CODE_SEQ) from TEST_SYSTEM_CODE_DATA where plant = '"+ plant + "' and TABLE_NAME = '" + plant + "ET'";
            OracleCommand cmd = new OracleCommand(Query,_con);
            cmd.ExecuteScalar();
            object resultObj = cmd.ExecuteScalar();
            MessageBox.Show(resultObj.GetType().ToString());
            if (resultObj.GetType() == typeof(DBNull))
            {
                result = 0;
            }
            else
            {
                result = Convert.ToInt32(resultObj);
            }
            return result;
        }

        /**
         * 직원 이름으로 공장이름 구하는 메서드
         */
        public List<string> getPlantByCodeName(string employeeName, string employeePassword)
        {
            List<string> resultList = new List<string>();
            string Query = "select plant from TEST_SYSTEM_CODE_DATA where CODE_NAME = '"+ employeeName + "' and CODE_GROUP3 = '"+ employeePassword +"'";
            OracleCommand cmd = new OracleCommand(Query, _con);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for(int i = 0; i < dr.FieldCount; i++)
                {
                    resultList.Add(dr.GetString(i));
                }
            }
            return resultList;
        }

        /**
         * 로그인을 위한 아이디 체크 하는 메서드
         */
        public bool CheckId(string plant ,string employeeName, string employeePassword)
        {
            bool isCheck = false;
            string Query = "select count(1) from TEST_SYSTEM_CODE_DATA where PLANT = '"+ plant + "' and TABLE_NAME = '"+ plant + "ET' and CODE_NAME = '" + employeeName + "' and CODE_GROUP3 = '" + employeePassword + "'";
            OracleCommand cmd = new OracleCommand(Query, _con);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            if(result == 1)
            {
                isCheck = true;
            }
            return isCheck;
        }

        /**
         * 직원 리스트 가져오기
         */
        public DataTable GetEmployeeList(string plant)
        {
            string Query = "select CODE_NAME,DESCRIPTION,CODE_GROUP1,CODE_GROUP2 from TEST_SYSTEM_CODE_DATA where PLANT = '" + plant + "' and TABLE_NAME = '" + plant + "ET'";
            OracleDataAdapter adp = new OracleDataAdapter(Query, _con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
