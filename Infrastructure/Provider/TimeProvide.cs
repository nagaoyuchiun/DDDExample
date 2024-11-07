using Contracts.Interface.IProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Provider
{
    public class TimeProvide : ITimeProvider
    {
        public DateTime GetNow()
        {
            return DateTime.UtcNow;
        }
    }
}
