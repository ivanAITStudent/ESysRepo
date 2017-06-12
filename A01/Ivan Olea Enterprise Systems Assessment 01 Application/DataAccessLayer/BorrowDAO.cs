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
        }

        //get data queries
        public BorrowDS.TabBorrowDataTable GetAllBorrows()
        {
            _dataSet.TabBorrow.Clear(); // clear data table

            try
            {
                _tabBorrowAdapter.Fill(_dataSet.TabBorrow); // use table adapter to fill data table
                return _dataSet.TabBorrow;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred: Could Not FIll Borrow Table");
                throw ex;
            }
        }

        public BorrowDS.UserBorrowHistoryDataTableDataTable GetAllBorrowHistory(int _userID)
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

        //insert record
        public int insertNewBorrowRecord (Int32 _userID, Int32 _mediaID, DateTime _borrowDate, DateTime _returnDate)
        {
            _dataSet.TabBorrow.Clear();
            try
            {
               return _tabBorrowAdapter.InsertBorrowUIDMediaID_Query(_userID, _mediaID,_borrowDate.ToShortTimeString(), _returnDate.ToShortTimeString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceotion: Could not access datatable");
                throw ex;
            }
            
        }

        //update record
    }
}
