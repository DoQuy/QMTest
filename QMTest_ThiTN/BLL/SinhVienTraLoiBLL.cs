using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QMTest_ThiTN.DAL;

namespace QMTest_ThiTN.BLL
{
    public class SinhVienTraLoiBLL : EntityMethod<sinhvientraloi, long>
    {
        qm_testEntities1 qm = new qm_testEntities1();
        public List<sinhvientraloi> GetList()
        {
            throw new NotImplementedException();
        }

        public List<sinhvientraloi> GetList(long key)
        {
            throw new NotImplementedException();
        }

        public sinhvientraloi GetEntity(long key)
        {
            throw new NotImplementedException();
        }

        public void Insert(sinhvientraloi entity)
        {
            qm.sinhvientralois.AddObject(entity);
            //qm.AddTosinhvientralois(entity);
            qm.SaveChanges();
        }

        public void Update(sinhvientraloi entity)
        {
            var sv = qm.sinhvientralois.SingleOrDefault(i => i.IdSinhVien == "10K40611086");
            sv.LuaChon = "A";
            qm.SaveChanges();
        }

        public void Delete(sinhvientraloi entity)
        {
            throw new NotImplementedException();
        }
    }
}
