using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.MediaDataSetTableAdapters;


namespace DataAccessLayer
{
    public class MediaDataAccessObject
    {
        //private variables
        private MediaDataSet _mediaDataSet;
        private TabMediaTableAdapter _mediaTabTableAdapter;

        //constructor 
        public MediaDataAccessObject()
        {
            _mediaDataSet = new MediaDataSet();
            _mediaTabTableAdapter = new TabMediaTableAdapter();
        }

        // Get Function that returns a DATASET from TABMEDIA
        // Captures the DATASET in variable _mediaDataSet
        public MediaDataSet.TabMediaDataTable GetMediaAll()
        {
            try
            {
                _mediaDataSet.TabMedia.Clear(); // clears data table of data
                _mediaDataSet.EnforceConstraints = false;
                _mediaTabTableAdapter.FillByAllTabs(_mediaDataSet.TabMedia);

                //_mediaTabTableAdapter.FillAll(_mediaDataSet.TabMedia);

                //DEBUG
                //if (_mediaDataSet.TabMedia.Columns.Count > 0)
                //{
                //    for (int i = 0; i < _mediaDataSet.TabMedia.Columns.Count; i++)
                //    {
                //        Console.WriteLine("TabMedia_Model Col Name: "
                //                            + _mediaDataSet.TabMedia.Columns[0].ToString());
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("No Columns Exist");
                //}

                return _mediaDataSet.TabMedia;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MediaDataSet.TabMediaDataTable GetByTitle(string _title)
        {
            try
            {
                _mediaDataSet.TabMedia.Clear(); // clears data table of data
                _mediaDataSet.EnforceConstraints = false;
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
            try
            {
                _mediaDataSet.TabMedia.Clear();
                _mediaDataSet.EnforceConstraints = false;
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

    }

}
