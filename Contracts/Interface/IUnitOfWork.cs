using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface
{
    public interface IUnitOfWork<T>
    {
        public T GetContext();
        public  Task BeginTransactionAsync();
        public  Task CommitTransactionAsync();
        public  Task RollbackTransactionAsync();
        public Task SaveChangesAsync();
    }
}
