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
        private List<BorrowModel> currentBorrowList;
        private BorrowLogic bLogic;

        public BorrowHistoryForm()
        {
            InitializeComponent();
            updateFormDetails();
        }

        private void updateFormDetails()
        {
            currentBorrowList = new List<BorrowModel>();
            bLogic = new BorrowLogic();

            try
            {
                dataGridView.DataSource = bLogic.AllBorrowHistory();
                //dataGridView.Columns["MediaID"].Visible = false;
                //dataGridView.Columns["UID"].Visible = false;
                //dataGridView.Columns["Title"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Accessing DB");
            }
        }


        private void userhistory_btn_Click(object sender, EventArgs e)
        {
            #region Algo.
            // validate userid and username
            // get userid
            //// if userID is null
            //// then 
            ////// userID = -1
            ////// flag userid being used to false
            //// else 
            ////// get userID
            ////// flag userid being used to true
            // get username
            //// if username is empty or null
            ////// flag username being used to false
            //// else
            ////// get username
            ////// flag username being used to true
            // IF userIDFLag is true AND userNameFlag is true
            // THEN
            //// QUERY: 
            //////  select UID, Username, MID, MediaTitle, BorrowDate, ReturnDate, ActualReturnDate, Late fee 
            //////  from borrowHistory where UID = ?uid AND Username = ?username
            // ELSE IF userIDFLag is true
            // THEN
            //// QUERY:
            //////  select UID, Username, MID, MediaTitle, BorrowDate, ReturnDate, ActualReturnDate, Late fee
            //////  from borrowHistory where UID = ?uid 
            // ELSE IF userNameFlag is true
            //// QUERY:
            //////  select UID, Username, MID, MediaTitle, BorrowDate, ReturnDate, ActualReturnDate, Late fee
            //////  from borrowHistory where Username = ?username
            #endregion Algo.

            //impl algo
            // validate userid and username text input
                // get userid
                int userID_input;
                bool userID_input_used;

                if (userID_tb.Text == "")//// if userID is null
                {
                    userID_input = -1;
                    userID_input_used = false;//flag userid being used to false
                }
                else
                {
                    userID_input = Int32.Parse(userID_tb.Text);//get id
                    userID_input_used = true; ////// flag userid being used to true
                }

                // get username
                string userName_input;
                bool userName_input_used;

                if (uesrName_tb.Text == "") //// if username is empty or null
                {
                    userName_input_used = false;////// flag username being used to false
                }
                else
                {
                    userName_input = uesrName_tb.Text;//get username
                    userName_input_used = true;////// flag username being used to true
                }

            try
            {
                if (userID_input_used && userName_input_used)// IF userIDFLag is true AND userNameFlag is true
                {
                    MessageBox.Show("STILL TO COMPLETE METHOD", "TODO");
                    //// QUERY: 
                    //////  select UID, Username, MID, MediaTitle, BorrowDate, ReturnDate, ActualReturnDate, Late fee 
                    //////  from borrowHistory where UID = ?uid AND Username = ?username
                }
                else if (userID_input_used) //ELSE IF userIDFLag is true
                {
                    currentBorrowList = new List<BorrowModel>();
                    bLogic = new BorrowLogic();
                        currentBorrowList = bLogic.UserBorrowHistory(userID_input);
                    dataGridView.DataSource = currentBorrowList;
                    //// QUERY:
                    //////  select UID, Username, MID, MediaTitle, BorrowDate, ReturnDate, ActualReturnDate, Late fee
                    //////  from borrowHistory where UID = ?uid 
                }
                else if (userName_input_used) // ELSE IF userNameFlag is true
                {
                    MessageBox.Show("STILL TO COMPLETE METHOD", "TODO");
                    //// QUERY:
                    //////  select UID, Username, MID, MediaTitle, BorrowDate, ReturnDate, ActualReturnDate, Late fee
                    //////  from borrowHistory where Username = ?username
                }//endif

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "EXCEPTION");
            }
        }//endm

        private void allBorrows_btn_Click(object sender, EventArgs e)
        {
            currentBorrowList = new List<BorrowModel>();
            bLogic = new BorrowLogic();

            try
            {
                dataGridView.DataSource = bLogic.AllBorrowHistory();
                //dataGridView.Columns["MediaID"].Visible = false;
                //dataGridView.Columns["UID"].Visible = false;
                //dataGridView.Columns["Title"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Accessing DB");
            }

        }

        private void byDate_btn_Click(object sender, EventArgs e)
        {
            //sort datagrid view by borrow date
            //get fromdate
            //get todate
            //get newlist
            //for each row in datagrid 
            ////if (borDate >= fromdate AND borDate<=todate)
            ////then add row to newlist
            //endfor
            //display newlist in data grid

            List<BorrowModel> dglist = (List<BorrowModel>)dataGridView.DataSource; // get data grid list of models
            List<BorrowModel> newdglist = new List<BorrowModel>();            //display list in data grid


            foreach (BorrowModel model in dglist)
            {
                
                if (model.BorrowDate >= from_calendar.Value && model.BorrowDate <= to_calendar.Value)
                {
                    newdglist.Add(model);
                }
            }
            // display new list of selected rows
            dataGridView.DataSource = newdglist;
        }

        private void sortBy_lbl_Click(object sender, EventArgs e)
        {

        }
    }//endc
}//endns
