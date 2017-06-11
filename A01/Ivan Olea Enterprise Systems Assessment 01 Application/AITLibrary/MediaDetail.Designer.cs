namespace AITLibrary
{
    partial class MediaDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaDetail));
            this.title_lbl = new System.Windows.Forms.Label();
            this.director_lbl = new System.Windows.Forms.Label();
            this.year_lbl = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mediaImage = new System.Windows.Forms.PictureBox();
            this.borrow_btn = new System.Windows.Forms.Button();
            this.reserve_btn = new System.Windows.Forms.Button();
            this.options_pnl = new System.Windows.Forms.Panel();
            this.reserve_dyn_lbl = new System.Windows.Forms.Label();
            this.onLoan_dyn_lbl = new System.Windows.Forms.Label();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.budget_lbl = new System.Windows.Forms.Label();
            this.langauge_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaImage)).BeginInit();
            this.options_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoEllipsis = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_lbl.Font = new System.Drawing.Font("Corbel", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(0, 0);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title_lbl.Size = new System.Drawing.Size(284, 29);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Title";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // director_lbl
            // 
            this.director_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.director_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.director_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.director_lbl.Location = new System.Drawing.Point(0, 29);
            this.director_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.director_lbl.Name = "director_lbl";
            this.director_lbl.Size = new System.Drawing.Size(284, 25);
            this.director_lbl.TabIndex = 2;
            this.director_lbl.Text = "Director Name";
            this.director_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year_lbl
            // 
            this.year_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.year_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_lbl.Location = new System.Drawing.Point(0, 54);
            this.year_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(284, 25);
            this.year_lbl.TabIndex = 5;
            this.year_lbl.Text = "0000";
            this.year_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "available_icon.png");
            this.imageList1.Images.SetKeyName(1, "onLoan_icon.png");
            this.imageList1.Images.SetKeyName(2, "reserve_icon.png");
            // 
            // mediaImage
            // 
            this.mediaImage.Image = global::AITLibrary.Properties.Resources.mediaImageStandIn;
            this.mediaImage.InitialImage = global::AITLibrary.Properties.Resources.mediaImageStandIn;
            this.mediaImage.Location = new System.Drawing.Point(0, 0);
            this.mediaImage.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.mediaImage.Name = "mediaImage";
            this.mediaImage.Size = new System.Drawing.Size(250, 250);
            this.mediaImage.TabIndex = 6;
            this.mediaImage.TabStop = false;
            // 
            // borrow_btn
            // 
            this.borrow_btn.AutoEllipsis = true;
            this.borrow_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.borrow_btn.BackColor = System.Drawing.Color.Transparent;
            this.borrow_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.borrow_btn.FlatAppearance.BorderSize = 0;
            this.borrow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_btn.ImageIndex = 1;
            this.borrow_btn.ImageList = this.imageList1;
            this.borrow_btn.Location = new System.Drawing.Point(0, 132);
            this.borrow_btn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(50, 59);
            this.borrow_btn.TabIndex = 0;
            this.borrow_btn.Text = "\r\n";
            this.borrow_btn.UseVisualStyleBackColor = false;
            this.borrow_btn.Click += new System.EventHandler(this.borrow_btn_Click);
            this.borrow_btn.MouseLeave += new System.EventHandler(this.borrow_btn_MouseLeave);
            this.borrow_btn.MouseHover += new System.EventHandler(this.borrow_btn_MouseHover);
            // 
            // reserve_btn
            // 
            this.reserve_btn.BackColor = System.Drawing.Color.Transparent;
            this.reserve_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reserve_btn.FlatAppearance.BorderSize = 0;
            this.reserve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve_btn.ImageIndex = 2;
            this.reserve_btn.ImageList = this.imageList1;
            this.reserve_btn.Location = new System.Drawing.Point(0, 191);
            this.reserve_btn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.reserve_btn.Name = "reserve_btn";
            this.reserve_btn.Size = new System.Drawing.Size(50, 59);
            this.reserve_btn.TabIndex = 1;
            this.reserve_btn.Text = "\r\n";
            this.reserve_btn.UseVisualStyleBackColor = false;
            this.reserve_btn.MouseLeave += new System.EventHandler(this.borrow_btn_MouseLeave);
            this.reserve_btn.MouseHover += new System.EventHandler(this.borrow_btn_MouseHover);
            // 
            // options_pnl
            // 
            this.options_pnl.BackColor = System.Drawing.Color.LightCyan;
            this.options_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.options_pnl.Controls.Add(this.reserve_dyn_lbl);
            this.options_pnl.Controls.Add(this.onLoan_dyn_lbl);
            this.options_pnl.Controls.Add(this.reserve_btn);
            this.options_pnl.Controls.Add(this.borrow_btn);
            this.options_pnl.Controls.Add(this.mediaImage);
            this.options_pnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_pnl.ForeColor = System.Drawing.Color.Chocolate;
            this.options_pnl.Location = new System.Drawing.Point(12, 107);
            this.options_pnl.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.options_pnl.Name = "options_pnl";
            this.options_pnl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.options_pnl.Size = new System.Drawing.Size(249, 253);
            this.options_pnl.TabIndex = 7;
            // 
            // reserve_dyn_lbl
            // 
            this.reserve_dyn_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve_dyn_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserve_dyn_lbl.Location = new System.Drawing.Point(54, 191);
            this.reserve_dyn_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reserve_dyn_lbl.Name = "reserve_dyn_lbl";
            this.reserve_dyn_lbl.Size = new System.Drawing.Size(195, 59);
            this.reserve_dyn_lbl.TabIndex = 9;
            this.reserve_dyn_lbl.Text = "click to reserve";
            this.reserve_dyn_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reserve_dyn_lbl.Visible = false;
            // 
            // onLoan_dyn_lbl
            // 
            this.onLoan_dyn_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onLoan_dyn_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onLoan_dyn_lbl.Location = new System.Drawing.Point(54, 132);
            this.onLoan_dyn_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.onLoan_dyn_lbl.Name = "onLoan_dyn_lbl";
            this.onLoan_dyn_lbl.Size = new System.Drawing.Size(196, 54);
            this.onLoan_dyn_lbl.TabIndex = 8;
            this.onLoan_dyn_lbl.Text = "---";
            this.onLoan_dyn_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.onLoan_dyn_lbl.Visible = false;
            // 
            // genre_lbl
            // 
            this.genre_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.genre_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_lbl.Location = new System.Drawing.Point(0, 427);
            this.genre_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.Size = new System.Drawing.Size(284, 37);
            this.genre_lbl.TabIndex = 9;
            this.genre_lbl.Text = "0000";
            this.genre_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // budget_lbl
            // 
            this.budget_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.budget_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budget_lbl.Location = new System.Drawing.Point(0, 394);
            this.budget_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.budget_lbl.Name = "budget_lbl";
            this.budget_lbl.Size = new System.Drawing.Size(284, 33);
            this.budget_lbl.TabIndex = 10;
            this.budget_lbl.Text = "0000";
            this.budget_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // langauge_lbl
            // 
            this.langauge_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.langauge_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langauge_lbl.Location = new System.Drawing.Point(0, 357);
            this.langauge_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.langauge_lbl.Name = "langauge_lbl";
            this.langauge_lbl.Size = new System.Drawing.Size(284, 37);
            this.langauge_lbl.TabIndex = 11;
            this.langauge_lbl.Text = "0000";
            this.langauge_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MediaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(284, 464);
            this.Controls.Add(this.langauge_lbl);
            this.Controls.Add(this.budget_lbl);
            this.Controls.Add(this.genre_lbl);
            this.Controls.Add(this.options_pnl);
            this.Controls.Add(this.year_lbl);
            this.Controls.Add(this.director_lbl);
            this.Controls.Add(this.title_lbl);
            this.Font = new System.Drawing.Font("Impact", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximizeBox = false;
            this.Name = "MediaDetail";
            this.Text = "Media Detail";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.mediaImage)).EndInit();
            this.options_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label director_lbl;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.PictureBox mediaImage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.Button reserve_btn;
        private System.Windows.Forms.Panel options_pnl;
        private System.Windows.Forms.Label reserve_dyn_lbl;
        private System.Windows.Forms.Label onLoan_dyn_lbl;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.Label budget_lbl;
        private System.Windows.Forms.Label langauge_lbl;
    }
}