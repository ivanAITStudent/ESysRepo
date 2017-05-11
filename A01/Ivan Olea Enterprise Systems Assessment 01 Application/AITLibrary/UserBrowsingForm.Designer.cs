namespace AITLibrary
{
    partial class BookBrowsingForm
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
            this.dataGridView_BookBrowsing = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ShowAllBooks = new System.Windows.Forms.Button();
            this.label_ByBookName = new System.Windows.Forms.Label();
            this.label_ByAuthorName = new System.Windows.Forms.Label();
            this.textBox_ByBookName = new System.Windows.Forms.TextBox();
            this.textBox_ByAuthorName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.button_BookDetails = new System.Windows.Forms.Button();
            this.button_ReserveBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookBrowsing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_BookBrowsing
            // 
            this.dataGridView_BookBrowsing.AllowUserToAddRows = false;
            this.dataGridView_BookBrowsing.AllowUserToDeleteRows = false;
            this.dataGridView_BookBrowsing.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_BookBrowsing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_BookBrowsing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BookBrowsing.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_BookBrowsing.Location = new System.Drawing.Point(31, 87);
            this.dataGridView_BookBrowsing.MultiSelect = false;
            this.dataGridView_BookBrowsing.Name = "dataGridView_BookBrowsing";
            this.dataGridView_BookBrowsing.ReadOnly = true;
            this.dataGridView_BookBrowsing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BookBrowsing.Size = new System.Drawing.Size(507, 153);
            this.dataGridView_BookBrowsing.TabIndex = 0;
            this.dataGridView_BookBrowsing.SelectionChanged += new System.EventHandler(this.dataGridView_BookBrowsing_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(246, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By";
            // 
            // button_ShowAllBooks
            // 
            this.button_ShowAllBooks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_ShowAllBooks.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_ShowAllBooks.FlatAppearance.BorderSize = 0;
            this.button_ShowAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowAllBooks.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_ShowAllBooks.Location = new System.Drawing.Point(227, 263);
            this.button_ShowAllBooks.Name = "button_ShowAllBooks";
            this.button_ShowAllBooks.Size = new System.Drawing.Size(125, 26);
            this.button_ShowAllBooks.TabIndex = 2;
            this.button_ShowAllBooks.Text = "Show All Users";
            this.button_ShowAllBooks.UseVisualStyleBackColor = false;
            this.button_ShowAllBooks.Click += new System.EventHandler(this.button_ShowAllBooks_Click);
            // 
            // label_ByBookName
            // 
            this.label_ByBookName.AutoSize = true;
            this.label_ByBookName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_ByBookName.Location = new System.Drawing.Point(39, 406);
            this.label_ByBookName.Name = "label_ByBookName";
            this.label_ByBookName.Size = new System.Drawing.Size(43, 13);
            this.label_ByBookName.TabIndex = 3;
            this.label_ByBookName.Text = "User ID";
            // 
            // label_ByAuthorName
            // 
            this.label_ByAuthorName.AutoSize = true;
            this.label_ByAuthorName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_ByAuthorName.Location = new System.Drawing.Point(292, 405);
            this.label_ByAuthorName.Name = "label_ByAuthorName";
            this.label_ByAuthorName.Size = new System.Drawing.Size(60, 13);
            this.label_ByAuthorName.TabIndex = 4;
            this.label_ByAuthorName.Text = "User Name";
            // 
            // textBox_ByBookName
            // 
            this.textBox_ByBookName.Location = new System.Drawing.Point(123, 399);
            this.textBox_ByBookName.Name = "textBox_ByBookName";
            this.textBox_ByBookName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ByBookName.TabIndex = 5;
            // 
            // textBox_ByAuthorName
            // 
            this.textBox_ByAuthorName.Location = new System.Drawing.Point(382, 398);
            this.textBox_ByAuthorName.Name = "textBox_ByAuthorName";
            this.textBox_ByAuthorName.Size = new System.Drawing.Size(100, 20);
            this.textBox_ByAuthorName.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(223, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search With Criteria";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_SearchWithCriteria);
            // 
            // label_Message
            // 
            this.label_Message.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label_Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Message.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_Message.Location = new System.Drawing.Point(160, 477);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(250, 41);
            this.label_Message.TabIndex = 10;
            this.label_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_BookDetails
            // 
            this.button_BookDetails.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_BookDetails.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_BookDetails.FlatAppearance.BorderSize = 0;
            this.button_BookDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BookDetails.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_BookDetails.Location = new System.Drawing.Point(413, 263);
            this.button_BookDetails.Name = "button_BookDetails";
            this.button_BookDetails.Size = new System.Drawing.Size(125, 26);
            this.button_BookDetails.TabIndex = 11;
            this.button_BookDetails.Text = "User Details";
            this.button_BookDetails.UseVisualStyleBackColor = false;
            this.button_BookDetails.Click += new System.EventHandler(this.button_BookDetails_Click);
            // 
            // button_ReserveBook
            // 
            this.button_ReserveBook.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_ReserveBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_ReserveBook.FlatAppearance.BorderSize = 0;
            this.button_ReserveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ReserveBook.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_ReserveBook.Location = new System.Drawing.Point(413, 296);
            this.button_ReserveBook.Name = "button_ReserveBook";
            this.button_ReserveBook.Size = new System.Drawing.Size(125, 26);
            this.button_ReserveBook.TabIndex = 12;
            this.button_ReserveBook.Text = "Update User";
            this.button_ReserveBook.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(265, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Users";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(413, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 26);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add User";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Location = new System.Drawing.Point(31, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 26);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete User";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AITLibrary.Properties.Resources.ALMS_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(462, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 63);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // BookBrowsingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ReserveBook);
            this.Controls.Add(this.button_BookDetails);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_ByAuthorName);
            this.Controls.Add(this.textBox_ByBookName);
            this.Controls.Add(this.label_ByAuthorName);
            this.Controls.Add(this.label_ByBookName);
            this.Controls.Add(this.button_ShowAllBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_BookBrowsing);
            this.Name = "BookBrowsingForm";
            this.Text = "UserBrowsingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookBrowsing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_BookBrowsing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ShowAllBooks;
        private System.Windows.Forms.Label label_ByBookName;
        private System.Windows.Forms.Label label_ByAuthorName;
        private System.Windows.Forms.TextBox textBox_ByBookName;
        private System.Windows.Forms.TextBox textBox_ByAuthorName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button button_BookDetails;
        private System.Windows.Forms.Button button_ReserveBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}