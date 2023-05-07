using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
   public class TonkhoService
    {
        private static readonly TonkhoDAL db = new TonkhoDAL();
        #region[Tonkho_GetByTop]
        public static DataTable Tonkho_GetByTop(string Top, string Where, string Order)
        {
            return db.Tonkho_GetByTop(Top, Where, Order);
        }
        #endregion
    }
}
