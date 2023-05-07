using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class QuyenService
    {

        private static readonly QuyenDAL db = new QuyenDAL();
        #region[Quyen_Kiemtra]
        public static int Quyen_Kiemtra(string TenKhuVuc)
        {
            return db.Quyen_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[Quyen_GetById]
        public static DataTable Quyen_GetById(QuyenInfo Data)
        {
            return db.Quyen_GetById(Data);
        }
        #endregion
        #region[Quyen_GetByAll]
        public static DataTable Quyen_GetByAll()
        {
            return db.Quyen_GetByAll();
        }
        #endregion
        #region[Quyen_GetByTop]
        public static DataTable Quyen_GetByTop(string Top, string Where, string Order)
        {
            return db.Quyen_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[Quyen_Insert]
        public static void Quyen_Insert(QuyenInfo Data)
        {
            db.Quyen_Insert(Data);
        }
        #endregion
        #region[Quyen_Update]
        public static void Quyen_Update(QuyenInfo Data)
        {
            db.Quyen_Update(Data);
        }
        #endregion
        #region[Quyen_Delete]
        public static void Quyen_Delete(QuyenInfo data)
        {
            db.Quyen_Delete(data);
        }
        #endregion
    }
}