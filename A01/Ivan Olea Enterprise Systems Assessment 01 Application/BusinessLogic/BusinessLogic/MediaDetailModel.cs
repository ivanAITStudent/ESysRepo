using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class MediaDetailModel
    {
        private Int32 _mediaID;
        private String _title;

        private Int32 _publishYear;
        private Decimal _budget;
        private String _directorName;
        private String _genreName;
        private String _languageName;
        System.DateTime _borrrowDate;
        System.DateTime _actualReturnDate;

        public int MediaID { get => _mediaID; set => _mediaID = value; }
        public string Title { get => _title; set => _title = value; }
        public int PublishYear { get => _publishYear; set => _publishYear = value; }
        public decimal Budget { get => _budget; set => _budget = value; }
        public string DirectorName { get => _directorName; set => _directorName = value; }
        public string GenreName { get => _genreName; set => _genreName = value; }
        public string LanguageName { get => _languageName; set => _languageName = value; }
        public DateTime BorrrowDate { get => _borrrowDate; set => _borrrowDate = value; }
        public DateTime ActualReturnDate { get => _actualReturnDate; set => _actualReturnDate = value; }

        public static MediaDetailModel Parse(MediaDataSet.TabMediaDetailRow row)
        {
            if (row == null)
            {
                return null;
            }

            MediaDetailModel mm = new MediaDetailModel();
            mm.MediaID = row.MediaID;
            mm.Title = row.Title;
            mm.PublishYear = row.PublishYear;
            mm.Budget = row.Budget;
            mm.DirectorName = row.DirectorName;
            mm.GenreName = row.GenreName;
            mm.LanguageName = row.LanguageName;
            mm.BorrrowDate = DateTime.Parse(row.BorrrowDate);
            mm.ActualReturnDate = DateTime.Parse(row.ActualReturnDate);

            return mm;
        }
    }//endclass
}//endnamesp

