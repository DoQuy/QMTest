using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QMTest_ThiTN.DAL;

namespace QMTest_ThiTN.BLL
{
    public class CauTraLoiBLL : EntityMethod<tbl_cautraloichinhthuc, string>
    {
        qm_testEntities1 qm = new qm_testEntities1();
        public List<tbl_cautraloichinhthuc> GetList()
        {
            throw new NotImplementedException();
        }

        public List<tbl_cautraloichinhthuc> GetList(string IdCauHoi)
        {
            return qm.tbl_cautraloichinhthuc.Where(e => e.IdCauHoi == IdCauHoi).ToList();
        }

        public tbl_cautraloichinhthuc GetEntity(string key)
        {
            throw new NotImplementedException();
        }

        public void Insert(tbl_cautraloichinhthuc entity)
        {
            throw new NotImplementedException();
        }

        public void Update(tbl_cautraloichinhthuc entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(tbl_cautraloichinhthuc entity)
        {
            throw new NotImplementedException();
        }
    }
}
