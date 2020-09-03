using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.Domain.Services
{
    public interface IDataServices<T>
    {
        //async gannna puluwan wenna thami task ekak interface eka danne
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<T> Update(int id, T entity);
        Task<bool> Delete(int id);

    }
}
