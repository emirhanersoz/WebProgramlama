using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace eBilet.Data.Base
{
    public interface IEntityBaseRepository <T> where T: class, IEntityBase, new()
    {
        Task<IEnumerable<T>> HepsiniAlAsync();
        Task<IEnumerable<T>> HepsiniAlAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> IdİleAlAsync(int id);
        Task<T> IdİleAlAsync(int id, params Expression<Func<T, object>>[] includeProperties);
        Task EkleAsync(T entity);
        Task GüncelleAsync(int id, T entity);
        Task SilAsync(int id);
    }
}
