using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITLibrary
{
    public partial class TestRetrieval : PersistentData
    {
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MediaModel criteriaList = new MediaModel();

        public TestRetrieval()
        {
            InitializeComponent();
            
  
            this.year_tb.Validated += new System.EventHandler(this.year_tb_Validated);
            
            // Create and set the ErrorProvider for each data entry control.
            errorProvider1 = new System.Windows.Forms.ErrorProvider();
            errorProvider1.SetIconAlignment(this.year_tb, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconPadding(this.year_tb, 2);
            errorProvider1.BlinkRate = 1000;
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            
        }

        private void Search_Click(object sender, EventArgs e)
        {   
            MediaLogic _mediaLogic = new MediaLogic();
            
            // check if director textbox is empty
            if (director_tb.Text.Length == 0)
            {
                criteriaList.Director = "%";
            }
            else
            {
                criteriaList.Director = "%" + director_tb.Text + "%";
            }

            // check if title textbox is empty
            if (title_tb.Text.Length == 0)
            {
                criteriaList.Title = "%";
            }
            else
            {
                criteriaList.Title = "%" + title_tb.Text + "%";
            }

                ////check that the year is in the correct format
                //if (year_tb.Text.Length == 0)
                //{
                //    //if empty make value 0
                //    criteriaList.PublishYear = 0;
                //}
                //else
                //{
                //    //check date format

                //    criteriaList.PublishYear = Int32.Parse(year_tb.Text);
                //}

            //STUB Check criteria
                string criteriaCaptured = "Criteria: " + criteriaList.Director + " " + criteriaList.Title + " " + criteriaList.PublishYear;
                    label1.Text = criteriaCaptured;
            //
            
            
            dataGridView1.DataSource = _mediaLogic.getMediaByCriteria(criteriaList);

            //dataGridView1.Columns[0].Visible = false; //hide MediaID

        } //end func

        private void year_tb_Validating(object sender,
                 CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidYear(this.year_tb.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                this.year_tb.Select(0,this.year_tb.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(this.label1, errorMsg);

                criteriaList.PublishYear = -1;
            }

        }

        private void year_tb_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(this.year_tb, "-0-");
        }

        public bool ValidYear(string year, out string errorMessage)
        {
            int numberOfDigits = 4;
            bool isValid = false;
            errorMessage = "The year must be in the format YYYY, 1905";

            // Confirm that year is 4 digits long with no dashes or slashes
            if (year.Length == 0)
            {
                isValid = true;
            } else if (year.IndexOf("/") > -1 || year.IndexOf("-") > -1 || year.Length > numberOfDigits)
            {            
                errorMessage = "Please provide a valid date: YYYY";
                isValid = false;
            } else if (year.Length <= numberOfDigits) // then check that the year has only digits
            {
                //check that it is an int
                try
                {
                    int isAnInt = Int32.Parse(year);
                    Console.WriteLine(": Is An Int!");
                    isValid = true;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex + ": Not an Int");
                    isValid = false;
                }
            }

            Console.WriteLine(isValid);
            return isValid;
        }

        // function to get all data
        private void button1_Click(object sender, EventArgs e)
        {
            UserLogic u1 = new UserLogic();
            try
            {
                dataGridView1.DataSource = u1.GetAllUserDetails(pUserLevel);
            }
            catch (MLMSExceptions ex)
            {
                Console.WriteLine(ex);
                label1.Text = ex.Message;
            }
        }

    }
}
