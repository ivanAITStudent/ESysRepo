using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class HomeForm : PersistentData
    {
        private MediaModel criteriaList = new MediaModel(); //holds data entered in a list 

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //hide and unhide details based on user level
            if(pUserLevel == 1) //user view
            {
                return_button.Visible = false;
            }
            else if (pUserLevel == 2) // supervisor view
            {

            }
            else if (pUserLevel == 3) // Admin view
            {
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            // when the user clicks on search 
            // all textbox data is validated 
            // If data is invalid 
            // then ask user for correct informtion
            // else 
            // prep search data
            // add textbox data to criteria list media model
            // get result (criteria list)
            // Note: The only text box that needs 
            // validation is the year

            MediaLogic _mediaLogic = new MediaLogic(); // the portal to the data
            dataGridView.Refresh(); // clears view
            bool dataIsValid = false; //flag used to control access

            // Validate text entered and add entry to criteria list
            if (director_tb.Text.Length == 0 && title_tb.Text.Length == 0 && year_tb.Text.Length == 0)
            {
                //if all boxes are empty return all media
                criteriaList.Director = "%";
                criteriaList.Title = title_tb.Text;
                criteriaList.PublishYear = 0;
                dataIsValid = true;
            }
            else
            {
                // Validate and prep director textbox
                if (director_tb.Text.Length > 0)
                    {
                        criteriaList.Director = "%" + director_tb.Text + "%";
                    }
                    else
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
                    if (year_tb.Text.Length == 0)
                    {
                        //if empty make value 0
                        criteriaList.PublishYear = 0;
                            dataIsValid = true;
                    }
                    else if (ValidateYear(year_tb.Text)) // if date format is valid add to list
                    {
                        criteriaList.PublishYear = Int32.Parse(year_tb.Text);
                            dataIsValid = true;
                    }
                    else // date error. Inform user to type a correct date
                    {
                        criteriaList.PublishYear = 0;
                         System.Windows.Forms.MessageBox.Show("Invalid year entered: YYYY. Only 4 numbers allowed.");
                             dataIsValid = false;
                    }                    
                }//endif 

                //if inforamtion entered is valid then get info
                if (dataIsValid)
                {
                    dataGridView.DataSource = _mediaLogic.getMediaByCriteria(criteriaList);
                    //dataGridView.Columns["MediaID"].Visible = false; //hide MediaID
                    //dataGridView.Columns["Budget"].Visible = false; //hide budget
                } else
                {
                    System.Windows.Forms.MessageBox.Show("An error has occured understanding your entries.\nPlease try again.");
                }


            ////STUB Check criteria
            //string criteriaCaptured = "Criteria: "
            //                    + criteriaList.Director
            //                    + " "
            //                    + criteriaList.Title
            //                    + " "
            //                    + criteriaList.PublishYear;
            //System.Windows.Forms.MessageBox.Show(criteriaCaptured);
            ////END STUB

        }

        private bool ValidateYear(string year)
        {
            int numberOfDigits = 4;
            bool isValid = false;

            // Confirm that year is 4 digits long with no dashes or slashes

            if (year.Length == 0) // empty text box is valid
            {
                isValid = true;

            }
            else if (year.IndexOf("/") > -1 || year.IndexOf("-") > -1 || year.Length > numberOfDigits) // check format
            {
                isValid = false;

            }
            else if (year.Length <= numberOfDigits) // then check that the year has only digits
            {
                //check that it is an int
                try
                {
                    int isAnInt = 0;
                    isAnInt = Int32.Parse(year); //throws exception if the text is not a number
                    Console.WriteLine(": Is An Int!");
                    isValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex + ": Not an Int");
                    isValid = false;
                }
            }

            Console.WriteLine(isValid);
            return isValid;
        }

        private void details_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView.DataSource.Equals(null))
            {
                System.Windows.Forms.MessageBox.Show("No Media Selected");
            }else 
            {
                //get the selected media id 
                //open new window showing details
                DataGridViewRow row = dataGridView.SelectedRows[0];
                    Console.WriteLine(row.Cells["MediaID"].Value);
                        selectedMediaID = (Int32)row.Cells["MediaID"].Value;
                System.Threading.Thread t3 = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMediaDetailForm));
                t3.Start();
                
            }
            //Console.WriteLine(((List<MediaModel>)dataGridView.DataSource)[3].Title);
        } //endm

        private void OpenMediaDetailForm ()
        {
            Application.Run(new MediaDetail(selectedMediaID));
        }
    }
}
