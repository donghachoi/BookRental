using ERP_Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKRENTAL
{
    public partial class UserInsert : Form
    {
        DBconnection db;
        Main main;
        public UserInsert(Main main)
        {
            InitializeComponent();
            db = new DBconnection();
            db.DBConnection();
        }

        private void UserInsertBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTB.Text;
            string userBirth = UserBirthTB.Text;
            string userPhone = UserPhoneTB.Text;
            string sex;

            if (MaleRdiobox.Checked)
                sex = "남";
            else
                sex = "여";

            int SeqNum = db.GetCodeTableCount("user");
            string userCode = "UC_" + SeqNum.ToString();
            Console.WriteLine(SeqNum.ToString()); 
            string Query = "insert into TEST_SYSTEM_CODE_DATA (PLANT,TABLE_NAME,CODE_NAME,DESCRIPTION,CODE_GROUP1,CODE_GROUP2,CODE_GROUP3)"+
                        "values('user', 'usertable', '"+ userCode + "', '"+ userName + "', '"+ userBirth + "','"+ userPhone + "','"+ sex + "')";
            db.InsertQuery(Query);
            MessageBox.Show("등록되었습니다.");
            this.Close();
        }

        private void UserinsertCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool isTypied = true;
        string placeHolderForBirthTB = "EX)990101";
        private void UserBirthTB_Enter(object sender, EventArgs e)
        {
            if (isTypied || UserBirthTB.Text == placeHolderForBirthTB)
            {
                UserBirthTB.Text = "";
                UserBirthTB.ForeColor = Color.Black;
                UserBirthTB.Font = new Font(UserBirthTB.Font,FontStyle.Regular);
                isTypied = false;
            }
        }

        private void UserBirthTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserBirthTB.Text))
            {
                UserBirthTB.Text = placeHolderForBirthTB;
                UserBirthTB.ForeColor = Color.Gray;
                UserBirthTB.Font = new Font(UserBirthTB.Font, FontStyle.Italic);
            }
        }
    }
}
