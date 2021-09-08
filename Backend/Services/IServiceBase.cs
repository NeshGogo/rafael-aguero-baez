using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services
{
    public interface IServiceBase<T>
    {
        Task<List<T>> GetAsync();
        Task<T> GetAsync(int id);
        Task<T> AddAsync(T entity);
    }
}
