using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.ReserveDSTableAdapters;
namespace DataAccessLayer
{
    public class ReserveDAO
    {
        //private variables
        private ReserveDS _dataSet;
        private TabReservedTableAdapter _tableAdapter;
        private ReserveDS.TabReservedDataTable _dataTable;

        //constructor
        public ReserveDAO()
        {
            _dataSet = new ReserveDS();
            _tableAdapter = new TabReservedTableAdapter();
            _dataTable = new ReserveDS.TabReservedDataTable();
        }

        //get data queries
        public ReserveDS.TabReservedDataTable getAllReserved()
        {
            _dataSet.TabReserved.Clear();
            try
            {
                _tableAdapter.FillAll(_dataTable);
                return _dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ReserveDS.TabReservedDataTable getReservedByMediaID(Int32 _mid)
        {
            _dataSet.TabReserved.Clear();
            try
            {
                _tableAdapter.FillByMediaID(_dataSet.TabReserved, _mid);
                return _dataSet.TabReserved;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ReserveDS.TabReservedDataTable getReservedByUID(Int32 _uid)
        {
            _dataSet.TabReserved.Clear();
            try
            {
                _tableAdapter.FillByUID(_dataSet.TabReserved, _uid);
                return _dataSet.TabReserved;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ReserveDS.TabReservedDataTable getReservedByUID_MID(Int32 _uid, Int32 _mid)
        {
            _dataSet.TabReserved.Clear();
            try
            {
                _tableAdapter.FillByUIDandMID(_dataSet.TabReserved, _mid, _uid);
                return _dataSet.TabReserved;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ReserveDS.TabReservedDataTable getMediaGreaterThanBorrowLessThanReturn(DateTime _borrowDate, DateTime _returnDate, Int32 _mid)
        {
            _dataSet.TabReserved.Clear();
            try
            {
                _tableAdapter.FillByMediaGreaterThanBorrowLessThanReturn(_dataSet.TabReserved, _mid, _borrowDate.ToShortDateString(),_returnDate.ToShortDateString());
                return _dataSet.TabReserved;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ReserveDS.TabReservedDataTable getMediaGreaterThanBorrowDate(Int32 _mid, DateTime _borrowDate)
        {
            _dataSet.Clear();
            _dataTable.Clear();
            try
            {
                _tableAdapter.FillByResDateGreaterThanBorrowDate(_dataTable, _mid, _borrowDate.ToShortDateString());
                return _dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: could not access database.");
                throw ex;
            }
        }
        //insert queries
        public int InsertNewReserveRecord (Int32 _uid, Int32 _mid, DateTime _reserveDate)
        {
            int numberOfRowsAffected = 0;

            try
            {
                numberOfRowsAffected = _tableAdapter.InsertNewReserveRecord_Query(_uid, _mid, _reserveDate.ToLongDateString());
                return numberOfRowsAffected;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int DeleteByResID(Int32 _RID)
        {
            int numberOfRowsAffected = 0;
            try
            {
                numberOfRowsAffected = _tableAdapter.DeleteByRID_Query(_RID);
                return numberOfRowsAffected;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
