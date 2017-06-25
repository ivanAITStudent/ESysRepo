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
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.reserve_btn = new System.Windows.Forms.Button();
            this.reserve_lbl = new System.Windows.Forms.Label();
            this.unreserve_btn = new System.Windows.Forms.Button();
            this.myreserves_btn = new System.Windows.Forms.Button();
            this.showAll_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 77);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(449, 150);
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
            this.title_lbl.Size = new System.Drawing.Size(498, 40);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Title";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calendar
            // 
            this.calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Location = new System.Drawing.Point(26, 261);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(270, 25);
            this.calendar.TabIndex = 2;
            // 
            // reserve_btn
            // 
            this.reserve_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reserve_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.reserve_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reserve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve_btn.ForeColor = System.Drawing.Color.LightCyan;
            this.reserve_btn.Location = new System.Drawing.Point(329, 261);
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
            this.reserve_lbl.Size = new System.Drawing.Size(493, 18);
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
            this.unreserve_btn.Location = new System.Drawing.Point(329, 294);
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
            this.myreserves_btn.Location = new System.Drawing.Point(329, 325);
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
            this.showAll_btn.Location = new System.Drawing.Point(329, 355);
            this.showAll_btn.Margin = new System.Windows.Forms.Padding(0);
            this.showAll_btn.Name = "showAll_btn";
            this.showAll_btn.Size = new System.Drawing.Size(146, 23);
            this.showAll_btn.TabIndex = 25;
            this.showAll_btn.Text = "SHOW ALL RES.";
            this.showAll_btn.UseVisualStyleBackColor = false;
            this.showAll_btn.Click += new System.EventHandler(this.showAll_btn_Click);
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(498, 387);
            this.Controls.Add(this.showAll_btn);
            this.Controls.Add(this.myreserves_btn);
            this.Controls.Add(this.unreserve_btn);
            this.Controls.Add(this.reserve_lbl);
            this.Controls.Add(this.reserve_btn);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.dataGridView);
            this.Name = "ReserveForm";
            this.Text = "ReserveForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.Button reserve_btn;
        private System.Windows.Forms.Label reserve_lbl;
        private System.Windows.Forms.Button unreserve_btn;
        private System.Windows.Forms.Button myreserves_btn;
        private System.Windows.Forms.Button showAll_btn;
    }
}