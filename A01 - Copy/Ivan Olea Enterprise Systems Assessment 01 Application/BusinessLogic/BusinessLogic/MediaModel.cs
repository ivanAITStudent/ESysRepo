using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaModel
    {
        private Int32 _mediaID;
        public Int32 MediaID
        {
            get { return _mediaID; }
            set { _mediaID = value; }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _genre;
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        private string _director;
        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }

        private string _language;
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        private Int32 _publishYear;
        public Int32 PublishYear
        {
            get { return _publishYear; }
            set { _publishYear = value; }
        }

        private Decimal _budget;
        public Decimal Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }

        public static MediaModel Parse (MediaDataSet.TabMediaRow row)
        {
            if (row == null)
            {
                return null;
            }

            MediaModel mm = new MediaModel();

            mm.MediaID = row.MediaID;
            mm.Title = row.Title;
            mm.Director = row.Director;
            mm.PublishYear = row.PublishYear;
            mm.Budget = row.Budget;
            mm.Genre = row.Genre.ToString();
            mm.Language = row.Language.ToString();
            

            return mm;
        }

        public static MediaModel ParseBasic (MediaDataSet.TabMediaRow row)
        {
            if (row == null)
            {
                return null;
            }

            MediaModel mm = new MediaModel();
            mm.Title = row.Title;
            mm.Genre = row.Genre.ToString();
            mm.Director = row.Director.ToString();
            mm.Language = row.Language.ToString();
            mm.PublishYear = row.PublishYear;
            mm.Budget = row.Budget;
            mm.MediaID = row.MediaID;

            return mm;
        }
    }
}
