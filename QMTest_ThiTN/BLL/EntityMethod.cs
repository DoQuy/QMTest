using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QMTest_ThiTN.BLL
{
    public interface EntityMethod<T, U>
    {
        List<T> GetList();
        List<T> GetList(U key);
        T GetEntity(U key);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
