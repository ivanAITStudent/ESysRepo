using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class UserLevelModel
    {
        private Int32 level;
        private string levelName;

        public int Level { get => level; }
        public string LevelName { get => levelName; }

        public static UserLevelModel Parse(UserLevelDS.TabUserLevelRow rowFromDataSet)
        {
            if (rowFromDataSet == null)
            {
                return null;
            }

            UserLevelModel modelData = new UserLevelModel();
            modelData.level = rowFromDataSet.UserLevel;
            modelData.levelName = rowFromDataSet.UserLevelName;

            return modelData;
        }

    }

}
