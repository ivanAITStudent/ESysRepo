using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class ReserveLogic
    {
        //fields
        private List<ReserveModel> _reserveList;
        private ReserveDAO _reserveDAO;//DAO
        private ReserveDS _reserveDS;//data set
        private ReserveDS.TabReservedDataTable _reserveDataTable;//data table

        private DateTime nullDate = new DateTime(2001, 01, 01);

        //properties
        public DateTime NullDate { get => nullDate; set => nullDate = value; }
        public ReserveDAO ReserveDAO { get => _reserveDAO; set => _reserveDAO = value; }
        public ReserveDS ReserveDS { get => _reserveDS; set => _reserveDS = value; }
        public ReserveDS.TabReservedDataTable ReserveDataTable { get => _reserveDataTable; set => _reserveDataTable = value; }
        public List<ReserveModel> ReserveList { get => _reserveList; set => _reserveList = value; }

        //contstructor
        public ReserveLogic()
        {
            _reserveList = new List<ReserveModel>();
            _reserveDAO = new ReserveDAO();
            _reserveDS = new ReserveDS();
            _reserveDataTable = new ReserveDS.TabReservedDataTable();
        }

        //queries
        public List<ReserveModel> getAllReserves()
        {
            ReserveList.Clear();
            try
            {
                //get data table 
                ReserveDataTable = ReserveDAO.getAllReserved(); 

                //prep data for presentation layer
                foreach (ReserveDS.TabReservedRow row in ReserveDataTable.Rows)
                {
                    ReserveList.Add(ReserveModel.Parse(row));
                }

                return ReserveList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: Could Not Retrieve Data Table\n" + ex.Message);
                throw ex;
            }
        }

        public List<ReserveModel> getAllReservedMedia(Int32 _mid)
        {
            ReserveList.Clear();
            try
            {
                //get data table 
                ReserveDataTable = ReserveDAO.getReservedByMediaID(_mid);

                //prep data for presentation layer
                foreach (ReserveDS.TabReservedRow row in ReserveDataTable.Rows)
                {
                    ReserveList.Add(ReserveModel.Parse(row));
                }

                return ReserveList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: Could Not Retrieve Data Table\n" + ex.Message);
                throw ex;
            }
        }

        public List<ReserveModel> getAllReservedUID(Int32 _uid)
        {
            ReserveList.Clear();
            try
            {
                //get data table 
                ReserveDataTable = ReserveDAO.getReservedByUID(_uid);

                //prep data for presentation layer
                foreach (ReserveDS.TabReservedRow row in ReserveDataTable.Rows)
                {
                    ReserveList.Add(ReserveModel.Parse(row));
                }

                return ReserveList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: Could Not Retrieve Data Table\n" + ex.Message);
                throw ex;
            }
        }
        public List<ReserveModel> getAllReservedUID_MID(Int32 _uid, Int32 _mid)
        {
            ReserveList.Clear();
            try
            {
                //get data table 
                ReserveDataTable = ReserveDAO.getReservedByMediaID(_mid);

                //prep data for presentation layer
                foreach (ReserveDS.TabReservedRow row in ReserveDataTable.Rows)
                {
                    ReserveList.Add(ReserveModel.Parse(row));
                }

                return ReserveList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: Could Not Retrieve Data Table\n" + ex.Message);
                throw ex;
            }
        }
        public List<ReserveModel> getMediaGreaterThanBorrowLessThanReturn(DateTime _borrowDate, DateTime _returnDate, Int32 _mid)
        {
            _reserveList.Clear();
            _reserveDataTable.Clear();

            try
            {
                _reserveDataTable = _reserveDAO.getMediaGreaterThanBorrowLessThanReturn(_borrowDate, _returnDate, _mid);
                if (_reserveDataTable == null || _reserveDataTable.Rows.Count == 0)
                {
                    return _reserveList;
                }

                try
                {
                    //prep for presentation layer
                    foreach (ReserveDS.TabReservedRow row in _reserveDataTable)
                    {
                        _reserveList.Add(ReserveModel.Parse(row));
                    }
                    return _reserveList;
                } catch(Exception ex)
                {
                    throw new MLMSExceptions("Exception: No Rows In Table\nList is Empty.");
                }
            } catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public int InsertReserveRecord(Int32 _uid, Int32 _mid, DateTime _reserveDate)
        {
            ReserveDAO = new ReserveDAO();
            int affectedRecords = -1;
            try
            {
                affectedRecords = ReserveDAO.InsertNewReserveRecord(_uid, _mid, _reserveDate);
                if (affectedRecords <=0)
                {
                    string message = "No Record Inserted. Please try again.";
                    throw new MLMSExceptions(message);
                } else
                {
                    //Stub
                    Console.WriteLine("Records affected: " + affectedRecords);
                    return affectedRecords;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message); 
                throw ex; //throw exception up the acrhitecture so that the presentation layer 
                            //will open a dialogue box not the business layer
            }

        }
    }
}
