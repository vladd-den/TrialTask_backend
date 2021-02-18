using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trial_Task.Data
{
    public interface IRepository<T> where T :class, IEntity
    {
        Task<List<T>> GetAll();
        Task<Object> Update(T entity);
    }
}
