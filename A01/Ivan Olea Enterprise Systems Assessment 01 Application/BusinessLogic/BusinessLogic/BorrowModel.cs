using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BorrowModel
    {
        private Int32 _uID;
        private Int32 _bID;
        private Int32 _mediaID;
        private string _title;
        private string _userName;
        private DateTime _borrowDate;
        private DateTime _returnDate;
        private DateTime _actualReturnDate;
        private decimal _lateFee;

        public int UID { get => _uID; set => _uID = value; }
        public int BID { get => _bID; set => _bID = value; }
        public int MediaID { get => _mediaID; set => _mediaID = value; }
        public string Title { get => _title; set => _title = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public DateTime BorrowDate { get => _borrowDate; set => _borrowDate = value; }
        public DateTime ReturnDate { get => _returnDate; set => _returnDate = value; }
        public DateTime ActualReturnDate { get => _actualReturnDate; set => _actualReturnDate = value; }
        public decimal LateFee { get => _lateFee; set => _lateFee = value; }

        public static BorrowModel Parse(BorrowDS.UserBorrowHistoryDataTableRow row)
        {
            if (row == null)
            {
                return null;
            }

            BorrowModel bm = new BorrowModel();

            bm.BID = row.BID;
            bm.UID = row.UID;
            bm.MediaID = row.MediaID;
            bm.Title = row.Title;
            bm.UserName = row.UserName;
            bm.BorrowDate = row.BorrowDate;
            bm.ReturnDate = row.ReturnDate;
            bm.ActualReturnDate = row.ActualReturnDate;
            bm.LateFee = row.LateFee;

            return bm;
        }
    }
}
