using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.UserLevelDSTableAdapters;

namespace DataAccessLayer
{
    public class UserLevelDAO
    {
        //private variables
        private UserLevelDS _dataSet;
        private TabUserLevelTableAdapter _tableAdapter;
        private UserLevelDS.TabUserLevelDataTable _dataTable;

        public UserLevelDAO()
        {
            _dataSet = new UserLevelDS();
            _tableAdapter = new TabUserLevelTableAdapter();
            _dataTable = new UserLevelDS.TabUserLevelDataTable();

        }

        //get data queries, returns a data table
        public UserLevelDS.TabUserLevelDataTable getAllUserLevels()
        {
            _dataSet.TabUserLevel.Clear();
            try
            {
                _tableAdapter.FillAll(_dataTable);
                return _dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
