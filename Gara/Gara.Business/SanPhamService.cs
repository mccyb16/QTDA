using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class SanPhamService
    {

        private static readonly SanPhamDAL db = new SanPhamDAL();
        #region[SanPham_GetById]
        public static DataTable SanPham_GetById(SanPhamInfo Data)
        {
            return db.SanPham_GetById(Data);
        }
        #endregion
        #region[SanPham_GetByAll]
        public static DataTable SanPham_GetByAll()
        {
            return db.SanPham_GetByAll();
        }
        #endregion
        #region[SanPham_GetByTop]
        public static DataTable SanPham_GetByTop(string Top, string Where, string Order)
        {
            return db.SanPham_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[SanPham_Insert]
        public static void SanPham_Insert(SanPhamInfo Data)
        {
            db.SanPham_Insert(Data);
        }
        #endregion
        #region[SanPham_Update]
        public static void SanPham_Update(SanPhamInfo Data)
        {
            db.SanPham_Update(Data);
        }
        #endregion
        #region[SanPham_Delete]
        public static void SanPham_Delete(SanPhamInfo data)
        {
            db.SanPham_Delete(data);
        }
        #endregion
        #region[sq_SanPham_Updategia]
        public static void SanPham_Updategia(SanPhamInfo data)
        {
            db.SanPham_Updategia(data);
        }
        #endregion
    }
}