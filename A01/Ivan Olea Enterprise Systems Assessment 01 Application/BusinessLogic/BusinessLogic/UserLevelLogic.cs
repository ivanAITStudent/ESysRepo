using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class UserLevelLogic
    {
        public UserLevelLogic()
        {

        }

        public List<UserLevelModel> getAllUserLevels()
        {
            UserLevelDAO dao = new UserLevelDAO();
            UserLevelDS.TabUserLevelDataTable dataTable = new UserLevelDS.TabUserLevelDataTable();
            List<UserLevelModel> list = new List<UserLevelModel>();

            try
            {
                dataTable = dao.getAllUserLevels();
                if (dataTable.Count > 0)
                {
                    foreach (UserLevelDS.TabUserLevelRow row in dataTable)
                    {
                        list.Add(UserLevelModel.Parse(row));
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<UserLevelModel> getStandardUserLevel()
        {
            throw new NotImplementedException();
        }
    }
}
