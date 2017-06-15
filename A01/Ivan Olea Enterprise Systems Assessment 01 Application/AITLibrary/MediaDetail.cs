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
        private MediaDetailModel selectedMediaDetail;
        public int Mid { get => mid; set => mid = value; }

        public MediaDetail()
        {
            InitializeComponent();
            Mid = PersistentData.selectedMediaID;
            selectedMediaDetail = new MediaDetailModel();
            updateFormDetails();

        }

        public MediaDetail(Int32 _mid)
        {
            InitializeComponent();
            Mid = _mid;
            selectedMediaDetail = new MediaDetailModel();
            updateFormDetails();
        }

        private void updateFormDetails()
        { 
            // on load 
            // access database 
            try {
                    _mediaLogic = new MediaLogic(); // the portal to the data 
                 
                //get details 
                    List<MediaDetailModel> selectedMediaDetailModel = _mediaLogic.getMediaDetails(Mid);
                        selectedMediaDetail = selectedMediaDetailModel.First();

                // update details to screen 
                title_lbl.Text = selectedMediaDetail.Title; 
                director_lbl.Text = selectedMediaDetail.DirectorName; 
                year_lbl.Text = selectedMediaDetail.PublishYear.ToString();
                langauge_lbl.Text = "Language: " + selectedMediaDetail.LanguageName;
                budget_lbl.Text = "Budget: " + selectedMediaDetail.Budget.ToString();
                genre_lbl.Text = "Genre: " + selectedMediaDetail.GenreName;


                // update borrow button help strip
                if (!selectedMediaDetail.OnLoan)
                {
                    borrow_btn.ImageIndex = 0;
                    onLoan_dyn_lbl.Text = "available\nclick to borrow";
                }
                else
                {
                    borrow_btn.ImageIndex = 1;
                    onLoan_dyn_lbl.Text = "on loan until:\n" + ((selectedMediaDetail.BorrrowDate.AddDays(14)).ToShortDateString());
                }

            }
            catch (Exception ex)
            { 
                throw new PresentationLayerException ("Connection Error. Please Try Again", ex);
            }
         }

        public void hideBorrowButton()
        {
            this.borrow_btn.Visible = false;
        }
        public void showBorrowButton()
        {
            this.borrow_btn.Visible = true;
        }
        public void hideReserveButton()
        {
            this.reserve_btn.Visible = false;
        }
        public void showReserveButton()
        {
            this.reserve_btn.Visible = true;
        }
        public void hideOnLoanStrip()
        {
            this.onLoan_dyn_lbl.Visible = false;
        }
        public void showOnLoanStrip()
        {
            this.onLoan_dyn_lbl.Visible = true;
        }
        public void hideReserveStrip()
        {
            this.reserve_dyn_lbl.Visible = false;
        }
        public void showReserveStrip()
        {
            this.reserve_dyn_lbl.Visible = true;
        }


        private void borrow_btn_Click(object sender, EventArgs e)
        {
            //If not onloan
            ////borrow book, todays date time
            //else 
            ////Error - Book on loan Book can not be borrowed or 
            ////not returned please see the front desk for further enquiry
            if (!selectedMediaDetail.OnLoan)
            {
                try
                {
                    //_borrowLogic = new BorrowLogic();
                    //_borrowLogic.borrowMedia(Mid, Uid, Date);
                }
                catch
                {

                }

            }//endif
        }

        private void borrow_btn_MouseHover(object sender, EventArgs e)
        {
            //when mouse hovers show the available help strip
            if (sender.Equals(borrow_btn))
            {
                onLoan_dyn_lbl.Visible = true;
            } else if (sender.Equals(reserve_btn))
            {
                reserve_dyn_lbl.Visible = true;
            }
        }

        private void borrow_btn_MouseLeave(object sender, EventArgs e)
        {
            //when mouse leaves hide help strip
            if (sender.Equals(borrow_btn))
            {
                onLoan_dyn_lbl.Visible = false;
            }
            else if (sender.Equals(reserve_btn))
            {
                reserve_dyn_lbl.Visible = false;
            }
        }
    }
}
