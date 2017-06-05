using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaLogic
    {
        //fields
        private MediaDataAccessObject _mediaDAO;

        private List<MediaModel> _mediaList;
        private MediaDataSet.TabMediaDataTable _mediaDataTable;

        private List<MediaDetailModel> _mediaDetailList;
        private MediaDataSet.TabMediaDetailDataTable _mediaDetailDataTable;

        private MediaModel _selectedMedia;

        #region properties
        //properties
        public MediaDataAccessObject MediaDAO
        {
            get
            {
                return _mediaDAO;
            }

            set
            {
                _mediaDAO = value;
            }
        }

        public List<MediaModel> MediaList
        {
            get
            {
                return _mediaList;
            }

            set
            {
                _mediaList = value;
            }
        }

        public MediaDataSet.TabMediaDataTable MediaDataTable
        {
            get
            {
                return _mediaDataTable;
            }

            set
            {
                _mediaDataTable = value;
            }
        }

        public MediaModel SelectedMedia
        {
            get
            {
                return _selectedMedia;
            }

            set
            {
                _selectedMedia = value;
            }
        }

        public List<MediaDetailModel> MediaDetailList { get => _mediaDetailList; set => _mediaDetailList = value; }
        public MediaDataSet.TabMediaDetailDataTable MediaDetailDataTable { get => _mediaDetailDataTable; set => _mediaDetailDataTable = value; }
        #endregion

        //constructor
        public MediaLogic()
        {
            MediaDAO = new MediaDataAccessObject();

            MediaList = new List<MediaModel>();
            MediaDataTable = new MediaDataSet.TabMediaDataTable();

            MediaDetailList = new List<MediaDetailModel>();
            MediaDetailDataTable = new MediaDataSet.TabMediaDetailDataTable();

            SelectedMedia = new MediaModel();
        }

        public List<MediaModel> getMediaByCriteria(MediaModel criteriaList)
        {
            //search the database using the criteria in the list provided

            MediaList = new List<MediaModel>();

            try
            {
                //get table of data from Data Access Object
                MediaDataTable = _mediaDAO.GetByCriteria(criteriaList.Title, criteriaList.Director, criteriaList.PublishYear);

                //prepare presentation of data
                foreach (MediaDataSet.TabMediaRow row in MediaDataTable.Rows)
                {
                    MediaList.Add(MediaModel.Parse(row));
                        Console.WriteLine(row.ToString() + ": row added successfully");
                }

                //return list
                return MediaList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: No Search Conducted" + ex.Message);
                throw ex;
            }
        }

        public List<MediaModel> getAllMedia()
        {
            MediaList = new List<MediaModel>();

            try
            {
                //get table data from DAO
                MediaDataTable = _mediaDAO.GetMediaAll();

                //prepare presentation of data
                foreach (MediaDataSet.TabMediaRow row in MediaDataTable.Rows)
                {
                    MediaList.Add(MediaModel.Parse(row));
                }

                //return list
                return MediaList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<MediaDetailModel> getMediaDetails(int _mediaID)
        {
            MediaDetailList = new List<MediaDetailModel>();
            try
            {
                //get table data from DAO
                MediaDetailDataTable = _mediaDAO.GetMediaDetails(_mediaID);

                //prepare data for presentation
                foreach(MediaDataSet.TabMediaDetailRow row in MediaDetailDataTable.Rows)
                {
                    MediaDetailList.Add(MediaDetailModel.Parse(row));
                }

                //return list
                return MediaDetailList;
            }
            catch (Exception ex)
            {
                //do something with exception
                throw ex;
            }
        }
    }
}
