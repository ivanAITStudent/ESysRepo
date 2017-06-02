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
        private MediaModel criteriaList = new MediaModel(); //holds data entered in a list 

        public TestRetrieval()
        {
            InitializeComponent();                   
        }

        private void Search_Click(object sender, EventArgs e)
        {
            // when the user clicks on search it doesn't matter if they have filled in the textbox or not
            // If the text box has inforamtion then
            // the information should be validated and the action should be be 
            // either stopped with a request to the user to enter correct data 
            // or prepared for the data base enquiery
            // The only text box that needs validation is the year


            MediaLogic _mediaLogic = new MediaLogic(); // the portal to the data

            label1.Text = ""; //clear message box
            dataGridView_testRetrieval.Refresh(); //clear view

            // Populate grid view with data
                // Validate tb and prep for datbase enquiry
                    // Validate and prep director textbox
                    if (director_tb.Text.Length > 0)
                    {
                        criteriaList.Director = "%" + director_tb.Text + "%";
                    } else
                    {
                        criteriaList.Director = director_tb.Text;
                    }

                    // validate and prep title textbox
                    if (title_tb.Text.Length > 0)
                    {
                        criteriaList.Title = "%" + title_tb.Text + "%";
                    }
                    else
                    {
                        criteriaList.Title = title_tb.Text;
                    }

                    // validate and prep year textbox
                    // Here validating the year will either retrieve data or return an error 
                    if (year_tb.Text.Length == 0)
                    {
                        //if empty make value 0
                        criteriaList.PublishYear = 0;
                        dataGridView_testRetrieval.DataSource = _mediaLogic.getMediaByCriteria(criteriaList);
                        //dataGridView1.Columns[0].Visible = false; //hide MediaID
                    }
                    else if (ValidYear(year_tb.Text)) // if date format is valid add to list
                    {
                        criteriaList.PublishYear = Int32.Parse(year_tb.Text);
                        dataGridView_testRetrieval.DataSource = _mediaLogic.getMediaByCriteria(criteriaList);
                        //dataGridView1.Columns[0].Visible = false; //hide MediaID
                    }
                    else // date error. Inform user to type a correct date
                    {
                        criteriaList.PublishYear = 0;
                        label1.Text = "Invalid year entered: YYYY. Only 4 numbers allowed.";                
                    }

            //STUB Check criteria
                    string criteriaCaptured = "Criteria: " 
                                        + criteriaList.Director 
                                        + " " 
                                        + criteriaList.Title 
                                        + " " 
                                        + criteriaList.PublishYear;
                    label1.Text = criteriaCaptured;
            //END STUB


        } //end func


        private bool ValidYear(string year)
        {
            int numberOfDigits = 4;
            bool isValid = false;

            // Confirm that year is 4 digits long with no dashes or slashes

            if (year.Length == 0) // empty text box is valid
            {
                isValid = true;

            } else if (year.IndexOf("/") > -1 || year.IndexOf("-") > -1 || year.Length > numberOfDigits) // check format
            {            
                isValid = false;

            } else if (year.Length <= numberOfDigits) // then check that the year has only digits
            {
                //check that it is an int
                try
                {
                    int isAnInt = 0;
                    isAnInt = Int32.Parse(year); //throws exception if the text is not a number
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
                dataGridView_testRetrieval.DataSource = u1.GetAllUserDetails(pUserLevel);
            }
            catch (MLMSExceptions ex)
            {
                Console.WriteLine(ex);
                label1.Text = ex.Message;
            }
        }

        private void TestRetrieval_Load(object sender, EventArgs e)
        {

        }
    }
}
