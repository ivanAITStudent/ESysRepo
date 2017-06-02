using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.UserDataSetTableAdapters;

namespace DataAccessLayer
{
    public class UserDataAccessObject
    {
        //we create two variable for a User Data Set and Table Adapter
        private UserDataSet _userDataSet;
        private TabUserTableAdapter _tabUserTableAdapter;

        //constructor method to instantiate private variables
        public UserDataAccessObject()
        {
            _userDataSet = new UserDataSet();
            _tabUserTableAdapter = new TabUserTableAdapter();
        }

        //create a Get User function that returns a DATASET from TAB USER INFO and is captured in the variable _userDataSet.TabUser 
        public UserDataSet.TabUserDataTable GetUser()
        {
            try
            {
                _tabUserTableAdapter.FillAll(_userDataSet.TabUser);
                return _userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:"+ex.ToString()+", captured. Could Not Fill Table" );
                throw ex;
            }
        }

        public UserDataSet.TabUserDataTable GetLogin(String inputUsername, String inputPassword)
        {
            try
            {
                _tabUserTableAdapter.FillByUserNamePassword(_userDataSet.TabUser, inputUsername, inputPassword);
                return _userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }//end GetLogin


    }
}
