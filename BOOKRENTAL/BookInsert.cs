using ERP_Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKRENTAL
{
    public partial class BookInsert : Form
    {
        DBconnection db;
        Main main = null;
        public BookInsert(Main main)
        {
            InitializeComponent();
            initializeDateTimePicker();
            db = new DBconnection();
            db.DBConnection();
            this.main = main;
        }
        private void initializeDateTimePicker()
        {
            publichdatepicker.CustomFormat = "yyyy-MM-dd";
            publichdatepicker.Format = DateTimePickerFormat.Custom;
        }

        /// 책정보 입력시 입력됩니다. 유효성검사 전
        private void bookInsertBtn_Click(object sender, EventArgs e)
        {
            string bookTitle = bookTitleTB.Text;
            string bookPublisher = bookPublisherTB.Text;
            string bookwriter = bookWriterTB.Text;
            string bicCategory = bicCategoryCB.Text;
            string midCategory = midCategoryCB.Text;
            string samllCategory = smallCategoryCB.Text;
            string publishDate = publichdatepicker.Value.ToString("yyyy-MM-dd");
            int Seq = db.GetCodeTableCount("books");
            string bookCode = "BC_" + Seq.ToString();
            string genreCode = "GC_"+ Seq.ToString();
            string publisherCode = "PC_" + Seq.ToString();
            //해당책의 출판사 정보 insert query입니다.
            string publisherQuery = "insert into TEST_SYSTEM_CODE_DATA (PLANT,TABLE_NAME,CODE_NAME,CODE_SEQ,DESCRIPTION,CODE_GROUP1,CODE_GROUP2,CODE_GROUP3)"
                                + "values('books', 'bookpublisher', '" + publisherCode + "',0, '" + bookTitle + "의 출판사정보가 들어있습니다.','" + bookPublisher + "', '" + bookwriter + "', '" + publishDate + "')";
            //해당책의 장르 정보 insert query입니다.
            string genreQuery = "insert into TEST_SYSTEM_CODE_DATA (PLANT,TABLE_NAME,CODE_NAME,CODE_SEQ,DESCRIPTION,CODE_GROUP1,CODE_GROUP2,CODE_GROUP3)"
                                + "values('books', 'bookgenre', '" + genreCode + "', 0,'" + bookTitle + "의 장르정보가 들어있습니다.','" + bicCategory + "', '" + midCategory + "', '" + samllCategory + "')";
            //해당책의 그룹1에는 장르코드가 들어가고 그룹2에는 출판사 정보가 들어갑니다 그리고 그룹3에는 대여가능 여부가 있습니다 default. 
            string MainQuery = "insert into TEST_SYSTEM_CODE_DATA (PLANT,TABLE_NAME,CODE_NAME,CODE_SEQ,DESCRIPTION,CODE_GROUP1,CODE_GROUP2,CODE_GROUP3)"
                                + "values('books', 'bookstable', '"+ bookCode + "', 0, '" + bookTitle +"','"+ genreCode + "', '"+ publisherCode + "', 'true')";
            
            db.InsertQuery(publisherQuery);
            db.InsertQuery(genreQuery);
            db.InsertQuery(MainQuery);
            MessageBox.Show("등록되었습니다.");
            this.Close();

        }

        //닫기 버튼클릭시 창닫기
        private void bookInsertClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //중분류 콤보박스 변경시에 소분류 콤보박스 변경
        private void midCategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            smallCategoryCB.Items.Clear();
            smallCategoryCB.Text = "";
            string midCategory = midCategoryCB.Text;
            Console.WriteLine(midCategory);
            switch (midCategory)
            {
                case "소설":
                    smallCategoryCB.Items.Add("고전");
                    smallCategoryCB.Items.Add("근대소설");
                    smallCategoryCB.Items.Add("현대소설");
                    break;
                case "자기계발":
                    smallCategoryCB.Items.Add("성공전략");
                    smallCategoryCB.Items.Add("직장인을 위한 자기계발");
                    smallCategoryCB.Items.Add("진로설계");
                    break;
                case "전공":
                    smallCategoryCB.Items.Add("사회과학");
                    smallCategoryCB.Items.Add("자연과 과학");
                    smallCategoryCB.Items.Add("대중문화");
                    break;
                case "취미":
                    smallCategoryCB.Items.Add("레져");
                    smallCategoryCB.Items.Add("인테리어");
                    smallCategoryCB.Items.Add("애완동물");
                    break;
                
            }
        }
    }
}
