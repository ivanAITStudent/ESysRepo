using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.BorrowDSTableAdapters;

namespace DataAccessLayer
{
    public class BorrowDAO
    {
        //private variables
        private BorrowDS _dataSet;
        private TabBorrowTableAdapter _tabBorrowAdapter;
        private UserBorrowHistoryTableAdapter _borrowHistoryAdapter;



        //constructor
        public BorrowDAO()
        {
            _dataSet = new BorrowDS();
            _tabBorrowAdapter = new TabBorrowTableAdapter();
            _borrowHistoryAdapter = new UserBorrowHistoryTableAdapter();
        }

        //get data queries
        public BorrowDS.UserBorrowHistoryDataTableDataTable GetAllBorrows()
        {
            _dataSet.UserBorrowHistoryDataTable.Clear(); // clear data table

            try
            {
                _borrowHistoryAdapter.FillByAllBorrows(_dataSet.UserBorrowHistoryDataTable); // use table adapter to fill data table
                return _dataSet.UserBorrowHistoryDataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred: Could Not FIll Borrow Table");
                throw ex;
            }
        }

        public BorrowDS.UserBorrowHistoryDataTableDataTable GetAllUserBorrowHistory(int _userID)
        {
            _dataSet.UserBorrowHistoryDataTable.Clear();
            try
            {
                _borrowHistoryAdapter.FillUserBorrowHistory(_dataSet.UserBorrowHistoryDataTable, _userID);
                return _dataSet.UserBorrowHistoryDataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred: Could Not FIll Borrow Table");
                throw ex;
            }
        }

        public BorrowDS.UserBorrowHistoryDataTableDataTable GetAllMediaBorrowHistory(int _mediaID)
        {
            _dataSet.UserBorrowHistoryDataTable.Clear();
            try
            {
                _borrowHistoryAdapter.FillByMediaBorrowHistory(_dataSet.UserBorrowHistoryDataTable, _mediaID);
                return _dataSet.UserBorrowHistoryDataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred: Could Not FIll Borrow Table");
                throw ex;
            }
        }


        //insert record
        public int insertNewBorrowRecord (Int32 _userID, Int32 _mediaID, DateTime _borrowDate, DateTime _returnDate)
        {
            _dataSet.TabBorrow.Clear();
            try
            {
                int numRows = _tabBorrowAdapter.InsertBorrowUIDMediaID_Query(_userID, _mediaID,_borrowDate.ToShortDateString(), _returnDate.ToShortDateString());
                return numRows;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: Could not access datatable");
                throw ex;
            }
            
        }

        //update record

    }
}
