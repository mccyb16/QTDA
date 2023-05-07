using SamLop.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SamLop.Business
{
    public class XeBaoTriService
    {

        private static readonly XeBaoTriDAL db = new XeBaoTriDAL();
        #region[XeBaoTri_Kiemtra]
        public static int XeBaoTri_Kiemtra(string TenKhuVuc)
        {
            return db.XeBaoTri_Kiemtra(TenKhuVuc);
        }
        #endregion
        #region[XeBaoTri_GetById]
        public static DataTable XeBaoTri_GetById(XeBaoTriInfo Data)
        {
            return db.XeBaoTri_GetById(Data);
        }
        #endregion
        #region[XeBaoTri_GetByAll]
        public static DataTable XeBaoTri_GetByAll()
        {
            return db.XeBaoTri_GetByAll();
        }
        #endregion
        #region[XeBaoTri_GetByTop]
        public static DataTable XeBaoTri_GetByTop(string Top, string Where, string Order)
        {
            return db.XeBaoTri_GetByTop(Top, Where, Order);
        }
        #endregion
        #region[XeBaoTri_Insert]
        public static void XeBaoTri_Insert(XeBaoTriInfo Data)
        {
            db.XeBaoTri_Insert(Data);
        }
        #endregion
        #region[XeBaoTri_Update]
        public static void XeBaoTri_Update(XeBaoTriInfo Data)
        {
            db.XeBaoTri_Update(Data);
        }
        #endregion

        #region[XeBaoTri_Updatexong]
        public static void XeBaoTri_Updatexong(XeBaoTriInfo Data)
        {
            db.XeBaoTri_Updatexong(Data);
        }
        #endregion
        #region[XeBaoTri_Delete]
        public static void XeBaoTri_Delete(XeBaoTriInfo data)
        {
            db.XeBaoTri_Delete(data);
        }
        #endregion
    }
}
