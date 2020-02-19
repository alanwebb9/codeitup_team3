namespace SearchScreen
{
    partial class searchForm
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
            this.searchHospBtn = new System.Windows.Forms.Button();
            this.searchCatBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select an Option";
            // 
            // searchHospBtn
            // 
            this.searchHospBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchHospBtn.Location = new System.Drawing.Point(102, 145);
            this.searchHospBtn.Name = "searchHospBtn";
            this.searchHospBtn.Size = new System.Drawing.Size(124, 93);
            this.searchHospBtn.TabIndex = 1;
            this.searchHospBtn.Text = "Search by Hospital";
            this.searchHospBtn.UseVisualStyleBackColor = true;
            this.searchHospBtn.Click += new System.EventHandler(this.searchHospBtn_Click);
            // 
            // searchCatBtn
            // 
            this.searchCatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCatBtn.Location = new System.Drawing.Point(300, 145);
            this.searchCatBtn.Name = "searchCatBtn";
            this.searchCatBtn.Size = new System.Drawing.Size(121, 93);
            this.searchCatBtn.TabIndex = 2;
            this.searchCatBtn.Text = "Search by Category";
            this.searchCatBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(205, 267);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 32);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(158, 98);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SearchScreen.Properties.Resources.hospital_ThinkstockPhotos_482858629_620x3301;
            this.ClientSize = new System.Drawing.Size(523, 320);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchCatBtn);
            this.Controls.Add(this.searchHospBtn);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(541, 367);
            this.MinimumSize = new System.Drawing.Size(541, 367);
            this.Name = "searchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Search | Select an Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchHospBtn;
        private System.Windows.Forms.Button searchCatBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox txtSearch;
    }
}