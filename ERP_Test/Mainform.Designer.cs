namespace ERP_Test
{
    partial class Mainform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.plantInsert = new System.Windows.Forms.Button();
            this.plantList = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.productInsert = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeInsert = new System.Windows.Forms.Button();
            this.employeeList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.plantInsert);
            this.panel1.Controls.Add(this.plantList);
            this.panel1.Location = new System.Drawing.Point(126, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 202);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "공장";
            // 
            // plantInsert
            // 
            this.plantInsert.Location = new System.Drawing.Point(25, 28);
            this.plantInsert.Name = "plantInsert";
            this.plantInsert.Size = new System.Drawing.Size(183, 23);
            this.plantInsert.TabIndex = 3;
            this.plantInsert.Text = "공장등록";
            this.plantInsert.UseVisualStyleBackColor = true;
            this.plantInsert.Click += new System.EventHandler(this.plantInsert_Click);
            // 
            // plantList
            // 
            this.plantList.Location = new System.Drawing.Point(25, 68);
            this.plantList.Name = "plantList";
            this.plantList.Size = new System.Drawing.Size(183, 23);
            this.plantList.TabIndex = 4;
            this.plantList.Text = "공장리스트";
            this.plantList.UseVisualStyleBackColor = true;
            this.plantList.Click += new System.EventHandler(this.plantList_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.productInsert);
            this.panel3.Controls.Add(this.productList);
            this.panel3.Location = new System.Drawing.Point(799, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 202);
            this.panel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "상품";
            // 
            // productInsert
            // 
            this.productInsert.Location = new System.Drawing.Point(25, 28);
            this.productInsert.Name = "productInsert";
            this.productInsert.Size = new System.Drawing.Size(183, 23);
            this.productInsert.TabIndex = 3;
            this.productInsert.Text = "상품등록";
            this.productInsert.UseVisualStyleBackColor = true;
            // 
            // productList
            // 
            this.productList.Location = new System.Drawing.Point(25, 68);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(183, 23);
            this.productList.TabIndex = 4;
            this.productList.Text = "상품리스트";
            this.productList.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.employeeInsert);
            this.panel2.Controls.Add(this.employeeList);
            this.panel2.Location = new System.Drawing.Point(462, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 202);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "직원";
            // 
            // employeeInsert
            // 
            this.employeeInsert.Location = new System.Drawing.Point(25, 28);
            this.employeeInsert.Name = "employeeInsert";
            this.employeeInsert.Size = new System.Drawing.Size(183, 23);
            this.employeeInsert.TabIndex = 3;
            this.employeeInsert.Text = "직원등록";
            this.employeeInsert.UseVisualStyleBackColor = true;
            this.employeeInsert.Click += new System.EventHandler(this.employeeInsert_Click);
            // 
            // employeeList
            // 
            this.employeeList.Location = new System.Drawing.Point(25, 68);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(183, 23);
            this.employeeList.TabIndex = 4;
            this.employeeList.Text = "직원리스트";
            this.employeeList.UseVisualStyleBackColor = true;
            this.employeeList.Click += new System.EventHandler(this.employeeList_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 479);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Mainform";
            this.Text = "Mainfrom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button plantInsert;
        private System.Windows.Forms.Button plantList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button employeeInsert;
        private System.Windows.Forms.Button employeeList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button productInsert;
        private System.Windows.Forms.Button productList;
    }
}