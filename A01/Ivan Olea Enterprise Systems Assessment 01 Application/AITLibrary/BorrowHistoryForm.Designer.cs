namespace AITLibrary
{
    partial class BorrowHistoryForm
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
            this.showAll_btn = new System.Windows.Forms.Button();
            this.userhistory_btn = new System.Windows.Forms.Button();
            this.dataViewTitle_lbl = new System.Windows.Forms.Label();
            this.from_calendar = new System.Windows.Forms.DateTimePicker();
            this.title_lbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.to_calendar = new System.Windows.Forms.DateTimePicker();
            this.userID_lbl = new System.Windows.Forms.Label();
            this.userID_tb = new System.Windows.Forms.TextBox();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.uesrName_tb = new System.Windows.Forms.TextBox();
            this.fromCal_lbl = new System.Windows.Forms.Label();
            this.to_cal_label = new System.Windows.Forms.Label();
            this.byDate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mediaHistory = new System.Windows.Forms.Button();
            this.allBorrows_btn = new System.Windows.Forms.Button();
            this.byActualReturn_btn = new System.Windows.Forms.Button();
            this.byReturn_btn = new System.Windows.Forms.Button();
            this.sortBy_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showAll_btn
            // 
            this.showAll_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showAll_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.showAll_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.showAll_btn.Location = new System.Drawing.Point(454, 397);
            this.showAll_btn.Margin = new System.Windows.Forms.Padding(0);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(146, 23);
            this.showAll_btn.TabIndex = 33;
            this.showAll_btn.Text = "MEDIA / USER HISTORY";
            this.showAll_btn.UseVisualStyleBackColor = false;
            // 
            // userhistory_btn
            // 
            this.userhistory_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userhistory_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.userhistory_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.userhistory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userhistory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userhistory_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.userhistory_btn.Location = new System.Drawing.Point(454, 305);
            this.userhistory_btn.Margin = new System.Windows.Forms.Padding(0);
            this.userhistory_btn.Name = "userhistory_btn";
            this.userhistory_btn.Size = new System.Drawing.Size(146, 24);
            this.userhistory_btn.TabIndex = 32;
            this.userhistory_btn.Text = "USER HISTORY";
            this.userhistory_btn.UseVisualStyleBackColor = false;
            this.userhistory_btn.Click += new System.EventHandler(this.userhistory_btn_Click);
            // 
            // dataViewTitle_lbl
            // 
            this.dataViewTitle_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataViewTitle_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataViewTitle_lbl.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataViewTitle_lbl.ForeColor = System.Drawing.Color.Chocolate;
            this.dataViewTitle_lbl.Location = new System.Drawing.Point(5, 57);
            this.dataViewTitle_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataViewTitle_lbl.Name = "dataViewTitle_lbl";
            this.dataViewTitle_lbl.Size = new System.Drawing.Size(618, 18);
            this.dataViewTitle_lbl.TabIndex = 30;
            this.dataViewTitle_lbl.Text = "BORROW DATES";
            this.dataViewTitle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // from_calendar
            // 
            this.from_calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.from_calendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_calendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_calendar.Location = new System.Drawing.Point(117, 521);
            this.from_calendar.Name = "from_calendar";
            this.from_calendar.Size = new System.Drawing.Size(304, 25);
            this.from_calendar.TabIndex = 28;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoEllipsis = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_lbl.Font = new System.Drawing.Font("Corbel", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Chocolate;
            this.title_lbl.Location = new System.Drawing.Point(0, 0);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(5);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Padding = new System.Windows.Forms.Padding(5);
            this.title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title_lbl.Size = new System.Drawing.Size(623, 40);
            this.title_lbl.TabIndex = 27;
            this.title_lbl.Text = "Title";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 81);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(574, 187);
            this.dataGridView.TabIndex = 26;
            // 
            // to_calendar
            // 
            this.to_calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.to_calendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_calendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_calendar.Location = new System.Drawing.Point(117, 576);
            this.to_calendar.Name = "to_calendar";
            this.to_calendar.Size = new System.Drawing.Size(304, 25);
            this.to_calendar.TabIndex = 34;
            // 
            // userID_lbl
            // 
            this.userID_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userID_lbl.AutoSize = true;
            this.userID_lbl.Location = new System.Drawing.Point(218, 328);
            this.userID_lbl.Name = "userID_lbl";
            this.userID_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userID_lbl.Size = new System.Drawing.Size(43, 13);
            this.userID_lbl.TabIndex = 36;
            this.userID_lbl.Text = "User ID";
            this.userID_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userID_tb
            // 
            this.userID_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userID_tb.BackColor = System.Drawing.Color.PowderBlue;
            this.userID_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID_tb.Location = new System.Drawing.Point(117, 305);
            this.userID_tb.MinimumSize = new System.Drawing.Size(100, 19);
            this.userID_tb.Name = "userID_tb";
            this.userID_tb.Size = new System.Drawing.Size(144, 19);
            this.userID_tb.TabIndex = 35;
            this.userID_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // userName_lbl
            // 
            this.userName_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Location = new System.Drawing.Point(363, 328);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userName_lbl.Size = new System.Drawing.Size(55, 13);
            this.userName_lbl.TabIndex = 38;
            this.userName_lbl.Text = "Username";
            this.userName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uesrName_tb
            // 
            this.uesrName_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uesrName_tb.BackColor = System.Drawing.Color.PowderBlue;
            this.uesrName_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uesrName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uesrName_tb.Location = new System.Drawing.Point(300, 305);
            this.uesrName_tb.MinimumSize = new System.Drawing.Size(50, 19);
            this.uesrName_tb.Name = "uesrName_tb";
            this.uesrName_tb.Size = new System.Drawing.Size(121, 19);
            this.uesrName_tb.TabIndex = 37;
            this.uesrName_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fromCal_lbl
            // 
            this.fromCal_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fromCal_lbl.AutoSize = true;
            this.fromCal_lbl.Location = new System.Drawing.Point(391, 549);
            this.fromCal_lbl.Name = "fromCal_lbl";
            this.fromCal_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fromCal_lbl.Size = new System.Drawing.Size(27, 13);
            this.fromCal_lbl.TabIndex = 39;
            this.fromCal_lbl.Text = "from";
            this.fromCal_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // to_cal_label
            // 
            this.to_cal_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.to_cal_label.AutoSize = true;
            this.to_cal_label.Location = new System.Drawing.Point(402, 604);
            this.to_cal_label.Name = "to_cal_label";
            this.to_cal_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.to_cal_label.Size = new System.Drawing.Size(16, 13);
            this.to_cal_label.TabIndex = 40;
            this.to_cal_label.Text = "to";
            this.to_cal_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // byDate_btn
            // 
            this.byDate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.byDate_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.byDate_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.byDate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byDate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byDate_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.byDate_btn.Location = new System.Drawing.Point(454, 521);
            this.byDate_btn.Margin = new System.Windows.Forms.Padding(0);
            this.byDate_btn.Name = "byDate_btn";
            this.byDate_btn.Size = new System.Drawing.Size(146, 24);
            this.byDate_btn.TabIndex = 41;
            this.byDate_btn.Text = "BORROW DATE";
            this.byDate_btn.UseVisualStyleBackColor = false;
            this.byDate_btn.Click += new System.EventHandler(this.byDate_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 376);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Media Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(300, 353);
            this.textBox1.MinimumSize = new System.Drawing.Size(50, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 19);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 376);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Media ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(117, 353);
            this.textBox2.MinimumSize = new System.Drawing.Size(100, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 19);
            this.textBox2.TabIndex = 42;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mediaHistory
            // 
            this.mediaHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaHistory.BackColor = System.Drawing.Color.CadetBlue;
            this.mediaHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mediaHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediaHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaHistory.ForeColor = System.Drawing.Color.LightCyan;
            this.mediaHistory.Location = new System.Drawing.Point(454, 353);
            this.mediaHistory.Margin = new System.Windows.Forms.Padding(0);
            this.mediaHistory.Name = "mediaHistory";
            this.mediaHistory.Size = new System.Drawing.Size(146, 24);
            this.mediaHistory.TabIndex = 46;
            this.mediaHistory.Text = "MEDIA HISTORY";
            this.mediaHistory.UseVisualStyleBackColor = false;
            // 
            // allBorrows_btn
            // 
            this.allBorrows_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.allBorrows_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.allBorrows_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.allBorrows_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allBorrows_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBorrows_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.allBorrows_btn.Location = new System.Drawing.Point(454, 438);
            this.allBorrows_btn.Margin = new System.Windows.Forms.Padding(0);
            this.allBorrows_btn.Name = "allBorrows_btn";
            this.allBorrows_btn.Size = new System.Drawing.Size(146, 23);
            this.allBorrows_btn.TabIndex = 47;
            this.allBorrows_btn.Text = "ALL HISTORY";
            this.allBorrows_btn.UseVisualStyleBackColor = false;
            this.allBorrows_btn.Click += new System.EventHandler(this.allBorrows_btn_Click);
            // 
            // byActualReturn_btn
            // 
            this.byActualReturn_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.byActualReturn_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.byActualReturn_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.byActualReturn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byActualReturn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byActualReturn_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.byActualReturn_btn.Location = new System.Drawing.Point(454, 552);
            this.byActualReturn_btn.Margin = new System.Windows.Forms.Padding(0);
            this.byActualReturn_btn.Name = "byActualReturn_btn";
            this.byActualReturn_btn.Size = new System.Drawing.Size(146, 24);
            this.byActualReturn_btn.TabIndex = 48;
            this.byActualReturn_btn.Text = "ACTUAL RETURN DATE";
            this.byActualReturn_btn.UseVisualStyleBackColor = false;
            // 
            // byReturn_btn
            // 
            this.byReturn_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.byReturn_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.byReturn_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.byReturn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byReturn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byReturn_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.byReturn_btn.Location = new System.Drawing.Point(454, 582);
            this.byReturn_btn.Margin = new System.Windows.Forms.Padding(0);
            this.byReturn_btn.Name = "byReturn_btn";
            this.byReturn_btn.Size = new System.Drawing.Size(146, 24);
            this.byReturn_btn.TabIndex = 49;
            this.byReturn_btn.Text = "RETURN DATE";
            this.byReturn_btn.UseVisualStyleBackColor = false;
            // 
            // sortBy_lbl
            // 
            this.sortBy_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortBy_lbl.AutoSize = true;
            this.sortBy_lbl.Location = new System.Drawing.Point(363, 494);
            this.sortBy_lbl.Name = "sortBy_lbl";
            this.sortBy_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sortBy_lbl.Size = new System.Drawing.Size(127, 13);
            this.sortBy_lbl.TabIndex = 51;
            this.sortBy_lbl.Text = "SORT BY DATE RANGE";
            this.sortBy_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sortBy_lbl.Click += new System.EventHandler(this.sortBy_lbl_Click);
            // 
            // BorrowHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(623, 633);
            this.Controls.Add(this.sortBy_lbl);
            this.Controls.Add(this.byReturn_btn);
            this.Controls.Add(this.byActualReturn_btn);
            this.Controls.Add(this.allBorrows_btn);
            this.Controls.Add(this.mediaHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.byDate_btn);
            this.Controls.Add(this.to_cal_label);
            this.Controls.Add(this.fromCal_lbl);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.uesrName_tb);
            this.Controls.Add(this.userID_lbl);
            this.Controls.Add(this.userID_tb);
            this.Controls.Add(this.to_calendar);
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.userhistory_btn);
            this.Controls.Add(this.dataViewTitle_lbl);
            this.Controls.Add(this.from_calendar);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.dataGridView);
            this.Name = "BorrowHistoryForm";
            this.Text = "BorrowHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAll_btn;
        private System.Windows.Forms.Button userhistory_btn;
        private System.Windows.Forms.Label dataViewTitle_lbl;
        private System.Windows.Forms.DateTimePicker from_calendar;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker to_calendar;
        private System.Windows.Forms.Label userID_lbl;
        private System.Windows.Forms.TextBox userID_tb;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.TextBox uesrName_tb;
        private System.Windows.Forms.Label fromCal_lbl;
        private System.Windows.Forms.Label to_cal_label;
        private System.Windows.Forms.Button byDate_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button mediaHistory;
        private System.Windows.Forms.Button allBorrows_btn;
        private System.Windows.Forms.Button byActualReturn_btn;
        private System.Windows.Forms.Button byReturn_btn;
        private System.Windows.Forms.Label sortBy_lbl;
    }
}