using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAsync();
        Task<List<T>> GetAsync(string includeValue);
        Task<T> GetAsync(int id);
        Task<T> AddAsync(T entity);
    }
}
