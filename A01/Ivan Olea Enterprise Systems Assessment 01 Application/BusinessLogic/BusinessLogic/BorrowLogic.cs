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
            //// QUERY: get all mediaID 
            //////          where reserveDate>=minimumDate 
            //////          AND reserveDate <= maximumDate
            //////             Order by reserveDate Asc 
            //////                This query captures the topmost as the earliest reserve date
            // get borrowDate, returnDate
            // for each reservationDate in query
            //// get reserveDate
            //// reservationReturnDate = reservationDate + loanPeriod
            //// IF reserveDate < borDate OR resDate > retDate 
            ////// then can borrow
            ////// dates remain the same
            //// ELSE IF resDate == borDate 
            ////// then !canBorrow, 
            ////// borDate = resRet + 1 Day, 
            ////// borRet = borDate + loan Period
            //// ELSE IF resDate > borDate AND resDate <= borRet 
            ////// then canBorrow but only until the resDate
            ////// borDate stays the same
            ////// borRet = resDate - 1Day
            //// ENDIF
            // ENDFOR
            // return model
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
                        // then canBorrow and dates remain the same
                        canBorrow = true;

                            //STUB
                            Console.WriteLine("resdate < borDate OR > retDate\n");
                            Console.WriteLine("resRet: " + reservationDate);
                            Console.WriteLine("borDate " + model.BorrowDate );
                            //endstub    
                    }
                    else if (reservationDate.Equals(model.BorrowDate)) // ELSE IF resDate == borDate  
                    {
                        // then !canBorrow, but can after reservation is returned
                        canBorrow = false;
                            //STUB
                            Console.WriteLine("resDate == borDate \n");
                            Console.WriteLine("resDate: " + reservationDate );
                            Console.WriteLine("borDate " + model.BorrowDate );
                            //end stub

                        model.BorrowDate = reservationReturnDate; // borDate = resRetDate
                        model.ReturnDate = model.BorrowDate.AddDays(loanPeriod); // borRet = borDate + loan period
                        
                            //stub
                            Console.WriteLine("borDate + 1" + model.BorrowDate );
                            Console.WriteLine("retDate + loanperiod: " + model.ReturnDate);
                            //endstub
                    }
                    else if ((reservationDate > model.BorrowDate) && (reservationDate < model.ReturnDate)) //// ELSE IF resDate > borDate AND resDate < borRet 
                    {
                        //then can borrow but only up to resDate
                        canBorrow = true;
                        
                            //STUB
                            Console.WriteLine("resDate > borDate AND < retDate\n");
                            Console.WriteLine("resRet: " + reservationDate );
                            Console.WriteLine("borDate " + model.BorrowDate );
                            Console.WriteLine("retDate: " + model.ReturnDate );
                            //endstub

                        model.ReturnDate = reservationDate; // borRet = borDate + loanperiod

                            //STUB
                            Console.WriteLine("bor = resRet + 1: " + model.BorrowDate );
                            Console.WriteLine("retDate = bor + loanperiod: " + model.ReturnDate );
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
