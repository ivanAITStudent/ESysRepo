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
        private MediaLogic _mediaLogic;

        public MediaDetail()
        {
            InitializeComponent();
            mid = PersistentData.selectedMediaID;
            setDetails();
        }

        private void setDetails()
        {

                // on load 
                // access database 
                    try {
                    _mediaLogic = new MediaLogic(); // the portal to the data 
                 
                //get details 
                    
                    List<MediaDetailModel> selectedMediaDetailModel = _mediaLogic.getMediaDetails(1);
               
                // update details to screen 
                title_lbl.Text = selectedMediaDetailModel.First().Title; 
                //director_lbl.Text = selectedMediaDetailModel[0].DirectorName; 
                //year_lbl.Text = selectedMediaDetailModel[0].PublishYear.ToString(); 
            }
                catch (Exception ex)
                {
                    throw ex;
                }
         }



        
    }
}
