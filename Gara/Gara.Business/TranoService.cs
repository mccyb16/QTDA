using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class TranoService
    {

        private static readonly TranoDAL db = new TranoDAL();
        #region[Trano_GetById]
        public static DataTable Trano_GetById(TranoInfo Data)
        {
            return db.Trano_GetById(Data);
        }
        #endregion
        #region[Trano_GetByAll]
        public static DataTable Trano_GetByAll()
        {
            return db.Trano_GetByAll();
        }
        #endregion
        #region[Trano_GetByTop]
        public static DataTable Trano_GetByTop(string Top, string Where, string Order)
        {
            return db.Trano_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[Trano_Insert]
        public static void Trano_Insert(TranoInfo Data)
        {
            db.Trano_Insert(Data);
        }
        #endregion
        #region[Trano_Update]
        public static void Trano_Update(TranoInfo Data)
        {
            db.Trano_Update(Data);
        }
        #endregion
        #region[Trano_Delete]
        public static void Trano_Delete(TranoInfo data)
        {
            db.Trano_Delete(data);
        }
        #endregion
    }
}