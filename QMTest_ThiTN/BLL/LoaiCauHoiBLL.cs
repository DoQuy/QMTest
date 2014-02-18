using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QMTest_ThiTN.DAL;

namespace QMTest_ThiTN.BLL
{
    public class LoaiCauHoiBLL
    {
        qm_testEntities1 qm = new qm_testEntities1();
        public string GetIdLoaiCauHoi()
        {
            var idloaicau = from loaicau in qm.tbl_loaicauhoi
                            select new { loaicau.IdLoaiCauHoi };
            return idloaicau.ToString();
        }
    }
}
