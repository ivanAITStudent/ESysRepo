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

        //fields used for retrieving media details including on loan status
        private List<MediaDetailModel> _mediaDetailList;
        private MediaDataAccessObject _mediaDAO;
        private AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable _mediaDetailDataTable;
        
        //fields used to retrieve, insert, delete and update borrowing history 
        private List<BorrowModel> _borrowHistoryList;
        private BorrowDAO _borrowDAO;
        private BorrowDS.UserBorrowHistoryDataTableDataTable _borrowHistoryDataTable;

        private BorrowDS.TabBorrowDataTable _mediaIDBorrowHistoryDataTable; //used for inserting new borrow record
        private BorrowDS.TabBorrowDataTable _insertBorrowDataTable; //used for inserting new borrow record

 #endregion

 #region Properties
        public List<MediaDetailModel> MediaDetailList { get => _mediaDetailList; set => _mediaDetailList = value; }
        public MediaDataAccessObject MediaDAO { get => _mediaDAO; set => _mediaDAO = value; }
        public AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable MediaDetailDataTable { get => _mediaDetailDataTable; set => _mediaDetailDataTable = value; }
        internal List<BorrowModel> BorrowHistoryList { get => _borrowHistoryList; set => _borrowHistoryList = value; }
        public BorrowDAO BorrowDAO { get => _borrowDAO; set => _borrowDAO = value; }
        public BorrowDS.UserBorrowHistoryDataTableDataTable BorrowHistoryDataTable { get => _borrowHistoryDataTable; set => _borrowHistoryDataTable = value; }
        public BorrowDS.TabBorrowDataTable InsertBorrowDataTable { get => _insertBorrowDataTable; set => _insertBorrowDataTable = value; }
        public BorrowDS.TabBorrowDataTable MediaIDBorrowHistoryDataTable { get => _mediaIDBorrowHistoryDataTable; set => _mediaIDBorrowHistoryDataTable = value; }

        #endregion

        //constructor
        public BorrowLogic()
        {

        }

        //public methods
        public List<MediaDetailModel>   AllBorrowHistory ()
        {
            MediaDetailList = new List<MediaDetailModel>();
                MediaDAO = new MediaDataAccessObject();
                    MediaDetailDataTable = new AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable();
            return MediaDetailList;
        }

        public List<BorrowModel>        UserBorrowHistory (Int32 _userID)
        { 
            BorrowHistoryList = new List<BorrowModel>();
            BorrowDAO = new BorrowDAO();
            BorrowHistoryDataTable = new BorrowDS.UserBorrowHistoryDataTableDataTable();

            try
            {
                BorrowHistoryDataTable = BorrowDAO.GetAllUserBorrowHistory(_userID);

                //prep borrow history list for presentation layer
                if (BorrowHistoryDataTable.Rows.Count > 0)
                {
                    //STUB
                    Console.WriteLine("TODO: COMPELTE THIS METHOD");
                    //endstub

                    //send through to model
                }
                return BorrowHistoryList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
        public List<xxx> MediaUserBorrowHistory (Int32 _userID, Int32 _mediaID)
        {
            //STUB
            Console.WriteLine("TODO: COMPELTE THIS METHOD");
            //endstub
        }
        */


        public List<BorrowModel>   MediaBorrowHistory(Int32 _mediaID)
        {
            BorrowHistoryList = new List<BorrowModel>();
            BorrowDAO = new BorrowDAO();
            BorrowHistoryDataTable= new BorrowDS.UserBorrowHistoryDataTableDataTable();

                try
                {
                    //STUB
                    Console.WriteLine("TODO: COMPELTE THIS METHOD");
                    //endstub
                    BorrowHistoryDataTable = BorrowDAO.GetAllMediaBorrowHistory(_mediaID);

                    if (BorrowHistoryDataTable.Rows.Count > 0)
                    {
                        //prep for presentation
                        foreach (BorrowDS.UserBorrowHistoryDataTableRow row in BorrowHistoryDataTable)
                        {
                            BorrowHistoryList.Add(BorrowModel.Parse(row));
                        }
                    }//end if

                return BorrowHistoryList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }//end trycatch
        }//endm

        public BorrowModel setLoanDates(BorrowModel model, Int32 loanPeriod)
        {
            #region ALGORITHM
            // check if item has a reservation within the loan period
            // if the user can borrow then the borrow date and return date ar set accordingly 
            // if the reservation is before the borrow date, dates stay the same
            // if the reservation is on the borrow date, check if it is the users reservation
            //// if it is the users reservation then dates stay the same
            // if the reservation is within the borrow period then the return dates changes to 
            // the reservation date - 1, borrow date stays the same
            // if the reservation is outside the borrow period then the dates stay the same 

            // METHOD: SETLOANDATES(MODEL, LOANPERIOD)
            //// QUERY: get all mediaID 
            //////          where reserveDate>=minimumDate 
            //////          AND reserveDate <= maximumDate
            //////             Order by reserveDate Asc 
            //// This query captures the topmost as the earliest reserve date and will scan from earliest
            //// reservation to the last reservation.
            // START
            // get borrowDate, returnDate, userID, mediaID from MODEL
            // get loanperiod
            // for each reservation in query
            //// get reserveDate
            //// reservationReturnDate = reservationDate + loanPeriod
            //// IF reserveDate < borDate OR resDate > borRet 
            ////// dates remain the same
            //// ELSE IF resDate == borDate 
            ////// IF reservation.userID = userID AND reservation.MID = mediaID
            //////// THEN dates stay the same
            ////// ELSE borDate = resRetDate 
            ////////// AND borRet = borDate + loan Period
            ////// ENDIF
            //// ELSE IF resDate > borDate AND resDate <= borRet 
            ////// borDate stays the same
            ////// borRet = reserveDate
            //// ENDIF
            // ENDFOR
            // return model
            //END

            #endregion

            // ### ALGO. IMPLEMENTATION
            // check if item has a reservation within the loan period

            int _uid = model.UID;// get userID
            int _mid = model.MediaID;// get selected mediaID
            DateTime _borrowDate = model.BorrowDate;// set borrowDate = today
            DateTime _borrowReturnDate = model.ReturnDate; // set returnDate
            DateTime minDate = _borrowDate.AddDays(-loanPeriod);// 
            ReserveLogic rLogic = new ReserveLogic();

            //STUB checks borrow date and returndate values
            Console.WriteLine("-------");
            Console.WriteLine("Loan Period: " + loanPeriod);
            Console.WriteLine("todays date is: " + _borrowDate);
                Console.WriteLine("return date before check: " + _borrowReturnDate);
                    Console.WriteLine("minDate :" + minDate);
            //endstub

            //check if item can be borrowed based on the reserved date
            bool canBorrow = false;
            try
            {
                //list of all reserves after minDate 
                List<ReserveModel> reserves = rLogic.getMediaGreaterThanBorrowLessThanReturn(minDate, _borrowReturnDate, _mid);
               
                foreach (ReserveModel rm in reserves) // for each reservationDate in query 
                {
                    Int32 reservationID = rm.Uid;
                    Int32 reservationMID = rm.Mid;
                    DateTime reservationDate = rm.ReserveDate;
                    DateTime reservationReturnDate = reservationDate.AddDays(loanPeriod);

                    //stub
                    Console.WriteLine("current reservation date: " + reservationDate);
                    Console.WriteLine("model borDate: " + model.BorrowDate );
                    Console.WriteLine("" + model.ReturnDate );
                    Console.WriteLine("---------\n");
                    //endStub

                    if (reservationDate < model.BorrowDate || reservationDate > model.ReturnDate) // IF resDate < borDate || > retDate  
                    {
                        // Dates remain the same
                            //STUB
                            Console.WriteLine("resdate < borDate OR > retDate\n");
                            Console.WriteLine("resRet: " + reservationDate);
                            Console.WriteLine("borDate " + model.BorrowDate );
                            //endstub    
                    }
                    else if (reservationDate.Equals(model.BorrowDate)) // ELSE IF resDate == borDate  
                    {
                        // if it is user's reservation (_uid, _mid)
                        //// dates remain the same
                        // otherwise borDate == resRetDate, retDate = borDate + loanperiod
                            
                            //STUB
                            Console.WriteLine("resDate == borDate \n");
                            Console.WriteLine("resDate: " + reservationDate );
                            Console.WriteLine("borDate " + model.BorrowDate );
                            //end stub

                        if (reservationID == _uid && reservationMID == _mid)
                        {
                            //dates remain the same
                        }
                        else
                        {
                            model.BorrowDate = reservationReturnDate; // borDate = resRetDate
                            model.ReturnDate = model.BorrowDate.AddDays(loanPeriod); // borRet = borDate + loan period
                        }//endif

                            //stub
                            Console.WriteLine("borDate + 1" + model.BorrowDate);
                            Console.WriteLine("retDate + loanperiod: " + model.ReturnDate);
                            //endstub

                    }
                    else if ((reservationDate > model.BorrowDate) && (reservationDate < model.ReturnDate)) //// ELSE IF resDate > borDate AND resDate < borRet 
                    {
                        // borrow date stays the same
                        // borrow return = reserve date
                        
                            //STUB
                            Console.WriteLine("resDate > borDate AND < retDate\n");
                            Console.WriteLine("resRet: " + reservationDate );
                            Console.WriteLine("borDate " + model.BorrowDate );
                            Console.WriteLine("retDate: " + model.ReturnDate );
                            //endstub

                        model.ReturnDate = reservationDate; // borRet = borDate + loanperiod

                            //STUB
                            Console.WriteLine("bor: " + model.BorrowDate );
                            Console.WriteLine("retDate = reserve date: " + model.ReturnDate );
                            //endstub
                    }//end if
                } //end for
            }//end try
            catch (Exception ex)
            {
                throw ex;
            }//end catch

            return model;
        }//endm
 
        //private methods

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
                }
                else
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

    }
}
