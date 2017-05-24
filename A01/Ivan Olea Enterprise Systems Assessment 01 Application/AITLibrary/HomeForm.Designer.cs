namespace AITLibrary
{
    partial class HomeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.year_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.year_tb = new System.Windows.Forms.TextBox();
            this.director_tb = new System.Windows.Forms.TextBox();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.borrow_btn = new System.Windows.Forms.Button();
            this.reserve_btn = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.details_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(848, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Location = new System.Drawing.Point(619, 326);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.year_lbl.Size = new System.Drawing.Size(58, 13);
            this.year_lbl.TabIndex = 16;
            this.year_lbl.Text = "Year (yyyy)";
            this.year_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(451, 326);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date_lbl.Size = new System.Drawing.Size(44, 13);
            this.date_lbl.TabIndex = 15;
            this.date_lbl.Text = "Director";
            this.date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(281, 326);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(27, 13);
            this.title_lbl.TabIndex = 14;
            this.title_lbl.Text = "Title";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // year_tb
            // 
            this.year_tb.Location = new System.Drawing.Point(561, 299);
            this.year_tb.Name = "year_tb";
            this.year_tb.Size = new System.Drawing.Size(121, 20);
            this.year_tb.TabIndex = 13;
            this.year_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // director_tb
            // 
            this.director_tb.Location = new System.Drawing.Point(379, 299);
            this.director_tb.Name = "director_tb";
            this.director_tb.Size = new System.Drawing.Size(121, 20);
            this.director_tb.TabIndex = 12;
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(192, 299);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(121, 20);
            this.title_tb.TabIndex = 11;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(742, 299);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(146, 23);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // borrow_btn
            // 
            this.borrow_btn.Location = new System.Drawing.Point(742, 449);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(146, 23);
            this.borrow_btn.TabIndex = 17;
            this.borrow_btn.Text = "BORROW";
            this.borrow_btn.UseVisualStyleBackColor = true;
            // 
            // reserve_btn
            // 
            this.reserve_btn.Location = new System.Drawing.Point(742, 378);
            this.reserve_btn.Name = "reserve_btn";
            this.reserve_btn.Size = new System.Drawing.Size(146, 23);
            this.reserve_btn.TabIndex = 18;
            this.reserve_btn.Text = "RESERVE";
            this.reserve_btn.UseVisualStyleBackColor = true;
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(928, 174);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(146, 23);
            this.return_button.TabIndex = 19;
            this.return_button.Text = "RETURN";
            this.return_button.UseVisualStyleBackColor = true;
            // 
            // details_btn
            // 
            this.details_btn.Location = new System.Drawing.Point(742, 328);
            this.details_btn.Name = "details_btn";
            this.details_btn.Size = new System.Drawing.Size(146, 23);
            this.details_btn.TabIndex = 20;
            this.details_btn.Text = "DETAILS";
            this.details_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(966, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "SUPERVISOR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "LOGOUT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(928, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "REGISTER USER";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(928, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "ADD NEW MEDIA";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1127, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "DELETE MEDIA";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1127, 65);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button6.Size = new System.Drawing.Size(146, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "DELETE USER";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1175, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ADMIN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "ACCOUNT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.details_btn);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.reserve_btn);
            this.Controls.Add(this.borrow_btn);
            this.Controls.Add(this.year_lbl);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.year_tb);
            this.Controls.Add(this.director_tb);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HomeForm";
            this.Text = "AIT Media Library";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox year_tb;
        private System.Windows.Forms.TextBox director_tb;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.Button reserve_btn;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button details_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}