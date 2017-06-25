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
            this.myreserves_btn = new System.Windows.Forms.Button();
            this.unreserve_btn = new System.Windows.Forms.Button();
            this.dataViewTitle_lbl = new System.Windows.Forms.Label();
            this.reserve_btn = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.title_lbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.year_lbl = new System.Windows.Forms.Label();
            this.year_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.showAll_btn.Location = new System.Drawing.Point(340, 420);
            this.showAll_btn.Margin = new System.Windows.Forms.Padding(0);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(146, 23);
            this.showAll_btn.TabIndex = 33;
            this.showAll_btn.Text = "SHOW ALL RES.";
            this.showAll_btn.UseVisualStyleBackColor = false;
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // myreserves_btn
            // 
            this.myreserves_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.myreserves_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.myreserves_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.myreserves_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myreserves_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myreserves_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.myreserves_btn.Location = new System.Drawing.Point(340, 390);
            this.myreserves_btn.Margin = new System.Windows.Forms.Padding(0);
            this.myreserves_btn.Name = "myreserves_btn";
            this.myreserves_btn.Size = new System.Drawing.Size(146, 23);
            this.myreserves_btn.TabIndex = 32;
            this.myreserves_btn.Text = "MY RESERVES";
            this.myreserves_btn.UseVisualStyleBackColor = false;
            this.myreserves_btn.Click += new System.EventHandler(this.myreserves_btn_Click);
            // 
            // unreserve_btn
            // 
            this.unreserve_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unreserve_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.unreserve_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.unreserve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unreserve_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.unreserve_btn.Location = new System.Drawing.Point(340, 359);
            this.unreserve_btn.Name = "unreserve_btn";
            this.unreserve_btn.Size = new System.Drawing.Size(146, 23);
            this.unreserve_btn.TabIndex = 31;
            this.unreserve_btn.Text = "UNRESERVE";
            this.unreserve_btn.UseVisualStyleBackColor = false;
            this.unreserve_btn.Click += new System.EventHandler(this.unreserve_btn_Click);
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
            // reserve_btn
            // 
            this.reserve_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reserve_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.reserve_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reserve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.reserve_btn.Location = new System.Drawing.Point(340, 326);
            this.reserve_btn.Name = "reserve_btn";
            this.reserve_btn.Size = new System.Drawing.Size(146, 23);
            this.reserve_btn.TabIndex = 29;
            this.reserve_btn.Text = "RESERVE";
            this.reserve_btn.UseVisualStyleBackColor = false;
            this.reserve_btn.Click += new System.EventHandler(this.reserve_btn_Click);
            // 
            // calendar
            // 
            this.calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Location = new System.Drawing.Point(26, 352);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(281, 25);
            this.calendar.TabIndex = 28;
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
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 407);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 25);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Location = new System.Drawing.Point(89, 323);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.year_lbl.Size = new System.Drawing.Size(58, 13);
            this.year_lbl.TabIndex = 36;
            this.year_lbl.Text = "Year (yyyy)";
            this.year_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // year_tb
            // 
            this.year_tb.BackColor = System.Drawing.Color.PowderBlue;
            this.year_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_tb.Location = new System.Drawing.Point(26, 300);
            this.year_tb.Name = "year_tb";
            this.year_tb.Size = new System.Drawing.Size(121, 19);
            this.year_tb.TabIndex = 35;
            this.year_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 323);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Year (yyyy)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(186, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 19);
            this.textBox1.TabIndex = 37;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 380);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Year (yyyy)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 435);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Year (yyyy)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BorrowHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.year_lbl);
            this.Controls.Add(this.year_tb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.myreserves_btn);
            this.Controls.Add(this.unreserve_btn);
            this.Controls.Add(this.dataViewTitle_lbl);
            this.Controls.Add(this.reserve_btn);
            this.Controls.Add(this.calendar);
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
        private System.Windows.Forms.Button myreserves_btn;
        private System.Windows.Forms.Button unreserve_btn;
        private System.Windows.Forms.Label dataViewTitle_lbl;
        private System.Windows.Forms.Button reserve_btn;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.TextBox year_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}