using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTLASPMONGO.Models.BusinessModels
{
    public interface IRepositoryGeneric<T,K>
    {
        List<T> GetAll();
        T GetById(K key);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(K key);
    }
}
