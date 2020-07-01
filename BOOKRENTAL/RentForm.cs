using ERP_Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKRENTAL
{
    public partial class RentForm : Form
    {
        private DBconnection db;
        private string bookNum;


        public RentForm(string bookNum, string bookTitle, string bookPublisher, string bookWriter)
        {
            InitializeComponent();
            db = new DBconnection();
            db.DBConnection();
            db.GetUsersList(userListView);
            bookNumTB.Text = bookNum;
            bookTilteTB.Text = bookTitle;
            PublisherTB.Text = bookPublisher;
            WriterTB.Text = bookWriter;
            this.bookNum = bookNum;
            
        }
        
        private void rentBtn_Click(object sender, EventArgs e)
        {
            string userNum = "";
            if (userListView.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = userListView.SelectedItems;
                ListViewItem item = items[0];
                userNum = item.SubItems[0].Text;
            }
            else
            {
                MessageBox.Show("회원을 선택해주세요.");
            }
            Console.WriteLine(this.bookNum + "<<<< ===  this.bookNum");
            Console.WriteLine(userNum + "<<<< ===  userNum");
            int seq = db.GetCodeTableCount("rent");
            string bookCode = "BC_"+this.bookNum;
            string userCode = "UC_" + userNum;
            string rentCode = "RC_" + seq.ToString();
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string Query = "insert into TEST_SYSTEM_CODE_DATA (PLANT, TABLE_NAME, CODE_NAME, DESCRIPTION, CODE_GROUP1, CODE_GROUP2, CODE_GROUP3) values('rent','renttable','"+ rentCode + "','"+ today + "','"+ userCode + "','"+ bookCode + "','')";
            db.InsertQuery(Query);
            MessageBox.Show("대여 성공");
            this.Close();

        }

        private void UserSearchBtn_Click(object sender, EventArgs e)
        {
            string seachValue = SearchTB.Text;
            string seachType = ChangeComboBoxForUser(UserSearchCB.Text);
            db.SearchUser(seachType, seachValue, userListView);
        }

        private string ChangeComboBoxForUser(string seachType)
        {
            string result = "";
            if (seachType.Equals("회원이름"))
                result = "DESCRIPTION";
            else if (seachType.Equals("생년월일"))
                result = "CODE_GROUP1";
            else if (seachType.Equals("전화번호"))
                result = "CODE_GROUP2";
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
