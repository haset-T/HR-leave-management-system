using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leave_management_system.Application.Persistence.Contracts
{
    public interface IGenericRepository <T> where T : class
    {
        Task<T> Get(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<bool> Exists(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}
