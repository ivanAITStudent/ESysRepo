using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class BorrowHistoryForm : Form
    {
        private Int32 _mid;
        

        public BorrowHistoryForm(Int32 mediaId)
        {
            InitializeComponent();
            updateFormDetails(mediaId);
        }

        private void updateFormDetails(Int32 _mid)
        {
            List<BorrowModel> borrowList = new List<BorrowModel>();
            BorrowLogic bLogic = new BorrowLogic();

            try
            {
                dataGridView.DataSource = bLogic.MediaBorrowHistory(_mid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Accessing DB");
            }
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {

        }

        private void myreserves_btn_Click(object sender, EventArgs e)
        {

        }

        private void unreserve_btn_Click(object sender, EventArgs e)
        {

        }

        private void reserve_btn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
