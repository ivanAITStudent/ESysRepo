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
        private AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable _mediaDetailDataTable;

        private MediaDetailModel _selectedMedia;
        private DateTime nullDate = new DateTime(2001, 01, 01);

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

        public MediaDetailModel SelectedMedia
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
        public AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable MediaDetailDataTable { get => _mediaDetailDataTable; set => _mediaDetailDataTable = value; }
        public DateTime NullDate { get => nullDate; set => nullDate = value; }
        #endregion

        //constructor
        public MediaLogic()
        {
            MediaDAO = new MediaDataAccessObject();

            MediaList = new List<MediaModel>();
            MediaDataTable = new MediaDataSet.TabMediaDataTable();

            MediaDetailList = new List<MediaDetailModel>();
            MediaDetailDataTable = new AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusDataTable();

            SelectedMedia = new MediaDetailModel();
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
                

                foreach(AllMediaDetailsOnLoanStatus.TabAllMediaDetailsOnLoanStatusRow row in MediaDetailDataTable.Rows)
                {
                    //check for nulls
                    if (row.IsActualReturnDateNull())
                    {
                        row.ActualReturnDate = NullDate;
                    }
                    MediaDetailList.Add(MediaDetailModel.Parse(row));
                }

                //return list
                return MediaDetailList;
            }
            catch (Exception ex)
            {
                //do something with exception
                Console.WriteLine("Media Logic Exception: " + ex.ToString());
                throw ex;
            }
        }
    }
}
