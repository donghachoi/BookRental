namespace ERP_Test.Plant
{
    partial class PlantList
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
            this.PlantListGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PlantListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 40F);
            this.label1.Location = new System.Drawing.Point(243, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "공장 리스트";
            // 
            // PlantListGrid
            // 
            this.PlantListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlantListGrid.Location = new System.Drawing.Point(12, 112);
            this.PlantListGrid.Name = "PlantListGrid";
            this.PlantListGrid.RowHeadersWidth = 51;
            this.PlantListGrid.RowTemplate.Height = 27;
            this.PlantListGrid.Size = new System.Drawing.Size(324, 304);
            this.PlantListGrid.TabIndex = 2;
            // 
            // PlantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 464);
            this.Controls.Add(this.PlantListGrid);
            this.Controls.Add(this.label1);
            this.Name = "PlantList";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.PlantListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PlantListGrid;
    }
}