namespace BOOKRENTAL
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("고전");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("근대소설");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("현대소설");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("소설", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("성공전략");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("직장인을 위한 자기계발");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("진로설계");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("자기계발", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("사회과학");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("자연과 과학");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("대중문화");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("전공", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("레져");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("인테리어");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("애완동물");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("취미", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("국내", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("고전");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("근대소설");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("현대소설");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("소설", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("성공전략");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("직장인을 위한 자기계발");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("진로설계");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("자기계발", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("사회과학");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("자연과 과학");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("대중문화");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("전공", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("레져");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("인테리어");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("애완동물");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("취미", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("해외", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode25,
            treeNode29,
            treeNode33});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.headPanel = new System.Windows.Forms.Panel();
            this.EndBtn = new System.Windows.Forms.Button();
            this.RedirectBtn = new System.Windows.Forms.Button();
            this.BookInsertBtn = new System.Windows.Forms.Button();
            this.UserInsertBtn = new System.Windows.Forms.Button();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bookDetail = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bookWriterTB = new System.Windows.Forms.TextBox();
            this.bookPublisherTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.BookDeleteBtn = new System.Windows.Forms.Button();
            this.RentalBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.bookTitleTB = new System.Windows.Forms.TextBox();
            this.bookNumTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.BookSearchCB = new System.Windows.Forms.ComboBox();
            this.BookSearchTB = new System.Windows.Forms.TextBox();
            this.BookSearchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BookListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.userDetail = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UserIdTB = new System.Windows.Forms.TextBox();
            this.UserPhoneTB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.UserSearchBtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.UserDeleteBtn = new System.Windows.Forms.Button();
            this.UserUpdateBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.UserListView = new System.Windows.Forms.ListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.RentlistView = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.Leftpanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.bookDetail.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.userDetail.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.headPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Leftpanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 836);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.SetColumnSpan(this.headPanel, 2);
            this.headPanel.Controls.Add(this.EndBtn);
            this.headPanel.Controls.Add(this.RedirectBtn);
            this.headPanel.Controls.Add(this.BookInsertBtn);
            this.headPanel.Controls.Add(this.UserInsertBtn);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headPanel.Location = new System.Drawing.Point(3, 2);
            this.headPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1133, 146);
            this.headPanel.TabIndex = 0;
            // 
            // EndBtn
            // 
            this.EndBtn.BackColor = System.Drawing.Color.White;
            this.EndBtn.Font = new System.Drawing.Font("돋움", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EndBtn.Location = new System.Drawing.Point(870, 39);
            this.EndBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(240, 65);
            this.EndBtn.TabIndex = 3;
            this.EndBtn.Text = "프로그램 종료";
            this.EndBtn.UseVisualStyleBackColor = false;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // RedirectBtn
            // 
            this.RedirectBtn.BackColor = System.Drawing.Color.White;
            this.RedirectBtn.Font = new System.Drawing.Font("돋움", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RedirectBtn.Location = new System.Drawing.Point(593, 39);
            this.RedirectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RedirectBtn.Name = "RedirectBtn";
            this.RedirectBtn.Size = new System.Drawing.Size(240, 65);
            this.RedirectBtn.TabIndex = 2;
            this.RedirectBtn.Text = "새로고침";
            this.RedirectBtn.UseVisualStyleBackColor = false;
            this.RedirectBtn.Click += new System.EventHandler(this.RedirectBtn_Click);
            // 
            // BookInsertBtn
            // 
            this.BookInsertBtn.BackColor = System.Drawing.Color.White;
            this.BookInsertBtn.Font = new System.Drawing.Font("돋움", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BookInsertBtn.Location = new System.Drawing.Point(315, 39);
            this.BookInsertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookInsertBtn.Name = "BookInsertBtn";
            this.BookInsertBtn.Size = new System.Drawing.Size(240, 65);
            this.BookInsertBtn.TabIndex = 1;
            this.BookInsertBtn.Text = "책 등록";
            this.BookInsertBtn.UseVisualStyleBackColor = false;
            this.BookInsertBtn.Click += new System.EventHandler(this.BookInsertBtn_Click);
            // 
            // UserInsertBtn
            // 
            this.UserInsertBtn.BackColor = System.Drawing.Color.White;
            this.UserInsertBtn.Font = new System.Drawing.Font("돋움", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserInsertBtn.Location = new System.Drawing.Point(34, 39);
            this.UserInsertBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserInsertBtn.Name = "UserInsertBtn";
            this.UserInsertBtn.Size = new System.Drawing.Size(240, 65);
            this.UserInsertBtn.TabIndex = 0;
            this.UserInsertBtn.Text = "회원등록";
            this.UserInsertBtn.UseVisualStyleBackColor = false;
            this.UserInsertBtn.Click += new System.EventHandler(this.UserInsertBtn_Click);
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.Leftpanel, 2);
            this.Leftpanel.Controls.Add(this.tabControl1);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Leftpanel.Location = new System.Drawing.Point(3, 152);
            this.Leftpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(1133, 682);
            this.Leftpanel.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bookDetail);
            this.tabControl1.Controls.Add(this.userDetail);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1133, 682);
            this.tabControl1.TabIndex = 4;
            // 
            // bookDetail
            // 
            this.bookDetail.Controls.Add(this.tableLayoutPanel2);
            this.bookDetail.Location = new System.Drawing.Point(4, 25);
            this.bookDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookDetail.Name = "bookDetail";
            this.bookDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookDetail.Size = new System.Drawing.Size(1125, 653);
            this.bookDetail.TabIndex = 0;
            this.bookDetail.Text = "책정보";
            this.bookDetail.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.89975F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.10025F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1119, 649);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(253, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 313);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.10122F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.89878F));
            this.tableLayoutPanel4.Controls.Add(this.bookWriterTB, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.bookPublisherTB, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel8, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(863, 313);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // bookWriterTB
            // 
            this.bookWriterTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookWriterTB.Location = new System.Drawing.Point(116, 130);
            this.bookWriterTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookWriterTB.Name = "bookWriterTB";
            this.bookWriterTB.Size = new System.Drawing.Size(167, 25);
            this.bookWriterTB.TabIndex = 14;
            // 
            // bookPublisherTB
            // 
            this.bookPublisherTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookPublisherTB.Location = new System.Drawing.Point(116, 73);
            this.bookPublisherTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookPublisherTB.Name = "bookPublisherTB";
            this.bookPublisherTB.Size = new System.Drawing.Size(167, 25);
            this.bookPublisherTB.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 57);
            this.label11.TabIndex = 11;
            this.label11.Text = "검색 :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 57);
            this.label5.TabIndex = 5;
            this.label5.Text = "저자 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 57);
            this.label3.TabIndex = 3;
            this.label3.Text = "출판사 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.panel8, 2);
            this.panel8.Controls.Add(this.tableLayoutPanel7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 232);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(857, 77);
            this.panel8.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel7.Controls.Add(this.cancelBtn, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.BookDeleteBtn, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.RentalBtn, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(857, 77);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelBtn.Location = new System.Drawing.Point(573, 4);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(281, 69);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "취소";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // BookDeleteBtn
            // 
            this.BookDeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookDeleteBtn.Location = new System.Drawing.Point(288, 4);
            this.BookDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookDeleteBtn.Name = "BookDeleteBtn";
            this.BookDeleteBtn.Size = new System.Drawing.Size(279, 69);
            this.BookDeleteBtn.TabIndex = 2;
            this.BookDeleteBtn.Text = "삭제";
            this.BookDeleteBtn.UseVisualStyleBackColor = true;
            this.BookDeleteBtn.Click += new System.EventHandler(this.BookDeleteBtn_Click);
            // 
            // RentalBtn
            // 
            this.RentalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentalBtn.Location = new System.Drawing.Point(3, 4);
            this.RentalBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RentalBtn.Name = "RentalBtn";
            this.RentalBtn.Size = new System.Drawing.Size(279, 69);
            this.RentalBtn.TabIndex = 0;
            this.RentalBtn.Text = "대여";
            this.RentalBtn.UseVisualStyleBackColor = true;
            this.RentalBtn.Click += new System.EventHandler(this.RentalBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "책 제목 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 717F));
            this.tableLayoutPanel5.Controls.Add(this.bookTitleTB, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.bookNumTB, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(116, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(744, 49);
            this.tableLayoutPanel5.TabIndex = 18;
            // 
            // bookTitleTB
            // 
            this.bookTitleTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookTitleTB.Location = new System.Drawing.Point(3, 12);
            this.bookTitleTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookTitleTB.Name = "bookTitleTB";
            this.bookTitleTB.Size = new System.Drawing.Size(164, 25);
            this.bookTitleTB.TabIndex = 0;
            // 
            // bookNumTB
            // 
            this.bookNumTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookNumTB.Location = new System.Drawing.Point(259, 12);
            this.bookNumTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookNumTB.Name = "bookNumTB";
            this.bookNumTB.Size = new System.Drawing.Size(54, 25);
            this.bookNumTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(179, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "책 번호 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 687F));
            this.tableLayoutPanel6.Controls.Add(this.BookSearchCB, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.BookSearchTB, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.BookSearchBtn, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(116, 175);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(744, 49);
            this.tableLayoutPanel6.TabIndex = 19;
            // 
            // BookSearchCB
            // 
            this.BookSearchCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BookSearchCB.FormattingEnabled = true;
            this.BookSearchCB.Items.AddRange(new object[] {
            "책번호",
            "책이름",
            "출판사",
            "저자"});
            this.BookSearchCB.Location = new System.Drawing.Point(3, 13);
            this.BookSearchCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookSearchCB.Name = "BookSearchCB";
            this.BookSearchCB.Size = new System.Drawing.Size(111, 23);
            this.BookSearchCB.TabIndex = 0;
            // 
            // BookSearchTB
            // 
            this.BookSearchTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BookSearchTB.Location = new System.Drawing.Point(122, 12);
            this.BookSearchTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookSearchTB.Name = "BookSearchTB";
            this.BookSearchTB.Size = new System.Drawing.Size(158, 25);
            this.BookSearchTB.TabIndex = 1;
            // 
            // BookSearchBtn
            // 
            this.BookSearchBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BookSearchBtn.Location = new System.Drawing.Point(289, 11);
            this.BookSearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BookSearchBtn.Name = "BookSearchBtn";
            this.BookSearchBtn.Size = new System.Drawing.Size(86, 26);
            this.BookSearchBtn.TabIndex = 2;
            this.BookSearchBtn.Text = "검색";
            this.BookSearchBtn.UseVisualStyleBackColor = true;
            this.BookSearchBtn.Click += new System.EventHandler(this.BookSearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.BookListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 319);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 328);
            this.panel1.TabIndex = 0;
            // 
            // BookListView
            // 
            this.BookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.BookListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookListView.FullRowSelect = true;
            this.BookListView.GridLines = true;
            this.BookListView.HideSelection = false;
            this.BookListView.Location = new System.Drawing.Point(0, 0);
            this.BookListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookListView.MultiSelect = false;
            this.BookListView.Name = "BookListView";
            this.BookListView.Size = new System.Drawing.Size(1113, 328);
            this.BookListView.TabIndex = 0;
            this.BookListView.UseCompatibleStateImageBehavior = false;
            this.BookListView.View = System.Windows.Forms.View.Details;
            this.BookListView.Click += new System.EventHandler(this.BookListView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "책번호";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "제목";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "출판사";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "저자";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "등록일자";
            this.columnHeader5.Width = 131;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "대분류";
            this.columnHeader6.Width = 132;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "중분류";
            this.columnHeader7.Width = 121;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "소분류";
            this.columnHeader8.Width = 159;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 313);
            this.panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드10";
            treeNode1.Text = "고전";
            treeNode2.Name = "노드11";
            treeNode2.Text = "근대소설";
            treeNode3.Name = "노드12";
            treeNode3.Text = "현대소설";
            treeNode4.Name = "노드2";
            treeNode4.Text = "소설";
            treeNode5.Name = "노드13";
            treeNode5.Text = "성공전략";
            treeNode6.Name = "노드14";
            treeNode6.Text = "직장인을 위한 자기계발";
            treeNode7.Name = "노드15";
            treeNode7.Text = "진로설계";
            treeNode8.Name = "노드3";
            treeNode8.Text = "자기계발";
            treeNode9.Name = "노드16";
            treeNode9.Text = "사회과학";
            treeNode10.Name = "노드17";
            treeNode10.Text = "자연과 과학";
            treeNode11.Name = "노드18";
            treeNode11.Text = "대중문화";
            treeNode12.Name = "노드4";
            treeNode12.Text = "전공";
            treeNode13.Name = "노드19";
            treeNode13.Text = "레져";
            treeNode14.Name = "노드20";
            treeNode14.Text = "인테리어";
            treeNode15.Name = "노드21";
            treeNode15.Text = "애완동물";
            treeNode16.Name = "노드5";
            treeNode16.Text = "취미";
            treeNode17.Name = "노드0";
            treeNode17.Text = "국내";
            treeNode18.Name = "노드0";
            treeNode18.Text = "고전";
            treeNode19.Name = "노드1";
            treeNode19.Text = "근대소설";
            treeNode20.Name = "노드2";
            treeNode20.Text = "현대소설";
            treeNode21.Name = "노드6";
            treeNode21.Text = "소설";
            treeNode22.Name = "노드3";
            treeNode22.Text = "성공전략";
            treeNode23.Name = "노드4";
            treeNode23.Text = "직장인을 위한 자기계발";
            treeNode24.Name = "노드5";
            treeNode24.Text = "진로설계";
            treeNode25.Name = "노드7";
            treeNode25.Text = "자기계발";
            treeNode26.Name = "노드6";
            treeNode26.Text = "사회과학";
            treeNode27.Name = "노드7";
            treeNode27.Text = "자연과 과학";
            treeNode28.Name = "노드8";
            treeNode28.Text = "대중문화";
            treeNode29.Name = "노드8";
            treeNode29.Text = "전공";
            treeNode30.Name = "노드9";
            treeNode30.Text = "레져";
            treeNode31.Name = "노드10";
            treeNode31.Text = "인테리어";
            treeNode32.Name = "노드11";
            treeNode32.Text = "애완동물";
            treeNode33.Name = "노드9";
            treeNode33.Text = "취미";
            treeNode34.Name = "노드1";
            treeNode34.Text = "해외";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode34});
            this.treeView1.Size = new System.Drawing.Size(244, 313);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // userDetail
            // 
            this.userDetail.BackColor = System.Drawing.Color.White;
            this.userDetail.Controls.Add(this.tableLayoutPanel3);
            this.userDetail.Location = new System.Drawing.Point(4, 25);
            this.userDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userDetail.Name = "userDetail";
            this.userDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userDetail.Size = new System.Drawing.Size(1125, 653);
            this.userDetail.TabIndex = 1;
            this.userDetail.Text = "회원정보";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.37405F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.62595F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1119, 649);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.tableLayoutPanel3.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.tableLayoutPanel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1113, 296);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 794F));
            this.tableLayoutPanel8.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.UserIdTB, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.UserPhoneTB, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.panel9, 0, 3);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.99946F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.99945F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.99944F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.00166F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1113, 296);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 71);
            this.label14.TabIndex = 6;
            this.label14.Text = "전화번호 :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 71);
            this.label4.TabIndex = 0;
            this.label4.Text = "회원이름 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 71);
            this.label12.TabIndex = 12;
            this.label12.Text = "검색 :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserIdTB
            // 
            this.UserIdTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserIdTB.Location = new System.Drawing.Point(210, 23);
            this.UserIdTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserIdTB.Name = "UserIdTB";
            this.UserIdTB.Size = new System.Drawing.Size(180, 25);
            this.UserIdTB.TabIndex = 13;
            // 
            // UserPhoneTB
            // 
            this.UserPhoneTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserPhoneTB.Location = new System.Drawing.Point(210, 94);
            this.UserPhoneTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPhoneTB.Name = "UserPhoneTB";
            this.UserPhoneTB.Size = new System.Drawing.Size(180, 25);
            this.UserPhoneTB.TabIndex = 15;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.70588F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.92157F));
            this.tableLayoutPanel9.Controls.Add(this.userComboBox, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.SearchTB, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.UserSearchBtn, 2, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(210, 146);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(369, 63);
            this.tableLayoutPanel9.TabIndex = 17;
            // 
            // userComboBox
            // 
            this.userComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Items.AddRange(new object[] {
            "회원이름",
            "생년월일",
            "전화번호"});
            this.userComboBox.Location = new System.Drawing.Point(3, 20);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(68, 23);
            this.userComboBox.TabIndex = 0;
            // 
            // SearchTB
            // 
            this.SearchTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchTB.Location = new System.Drawing.Point(94, 19);
            this.SearchTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(138, 25);
            this.SearchTB.TabIndex = 1;
            // 
            // UserSearchBtn
            // 
            this.UserSearchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserSearchBtn.Location = new System.Drawing.Point(282, 4);
            this.UserSearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserSearchBtn.Name = "UserSearchBtn";
            this.UserSearchBtn.Size = new System.Drawing.Size(84, 55);
            this.UserSearchBtn.TabIndex = 2;
            this.UserSearchBtn.Text = "검색";
            this.UserSearchBtn.UseVisualStyleBackColor = true;
            this.UserSearchBtn.Click += new System.EventHandler(this.UserSearchBtn_Click);
            // 
            // panel9
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.panel9, 3);
            this.panel9.Controls.Add(this.tableLayoutPanel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 217);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1370, 75);
            this.panel9.TabIndex = 18;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Controls.Add(this.UserDeleteBtn, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.UserUpdateBtn, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1370, 75);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // UserDeleteBtn
            // 
            this.UserDeleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDeleteBtn.Location = new System.Drawing.Point(7, 8);
            this.UserDeleteBtn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.UserDeleteBtn.Name = "UserDeleteBtn";
            this.UserDeleteBtn.Size = new System.Drawing.Size(442, 59);
            this.UserDeleteBtn.TabIndex = 1;
            this.UserDeleteBtn.Text = "회원삭제";
            this.UserDeleteBtn.UseVisualStyleBackColor = true;
            this.UserDeleteBtn.Click += new System.EventHandler(this.UserDeleteBtn_Click);
            // 
            // UserUpdateBtn
            // 
            this.UserUpdateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserUpdateBtn.Location = new System.Drawing.Point(463, 8);
            this.UserUpdateBtn.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.UserUpdateBtn.Name = "UserUpdateBtn";
            this.UserUpdateBtn.Size = new System.Drawing.Size(442, 59);
            this.UserUpdateBtn.TabIndex = 0;
            this.UserUpdateBtn.Text = "회원수정";
            this.UserUpdateBtn.UseVisualStyleBackColor = true;
            this.UserUpdateBtn.Click += new System.EventHandler(this.UserUpdateBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel3.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.UserListView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 304);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1113, 341);
            this.panel5.TabIndex = 2;
            // 
            // UserListView
            // 
            this.UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader23,
            this.columnHeader9});
            this.UserListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserListView.FullRowSelect = true;
            this.UserListView.GridLines = true;
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(0, 0);
            this.UserListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserListView.MultiSelect = false;
            this.UserListView.Name = "UserListView";
            this.UserListView.ShowGroups = false;
            this.UserListView.Size = new System.Drawing.Size(1113, 341);
            this.UserListView.TabIndex = 0;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            this.UserListView.View = System.Windows.Forms.View.Details;
            this.UserListView.SelectedIndexChanged += new System.EventHandler(this.UserListView_SelectedIndexChanged);
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "회원번호";
            this.columnHeader18.Width = 108;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "회원이름";
            this.columnHeader19.Width = 109;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "생년월일";
            this.columnHeader20.Width = 127;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "전화번호";
            this.columnHeader21.Width = 106;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "성별";
            this.columnHeader23.Width = 89;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "대여한책";
            this.columnHeader9.Width = 80;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel11);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1125, 653);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "대여현황";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.ReturnBtn, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.RentlistView, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.19728F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.80272F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1119, 645);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBtn.Location = new System.Drawing.Point(796, 43);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(3, 4, 17, 19);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(306, 55);
            this.ReturnBtn.TabIndex = 0;
            this.ReturnBtn.Text = "반납하기";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // RentlistView
            // 
            this.RentlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader17,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader22,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader15,
            this.columnHeader16});
            this.RentlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentlistView.FullRowSelect = true;
            this.RentlistView.GridLines = true;
            this.RentlistView.HideSelection = false;
            this.RentlistView.Location = new System.Drawing.Point(3, 121);
            this.RentlistView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RentlistView.Name = "RentlistView";
            this.RentlistView.Size = new System.Drawing.Size(1113, 520);
            this.RentlistView.TabIndex = 1;
            this.RentlistView.UseCompatibleStateImageBehavior = false;
            this.RentlistView.View = System.Windows.Forms.View.Details;
            this.RentlistView.SelectedIndexChanged += new System.EventHandler(this.RentlistView_SelectedIndexChanged);
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "NO.";
            this.columnHeader14.Width = 91;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "빌린사람";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 91;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "전화번호";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 165;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "생년월일";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "장르";
            this.columnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader22.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "책제목";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 147;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "출판사";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 71;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "저자";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 105;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "대여날짜";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 122;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1139, 836);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            this.Leftpanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.bookDetail.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.userDetail.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Button RedirectBtn;
        private System.Windows.Forms.Button BookInsertBtn;
        private System.Windows.Forms.Button UserInsertBtn;
        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bookDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox bookWriterTB;
        private System.Windows.Forms.TextBox bookPublisherTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button BookDeleteBtn;
        private System.Windows.Forms.Button RentalBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox bookTitleTB;
        private System.Windows.Forms.TextBox bookNumTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox BookSearchCB;
        private System.Windows.Forms.TextBox BookSearchTB;
        private System.Windows.Forms.Button BookSearchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView BookListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage userDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox UserIdTB;
        private System.Windows.Forms.TextBox UserPhoneTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Button UserSearchBtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button UserDeleteBtn;
        private System.Windows.Forms.Button UserUpdateBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.ListView RentlistView;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader22;
    }
}

