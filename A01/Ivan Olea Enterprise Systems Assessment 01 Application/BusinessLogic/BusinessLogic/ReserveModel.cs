using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class ReserveModel
    {
        //fields
        private Int32 _rid;
        private Int32 _uid;
        private Int32 _mid;
        private DateTime _reserveDate;

        //properties
        public int Rid { get => _rid; set => _rid = value; }
        public int Uid { get => _uid; set => _uid = value; }
        public int Mid { get => _mid; set => _mid = value; }
        public DateTime ReserveDate { get => _reserveDate; set => _reserveDate = value; }

        public static ReserveModel Parse(ReserveDS.TabReservedRow row)
        {
            if (row == null)
            {
                return null;
            }

            ReserveModel rM = new ReserveModel();
            rM.Rid = row.RID;
            rM.Uid = row.UID;
            rM.Mid = row.MediaID;
            rM.ReserveDate = row.ReservedDate;

            return rM;

        }
    }
}
