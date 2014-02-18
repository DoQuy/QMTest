using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QMTest_ThiTN.DAL;

namespace QMTest_ThiTN.BLL
{
    public class CauHoiBLL : EntityMethod<tbl_cauhoichinhthuc, string>
    {
        qm_testEntities1 qm = new qm_testEntities1();

        public List<tbl_cauhoichinhthuc> GetList()
        {
            return qm.tbl_cauhoichinhthuc.ToList();
        }

        public List<tbl_cauhoichinhthuc> GetList(string key)
        {
            throw new NotImplementedException();
        }

        public tbl_cauhoichinhthuc GetEntity(string key)
        {
            throw new NotImplementedException();
        }

        public void Insert(tbl_cauhoichinhthuc entity)
        {
            qm.tbl_cauhoichinhthuc.AddObject(entity);
            qm.SaveChanges();
        }

        public void Update(tbl_cauhoichinhthuc entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(tbl_cauhoichinhthuc entity)
        {
            throw new NotImplementedException();
        }
    }
}
