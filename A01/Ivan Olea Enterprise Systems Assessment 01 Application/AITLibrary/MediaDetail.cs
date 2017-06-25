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
    public partial class MediaDetail : PersistentData
    {
        //fields
        private int _mid;
        private MediaLogic _mediaLogic;
        private MediaDetailModel selectedMediaDetail;

        #region messages
        //string message fields
        private string newline = "\n";

        private string errorMessageTitle1 = "MLMS Exception";

        private string errorMessage2 = "An Error Has Occured.";
            
        private string messageTitle1 = "Item Not Available For Loan";
        private string messageTitle2 = "Item Available";
        private string messageTitle3 = "This item HAS BEEN RESERVED";

        private string message1 = "Click to Borrow";
        private string message2 = "Please take item to the front counter for further assistance.";
        private string message3 = "Check The Items Reservations For Further Details";
        private string message8 = "The earliest this item can be borrowed is: ";
        private string message9 = "on loan until: ";

        #endregion

        //properties
        public int Mid { get => _mid; set => _mid = value; }

        //constructors
        public MediaDetail()
        {
            InitializeComponent();
            Mid = PersistentData.selectedMediaID;
            selectedMediaDetail = new MediaDetailModel();
            updateFormDetails();

        }

        public MediaDetail(Int32 _mid)
        {
            InitializeComponent();
            Mid = _mid;
            selectedMediaDetail = new MediaDetailModel();
            updateFormDetails();
        }


        //assistive methods
        #region toggle buttons and strips
        // enable or disable buttons
        public void enableBorrowButton() { this.borrow_btn.Enabled = true; }
        public void disableBorrowButton() { this.borrow_btn.Enabled = false; }
        public void enableReserveButton() { this.reserve_btn.Enabled = true; }
        public void disableReserveButton() { this.reserve_btn.Enabled = false; }

        //toggle visiablity of items
        public void hideBorrowButton() { this.borrow_btn.Visible = false; }
        public void showBorrowButton() { this.borrow_btn.Visible = true; }
        public void hideReserveButton() { this.reserve_btn.Visible = false; }
        public void showReserveButton() { this.reserve_btn.Visible = true; }
        public void hideOnLoanStrip() { this.onLoan_dyn_lbl.Visible = false; }
        public void showOnLoanStrip() { this.onLoan_dyn_lbl.Visible = true; }
        public void hideReserveStrip() { this.reserve_dyn_lbl.Visible = false; }
        public void showReserveStrip() { this.reserve_dyn_lbl.Visible = true; }
        #endregion

        private void updateFormDetails()
        {
            try {
                _mediaLogic = new MediaLogic(); // the portal to the data 
 
                //get details 
                    List<MediaDetailModel> selectedMediaDetailModel = _mediaLogic.getMediaDetails(Mid);
                        selectedMediaDetail = selectedMediaDetailModel[0];

                // update details to screen 
                title_lbl.Text = selectedMediaDetail.Title; 
                director_lbl.Text = selectedMediaDetail.DirectorName; 
                year_lbl.Text = selectedMediaDetail.PublishYear.ToString();
                langauge_lbl.Text = "Language: " + selectedMediaDetail.LanguageName;
                budget_lbl.Text = "Budget: " + selectedMediaDetail.Budget.ToString();
                genre_lbl.Text = "Genre: " + selectedMediaDetail.GenreName;


                // update borrow button help strip
                if (!(selectedMediaDetail.OnLoan))
                {
                    borrow_btn.ImageIndex = 0;
                    onLoan_dyn_lbl.Text = messageTitle2 + newline + message1;
                }
                else
                {
                    borrow_btn.ImageIndex = 1;
                    onLoan_dyn_lbl.Text = messageTitle1 + newline + message9 + newline + selectedMediaDetail.ReturnDate.ToShortDateString();
                }

            }
            catch (Exception ex)
            { 
                throw new PresentationLayerException ("Connection Error. Please Try Again", ex);
            }
         }
        
        //button methods
        private void borrow_btn_Click(object sender, EventArgs e)
        {
            if (selectedMediaDetail.OnLoan)
            {
                //do nothing
            }
            else
            {
                #region ### ALGORITHM
                // ASSUMPTION
                // For an item to be borrowed it is physically available to borrow
                // If the item is on loan yet is it physically available to borrow it must be returned first
                // if the item has been reserved it must be checked against the loan period
                // Any resevation takes precedence over borrowing, this means an itme 
                // is removed from borrowing on the day of reservation
                
                // initialise variables
                // get userID
                // capture selected mediaID
                // set loanPeriod
                // set borrowDate to today
                // set returnDate to borrowDate + loanPeriod


                // borrowDetails = check borrow status against any reservations (borrowDetails, loanPeriod)
                // ON RETURN
                // if borrowDetails.borrowDate == nullDate || details.returnDate <= borrowDate
                //// item not available for loan
                //// please take item to the front counter for further assistence
                // ELSE IF details.borrowDate > today then 
                //// item not available for Loan
                //// this item has been reserved
                //// the earliest this item can be borrowed is + details.borrowDate + 
                //// to be returned on + details.returnDate
                // ELSE IF details.borrowDate == today AND details.returnDate > details.borrowDate +1Day
                //// Media Name + is available for loan
                //// for the period + details.borrowDate + to + details.returnDate
                //// would you like to proceed Y/N
                // ELSE
                //// An error has occurred and the item can not be borrowed at this time. 
                //// Please see Attendant.

                // if (yes)
                ////// INSERT NEW RECORD (_userID, mediaID, borrowDate, returnDate)
                // END IF
    #endregion

                // ### ALGO. IMPLEMENTATION
                // initialise variables
                BorrowLogic borrowLogic = new BorrowLogic(); //init access
                BorrowModel borrowDetails = new BorrowModel();

                borrowDetails.UID = PersistentData.pUserID;// get userID
                borrowDetails.MediaID = Mid; // get selected mediaID
                borrowDetails.BorrowDate = DateTime.Today;// set borrowDate = today
                borrowDetails.ReturnDate = DateTime.Today.AddDays(PersistentData.PLoanPeriod); // set returnDate to borrowDate + loanPeriod from persistent data

                    //STUB checks borrow date and returndate values
                    Console.WriteLine("todays date is: " + borrowDetails.BorrowDate);
                    Console.WriteLine("return date before check: " + borrowDetails.ReturnDate);
                    //endStub

                // details = check borrow status against any reservations (details, loanPeriod)
                borrowDetails = borrowLogic.setLoanDates(borrowDetails, PLoanPeriod);

                #region ### ALGO: check borrow dates are valid

                // if details.borrowDate == nullDate || details.returnDate <= borrowDate
                //// item not available for loan
                //// this item has been reserved, 
                //// please take it to the front counter for further assistence
                // ELSE IF details.borrowDate <> today then 
                //// item not available for Loan
                //// this item has been reserved
                //// the earliest this item can be borrowed is + details.borrowDate + 
                //// to be returned on + details.returnDate
                // ELSE IF details.borrowDate == today AND details.returnDate > details.borrowDate +1Day
                //// Media Name + is available for loan
                //// for the period + details.borrowDate + to + details.returnDate
                //// would you like to proceed Y/N
                // ELSE
                //// An error has occurred and the item can not be borrowed at this time. 
                //// Please see Attendant.
                #endregion

                bool canBorrow = false;
                Console.WriteLine("NullDateTime: " + PNullDateTime);

                if ((borrowDetails.BorrowDate.Equals(PNullDateTime)) || (borrowDetails.ReturnDate <= borrowDetails.BorrowDate))
                {
                    canBorrow = false; 
                    MessageBox.Show(message2, messageTitle1);
                }
                else if (borrowDetails.BorrowDate > DateTime.Today)
                {
                    canBorrow = false;
                    string messageForBox = messageTitle3 + newline
                                                + message8 + " " + borrowDetails.BorrowDate.ToShortDateString() + newline
                                                + message9 + " " + borrowDetails.ReturnDate.ToShortDateString() + newline
                                                + message3;

                    MessageBox.Show(messageForBox, messageTitle1);
                }
                else if (borrowDetails.BorrowDate.ToShortDateString().Equals(DateTime.Today.ToShortDateString()) //check only date and exclude times
                                                                   && (borrowDetails.ReturnDate >= borrowDetails.BorrowDate.AddDays(1)))
                {
                    string messageForBox = selectedMediaDetail.Title 
                                                + " is available for loan for the period: " + newline 
                                                        + borrowDetails.BorrowDate.ToShortDateString() 
                                                                + " to " 
                                                                    + borrowDetails.ReturnDate.ToShortDateString() + newline
                                                                        + "Would you like to borrow this item?";
                    string titleForBox = messageTitle2;

                    int messageBoxResponse = (int)MessageBox.Show(messageForBox, titleForBox, MessageBoxButtons.YesNoCancel);
                    if (messageBoxResponse == 6)//yes
                    {
                        canBorrow = true;
                    } else
                    {
                        canBorrow = false;
                    }
                }
                else
                {
                    canBorrow = false;
                    MessageBox.Show(errorMessage2 + newline + message2,  errorMessage2);
                }

                //insert borrow record
                if (canBorrow)
                {
                    int affectedRecords = -1;
                    try
                    {
                        affectedRecords = borrowLogic.InsertBorrow(borrowDetails.UID,borrowDetails.MediaID,borrowDetails.BorrowDate,borrowDetails.ReturnDate);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    if (affectedRecords > 0)
                    {
                        try
                        {
                            //update details
                            ////change loan icon
                            //borrow_btn.ImageIndex = 1;
                            ////update loan return date
                            //onLoan_dyn_lbl.Text = "on loan until:\n" + ((selectedMediaDetail.ReturnDate.ToShortDateString()));
                            updateFormDetails();
                            System.Windows.Forms.MessageBox.Show("Borrow Successful");

                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show("An Error Has Occured\nPlease try again later.");
                        }
                    } //end if
                }//end if 
            }//end if
        }//endm


        private void borrow_btn_MouseHover(object sender, EventArgs e)
        {
            //when mouse hovers show the available help strip
            if (sender.Equals(borrow_btn))
            {
                onLoan_dyn_lbl.Visible = true;
            } else if (sender.Equals(reserve_btn))
            {
                reserve_dyn_lbl.Visible = true;
            }
        }

        private void borrow_btn_MouseLeave(object sender, EventArgs e)
        {
            //when mouse leaves hide help strip
            if (sender.Equals(borrow_btn))
            {
                onLoan_dyn_lbl.Visible = false;
            }
            else if (sender.Equals(reserve_btn))
            {
                reserve_dyn_lbl.Visible = false;
            }
        }

        private void reserve_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ReserveForm rF = new ReserveForm(Mid);
                rF.Focus();
                rF.BringToFront();
                rF.Show();
                this.SendToBack();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open window.\n" + ex, errorMessageTitle1);
            }

        }
    }
}
