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
            this.options_pnl = new System.Windows.Forms.Panel();
            this.reserve_btn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.borrow_btn = new System.Windows.Forms.Button();
            this.mediaImage = new System.Windows.Forms.PictureBox();
            this.options_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(93, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(76, 39);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Title";
            // 
            // director_lbl
            // 
            this.director_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.director_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.director_lbl.Location = new System.Drawing.Point(38, 47);
            this.director_lbl.Name = "director_lbl";
            this.director_lbl.Size = new System.Drawing.Size(182, 22);
            this.director_lbl.TabIndex = 2;
            this.director_lbl.Text = "Director Name";
            this.director_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_lbl.Location = new System.Drawing.Point(105, 69);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(46, 22);
            this.year_lbl.TabIndex = 5;
            this.year_lbl.Text = "0000";
            // 
            // options_pnl
            // 
            this.options_pnl.Controls.Add(this.reserve_btn);
            this.options_pnl.Controls.Add(this.borrow_btn);
            this.options_pnl.Location = new System.Drawing.Point(12, 227);
            this.options_pnl.Name = "options_pnl";
            this.options_pnl.Size = new System.Drawing.Size(82, 104);
            this.options_pnl.TabIndex = 7;
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
            this.reserve_btn.Location = new System.Drawing.Point(14, 51);
            this.reserve_btn.Name = "reserve_btn";
            this.reserve_btn.Size = new System.Drawing.Size(50, 50);
            this.reserve_btn.TabIndex = 1;
            this.reserve_btn.Text = "\r\n";
            this.reserve_btn.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "available_icon.png");
            this.imageList1.Images.SetKeyName(1, "onLoan_icon.png");
            this.imageList1.Images.SetKeyName(2, "reserve_icon.png");
            // 
            // borrow_btn
            // 
            this.borrow_btn.BackColor = System.Drawing.Color.Transparent;
            this.borrow_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.borrow_btn.FlatAppearance.BorderSize = 0;
            this.borrow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_btn.ImageList = this.imageList1;
            this.borrow_btn.Location = new System.Drawing.Point(14, 0);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(50, 50);
            this.borrow_btn.TabIndex = 0;
            this.borrow_btn.Text = "\r\n";
            this.borrow_btn.UseVisualStyleBackColor = false;
            // 
            // mediaImage
            // 
            this.mediaImage.InitialImage = null;
            this.mediaImage.Location = new System.Drawing.Point(12, 94);
            this.mediaImage.Name = "mediaImage";
            this.mediaImage.Size = new System.Drawing.Size(250, 237);
            this.mediaImage.TabIndex = 6;
            this.mediaImage.TabStop = false;
            // 
            // MediaDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 402);
            this.Controls.Add(this.options_pnl);
            this.Controls.Add(this.year_lbl);
            this.Controls.Add(this.director_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.mediaImage);
            this.Name = "MediaDetail";
            this.Text = "MediaDetail";
            this.options_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label director_lbl;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.PictureBox mediaImage;
        private System.Windows.Forms.Panel options_pnl;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button reserve_btn;
    }
}