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
        private TabBorrowTableAdapter _tableAdapter;


        //constructor
        public BorrowDAO()
        {
            _dataSet = new BorrowDS();
            _tableAdapter = new TabBorrowTableAdapter();
        }

        //get data queries
        public BorrowDS.TabBorrowDataTable GetAllBorrows()
        {
            _dataSet.TabBorrow.Clear(); // clear data table

            try
            {
                _tableAdapter.Fill(_dataSet.TabBorrow); // use table adapter to fill data table
                return _dataSet.TabBorrow;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred: Could Not FIll Borrow Table");
                throw ex;
            }
        }

        //insert record

        //update record
    }
}
