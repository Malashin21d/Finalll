using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task Add(T entity);
        Task Delete(T entity);
    }

}
