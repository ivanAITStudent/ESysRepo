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
            message_lbl.Text = "";
            UserLogic uL = new UserLogic();
            string un = username_tb.Text;
            string pw = password_tb.Text;

            //DEBUG
            //    Console.WriteLine("Check Data: " + un + ": " + pw);
            //

            //check if text boxes are empty
            // if either textbox is empty
            if (username_tb.Text.Length.Equals(0) || password_tb.Text.Equals(0))
            {
                //      then show error
                System.Windows.Forms.MessageBox.Show("Please Complete the form\n to log in.");
            }
            else
            {
                // else attempt to login
                //LOGIN ATTEMPT
                try
                {
                    // get user details
                    List<TabUserModel> _userList = uL.GetLogin(un, pw);

                    // if user exists store details in persistent data
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
                catch (Exception ex)
                {
                    // connection failed exception
                    // show login failed message
                    message_lbl.Text = "Connection Failed.\nPlease try again later.";
                }

            }

        }

        private void OpenApplication ()
        {
            Application.Run(new HomeForm());
        }

//# DEBUGGER #
        private void button1_Click(object sender, EventArgs e)
        {
            String buttonName = ((Button)sender).Name;
            switch (buttonName)
            {
                case "button2":
                    message_lbl.Text = "you pressed " + buttonName;
                    username_tb.Text = "sup";
                    password_tb.Text = "Sup12345";
                    break;
                case "button3":
                    message_lbl.Text = "You Pressed " + buttonName;
                    username_tb.Text = "admin";
                    password_tb.Text = "Admin123";
                    break;
                default:
                    message_lbl.Text = "you pressed " + buttonName;
                    username_tb.Text = "user1";
                    password_tb.Text = "user";
                    break;
            }
        }
//END DEBUGGER

    }
}
