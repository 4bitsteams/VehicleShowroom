using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleShowroom.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll(ref List<T> entities);
        T GetById(object id, ref List<T> entities);
        long Add(T entity, ref List<T> entities);
        bool Update(T entity, ref List<T> entities);
        bool Remove(object id, ref List<T> entities);
        bool Exist(object id, ref List<T> entities);
    }
}
