using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class TabUserModel
    {
        // fields (private variables) 
            private int _userID;
            private string _userName;
            private int _userLevel;
            private string _userEmail;

        // properties 
        #region
            public int UserID
            {
                get {return _userID;}
                set {_userID = value;}
            }

            public string UserName
            {
                get { return _userName; }
                set { _userName = value; }
            }

            public int UserLevel
            {
                get { return _userLevel; }
                set { _userLevel = value; }
            }

            public string UserEmail
            {
                get
                {
                    return _userEmail;
                }

                set
                {
                    _userEmail = value;
                }
            }
            #endregion


        //create a PARSE function that is static  
        public static TabUserModel Parse (UserDataSet.TabUserRow rowFromDataSet)
            {
                if (rowFromDataSet == null)
                {
                    return null;
                }

                TabUserModel modelData = new TabUserModel();
                    modelData.UserID = rowFromDataSet.UID;
                    modelData.UserName = rowFromDataSet.UserName;
                    modelData.UserLevel = rowFromDataSet.UserLevel;
                    modelData.UserEmail = rowFromDataSet.UserEmail;

                return modelData;
            }
    
    }
}
