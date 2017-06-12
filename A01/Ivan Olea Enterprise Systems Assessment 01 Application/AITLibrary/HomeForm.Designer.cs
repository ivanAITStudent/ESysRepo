using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.year_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.year_tb = new System.Windows.Forms.TextBox();
            this.director_tb = new System.Windows.Forms.TextBox();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.borrow_btn = new System.Windows.Forms.Button();
            this.reserve_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.details_btn = new System.Windows.Forms.Button();
            this.sup_lbl = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.registerUser_btn = new System.Windows.Forms.Button();
            this.addNewMedia_btn = new System.Windows.Forms.Button();
            this.deleteMedia_btn = new System.Windows.Forms.Button();
            this.deleteUser_btn = new System.Windows.Forms.Button();
            this.admin_lbl = new System.Windows.Forms.Label();
            this.account_btn = new System.Windows.Forms.Button();
            this.genre_tb = new System.Windows.Forms.TextBox();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.language_tb = new System.Windows.Forms.TextBox();
            this.language_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Location = new System.Drawing.Point(624, 322);
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
            this.date_lbl.Location = new System.Drawing.Point(456, 322);
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
            this.title_lbl.Location = new System.Drawing.Point(286, 322);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(27, 13);
            this.title_lbl.TabIndex = 14;
            this.title_lbl.Text = "Title";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // year_tb
            // 
            this.year_tb.BackColor = System.Drawing.Color.PowderBlue;
            this.year_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_tb.Location = new System.Drawing.Point(561, 299);
            this.year_tb.Name = "year_tb";
            this.year_tb.Size = new System.Drawing.Size(121, 19);
            this.year_tb.TabIndex = 13;
            this.year_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // director_tb
            // 
            this.director_tb.BackColor = System.Drawing.Color.PowderBlue;
            this.director_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.director_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.director_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.director_tb.Location = new System.Drawing.Point(379, 299);
            this.director_tb.Name = "director_tb";
            this.director_tb.Size = new System.Drawing.Size(121, 19);
            this.director_tb.TabIndex = 12;
            // 
            // title_tb
            // 
            this.title_tb.BackColor = System.Drawing.Color.PowderBlue;
            this.title_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.title_tb.Location = new System.Drawing.Point(192, 299);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(121, 19);
            this.title_tb.TabIndex = 11;
            // 
            // borrow_btn
            // 
            this.borrow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow_btn.Location = new System.Drawing.Point(742, 449);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(146, 23);
            this.borrow_btn.TabIndex = 17;
            this.borrow_btn.Text = "BORROW";
            this.borrow_btn.UseVisualStyleBackColor = true;
            this.borrow_btn.Click += new System.EventHandler(this.borrow_btn_Click);
            // 
            // reserve_btn
            // 
            this.reserve_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve_btn.Location = new System.Drawing.Point(742, 378);
            this.reserve_btn.Name = "reserve_btn";
            this.reserve_btn.Size = new System.Drawing.Size(146, 23);
            this.reserve_btn.TabIndex = 18;
            this.reserve_btn.Text = "RESERVE";
            this.reserve_btn.UseVisualStyleBackColor = true;
            // 
            // return_btn
            // 
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Location = new System.Drawing.Point(928, 174);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(146, 23);
            this.return_btn.TabIndex = 19;
            this.return_btn.Text = "RETURN";
            this.return_btn.UseVisualStyleBackColor = true;
            // 
            // details_btn
            // 
            this.details_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.details_btn.Location = new System.Drawing.Point(742, 328);
            this.details_btn.Name = "details_btn";
            this.details_btn.Size = new System.Drawing.Size(146, 23);
            this.details_btn.TabIndex = 20;
            this.details_btn.Text = "DETAILS";
            this.details_btn.UseVisualStyleBackColor = true;
            this.details_btn.Click += new System.EventHandler(this.details_btn_Click);
            // 
            // sup_lbl
            // 
            this.sup_lbl.AutoSize = true;
            this.sup_lbl.Location = new System.Drawing.Point(966, 31);
            this.sup_lbl.Name = "sup_lbl";
            this.sup_lbl.Size = new System.Drawing.Size(77, 13);
            this.sup_lbl.TabIndex = 22;
            this.sup_lbl.Text = "SUPERVISOR";
            // 
            // logout_btn
            // 
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Location = new System.Drawing.Point(40, 449);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(146, 23);
            this.logout_btn.TabIndex = 23;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // registerUser_btn
            // 
            this.registerUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerUser_btn.Location = new System.Drawing.Point(928, 65);
            this.registerUser_btn.Name = "registerUser_btn";
            this.registerUser_btn.Size = new System.Drawing.Size(146, 23);
            this.registerUser_btn.TabIndex = 24;
            this.registerUser_btn.Text = "REGISTER USER";
            this.registerUser_btn.UseVisualStyleBackColor = true;
            // 
            // addNewMedia_btn
            // 
            this.addNewMedia_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMedia_btn.Location = new System.Drawing.Point(928, 121);
            this.addNewMedia_btn.Name = "addNewMedia_btn";
            this.addNewMedia_btn.Size = new System.Drawing.Size(146, 23);
            this.addNewMedia_btn.TabIndex = 25;
            this.addNewMedia_btn.Text = "ADD NEW MEDIA";
            this.addNewMedia_btn.UseVisualStyleBackColor = true;
            // 
            // deleteMedia_btn
            // 
            this.deleteMedia_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMedia_btn.Location = new System.Drawing.Point(1127, 121);
            this.deleteMedia_btn.Name = "deleteMedia_btn";
            this.deleteMedia_btn.Size = new System.Drawing.Size(146, 23);
            this.deleteMedia_btn.TabIndex = 26;
            this.deleteMedia_btn.Text = "DELETE MEDIA";
            this.deleteMedia_btn.UseVisualStyleBackColor = true;
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser_btn.Location = new System.Drawing.Point(1127, 65);
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteUser_btn.Size = new System.Drawing.Size(146, 23);
            this.deleteUser_btn.TabIndex = 27;
            this.deleteUser_btn.Text = "DELETE USER";
            this.deleteUser_btn.UseVisualStyleBackColor = true;
            // 
            // admin_lbl
            // 
            this.admin_lbl.AutoSize = true;
            this.admin_lbl.Location = new System.Drawing.Point(1175, 31);
            this.admin_lbl.Name = "admin_lbl";
            this.admin_lbl.Size = new System.Drawing.Size(42, 13);
            this.admin_lbl.TabIndex = 28;
            this.admin_lbl.Text = "ADMIN";
            // 
            // account_btn
            // 
            this.account_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_btn.Location = new System.Drawing.Point(40, 420);
            this.account_btn.Name = "account_btn";
            this.account_btn.Size = new System.Drawing.Size(146, 23);
            this.account_btn.TabIndex = 29;
            this.account_btn.Text = "ACCOUNT";
            this.account_btn.UseVisualStyleBackColor = true;
            // 
            // genre_tb
            // 
            this.genre_tb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.genre_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genre_tb.Enabled = false;
            this.genre_tb.Location = new System.Drawing.Point(379, 378);
            this.genre_tb.Name = "genre_tb";
            this.genre_tb.Size = new System.Drawing.Size(121, 13);
            this.genre_tb.TabIndex = 30;
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.Location = new System.Drawing.Point(464, 401);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.genre_lbl.Size = new System.Drawing.Size(36, 13);
            this.genre_lbl.TabIndex = 31;
            this.genre_lbl.Text = "Genre";
            this.genre_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // language_tb
            // 
            this.language_tb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.language_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.language_tb.Enabled = false;
            this.language_tb.Location = new System.Drawing.Point(561, 381);
            this.language_tb.Name = "language_tb";
            this.language_tb.Size = new System.Drawing.Size(121, 13);
            this.language_tb.TabIndex = 32;
            // 
            // language_lbl
            // 
            this.language_lbl.AutoSize = true;
            this.language_lbl.Location = new System.Drawing.Point(627, 404);
            this.language_lbl.Name = "language_lbl";
            this.language_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.language_lbl.Size = new System.Drawing.Size(55, 13);
            this.language_lbl.TabIndex = 33;
            this.language_lbl.Text = "Language";
            this.language_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // search_btn
            // 
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.search_btn.Location = new System.Drawing.Point(742, 299);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(146, 23);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(40, 31);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.RowTemplate.DividerHeight = 2;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(848, 236);
            this.dataGridView.TabIndex = 34;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1285, 552);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.language_lbl);
            this.Controls.Add(this.language_tb);
            this.Controls.Add(this.genre_lbl);
            this.Controls.Add(this.genre_tb);
            this.Controls.Add(this.account_btn);
            this.Controls.Add(this.admin_lbl);
            this.Controls.Add(this.deleteUser_btn);
            this.Controls.Add(this.deleteMedia_btn);
            this.Controls.Add(this.addNewMedia_btn);
            this.Controls.Add(this.registerUser_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.sup_lbl);
            this.Controls.Add(this.details_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.reserve_btn);
            this.Controls.Add(this.borrow_btn);
            this.Controls.Add(this.year_lbl);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.year_tb);
            this.Controls.Add(this.director_tb);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.search_btn);
            this.Name = "HomeForm";
            this.Text = "AIT Media Library";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox year_tb;
        private System.Windows.Forms.TextBox director_tb;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.Button reserve_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button details_btn;
        protected System.Windows.Forms.Label sup_lbl;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button registerUser_btn;
        private System.Windows.Forms.Button addNewMedia_btn;
        private System.Windows.Forms.Button deleteMedia_btn;
        private System.Windows.Forms.Button deleteUser_btn;
        private System.Windows.Forms.Label admin_lbl;
        protected System.Windows.Forms.Button account_btn;
        private System.Windows.Forms.TextBox genre_tb;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.TextBox language_tb;
        private System.Windows.Forms.Label language_lbl;
        private DataGridView dataGridView;
    }
}