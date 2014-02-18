using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QMTest_ThiTN.DAL;

namespace QMTest_ThiTN.BLL
{
    public class TaiKhoanBLL : IDisposable
    {
        qm_testEntities1 qm = new qm_testEntities1();
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                if (qm != null)
                {
                    qm.Dispose();
                    qm = null;
                }
        }
        ~TaiKhoanBLL()
        {
            Dispose(false);
        }
        /// <summary>
        /// Kiểm tra đăng nhập
        /// </summary>
        /// <param name="useName">Tên đăng nhập</param>
        /// <param name="passWord">Mật khẩu</param>
        /// <returns>Tài khoản tương ứng hoặc null</returns>
        public tbl_taikhoansinhvien Validate(string userName, string passWord)
        {
            return qm.tbl_taikhoansinhvien.Where(e => e.IdSinhVien == userName && e.MatKhau == passWord).SingleOrDefault();
        }

        public List<tbl_taikhoansinhvien> GetList_Account()
        {
            return qm.tbl_taikhoansinhvien.ToList();
        }

        public void Insert(tbl_taikhoansinhvien tk)
        {
            qm.tbl_taikhoansinhvien.AddObject(tk);
            qm.SaveChanges();
        }

        public void Delete(tbl_taikhoansinhvien tk)
        {
            tbl_taikhoansinhvien tksv = qm.tbl_taikhoansinhvien.SingleOrDefault(e => e.IdSinhVien == tk.IdSinhVien);
            qm.tbl_taikhoansinhvien.DeleteObject(tksv);
            qm.SaveChanges();
        }
    }
}
