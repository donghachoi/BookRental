namespace ERP_Test.Employee
{
    partial class EmployeeInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.employeeLevel = new System.Windows.Forms.ComboBox();
            this.employeeDepartment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plantcombox = new System.Windows.Forms.ComboBox();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeDESC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeInsertBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 40F);
            this.label1.Location = new System.Drawing.Point(219, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(319, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "직원 등록";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.9473F));
            this.tableLayoutPanel1.Controls.Add(this.employeeLevel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.employeeDepartment, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.plantcombox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.employeeName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.employeeDESC, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(172, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 211);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // employeeLevel
            // 
            this.employeeLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.employeeLevel.FormattingEnabled = true;
            this.employeeLevel.Items.AddRange(new object[] {
            "상무",
            "수석",
            "책임",
            "선임",
            "전임",
            "주임",
            "사원",
            "수습"});
            this.employeeLevel.Location = new System.Drawing.Point(105, 129);
            this.employeeLevel.Name = "employeeLevel";
            this.employeeLevel.Size = new System.Drawing.Size(273, 23);
            this.employeeLevel.TabIndex = 15;
            // 
            // employeeDepartment
            // 
            this.employeeDepartment.Location = new System.Drawing.Point(105, 171);
            this.employeeDepartment.Name = "employeeDepartment";
            this.employeeDepartment.Size = new System.Drawing.Size(273, 25);
            this.employeeDepartment.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 43);
            this.label8.TabIndex = 8;
            this.label8.Text = "부서명 :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "특이 사항 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "이름 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "공장 이름 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plantcombox
            // 
            this.plantcombox.Dock = System.Windows.Forms.DockStyle.Left;
            this.plantcombox.FormattingEnabled = true;
            this.plantcombox.Location = new System.Drawing.Point(105, 45);
            this.plantcombox.Name = "plantcombox";
            this.plantcombox.Size = new System.Drawing.Size(273, 23);
            this.plantcombox.TabIndex = 2;
            // 
            // employeeName
            // 
            this.employeeName.Dock = System.Windows.Forms.DockStyle.Left;
            this.employeeName.Location = new System.Drawing.Point(105, 3);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(273, 25);
            this.employeeName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 42);
            this.label5.TabIndex = 11;
            this.label5.Text = "직책 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // employeeDESC
            // 
            this.employeeDESC.Location = new System.Drawing.Point(105, 87);
            this.employeeDESC.Name = "employeeDESC";
            this.employeeDESC.Size = new System.Drawing.Size(273, 25);
            this.employeeDESC.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.employeeInsertBtn);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 400);
            this.panel1.TabIndex = 2;
            // 
            // employeeInsertBtn
            // 
            this.employeeInsertBtn.Location = new System.Drawing.Point(397, 347);
            this.employeeInsertBtn.Name = "employeeInsertBtn";
            this.employeeInsertBtn.Size = new System.Drawing.Size(153, 30);
            this.employeeInsertBtn.TabIndex = 2;
            this.employeeInsertBtn.Text = "직원 등록";
            this.employeeInsertBtn.UseVisualStyleBackColor = true;
            this.employeeInsertBtn.Click += new System.EventHandler(this.employeeInsertBtn_Click);
            // 
            // EmployeeInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 510);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeInsert";
            this.Text = "employeeInsert";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox plantcombox;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button employeeInsertBtn;
        private System.Windows.Forms.ComboBox employeeLevel;
        private System.Windows.Forms.TextBox employeeDepartment;
        private System.Windows.Forms.TextBox employeeDESC;
    }
}