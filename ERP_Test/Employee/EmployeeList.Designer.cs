namespace ERP_Test.Employee
{
    partial class EmployeeList
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
            this.employeeListView = new System.Windows.Forms.ListView();
            this.CODE_NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DESCRIPTION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CODE_GROUP1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CODE_GROUP2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeTreeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 40F);
            this.label1.Location = new System.Drawing.Point(210, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "직원 조직도";
            // 
            // employeeListView
            // 
            this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CODE_NAME,
            this.DESCRIPTION,
            this.CODE_GROUP1,
            this.CODE_GROUP2});
            this.employeeListView.GridLines = true;
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(522, 690);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(550, 116);
            this.employeeListView.TabIndex = 2;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.Details;
            this.employeeListView.Visible = false;
            // 
            // CODE_NAME
            // 
            this.CODE_NAME.Text = "이름";
            this.CODE_NAME.Width = 128;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.Text = "특기";
            this.DESCRIPTION.Width = 106;
            // 
            // CODE_GROUP1
            // 
            this.CODE_GROUP1.Text = "직책";
            this.CODE_GROUP1.Width = 107;
            // 
            // CODE_GROUP2
            // 
            this.CODE_GROUP2.Text = "부서";
            this.CODE_GROUP2.Width = 115;
            // 
            // EmployeeTreeView1
            // 
            this.EmployeeTreeView1.Location = new System.Drawing.Point(124, 138);
            this.EmployeeTreeView1.Name = "EmployeeTreeView1";
            this.EmployeeTreeView1.Size = new System.Drawing.Size(526, 381);
            this.EmployeeTreeView1.TabIndex = 3;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 835);
            this.Controls.Add(this.EmployeeTreeView1);
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.ColumnHeader CODE_NAME;
        private System.Windows.Forms.ColumnHeader DESCRIPTION;
        private System.Windows.Forms.ColumnHeader CODE_GROUP1;
        private System.Windows.Forms.ColumnHeader CODE_GROUP2;
        private System.Windows.Forms.TreeView EmployeeTreeView1;
    }
}