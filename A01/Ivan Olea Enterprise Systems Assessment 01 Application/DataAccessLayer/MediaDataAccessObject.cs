using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataAccessLayer;
using DataAccessLayer.MediaDataSetTableAdapters;


namespace DataAccessLayer
{
    public class MediaDataAccessObject
    {
        //private variables
        private MediaDataSet _mediaDataSet;
        private TabMediaTableAdapter _mediaTabTableAdapter;

        private DataAccessLayer.AllMediaDetailsOnLoanStatus _m2DataSet;
        private AllMediaDetailsOnLoanStatusTableAdapters.AllMediaDetailsOnLoanStatusTableAdapter _m2Adapter;



        //constructor 
        public MediaDataAccessObject()
        {
            _mediaDataSet = new MediaDataSet();
            _mediaTabTableAdapter = new TabMediaTableAdapter();

            _m2DataSet = new AllMediaDetailsOnLoanStatus();
            _m2Adapter = new AllMediaDetailsOnLoanStatusTableAdapters.AllMediaDetailsOnLoanStatusTableAdapter();
        }

        // Get Function that returns a DATASET from TABMEDIA
        // Captures the DATASET in variable _mediaDataSet
        public MediaDataSet.TabMediaDataTable GetMediaAll()
        {
            _mediaDataSet.TabMedia.Clear(); // clears data table of data
            _mediaDataSet.EnforceConstraints = false;
            try
            {
                _mediaTabTableAdapter.FillByAllTabs(_mediaDataSet.TabMedia);

                return _mediaDataSet.TabMedia;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MediaDataSet.TabMediaDataTable GetByTitle(string _title)
        {
            _mediaDataSet.TabMedia.Clear(); // clears data table of data
            _mediaDataSet.EnforceConstraints = false;
            try
            {
                _mediaTabTableAdapter.FillByTitleSearch(_mediaDataSet.TabMedia, _title);

                return _mediaDataSet.TabMedia;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MediaDataSet.TabMediaDataTable GetByCriteria(string _title, string _director, Int32 _year)
        {
            _mediaDataSet.TabMedia.Clear();
            _mediaDataSet.EnforceConstraints = false;
            try
            {
                _mediaTabTableAdapter.FillByCriteria(_mediaDataSet.TabMedia, _title, _director, _year);
                return _mediaDataSet.TabMedia;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fill By Criteria did not work: \n" + 
                    _title + "\n " +
                    _director + "\n " +
                    _year);
                throw ex;
            }
        }

        public AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable GetMediaDetails(int _id)
        {
            _m2DataSet.TabAllMediaDetailsOnLoanStatus.Clear(); // clears data table of data
            _m2DataSet.EnforceConstraints = false;
            try
            {
                _m2Adapter.FillAllMediaDetailsOnLoanStatus(_m2DataSet.TabAllMediaDetailsOnLoanStatus, _id);

                return _m2DataSet.TabAllMediaDetailsOnLoanStatus;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
