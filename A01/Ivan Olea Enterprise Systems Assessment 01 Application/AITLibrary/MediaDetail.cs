using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class MediaDetail : PersistentData
    {
        private int mid;

        public MediaDetail(int id)
        {
            InitializeComponent();
            mid = id;
        }

        private void MediaDetail_Load(object sender, EventArgs e)
        {
            // on load 
            // access database 
            MediaLogic _mediaLogic = new MediaLogic(); // the portal to the data

            // get details
            List<MediaDetailModel> selectedMediaDetailModel = _mediaLogic.getMediaDetails(mid);

            // update details to screen
            title_lbl.Text = selectedMediaDetailModel[0].Title;
            director_lbl.Text = selectedMediaDetailModel[0].DirectorName;
            year_lbl.Text = selectedMediaDetailModel[0].PublishYear.ToString();

        }
    }
}
