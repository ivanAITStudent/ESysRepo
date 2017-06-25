using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITLibrary
{
    public partial class ReserveForm : PersistentData
    {
        private Int32 _mid;
        private MediaLogic _mediaLogic;
        private MediaDetailModel _mediaModel;
        private ReserveLogic _reserveLogic;
        private ReserveModel _reserveModel;
        private bool showingMyReserves = false;

        public ReserveForm(Int32 _mid)
        {
            InitializeComponent();

            this._mid = _mid;
            _mediaLogic = new MediaLogic();
            _mediaModel = new MediaDetailModel();
            _reserveLogic = new ReserveLogic();
            _reserveModel = new ReserveModel();
            setFormDetails();
        }

        public void setFormDetails()
        {
            try
            {
                // set title
                title_lbl.Text = _mediaLogic.getMediaDetails(_mid)[0].Title;
                reserve_lbl.Text = "All Reservations";
                dataGridView.BackgroundColor = System.Drawing.Color.LightCyan;

                //fill view with data
                dataGridView.DataSource = null;
                dataGridView.DataSource = _reserveLogic.getMediaGreaterThanBorrowDate(_mid, DateTime.Today);
                //dataGridView.Columns["Rid"].Visible = false;
                dataGridView.Columns["Uid"].Visible = false;
                dataGridView.Columns["Mid"].Visible = false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Data Could not be shown.\nPlease try again.\n" + ex.ToString());              
            }

        }

        private void refreshData(bool _showingMyReserves)
        {
            if (_showingMyReserves)
            {
                reserve_lbl.Text = "My Reservations";
                dataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
                dataGridView.DataSource = null;
                dataGridView.DataSource = _reserveLogic.getAllReservedUID_MID(pUserID, _mid);
                //dataGridView.Columns["Rid"].Visible = false;
                dataGridView.Columns["Uid"].Visible = false;
                dataGridView.Columns["Mid"].Visible = false;
            }
            else
            {
                setFormDetails();
            }
        }


            private void reserve_btn_Click(object sender, EventArgs e)
            {
            // ### ALGORITHIM set reservation
            // get date chosen
            // get user id
            // get mediaID
            // if date chosen equals one of the reserve dates || chosen date <= today
            // show error dialog "can not reserve on selected date"
            // else 
            // reserve item

            // ### Implementation
            DateTime chosenDate =calendar.Value;
            bool canReserve = true;

            if (chosenDate <= DateTime.Today) // can not reserve before current day
            {
                string message = "Invalid Date\nPlease Choose Another";
                System.Windows.Forms.MessageBox.Show(message, "Invalid Date");
                canReserve = false;
            }
            else // check each row and check that media is not already reserved
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    DateTime currentResDate = ((DateTime)(row.Cells["ReserveDate"].Value)).Date;
                    if ((currentResDate == chosenDate.Date) || (chosenDate.Date < currentResDate.AddDays(PLoanPeriod)))
                    {
                        canReserve = false;
                    }
                }//endfor
            } 
            if (canReserve) // reserve media
            {
                try
                {
                    int affectedRecords = _reserveLogic.InsertReserveRecord(pUserID, _mid, chosenDate);
                    if (affectedRecords == 0)
                    {
                        throw new Exception("Could Not Save Reservation Please Try Again");
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message;
                    System.Windows.Forms.MessageBox.Show(message, "Warning");
                }
            }
            else
            {
                string message = "Invalid date:\n" + 
                                    "Please check date and try again\n" +
                                    "If the date you choose falls within the loan peroid:\n" +
                                    + PLoanPeriod + " days \n" +
                                    "from the day of reservation the attempt is INVALID";
                System.Windows.Forms.MessageBox.Show(message, "Warning");
            }
            refreshData(showingMyReserves);
        }



        private void unreserve_btn_Click(object sender, EventArgs e)
        {
            //to unreserve check the user level
            //userlevel 1 can only unreserve their on reservations
            //user level 2 and 3 can unreserve any
            // check to see if an item has been selected
            int row_UserID;
            int row_ReserveID;
            DateTime  row_ReserveDate;
            int affectedRecords = 0;
            
            //if no row are selected
            if (dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // an efficient way of checking whether the datagridview is empty
            {
                System.Windows.Forms.MessageBox.Show("No Media Selected");
            }
            else // try and delete the selected date
            {
                row_UserID = (Int32)dataGridView.SelectedRows[0].Cells["Uid"].Value;
                row_ReserveID = (Int32)dataGridView.SelectedRows[0].Cells["Rid"].Value;
                row_ReserveDate = (DateTime)dataGridView.SelectedRows[0].Cells["ReserveDate"].Value;

                // if user level permits deletion
                try
                {
                    if (pUserLevel == 1) ///user level 1 can only delete reserves with user id
                    {
                        if (row_UserID == PersistentData.pUserID)
                        {
                            try
                            {
                                //delete reserve record
                                affectedRecords = _reserveLogic.DeleteReservationByReserveID(row_ReserveID);
                                if (affectedRecords == 0)
                                {
                                    throw new Exception("No Reservation Deleted");
                                }
                                else
                                {
                                    // reservation deleted successfully
                                    // selected reserved date + title
                                    string message = title_lbl.Text + " " + row_ReserveDate + "\nSuccessfully Deleted";
                                    System.Windows.Forms.MessageBox.Show(message, "Reservation Deleted");
                                }//end if

                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }//end try
                        }
                        else
                        {
                            throw new Exception("Sorry this is not your Reservation");

                        }//end if

                    }
                    else if (pUserLevel == 2 || pUserLevel == 3)
                    {
                        try
                        {
                            //user can delete any reservatin
                            //delete reserve record
                            affectedRecords = _reserveLogic.DeleteReservationByReserveID(row_ReserveID);
                            if (affectedRecords == 0)
                            {
                                throw new Exception("No Reservation Deleted");
                            }
                            else
                            {
                                // reservation deleted successfully
                                // selected reserved date + title
                                string message = title_lbl.Text + " " + row_ReserveDate + "\nSuccessfully Deleted";
                                    System.Windows.Forms.MessageBox.Show(message, "Reservation Deleted");
                            }//end if
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }//end try
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Exception");
                }

                //refresh datagrid
                refreshData(showingMyReserves);

            }//endif
        }//endm

        private void myreserves_btn_Click(object sender, EventArgs e)
        {
            //list only user id reservations
            showingMyReserves = true;
            try
            {
                dataGridView.DataSource = null;
                dataGridView.DataSource = _reserveLogic.getAllReservedUID_MID(pUserID, _mid);
                
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                System.Windows.Forms.MessageBox.Show(message, "Exception");
            }//end try
            refreshData(showingMyReserves);
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            showingMyReserves = false;
            refreshData(showingMyReserves);
        }
    }
}
