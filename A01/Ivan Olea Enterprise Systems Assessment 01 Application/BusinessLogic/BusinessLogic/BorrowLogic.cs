using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BorrowLogic
    {
        #region Fields

        //fields
        private DateTime nullDate = new DateTime(2001, 01, 01);


        //fields used for retrieving media details including on loan status
        private List<MediaDetailModel> _mediaDetailList;
        private MediaDetailModel _selectedMediaModel;
            //Data access
            private MediaDataAccessObject _mediaDAO;
            //data table
            private AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable _mediaDetailDataTable;
        
        //fields used to retrieve, insert, delete and update borrowing history 
        private List<BorrowModel> _borrowHistoryList;
        private BorrowDAO _borrowDAO;
        private BorrowDS.UserBorrowHistoryDataTableDataTable _borrowHistoryDataTable;
                private BorrowDS.TabBorrowDataTable _insertBorrowDataTable; //used for inserting new borrow record
        #endregion

        #region Properties
        public List<MediaDetailModel> MediaDetailList { get => _mediaDetailList; set => _mediaDetailList = value; }
        public MediaDetailModel SelectedMediaModel { get => _selectedMediaModel; set => _selectedMediaModel = value; }
        public DateTime NullDate { get => nullDate; set => nullDate = value; }
        public MediaDataAccessObject MediaDAO { get => _mediaDAO; set => _mediaDAO = value; }
        public AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable MediaDetailDataTable { get => _mediaDetailDataTable; set => _mediaDetailDataTable = value; }
        internal List<BorrowModel> BorrowHistoryList { get => _borrowHistoryList; set => _borrowHistoryList = value; }
        public BorrowDAO BorrowDAO { get => _borrowDAO; set => _borrowDAO = value; }
        public BorrowDS.UserBorrowHistoryDataTableDataTable BorrowHistoryDataTable { get => _borrowHistoryDataTable; set => _borrowHistoryDataTable = value; }
        public BorrowDS.TabBorrowDataTable InsertBorrowDataTable { get => _insertBorrowDataTable; set => _insertBorrowDataTable = value; }

        #endregion

        //constructor
        public BorrowLogic()
        {
        }

        public List<MediaDetailModel> AllBorrowHistory()
        {
            MediaDetailList = new List<MediaDetailModel>();
            SelectedMediaModel = new MediaDetailModel();
            MediaDAO = new MediaDataAccessObject();
            MediaDetailDataTable = new AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable();


            return MediaDetailList;
        }

        public List<BorrowModel>  UserBorrowHistory (Int32 _userID)
        { 
            BorrowHistoryList = new List<BorrowModel>();
            BorrowDAO = new BorrowDAO();
            BorrowHistoryDataTable = new BorrowDS.UserBorrowHistoryDataTableDataTable();

            try
            {
                BorrowHistoryDataTable = BorrowDAO.GetAllUserBorrowHistory(_userID);

                //prep for presentation
                if (BorrowHistoryDataTable.Rows.Count > 0)
                {
                    //send through to model

                }
                return BorrowHistoryList;
            } catch (Exception ex)
            {
                throw ex;
            }

            
        }

        public List<MediaDetailModel> MediaBorrowHistory(Int32 _userID)
        {
            MediaDetailList = new List<MediaDetailModel>();
            SelectedMediaModel = new MediaDetailModel();
            MediaDAO = new MediaDataAccessObject();
            MediaDetailDataTable = new AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable();


            return MediaDetailList;
        }

        public int InsertBorrow(Int32 _UserID, Int32 _MediaID, DateTime _BorrowDate, DateTime _ReturnDate)
        {
            BorrowDAO = new BorrowDAO();
            int result = -1;
            try
            {
                result = BorrowDAO.insertNewBorrowRecord(_UserID, _MediaID, _BorrowDate, _ReturnDate);
                if (result <= 0)
                {
                    string message = "No Record Inserted. Please try again.";
                    throw new MLMSExceptions(message);
                } else
                {
                    Console.WriteLine("BorrowRecord Inserted!");
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString() + " caught/and thrown again!");
                throw ex;
            }
        }

        public xxx borrowMedia(Int32 _UserID, Int32 _MediaID, DateTime _BorrowDate, DateTime _ReturnDate)
        {
            // ### ALGORITHM
    
            //// FUNCTION: calculate return date
            ////// check to see if item has been reserved function
            ////// QUERY: get all mediaID 
            //////             where reserveDate>=@borrowDate 
            //////             AND reserveDate <= @returnDate
            //////             Order by reserveDate Asc 
            //////                This query captures the topmost as the earliest reserve date
            ////// if (row count != 0 AND not null)
            //////// returnDate = reserveDate - 1 day
            //////// ENDIF
            ////// return returnDate
            //// END FUNC
            //// INSERT NEW RECORD (_userID, mediaID, borrowDate, returnDate)
            // END IF

            // ### ALGO. IMPLEMENTATION
            // check to see if an item has been selected
            if (dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // an efficient way of checking whether the datagridview is empty
            {
                System.Windows.Forms.MessageBox.Show("No Media Selected");
            }
            else
            {

                captureItemSelected(); // get selected mediaID
                _borrowLogic = new BorrowLogic(); //init access

                int _uid = PersistentData.pUserID;// get userID
                int _mid = PersistentData.selectedMediaID; // get selected mediaID
                DateTime _borrowDate = DateTime.Today;// set borrowDate = today
                DateTime _returnDate = (_borrowDate.AddDays(PersistentData.pLoanPeriod)); // set returnDate to borrowDate + loanPeriod from persistent data

                //STUB checks borrow date and returndate values
                Console.WriteLine("todays date is: " + _borrowDate);
                Console.WriteLine("return date before check: " + _returnDate);
                //endstub

                //check borrow status
                if (itemIsOnLoan(_mid))
                {
                    //Show On Loan Message
                    System.Windows.Forms.MessageBox.Show("Media On Loan & Not Available.\nYou may, however, reserve the book below.");
                }
                else if (!itemIsOnLoan(_mid))
                {
                    // set the returnDate
                    _returnDate = setReturnDate(_returnDate, _borrowDate, _mid);
                    //check if item can be borrowed based on the reserved date
                    if (_returnDate.Equals(DateTime.Parse(PersistentData.pNullDate)))
                    {
                        //Show On Loan Message
                        System.Windows.Forms.MessageBox.Show("Media has been reserved & Not Available.\nYou may, however reserve the book\nfor a later time below.");
                    }
                    else
                    {

                        //insert borrow record
                        int affectedRecords = -1;
                        try
                        {
                            affectedRecords = _borrowLogic.InsertBorrow(_uid, _mid, _borrowDate, _returnDate);
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show("Borrow Unsuccessful\nPlease Try Again");
                        }

                        if (affectedRecords > 0)
                        {
                            try
                            {
                                //open new media detail form showing item borrowed
                                MediaDetail borrowedWindow = new MediaDetail(_mid);
                                borrowedWindow.hideBorrowButton();
                                borrowedWindow.hideReserveButton();
                                borrowedWindow.showOnLoanStrip();
                                borrowedWindow.Show();
                                System.Windows.Forms.MessageBox.Show("Borrow Successful");

                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show("An Error Has Occured\nPlease try again later.");
                            }
                        } //endif
                    }//endif
                }//endif
            }//endif
        }

    }
}
