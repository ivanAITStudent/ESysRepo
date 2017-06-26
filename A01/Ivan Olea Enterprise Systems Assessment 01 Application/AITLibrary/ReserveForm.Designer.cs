namespace AITLibrary
{
    partial class ReserveForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.title_lbl = new System.Windows.Forms.Label();
            this.from_calendar = new System.Windows.Forms.DateTimePicker();
            this.reserve_btn = new System.Windows.Forms.Button();
            this.reserve_lbl = new System.Windows.Forms.Label();
            this.unreserve_btn = new System.Windows.Forms.Button();
            this.myreserves_btn = new System.Windows.Forms.Button();
            this.showAll_btn = new System.Windows.Forms.Button();
            this.to_calendar = new System.Windows.Forms.DateTimePicker();
            this.fromCal_lbl = new System.Windows.Forms.Label();
            this.toCal_lbl = new System.Windows.Forms.Label();
            this.reservation_cal = new System.Windows.Forms.DateTimePicker();
            this.reservationCal_lbl = new System.Windows.Forms.Label();
            this.showRange_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 77);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(500, 150);
            this.dataGridView.TabIndex = 0;
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
            this.title_lbl.Size = new System.Drawing.Size(549, 40);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Title";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // from_calendar
            // 
            this.from_calendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.from_calendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_calendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_calendar.Location = new System.Drawing.Point(26, 360);
            this.from_calendar.Name = "from_calendar";
            this.from_calendar.Size = new System.Drawing.Size(321, 25);
            this.from_calendar.TabIndex = 2;
            // 
            // reserve_btn
            // 
            this.reserve_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reserve_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.reserve_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reserve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.reserve_btn.Location = new System.Drawing.Point(380, 234);
            this.reserve_btn.Name = "reserve_btn";
            this.reserve_btn.Size = new System.Drawing.Size(146, 23);
            this.reserve_btn.TabIndex = 21;
            this.reserve_btn.Text = "RESERVE";
            this.reserve_btn.UseVisualStyleBackColor = false;
            this.reserve_btn.Click += new System.EventHandler(this.reserve_btn_Click);
            // 
            // reserve_lbl
            // 
            this.reserve_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reserve_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve_lbl.Font = new System.Drawing.Font("Trebuchet MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve_lbl.ForeColor = System.Drawing.Color.Chocolate;
            this.reserve_lbl.Location = new System.Drawing.Point(5, 53);
            this.reserve_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reserve_lbl.Name = "reserve_lbl";
            this.reserve_lbl.Size = new System.Drawing.Size(544, 18);
            this.reserve_lbl.TabIndex = 22;
            this.reserve_lbl.Text = "RESERVE DATES";
            this.reserve_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unreserve_btn
            // 
            this.unreserve_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unreserve_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.unreserve_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.unreserve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unreserve_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.unreserve_btn.Location = new System.Drawing.Point(380, 263);
            this.unreserve_btn.Name = "unreserve_btn";
            this.unreserve_btn.Size = new System.Drawing.Size(146, 23);
            this.unreserve_btn.TabIndex = 23;
            this.unreserve_btn.Text = "UNRESERVE";
            this.unreserve_btn.UseVisualStyleBackColor = false;
            this.unreserve_btn.Click += new System.EventHandler(this.unreserve_btn_Click);
            // 
            // myreserves_btn
            // 
            this.myreserves_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.myreserves_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.myreserves_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.myreserves_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myreserves_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myreserves_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.myreserves_btn.Location = new System.Drawing.Point(380, 292);
            this.myreserves_btn.Margin = new System.Windows.Forms.Padding(0);
            this.myreserves_btn.Name = "myreserves_btn";
            this.myreserves_btn.Size = new System.Drawing.Size(146, 23);
            this.myreserves_btn.TabIndex = 24;
            this.myreserves_btn.Text = "MY RESERVES";
            this.myreserves_btn.UseVisualStyleBackColor = false;
            this.myreserves_btn.Click += new System.EventHandler(this.myreserves_btn_Click);
            // 
            // showAll_btn
            // 
            this.showAll_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showAll_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.showAll_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showAll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.showAll_btn.Location = new System.Drawing.Point(380, 320);
            this.showAll_btn.Margin = new System.Windows.Forms.Padding(0);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(146, 23);
            this.showAll_btn.TabIndex = 25;
            this.showAll_btn.Text = "SHOW ALL RES.";
            this.showAll_btn.UseVisualStyleBackColor = false;
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // to_calendar
            // 
            this.to_calendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.to_calendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_calendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_calendar.Location = new System.Drawing.Point(26, 410);
            this.to_calendar.Name = "to_calendar";
            this.to_calendar.Size = new System.Drawing.Size(321, 25);
            this.to_calendar.TabIndex = 26;
            // 
            // fromCal_lbl
            // 
            this.fromCal_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fromCal_lbl.AutoSize = true;
            this.fromCal_lbl.Location = new System.Drawing.Point(320, 389);
            this.fromCal_lbl.Name = "fromCal_lbl";
            this.fromCal_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fromCal_lbl.Size = new System.Drawing.Size(27, 13);
            this.fromCal_lbl.TabIndex = 39;
            this.fromCal_lbl.Text = "from";
            this.fromCal_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fromCal_lbl.Click += new System.EventHandler(this.userName_lbl_Click);
            // 
            // toCal_lbl
            // 
            this.toCal_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toCal_lbl.AutoSize = true;
            this.toCal_lbl.Location = new System.Drawing.Point(320, 439);
            this.toCal_lbl.Name = "toCal_lbl";
            this.toCal_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toCal_lbl.Size = new System.Drawing.Size(16, 13);
            this.toCal_lbl.TabIndex = 40;
            this.toCal_lbl.Text = "to";
            this.toCal_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reservation_cal
            // 
            this.reservation_cal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservation_cal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_cal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_cal.Location = new System.Drawing.Point(26, 234);
            this.reservation_cal.Name = "reservation_cal";
            this.reservation_cal.Size = new System.Drawing.Size(321, 25);
            this.reservation_cal.TabIndex = 41;
            // 
            // reservationCal_lbl
            // 
            this.reservationCal_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationCal_lbl.AutoSize = true;
            this.reservationCal_lbl.Location = new System.Drawing.Point(264, 263);
            this.reservationCal_lbl.Name = "reservationCal_lbl";
            this.reservationCal_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reservationCal_lbl.Size = new System.Drawing.Size(83, 13);
            this.reservationCal_lbl.TabIndex = 42;
            this.reservationCal_lbl.Text = "reservation date";
            this.reservationCal_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reservationCal_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // showRange_btn
            // 
            this.showRange_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showRange_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.showRange_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showRange_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showRange_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRange_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.showRange_btn.Location = new System.Drawing.Point(380, 429);
            this.showRange_btn.Margin = new System.Windows.Forms.Padding(0);
            this.showRange_btn.Name = "showRange_btn";
            this.showRange_btn.Size = new System.Drawing.Size(146, 23);
            this.showRange_btn.TabIndex = 43;
            this.showRange_btn.Text = "SHOW RANGE";
            this.showRange_btn.UseVisualStyleBackColor = false;
            this.showRange_btn.Click += new System.EventHandler(this.showRange_btn_Click);
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(549, 464);
            this.Controls.Add(this.showRange_btn);
            this.Controls.Add(this.reservationCal_lbl);
            this.Controls.Add(this.reservation_cal);
            this.Controls.Add(this.toCal_lbl);
            this.Controls.Add(this.fromCal_lbl);
            this.Controls.Add(this.to_calendar);
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.myreserves_btn);
            this.Controls.Add(this.unreserve_btn);
            this.Controls.Add(this.reserve_lbl);
            this.Controls.Add(this.reserve_btn);
            this.Controls.Add(this.from_calendar);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.dataGridView);
            this.Name = "ReserveForm";
            this.Text = "ReserveForm";
            this.Load += new System.EventHandler(this.ReserveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.DateTimePicker from_calendar;
        private System.Windows.Forms.Button reserve_btn;
        private System.Windows.Forms.Label reserve_lbl;
        private System.Windows.Forms.Button unreserve_btn;
        private System.Windows.Forms.Button myreserves_btn;
        private System.Windows.Forms.Button showAll_btn;
        private System.Windows.Forms.DateTimePicker to_calendar;
        private System.Windows.Forms.Label fromCal_lbl;
        private System.Windows.Forms.Label toCal_lbl;
        private System.Windows.Forms.DateTimePicker reservation_cal;
        private System.Windows.Forms.Label reservationCal_lbl;
        private System.Windows.Forms.Button showRange_btn;
    }
}