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
    public partial class Main : Form
    {
        DBconnection db;
        //선택될 유저번호
        string SelectedUserNum = "";
        //선택될 렌트 번호
        string SelectedRentNum = "";


        public ListView listview { get { return BookListView; } }
        public Main()
        {
            InitializeComponent();
            db = new DBconnection();
            db.DBConnection();
            //db.GetCategory(TestTreeView);
            
        }
        
        //메인창이 활성화 될떄 이벤트
        private void Main_Activated(object sender, EventArgs e)
        {
            db.GetBooksList(BookListView);
            db.GetUsersList(UserListView);
            db.GetRentList(RentlistView);
        }

        //메인창에 책 검색 이벤트
        private void BookSearchBtn_Click(object sender, EventArgs e)
        {
            string seachValue = BookSearchTB.Text;
            string seachType = ChangeComboBox(BookSearchCB.Text);
            if (treeView1.SelectedNode != null)//장르가 선택 되어있을때
            {
                Console.WriteLine("선택되었습니다.");
                string[] result = treeView1.SelectedNode.FullPath.Split('\\');
                Console.WriteLine(result[0]);
                db.SerachBooks(seachType, seachValue, BookListView, result);
            }
            else
            {
                Console.WriteLine("장르가 선택되어 있지 않을때");
                db.SerachBooks(seachType, seachValue, BookListView);
            }
        }

        //메인창에 콤보박스 가 바뀔때 seachType이 바뀌는 이벤트
        public string ChangeComboBox(string seachType)
        {
            string result = "";
            if (seachType.Equals("책번호"))
                result = "t1.CODE_SEQ";
            else if (seachType.Equals("책이름"))
                result = "t1.DESCRIPTION";
            else if (seachType.Equals("출판사"))
                result = "t3.CODE_GROUP1";
            else if (seachType.Equals("저자"))
                result = "t2.CODE_GROUP2";
            return result;
        }

        private void UserInsertBtn_Click(object sender, EventArgs e)
        {
            UserInsert userInsert = new UserInsert(this);
            userInsert.Show();
        }

        private void BookInsertBtn_Click(object sender, EventArgs e)
        {
            BookInsert bookInsert = new BookInsert(this);
            bookInsert.Show();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RedirectBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void RentlistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RentlistView.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = RentlistView.SelectedItems;
                ListViewItem lvitem = items[0];
                SelectedRentNum = lvitem.SubItems[0].Text;
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            string rentCode = "RC_"+ SelectedRentNum;
            string Today = DateTime.Now.ToString("yyyy-MM-dd");
            string Query = "update TEST_SYSTEM_CODE_DATA set code_group3 = '"+ Today + "' where plant = 'rent' and code_name = '"+ rentCode + "'";
            db.InsertQuery(Query);
            MessageBox.Show("반납되었습니다.");
        }
        private void RentalBtn_Click(object sender, EventArgs e)
        {
            string bookTitle = bookTitleTB.Text;
            string bookNum = bookNumTB.Text;
            string bookPublisher = bookPublisherTB.Text;
            string bookWriter = bookWriterTB.Text;
            if (string.IsNullOrEmpty(bookTitleTB.Text))
            {
                MessageBox.Show("책을 선택해주세요.");
            }
            else
            {
                RentForm rentForm = new RentForm(bookNum, bookTitle, bookPublisher, bookWriter);
                rentForm.Show();
            }
        }

        private void BookListView_Click(object sender, EventArgs e)
        {

            string bookNum ="";
            string bookTitle = "";
            string bookPublisher = "";
            string bookWriter = "";
            if(BookListView.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = BookListView.SelectedItems;
                ListViewItem lvitem = items[0];
                bookNum = lvitem.SubItems[0].Text;
                bookTitle = lvitem.SubItems[1].Text;
                bookPublisher = lvitem.SubItems[2].Text;
                bookWriter = lvitem.SubItems[3].Text;
            }
            bookNumTB.Text = bookNum;
            bookTitleTB.Text = bookTitle;
            bookPublisherTB.Text = bookPublisher;
            bookWriterTB.Text = bookWriter;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            bookNumTB.Text = "";
            bookTitleTB.Text = "";
            bookPublisherTB.Text = "";
            bookWriterTB.Text = "";
            db.GetBooksList(BookListView);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Console.WriteLine(treeView1.SelectedNode.Text);
            //Console.WriteLine(treeView1.SelectedNode.FullPath);
            string[] result = treeView1.SelectedNode.FullPath.Split('\\');
            db.GetBooksList(BookListView, result);
            
        }

        private void BookDeleteBtn_Click(object sender, EventArgs e)
        {
            string booknum = bookNumTB.Text;
            string bookName = bookTitleTB.Text;
            if (!string.IsNullOrEmpty(booknum))
            {
                if (MessageBox.Show("선택하신 \""+bookName+"\" 을(를) 정말 삭제 하시겠습니까?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string bookCode = "BC_" + booknum;
                    db.DeleteBook(bookCode);
                    db.GetBooksList(BookListView); 
                }
            }
            else
            {
                MessageBox.Show("책을 선택해 주세요.");
            }
        }

        private void UserUpdateBtn_Click(object sender, EventArgs e)
        {
            string UpdateUsername = UserIdTB.Text;
            string UpdateUserPhone = UserPhoneTB.Text;
            string userCode = "UC_" + SelectedUserNum;
            string Query = "update TEST_SYSTEM_CODE_DATA set description = '" + UpdateUsername + "' ,code_group2 = '" + UpdateUserPhone + "' where plant = 'user' and code_name = '" + userCode + "'";
            db.InsertQuery(Query);
            MessageBox.Show("변경되었습니다.");

        }

        private void UserListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedUserName = "";
            string SelectedUserPhone = "";
            if (UserListView.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = UserListView.SelectedItems;
                ListViewItem lvitem = items[0];
                SelectedUserNum = lvitem.SubItems[0].Text;
                SelectedUserName = lvitem.SubItems[1].Text;
                SelectedUserPhone = lvitem.SubItems[3].Text;
            }
            UserIdTB.Text = SelectedUserName;
            UserPhoneTB.Text = SelectedUserPhone;
        }

        private void UserDeleteBtn_Click(object sender, EventArgs e)
        {
            string UserNum = SelectedUserNum;
            if (string.IsNullOrEmpty(UserNum) || UserNum != "")
            {
                string query = "delete from TEST_SYSTEM_CODE_DATA where plant = 'user' and code_name = 'UC_"+ UserNum + "'";
                db.InsertQuery(query);
                MessageBox.Show("삭제 되었습니다.");
            }
            else
            {
                MessageBox.Show("회원을 선택해주세요.");
            }
        }

        private void UserSearchBtn_Click(object sender, EventArgs e)
        {
            string seachType = ChangeComboBoxForUser(userComboBox.Text);
            string seachValue = SearchTB.Text;
            db.SearchUser(seachType, seachValue,UserListView);
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

        
    }
}