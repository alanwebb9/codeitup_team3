namespace SearchScreen
{
    partial class welcomeScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(160, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please select an option from below";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.Location = new System.Drawing.Point(201, 206);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(167, 79);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search for Beds";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(201, 315);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(167, 79);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "Logout";
            this.logOut.UseVisualStyleBackColor = true;
            // 
            // welcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SearchScreen.Properties.Resources.types_of_flowers_15797190851;
            this.ClientSize = new System.Drawing.Size(579, 483);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(597, 530);
            this.MinimumSize = new System.Drawing.Size(597, 530);
            this.Name = "welcomeScreen";
            this.Text = "Welcome | Please Select an Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button logOut;
    }
}

