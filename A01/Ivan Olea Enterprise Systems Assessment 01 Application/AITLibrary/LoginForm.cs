using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AITLibrary
{
    public partial class LoginForm : PersistentData
    {
        public LoginForm()
        {
            InitializeComponent();
            message_lbl.Text = "---";
        }

        private void login_btn_click(object sender, EventArgs e)
        {
            UserLogic uL = new UserLogic();
            string un = username_tb.Text;
            string pw = password_tb.Text;

            //DEBUG
            //    Console.WriteLine("Check Data: " + un + ": " + pw);
            //

            //check if text boxes are empty
            // if either textbox is empty
            //      then show error
            //      reset un and pw  
            // else attempt to login

                // get user details
                    List<TabUserModel> _userList = uL.GetLogin(un, pw);

                // is user exists store details in persistent data
                // then check userlevel and start a new thread with correct user level form
                // close this thread
                if (_userList.Count() > 0)
                {
                    // Show login success message
                        message_lbl.Text = "Login Success";
                    
                    //capture details in persistent data
                        pUserID = _userList.ElementAt(0).UserID;
                        pUserName = _userList.ElementAt(0).UserName;
                        pUserEmail = _userList.ElementAt(0).UserEmail;
                        pUserLevel = _userList.ElementAt(0).UserLevel;

                    //start a new thread with correct user level form

                        System.Threading.Thread t1 = new System.Threading.Thread(new System.Threading.ThreadStart(OpenApplication));
                        t1.Start();

                    // destroy old thread
                    this.Close();
                }
                else
                {
                    // show login failed message
                        message_lbl.Text = "Login Failed. Please try again";
                    // clear content of text boxes 
                        username_tb.Clear();
                        password_tb.Clear();
                } //endif

        }

        private void OpenApplication ()
        {
            switch (pUserLevel)
            {
                case 1: //user only access
                    Application.Run(new HomeForm());
                    break;
                case 2: //supervisor access
                    Application.Run(new HomeForm());
                    break;
                case 3: //administration access
                    Application.Run(new HomeForm());
                    break;
                default: //access denied
                    Console.WriteLine("Access Denied: incorrect user level. See Administrator for asssistance");
                    break;
            }

        }

    }
}
