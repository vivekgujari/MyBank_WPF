using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IDataService<T>
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Create(T Entity);
        Task<T> Update(int id, T Entity);
        Task<bool> Delete(int id);
    }
}
