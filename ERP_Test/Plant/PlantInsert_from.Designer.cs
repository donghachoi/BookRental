namespace ERP_Test.Plant
{
    partial class PlantInsert_from
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlantInsert = new System.Windows.Forms.Button();
            this.PlantDes = new System.Windows.Forms.TextBox();
            this.PlantName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.92308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.07692F));
            this.tableLayoutPanel1.Controls.Add(this.PlantInsert, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.PlantDes, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlantName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(146, 134);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33777F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 107);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PlantInsert
            // 
            this.PlantInsert.Dock = System.Windows.Forms.DockStyle.Right;
            this.PlantInsert.Location = new System.Drawing.Point(406, 73);
            this.PlantInsert.Name = "PlantInsert";
            this.PlantInsert.Size = new System.Drawing.Size(94, 31);
            this.PlantInsert.TabIndex = 4;
            this.PlantInsert.Text = "등록하기";
            this.PlantInsert.UseVisualStyleBackColor = true;
            this.PlantInsert.Click += new System.EventHandler(this.PlantInsert_Click);
            // 
            // PlantDes
            // 
            this.PlantDes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlantDes.Location = new System.Drawing.Point(98, 38);
            this.PlantDes.Name = "PlantDes";
            this.PlantDes.Size = new System.Drawing.Size(402, 25);
            this.PlantDes.TabIndex = 5;
            // 
            // PlantName
            // 
            this.PlantName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlantName.Location = new System.Drawing.Point(98, 3);
            this.PlantName.Name = "PlantName";
            this.PlantName.Size = new System.Drawing.Size(402, 25);
            this.PlantName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "공장 이름 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "공장 설명 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 40F);
            this.label1.Location = new System.Drawing.Point(250, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "공장 등록";
            // 
            // PlantInsert_from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlantInsert_from";
            this.Text = "PlantInsert";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlantDes;
        private System.Windows.Forms.TextBox PlantName;
        private System.Windows.Forms.Button PlantInsert;
    }
}