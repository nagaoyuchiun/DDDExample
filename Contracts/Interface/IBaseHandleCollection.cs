using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface.IBaseHandleCollection
{
    public interface ICreate<T> where T : IIdentifiable
    {
        Task<IIdentifiable> Create(T entity);
    }

    public interface IRead<T> where T : IIdentifiable
    {
        Task<T?> Get(int id);
        Task<IEnumerable<T>> Query(IQueryParameter<T> queryParameter);
    }

    public interface IUpdate<T> where T : IEntity
    {
        Task Update(T entity);
    }

    public interface IDelete<T> where T : IEntity
    {
        Task Delete(T entity);
    }

}
