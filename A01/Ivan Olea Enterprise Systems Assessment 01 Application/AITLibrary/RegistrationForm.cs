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
    public partial class RegistrationForm : PersistentData 
    {
        string name;
        string password;
        Int32 userLevel;
        string userLevelName;

        public RegistrationForm()
        {
            InitializeComponent();
            //init variables
            Text = pUserName + ": " + "Registration User Form";
            
            //prepare user view
            setUpView();
            
        }

        private void setUpView()
        {
            if (pUserLevel == 3) //admin
            {
                // add all user level options to combo
                //// add each userlevel from db
                UserLevelLogic ull= new UserLevelLogic();
                List<UserLevelModel> comboList = ull.getAllUserLevels();
                if (comboList.Count > 0 )
                {
                    foreach (UserLevelModel model in comboList)
                    {
                        userLevel_cb.Items.Add (model.LevelName);
                    }
                }
                userLevel_cb.Text =(string)userLevel_cb.Items[0];
            }
            else
            {
                //restrict user level options to only standard users
                UserLevelLogic ull = new UserLevelLogic();
                List<UserLevelModel> comboList = ull.getStandardUserLevel();
                if (comboList.Count > 0)
                {
                    userLevel_cb.DataSource = comboList;
                    userLevel_cb.Text = comboList.ElementAt(0).LevelName;
                    userLevel_cb.Enabled = false;
                }
            }
        }
        
    }
}
