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
            this.return_btn = new System.Windows.Forms.Button();
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
            this.showAll_btn.Location = new System.Drawing.Point(340, 300);
            this.showAll_btn.Margin = new System.Windows.Forms.Padding(0);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(146, 23);
            this.showAll_btn.TabIndex = 33;
            this.showAll_btn.Text = "SHOW ALL HISTORY";
            this.showAll_btn.UseVisualStyleBackColor = false;
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // userhistory_btn
            // 
            this.userhistory_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userhistory_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.userhistory_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.userhistory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userhistory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userhistory_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.userhistory_btn.Location = new System.Drawing.Point(340, 335);
            this.userhistory_btn.Margin = new System.Windows.Forms.Padding(0);
            this.userhistory_btn.Name = "userhistory_btn";
            this.userhistory_btn.Size = new System.Drawing.Size(146, 23);
            this.userhistory_btn.TabIndex = 32;
            this.userhistory_btn.Text = "USER HISTORY";
            this.userhistory_btn.UseVisualStyleBackColor = false;
            this.userhistory_btn.Click += new System.EventHandler(this.myreserves_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.return_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.return_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.return_btn.Location = new System.Drawing.Point(340, 425);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(146, 23);
            this.return_btn.TabIndex = 31;
            this.return_btn.Text = "RETURN";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.unreserve_btn_Click);
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
            this.dataViewTitle_lbl.Size = new System.Drawing.Size(504, 18);
            this.dataViewTitle_lbl.TabIndex = 30;
            this.dataViewTitle_lbl.Text = "BORROW DATES";
            this.dataViewTitle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // from_calendar
            // 
            this.from_calendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.from_calendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_calendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_calendar.Location = new System.Drawing.Point(26, 352);
            this.from_calendar.Name = "from_calendar";
            this.from_calendar.Size = new System.Drawing.Size(281, 25);
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
            this.title_lbl.Size = new System.Drawing.Size(509, 40);
            this.title_lbl.TabIndex = 27;
            this.title_lbl.Text = "Title";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 81);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(460, 204);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // to_calendar
            // 
            this.to_calendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.to_calendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_calendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_calendar.Location = new System.Drawing.Point(26, 407);
            this.to_calendar.Name = "to_calendar";
            this.to_calendar.Size = new System.Drawing.Size(281, 25);
            this.to_calendar.TabIndex = 34;
            // 
            // userID_lbl
            // 
            this.userID_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userID_lbl.AutoSize = true;
            this.userID_lbl.Location = new System.Drawing.Point(104, 323);
            this.userID_lbl.Name = "userID_lbl";
            this.userID_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userID_lbl.Size = new System.Drawing.Size(43, 13);
            this.userID_lbl.TabIndex = 36;
            this.userID_lbl.Text = "User ID";
            this.userID_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userID_tb
            // 
            this.userID_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userID_tb.BackColor = System.Drawing.Color.PowderBlue;
            this.userID_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userID_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID_tb.Location = new System.Drawing.Point(26, 300);
            this.userID_tb.MinimumSize = new System.Drawing.Size(100, 19);
            this.userID_tb.Name = "userID_tb";
            this.userID_tb.Size = new System.Drawing.Size(121, 19);
            this.userID_tb.TabIndex = 35;
            this.userID_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // userName_lbl
            // 
            this.userName_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Location = new System.Drawing.Point(249, 323);
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
            this.uesrName_tb.Location = new System.Drawing.Point(186, 300);
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
            this.fromCal_lbl.Location = new System.Drawing.Point(277, 380);
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
            this.to_cal_label.Location = new System.Drawing.Point(288, 435);
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
            this.byDate_btn.Location = new System.Drawing.Point(340, 370);
            this.byDate_btn.Margin = new System.Windows.Forms.Padding(0);
            this.byDate_btn.Name = "byDate_btn";
            this.byDate_btn.Size = new System.Drawing.Size(146, 23);
            this.byDate_btn.TabIndex = 41;
            this.byDate_btn.Text = "HISTORY BY DATE";
            this.byDate_btn.UseVisualStyleBackColor = false;
            // 
            // BorrowHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(509, 462);
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
            this.Controls.Add(this.return_btn);
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
        private System.Windows.Forms.Button return_btn;
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
    }
}