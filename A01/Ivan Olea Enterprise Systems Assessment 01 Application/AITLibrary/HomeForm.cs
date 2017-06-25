using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class HomeForm : PersistentData
    {
        private MediaModel criteriaList = new MediaModel(); //holds data entered in a list 
        private MediaLogic _mediaLogic;
        private ReserveLogic _reserveLogic;

        private string message5 = "No Media Selected";
        private string message6 = "Invalid year entered: YYYY. Only 4 numbers allowed.";

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //hide and unhide details based on user level
            if(pUserLevel == 1) //user view
            {
                setUpUserLevel();

            }
            else if (pUserLevel == 2) // supervisor view
            {
                setUpSupervisorLevel();
            }
            else if (pUserLevel == 3) // Admin view
            {
                setUpAdminLevel();
            }
        }

#region button methods
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

            _mediaLogic = new MediaLogic(); // the portal to the data
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
                            MessageBox.Show(message6);
                                dataIsValid = false;
                    }                    
                }//endif 

                //if inforamtion entered is valid then get info
                if (dataIsValid)
                {
                    dataGridView.DataSource = _mediaLogic.getMediaByCriteria(criteriaList);
                        //dataGridView.Columns["MediaID"].Visible = false; //hide MediaID
                            dataGridView.Columns["Budget"].Visible = false; //hide budget
                } else
                {
                    System.Windows.Forms.MessageBox.Show("An error has occured understanding your entries.\nPlease try again.");
                }

        }

        private void details_btn_Click(object sender, EventArgs e)
        {
            // Opens a Media Form Showing 
            // Media Details including loan status
            // options to borrow item and reserve item

            // ### Implementation
            // check to see if an item has been selected on the grid
            if (dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // an efficient way of checking whether the datagridview is empty
            {
                MessageBox.Show(message5);
            }
            else
            {
                int mediaID = captureItemSelected(); // get the selected media id from first row of items selected
                OpenMediaDetailForm(mediaID); // open new media details window with selectedMediaID from persistent data
            }//end if
        } //endm

        private void borrow_btn_Click(object sender, EventArgs e)
        {
            // runs detail button method
            // captures mediaID
            // opens a Media Detail Form (mediaID)

        }//endm

        private void reserve_btn_Click(object sender, EventArgs e)
        {
            //### ALGORITHM
            // open a reserve form that shows 
            // a datagrid of reservation dates
            // and a claendar to choose a date from

            if (dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // an efficient way of checking whether the datagridview is empty
            {
                System.Windows.Forms.MessageBox.Show(message5);
            }
            else
            {
                int mediaID = captureItemSelected();
                OpenReserveForm(mediaID);
            }//end if
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            // delete persistent data
            ClearData();
                // close thread 
                this.Close();
                    // go back to login screen
                    System.Threading.Thread t0 = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
                    t0.Start();
            // destroy old thread
            this.Close();
        }

        #endregion


#region assistive methods
        private void setUpAdminLevel()
        {
            //dont hide anything
            this.Name = "Administrator: " + pUserName;
        }

        private void setUpSupervisorLevel()
        {
            deleteMedia_btn.Visible = false;
            deleteUser_btn.Visible = false;
            admin_lbl.Visible = false;
            this.Name = "Supervisor: " + pUserName;
        }

        private void setUpUserLevel()
        {
            return_btn.Visible = false;
            registerUser_btn.Visible = false;
            addNewMedia_btn.Visible = false;
            return_btn.Visible = false;
            deleteMedia_btn.Visible = false;
            deleteUser_btn.Visible = false;
            sup_lbl.Visible = false;
            admin_lbl.Visible = false;
            PictureBox coverImage = new PictureBox();
            coverImage.Size = new System.Drawing.Size(1000, 1000);
            coverImage.Image = Properties.Resources.LogoVertical;
            coverImage.Location = new System.Drawing.Point(928, 0);
            //coverImage.ClientSize = new System.Drawing.Size(350, 800);
            this.Controls.Add(coverImage);
            this.Name = "AIT MLMS: " + pUserName;
        }


        private bool itemIsOnLoan (Int32 _mid)
        {
            MediaLogic mL = new MediaLogic();
            List<MediaDetailModel> _mL = mL.getMediaDetails(_mid);
            Console.WriteLine("On Loan: " + _mL[0].OnLoan);
            return _mL[0].OnLoan;
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

        private Int32 captureItemSelected()
        {
            // get the first row in case multiple rows were selected
            PersistentData.selectedMediaID = (Int32)dataGridView.SelectedRows[0].Cells["MediaID"].Value;// add value to persistent data
                
            //STUB
            Console.WriteLine("Saved Selected Media ID to Persistent Data: " + PersistentData.selectedMediaID);
            //endstub

            return PersistentData.selectedMediaID;
        }

        private void OpenMediaDetailForm(Int32 _mid)
        {
            try
            {
                MediaDetail md = new MediaDetail(_mid);
                md.Show();
                md.TopMost = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not open window.\n" + ex);
            }
        }

        private void OpenReserveForm(int _mid)
        {
            try
            {
                ReserveForm rF = new ReserveForm(_mid);
                rF.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not open window.\n" + ex);
            }
        }//endm

        private void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            details_btn_Click(sender, e);
        }
        #endregion

        private void registerUser_btn_Click(object sender, EventArgs e)
        {
            //open up a registration form
            //take registration details
            //check and store details
        }

        private void borrowHistory_btn_Click(object sender, EventArgs e)
        {
            // 
        }

        private void return_btn_Click(object sender, EventArgs e)
        {

        }
    }//endc
}//end nsp