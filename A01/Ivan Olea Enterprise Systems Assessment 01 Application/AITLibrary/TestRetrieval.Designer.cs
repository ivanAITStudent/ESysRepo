namespace AITLibrary
{
    partial class TestRetrieval
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
            this.dataGridView_testRetrieval = new System.Windows.Forms.DataGridView();
            this.btn_showAllUsers = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.director_tb = new System.Windows.Forms.TextBox();
            this.year_tb = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.year_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_testRetrieval)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_testRetrieval
            // 
            this.dataGridView_testRetrieval.AllowUserToAddRows = false;
            this.dataGridView_testRetrieval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_testRetrieval.Location = new System.Drawing.Point(30, 12);
            this.dataGridView_testRetrieval.Name = "dataGridView_testRetrieval";
            this.dataGridView_testRetrieval.Size = new System.Drawing.Size(888, 150);
            this.dataGridView_testRetrieval.TabIndex = 0;
            // 
            // btn_showAllUsers
            // 
            this.btn_showAllUsers.Location = new System.Drawing.Point(30, 180);
            this.btn_showAllUsers.Name = "btn_showAllUsers";
            this.btn_showAllUsers.Size = new System.Drawing.Size(146, 23);
            this.btn_showAllUsers.TabIndex = 1;
            this.btn_showAllUsers.Text = "Show All Users";
            this.btn_showAllUsers.UseVisualStyleBackColor = true;
            this.btn_showAllUsers.Visible = false;
            this.btn_showAllUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(772, 180);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(146, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.Search_Click);
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(226, 183);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(121, 20);
            this.title_tb.TabIndex = 4;
            // 
            // director_tb
            // 
            this.director_tb.Location = new System.Drawing.Point(413, 183);
            this.director_tb.Name = "director_tb";
            this.director_tb.Size = new System.Drawing.Size(121, 20);
            this.director_tb.TabIndex = 5;
            // 
            // year_tb
            // 
            this.year_tb.Location = new System.Drawing.Point(595, 183);
            this.year_tb.Name = "year_tb";
            this.year_tb.Size = new System.Drawing.Size(121, 20);
            this.year_tb.TabIndex = 6;
            this.year_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(320, 206);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(27, 13);
            this.title_lbl.TabIndex = 7;
            this.title_lbl.Text = "Title";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(490, 206);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date_lbl.Size = new System.Drawing.Size(44, 13);
            this.date_lbl.TabIndex = 8;
            this.date_lbl.Text = "Director";
            this.date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Location = new System.Drawing.Point(658, 206);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.year_lbl.Size = new System.Drawing.Size(58, 13);
            this.year_lbl.TabIndex = 9;
            this.year_lbl.Text = "Year (yyyy)";
            this.year_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // TestRetrieval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.year_lbl);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.year_tb);
            this.Controls.Add(this.director_tb);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.btn_showAllUsers);
            this.Controls.Add(this.dataGridView_testRetrieval);
            this.Name = "TestRetrieval";
            this.Text = "displayInfo";
            this.Load += new System.EventHandler(this.TestRetrieval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_testRetrieval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_testRetrieval;
        private System.Windows.Forms.Button btn_showAllUsers;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.TextBox director_tb;
        private System.Windows.Forms.TextBox year_tb;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.Label label1;
    }
}

