namespace AITLibrary
{
    partial class MyMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessageBox));
            this.footer_lbl = new System.Windows.Forms.Label();
            this.body_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.MyMessageImageList = new System.Windows.Forms.ImageList(this.components);
            this.MessageIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MessageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // footer_lbl
            // 
            this.footer_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer_lbl.ForeColor = System.Drawing.Color.Chocolate;
            this.footer_lbl.Location = new System.Drawing.Point(0, 140);
            this.footer_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.footer_lbl.Name = "footer_lbl";
            this.footer_lbl.Size = new System.Drawing.Size(284, 58);
            this.footer_lbl.TabIndex = 17;
            this.footer_lbl.Text = "---";
            // 
            // body_lbl
            // 
            this.body_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.body_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.body_lbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body_lbl.ForeColor = System.Drawing.Color.Chocolate;
            this.body_lbl.Location = new System.Drawing.Point(65, 32);
            this.body_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.body_lbl.Name = "body_lbl";
            this.body_lbl.Size = new System.Drawing.Size(215, 102);
            this.body_lbl.TabIndex = 13;
            this.body_lbl.Text = "The Message";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoEllipsis = true;
            this.title_lbl.BackColor = System.Drawing.Color.Transparent;
            this.title_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_lbl.Font = new System.Drawing.Font("Corbel", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Chocolate;
            this.title_lbl.Location = new System.Drawing.Point(0, 0);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title_lbl.Size = new System.Drawing.Size(284, 29);
            this.title_lbl.TabIndex = 12;
            this.title_lbl.Text = "Message Title";
            // 
            // MyMessageImageList
            // 
            this.MyMessageImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyMessageImageList.ImageStream")));
            this.MyMessageImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MyMessageImageList.Images.SetKeyName(0, "tick.PNG");
            // 
            // MessageIcon
            // 
            this.MessageIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageIcon.Location = new System.Drawing.Point(0, 32);
            this.MessageIcon.Name = "MessageIcon";
            this.MessageIcon.Size = new System.Drawing.Size(60, 105);
            this.MessageIcon.TabIndex = 18;
            this.MessageIcon.TabStop = false;
            this.MessageIcon.Click += new System.EventHandler(this.MessageIcon_Click);
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.MessageIcon);
            this.Controls.Add(this.footer_lbl);
            this.Controls.Add(this.body_lbl);
            this.Controls.Add(this.title_lbl);
            this.Name = "MyMessageBox";
            this.Text = "MyMessageBox";
            this.Load += new System.EventHandler(this.MyMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MessageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label footer_lbl;
        private System.Windows.Forms.Label body_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.ImageList MyMessageImageList;
        private System.Windows.Forms.PictureBox MessageIcon;
    }
}