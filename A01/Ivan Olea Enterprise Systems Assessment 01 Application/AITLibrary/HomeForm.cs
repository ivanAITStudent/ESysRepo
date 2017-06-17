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
        private BorrowLogic _borrowLogic;
        private ReserveLogic _reserveLogic;


        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //hide and unhide details based on user level
            if(pUserLevel == 1) //user view
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
            else if (pUserLevel == 2) // supervisor view
            {
                deleteMedia_btn.Visible = false;
                deleteUser_btn.Visible = false;
                admin_lbl.Visible = false;
                this.Name = "Supervisor: " + pUserName;
            }
            else if (pUserLevel == 3) // Admin view
            {
                //dont hide anything
                this.Name = "Administrator: " + pUserName;
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
                         System.Windows.Forms.MessageBox.Show("Invalid year entered: YYYY. Only 4 numbers allowed.");
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
            // check to see if an item has been selected
            if (dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // an efficient way of checking whether the datagridview is empty
            {
                System.Windows.Forms.MessageBox.Show("No Media Selected");
            }
            else
            {
                captureItemSelected(); // get the selected media id from first row of items selected
                OpenMediaDetailForm(); // open new media details window with selectedMediaID from persistent data
            }//end if
        } //endm

        private void borrow_btn_Click(object sender, EventArgs e)
        {
            // ### ALGORITHM
            // To borrow an item the user must have it physically in their hands 
            // It is assumed the item is scanned for borrowing

            // get userID
            // scan selected mediaID
            // set borrowDate = today
            // set returnDate = borrowDate + loanPeriod from persistent data
            // message1 = "This Item HAS BEEN RESERVED."
            // message2 = "Please return this book to the front counter."
            // message3 = "Reservations expire in one day please try again tomorrow"
            // message4 = "Please note: The return day has been brought forward to:\n"
            //                  + returnDate
            // check borrow status
            //// returnDate = calculate return date(media id, borrw date, return date)
            // if returnDate <= borrowDate
            //// message1 + "\n" + message2 + "\n" + message3
            // else 
            //// message1 + "\n" + message4
            //// INSERT NEW RECORD (_userID, mediaID, borrowDate, returnDate)
            // END IF

            // ### ALGO. IMPLEMENTATION
            string errorMessage1 = "Item Scan Invalid\n";
            string message1 = "This item HAS BEEN RESERVED";
            string message2 = "Please take item to the front counter\n"
                                    + "for further Assistance.\n";
            string message3 = "Reservations expire in one day please try again tomorrow";
            string message4 = "Please note: The return day has been brought forward to:\n";
            
            string debugMessage1 = "DEBUG INFO:\n";
            string debugMessage2 = "Please select media in the panel to test borrowing.\n";
            string debugMessage3 = "Media is on Loan and not available until returned.";

            // SCAN ITEM FUNCTION
            Int32 scannedID = scanItem();
            
            if (scannedID == -1) // scan error
            {
                System.Windows.Forms.MessageBox.Show(errorMessage1 + message2 + debugMessage1 + debugMessage2);
            }
            else
            {
                _borrowLogic = new BorrowLogic(); //init access

                int _uid = PersistentData.pUserID;// get userID
                int _mid = PersistentData.selectedMediaID; // get selected mediaID
                DateTime _borrowDate = DateTime.Today;// set borrowDate = today
                DateTime _returnDate = (_borrowDate.AddDays(PersistentData.pLoanPeriod)); // set returnDate to borrowDate + loanPeriod from persistent data

                //STUB checks borrow date and returndate values
                Console.WriteLine("todays date is: " + _borrowDate);
                Console.WriteLine("return date before check: " + _returnDate);
                //check borrow status
                if (itemIsOnLoan(_mid))
                {
                    //Show On Loan Message
                    System.Windows.Forms.MessageBox.Show(debugMessage1 + debugMessage3);
                }
                //endStub

                // set the returnDate
                _returnDate = setReturnDate(_returnDate, _borrowDate, _mid);
                
                //check if item can be borrowed based on the reserved date
                if (_returnDate.Equals(DateTime.Parse(PersistentData.pNullDate)))
                {
                    //Show On Loan Message
                    System.Windows.Forms.MessageBox.Show("Media has been reserved & Not Available.\nYou may, however reserve the book\nfor a later time below.");
                }
                else
                {
                    //insert borrow record
                    int affectedRecords = -1;
                    try
                    {
                        affectedRecords = _borrowLogic.InsertBorrow(_uid, _mid, _borrowDate, _returnDate);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Borrow Unsuccessful\nPlease Try Again");
                    }

                    if (affectedRecords > 0)
                    {
                        try
                        {
                            //open a media detail form to show item has been borrowed
                            MediaDetail borrowedWindow = new MediaDetail(_mid);
                                borrowedWindow.hideBorrowButton();
                                borrowedWindow.hideReserveButton();
                                    borrowedWindow.showOnLoanStrip();
                                        borrowedWindow.Show();
                            System.Windows.Forms.MessageBox.Show("Borrow Successful");
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show("An Error Has Occured\nPlease try again later.");
                        }
                    } //endif
                }//endif
            }//endif
        }//endm

        private void reserve_btn_Click(object sender, EventArgs e)
        {
            //### ALGORITHM
            // open a reserve form that shows 
            // a datagrid of reservation dates
            // and a claendar to choose a date from

            if (dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // an efficient way of checking whether the datagridview is empty
            {
                System.Windows.Forms.MessageBox.Show("No Media Selected");
            }
            else
            {
                captureItemSelected();
                OpenReserveForm(PersistentData.selectedMediaID);
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

            private int scanItem()
        {
            //STUB
            if (dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected) == 0) // no row selected
            {
                return -1;
            } else
            {
                captureItemSelected(); // store selected row mediaID in persistent data
            }
            //endstub
            
            // Scan Code goes here ...

            return PersistentData.selectedMediaID
        }
        
            private void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

            private DateTime setReturnDate(DateTime _returnDate, DateTime _borrowDate, Int32 _mid)
        {
            // ### Algotrithm: calculate return date: returns  
            // check to see if item has a reservation within the loan period, borrw dat and return date
            // QUERY: get all mediaID 
            //             where reserveDate>=@borrowDate 
            //                          AND reserveDate <= @returnDate
            //             Order by reserveDate Asc 
            //                The first entry from this query 
            //                    captures the earliest reserve date in the borrow range
            // if (query row count > 0)
            //// returnDate = reserveDate - 1 day
            // ENDIF
            // return returnDate
            

            // ###IMPLEMENTATION
            _reserveLogic = new ReserveLogic();
            List<ReserveModel> _listOfReservedMedia = new List<ReserveModel>();

            try
            {
                //try accessing DB
                _listOfReservedMedia = _reserveLogic.getMediaGreaterThanBorrowLessThanReturn(_borrowDate, _returnDate, _mid);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "MLMS Exception");
            }

            if (_listOfReservedMedia.Count > 0)
            {
                DateTime earliestReturnDate = _borrowDate.AddDays(1);
                if (_listOfReservedMedia[0].ReserveDate > earliestReturnDate) //there at least one day that the media can e borrowed
                {
                    //then the return date is the reserve date - 1 day
                    _returnDate = _listOfReservedMedia[0].ReserveDate.AddDays(-1);
                }
                else
                {
                    //can not borrow book, on reserve
                    _returnDate = DateTime.Parse(PersistentData.pNullDate);
                }
            }
            return _returnDate;
        }//end method

            private bool itemIsOnLoan (Int32 _mid)
            {
                MediaLogic mL = new MediaLogic();
                List<MediaDetailModel> _mL = mL.getMediaDetails(PersistentData.selectedMediaID);
                Console.WriteLine(_mL[0].OnLoan);
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

            private void captureItemSelected()
            {
                // get the first row in case multiple rows were selected
                PersistentData.selectedMediaID = (Int32)dataGridView.SelectedRows[0].Cells["MediaID"].Value;// add value to persistent data
                
                //STUB
                Console.WriteLine("Saved Selected Media ID to Persistent Data: " + PersistentData.selectedMediaID);
                //endstub
            }

            private void OpenMediaDetailForm()
            {
                try
                {
                    MediaDetail md = new MediaDetail();
                    md.ShowDialog();
                   //md.Activate();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("could not open window.\n" + ex);
                }
            }

            private void dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                details_btn_Click(sender, e);
            }

            private void OpenReserveForm(int _mid)
        {
            try
            {
                ReserveForm rF = new ReserveForm(_mid);
                rF.ShowDialog();

            }
            catch (Exception ex)
            {
                Console.WriteLine("could not open window.\n" + ex);
            }
        }
    }
}
