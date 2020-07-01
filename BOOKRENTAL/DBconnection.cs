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
        OracleConnection conn;
        OracleCommand command;
        public bool DBConnection()
        {
            bool retValue = false;
            try
            {
                conn = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                conn.Open();
                retValue = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                retValue = false;
            }
            return retValue;
        }

        #region    공통 쿼리들 ##################################################################################

        /**
         * 등록하는 쿼리 넣으면 등록해주는 메서드
         */
        public void InsertQuery(string Query)
        {
            OracleCommand command = new OracleCommand(Query, conn);
            command.ExecuteNonQuery();
        }

        /**
         * 순번 increase를 위한 유저에 모든 인원수 구하기
         */
        public int GetCodeTableCount(string tablename)
        {
            int result;
            string Query = "select Max(to_number(substr(CODE_NAME,instr(CODE_NAME,'_',1,1)+1))) from TEST_SYSTEM_CODE_DATA where plant = '" + tablename + "' and TABLE_NAME = '"+ tablename + "table'";
            OracleCommand cmd = new OracleCommand(Query, conn);
            cmd.ExecuteScalar();
            object resultObj = cmd.ExecuteScalar();
            if (resultObj.GetType() == typeof(DBNull))
            {
                result = 1;
            }
            else
            {
                result = Convert.ToInt32(resultObj)+1;
            }
            return result;
        }
        #endregion 공통 쿼리 END #########################################################################


        #region 회원 쿼리 ##############################################################################

        //회원 리스트 화면에 뿌리기.
        public void GetUsersList(ListView UserListView)
        {
            string Query = "select to_number(substr(CODE_NAME,instr(CODE_NAME,'_',1,1)+1)) as seq, DESCRIPTION,CODE_GROUP1,CODE_GROUP2,CODE_GROUP3 FROM TEST_SYSTEM_CODE_DATA where plant ='user' and table_name = 'usertable' order by seq";
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = Query;
            DataTable dt = new DataTable();
            OracleDataAdapter adp = new OracleDataAdapter(command);
            adp.Fill(dt);
            UserListView.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                UserListView.Items.Add(item);
            }
        }


        public void SearchUser(string seachType, string seachValue, ListView UserListView)
        {
            string Query = "select to_number(substr(CODE_NAME,instr(CODE_NAME,'_',1,1)+1)) as seq, DESCRIPTION,CODE_GROUP1,CODE_GROUP2,CODE_GROUP3 FROM TEST_SYSTEM_CODE_DATA where plant ='user' and table_name = 'usertable' and "+ seachType + " like '%"+ seachValue + "%' order by seq";
            Console.WriteLine(Query);
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = Query;
            DataTable dt = new DataTable();
            OracleDataAdapter adp = new OracleDataAdapter(command);
            adp.Fill(dt);
            UserListView.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                UserListView.Items.Add(item);
            }
        }
        public void DeleteUser(string UserName)
        {
            string Query = "delete from TEST_SYSTEM_CODE_DATA where plant = 'user' and description = '"+ UserName + "'";
            OracleCommand command = new OracleCommand(Query, conn);
            command.ExecuteNonQuery();
        }

        #endregion 회원 쿼리 END ##############################################################################

        #region 책 관련 쿼리 ##################################################################################

        /**
         * 선택된 책 삭제 메서드
         */
        public void DeleteBook(string bookCode)
        {
            string Query = "";
            string selectQuery = "select code_group1 ,code_group2 from TEST_SYSTEM_CODE_DATA where code_name = '"+ bookCode + "'";
            OracleCommand command = new OracleCommand(Query, conn); ;
            OracleCommand command1 = new OracleCommand(selectQuery, conn);
            DataTable dt = new DataTable(); 
            OracleDataAdapter adp = new OracleDataAdapter(command1);
            adp.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Query = "delete from TEST_SYSTEM_CODE_DATA where plant = 'books' and table_name = 'bookgenre' and code_name = '" + dr[0].ToString() + "'";
                command = new OracleCommand(Query, conn);
                command.ExecuteNonQuery();
                Query = "delete from TEST_SYSTEM_CODE_DATA where plant = 'books' and table_name = 'bookpublisher' and code_name = '" + dr[1].ToString() + "'";
                command = new OracleCommand(Query, conn);
                command.ExecuteNonQuery();
            }
            Query = "delete from TEST_SYSTEM_CODE_DATA where plant = 'books' and table_name = 'bookstable' and code_name = '" + bookCode + "'";
            command = new OracleCommand(Query, conn);
            command.ExecuteNonQuery();
        }

        /**
         * 대분류 중분류 소분류 treeview에 뿌리기 도전중....
         * */
        public void GetCategory(TreeView treeView1)
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            string Query = "select code_group1,code_group2,code_group3 from TEST_SYSTEM_CODE_DATA where table_name = 'bookgenre'";
            OracleCommand cmd = new OracleCommand(Query, conn);
            OracleDataAdapter adp = new OracleDataAdapter(cmd);
            adp.Fill(dt);

            bool isFirst = true;
            bool IsItsame = false;
            //첫번쨰 노드
            foreach (DataRow dr in dt.Rows)
            {   //dr 갯수만큼 돕니다.
                
                if (isFirst)
                {
                    treeView1.Nodes.Add(dr[0].ToString());
                    isFirst = false;
                }
                else
                {
                    for (int i = 0; i < treeView1.Nodes.Count; i++)
                    {
                        if (treeView1.Nodes[i].Text == dr[0].ToString()) 
                        {
                            IsItsame = false;
                            break;
                        }
                        else
                            IsItsame = true;
                    }
                }
                if (IsItsame)
                {
                    treeView1.Nodes.Add(dr[0].ToString());
                }
            }
            isFirst = true;
            //두번쨰 노드 중복제거해야한다.
            foreach (DataRow dr in dt.Rows)
            {
                foreach (TreeNode bicNodes in treeView1.Nodes)
                {
                    if(bicNodes.Text == dr[0].ToString())
                    {
                        Console.WriteLine("루트 노트랑 첫번쨰 컬럼이같을때");//여기서 중복만 제거하면된다.
                        bicNodes.Nodes.Add(dr[1].ToString());
                    }
                }
            }
        }
    
        /**
         * 책리스트 메인화면에 뿌리기 기본으로
         */
        public void GetBooksList(ListView BookListView)
        {
            string Query = @"select to_number(substr(t1.CODE_NAME,instr(t1.CODE_NAME,'_',1,1)+1)) as seq, t1.DESCRIPTION, t3.CODE_GROUP1, t3.CODE_GROUP2, t1.CODE_GROUP3, t2.CODE_GROUP1, t2.CODE_GROUP2, t2.CODE_GROUP3 from TEST_SYSTEM_CODE_DATA t1 inner join TEST_SYSTEM_CODE_DATA t2 on t1.CODE_GROUP1 = t2.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t3 on t1.CODE_GROUP2 = t3.CODE_NAME where t1.plant = 'books' order by seq";
            command = new OracleCommand
            {
                Connection = conn,
                CommandText = Query
            };
            DataTable dt = new DataTable();
            OracleDataAdapter adp = new OracleDataAdapter(command);
            adp.Fill(dt);
            BookListView.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                BookListView.Items.Add(item);
            }
        }

        //검색을 눌르지 않고 treeview만 선택 되었을때
        public void GetBooksList(ListView BookListView,string[] result)
        {
            string Query = "";
            switch (result.Length)
            {
                case 1:
                    Query = @"select to_number(substr(t1.CODE_NAME,instr(t1.CODE_NAME,'_',1,1)+1)) as seq, t1.DESCRIPTION, t3.CODE_GROUP1, t3.CODE_GROUP2, t1.CODE_GROUP3, t2.CODE_GROUP1, t2.CODE_GROUP2, t2.CODE_GROUP3 from TEST_SYSTEM_CODE_DATA t1 inner join TEST_SYSTEM_CODE_DATA t2 on t1.CODE_GROUP1 = t2.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t3 on t1.CODE_GROUP2 = t3.CODE_NAME where t1.plant = 'books' and t2.CODE_GROUP1 ='" + result[0]+"' order by seq";
                    break;
                case 2:
                    Query = @"select to_number(substr(t1.CODE_NAME,instr(t1.CODE_NAME,'_',1,1)+1)) as seq, t1.DESCRIPTION, t3.CODE_GROUP1, t3.CODE_GROUP2, t1.CODE_GROUP3, t2.CODE_GROUP1, t2.CODE_GROUP2, t2.CODE_GROUP3 from TEST_SYSTEM_CODE_DATA t1 inner join TEST_SYSTEM_CODE_DATA t2 on t1.CODE_GROUP1 = t2.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t3 on t1.CODE_GROUP2 = t3.CODE_NAME where t1.plant = 'books' and t2.CODE_GROUP1 ='" + result[0]+ "'and t2.CODE_GROUP2 = '"+ result [1]+ "' order by seq";
                    break;
                case 3:
                    Query = @"select to_number(substr(t1.CODE_NAME,instr(t1.CODE_NAME,'_',1,1)+1)) as seq, t1.DESCRIPTION, t3.CODE_GROUP1, t3.CODE_GROUP2, t1.CODE_GROUP3, t2.CODE_GROUP1, t2.CODE_GROUP2, t2.CODE_GROUP3 from TEST_SYSTEM_CODE_DATA t1 inner join TEST_SYSTEM_CODE_DATA t2 on t1.CODE_GROUP1 = t2.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t3 on t1.CODE_GROUP2 = t3.CODE_NAME where t1.plant = 'books' and t2.CODE_GROUP1 ='" + result[0]+ "'and t2.CODE_GROUP2 = '"+ result [1]+ "'and t2.code_group3='"+ result[2] + "' order by seq";
                    break;
            }
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = Query;
            DataTable dt = new DataTable();
            OracleDataAdapter adp = new OracleDataAdapter(command);
            adp.Fill(dt);
            BookListView.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                BookListView.Items.Add(item);
            }
        }
        
        //장르 treeview에 선택된 노드가 있을때
        public void SerachBooks(string seachType, string seachValue, ListView BookListView,string[] result)
        {
            string Query = "";
            switch (result.Length)
            {
                case 1:
                    Query = @"select to_number(substr(t1.CODE_NAME,instr(t1.CODE_NAME,'_',1,1)+1)) as seq, t1.DESCRIPTION, t3.CODE_GROUP1, t3.CODE_GROUP2, t1.CODE_GROUP3, t2.CODE_GROUP1, t2.CODE_GROUP2, t2.CODE_GROUP3 from TEST_SYSTEM_CODE_DATA t1 inner join TEST_SYSTEM_CODE_DATA t2 on t1.CODE_GROUP1 = t2.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t3 on t1.CODE_GROUP2 = t3.CODE_NAME where t1.plant = 'books' and t2.CODE_GROUP1 ='" + result[0] + "' and " + seachType + " like '%" + seachValue + "%' order by seq";
                    break;
                case 2:
                    Query = @"select to_number(substr(t1.CODE_NAME,instr(t1.CODE_NAME,'_',1,1)+1)) as seq, t1.DESCRIPTION, t3.CODE_GROUP1, t3.CODE_GROUP2, t1.CODE_GROUP3, t2.CODE_GROUP1, t2.CODE_GROUP2, t2.CODE_GROUP3 from TEST_SYSTEM_CODE_DATA t1 inner join TEST_SYSTEM_CODE_DATA t2 on t1.CODE_GROUP1 = t2.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t3 on t1.CODE_GROUP2 = t3.CODE_NAME where t1.plant = 'books' and t2.CODE_GROUP1 ='" + result[0] + "'and t2.CODE_GROUP2 = '" + result[1] + "' and " + seachType + " like '%" + seachValue + "%' order by seq";
                    break;
                case 3:
                    Query = @"select to_number(substr(t1.CODE_NAME,instr(t1.CODE_NAME,'_',1,1)+1)) as seq, t1.DESCRIPTION, t3.CODE_GROUP1, t3.CODE_GROUP2, t1.CODE_GROUP3, t2.CODE_GROUP1, t2.CODE_GROUP2, t2.CODE_GROUP3 from TEST_SYSTEM_CODE_DATA t1 inner join TEST_SYSTEM_CODE_DATA t2 on t1.CODE_GROUP1 = t2.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t3 on t1.CODE_GROUP2 = t3.CODE_NAME where t1.plant = 'books' and t2.CODE_GROUP1 ='" + result[0] + "'and t2.CODE_GROUP2 = '" + result[1] + "'and t2.code_group3='" + result[2] + "' and " + seachType + " like '%" + seachValue + "%' order by seq";
                    break;
            }
            Console.WriteLine(Query);
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = Query;
            DataTable dt = new DataTable();
            OracleDataAdapter adp = new OracleDataAdapter(command);
            adp.Fill(dt);
            BookListView.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                BookListView.Items.Add(item);
            }
        }

        //장르 treeview에 선택된 노드가 없을때
        public void SerachBooks(string seachType, string seachValue, ListView BookListView)
        {
            string Query = @"select to_number(substr(t1.CODE_NAME,instr(t1.CODE_NAME,'_',1,1)+1)) as seq, t1.DESCRIPTION, t3.CODE_GROUP1, t3.CODE_GROUP2, t1.CODE_GROUP3, t2.CODE_GROUP1, t2.CODE_GROUP2, t2.CODE_GROUP3 from TEST_SYSTEM_CODE_DATA t1 inner join TEST_SYSTEM_CODE_DATA t2 on t1.CODE_GROUP1 = t2.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t3 on t1.CODE_GROUP2 = t3.CODE_NAME where t1.plant = 'books' and " + seachType + " like '%"+ seachValue + "%' order by seq";
            command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = Query;
            DataTable dt = new DataTable();
            OracleDataAdapter adp = new OracleDataAdapter(command);
            adp.Fill(dt);
            BookListView.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                BookListView.Items.Add(item);
            }
        }
        #endregion 책 관련 쿼리 END ###########################################################################################

        #region 렌트 관련 쿼리 start ###########################################################################################
        public void GetRentList(ListView RentlistView)
        {
            string Query = "select to_number(substr(t1.CODE_NAME,instr(t1.CODE_NAME,'_',1,1)+1)) as seq,t2.description,t2.CODE_GROUP2,t2.CODE_GROUP1,concat(concat(concat(t4.CODE_GROUP1,' > '),concat(t4.CODE_GROUP2,' > ')),t4.CODE_GROUP3) as genre,t3.DESCRIPTION,t5.CODE_GROUP1,t5.CODE_GROUP2,t1.description from TEST_SYSTEM_CODE_DATA t1 inner join TEST_SYSTEM_CODE_DATA t2 on t1.CODE_GROUP1 = t2.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t3 on t1.CODE_GROUP2 = t3.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t4 on t3.code_group1= t4.CODE_NAME inner join TEST_SYSTEM_CODE_DATA t5 on t3.CODE_GROUP2 = t5.CODE_NAME where t1.plant ='rent' AND t1.CODE_GROUP3 IS NULL order by seq";
            command = new OracleCommand
            {
                Connection = conn,
                CommandText = Query
            };
            DataTable dt = new DataTable();
            OracleDataAdapter adp = new OracleDataAdapter(command);
            adp.Fill(dt);
            RentlistView.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                RentlistView.Items.Add(item);
            }
        }

        #endregion 렌트 관련 쿼리 END ###########################################################################################
    }
}

