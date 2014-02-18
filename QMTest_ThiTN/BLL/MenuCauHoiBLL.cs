using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QMTest_ThiTN.DAL;

namespace QMTest_ThiTN.BLL
{
    public class MenuCauHoiBLL : IDisposable
    {
        qm_testEntities1 qm = new qm_testEntities1();
        public string IdCauHoi
        {
            get;
            set;
        }
        public string TenCauHoi
        {
            get;
            set;
        }
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
        ~MenuCauHoiBLL()
        {
            Dispose(false);
        }
        public List<MenuCauHoiBLL> GetMenu()
        {
            var menu = (from ch in qm.tbl_cauhoichinhthuc
                        select new MenuCauHoiBLL
                        {
                            IdCauHoi = ch.IdCauHoi,
                        }).ToList();
            return menu;
        }
    }
}
