using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QMTest_ThiTN.DAL;

namespace QMTest_ThiTN.BLL
{
    public class LayKetQuaBLL : IDisposable
    {
        qm_testEntities1 qm = new qm_testEntities1();
        public string IdSinhVien { get; set; }
        public string NgayThi { get; set; }
        public string IdCauHoi { get; set; }
        public string LuaChon { get; set; }
        public string DapAn { get; set; }
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
        ~LayKetQuaBLL()
        {
            Dispose(false);
        }
        public List<LayKetQuaBLL> LayKetQua(string idsinhvien)
        {
            //return qm.sinhvientralois.Where(sv => sv.IdSinhVien == idsinhvien).ToList();
            var kq = (from sv in qm.sinhvientralois
                      from ctl in qm.tbl_cautraloichinhthuc
                      where sv.IdSinhVien == idsinhvien && ctl.DapAn != null && ctl.IdCauHoi==sv.IdCauHoi
                      select new LayKetQuaBLL
                      {
                          IdSinhVien = sv.IdSinhVien,
                          NgayThi = sv.ThoiGian,
                          IdCauHoi = sv.IdCauHoi,
                          LuaChon = sv.LuaChon,
                          DapAn = ctl.DapAn
                      }).Distinct().ToList();
            return kq;
        }
    }
}
