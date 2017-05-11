using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;


namespace BusinessLogic
{
    public class UserLogic
    {
        private UserDataAccessObject _userDAO;
        private List<TabUserModel> _users;
        private UserDataSet.TabUserDataTable _tabUserTable;

        //constructor
        public UserLogic()
        {
            _userDAO = new UserDataAccessObject();
            _users = new List<TabUserModel>();
            _tabUserTable = new UserDataSet.TabUserDataTable();

        }

        public List<TabUserModel> GetAllUserDetails(int requestLevel)
        {
           
            if (requestLevel == 3 )
            { 
                _users = new List<TabUserModel>();

                try
                {
                    _tabUserTable = _userDAO.GetUser();

                    foreach (UserDataSet.TabUserRow row in _tabUserTable.Rows)
                    {
                        _users.Add(TabUserModel.Parse(row));
                    }

                    return _users;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Table could not be filled");
                    throw ex;
                }
            }
            else
            {
                //throw access denied exception
                throw new MLMSExceptions("Access Deinied");
            }
        }

        public List<TabUserModel> GetLogin(String inputUsername, String inputPassword)
        {
            _users = new List<TabUserModel>();
            try
            {
                _tabUserTable = _userDAO.GetLogin(inputUsername, inputPassword);
                
                foreach (UserDataSet.TabUserRow row in _tabUserTable.Rows)
                {
                    _users.Add(TabUserModel.Parse(row));
                }
                return _users;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:"+ex.ToString()+", captured. Could Not Fill Table" );
                throw ex;
            }
        }//end GetLogin
    }
}
