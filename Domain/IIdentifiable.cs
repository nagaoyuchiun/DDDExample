using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public interface IIdentifiable
    {
        public long No { get; }
        public Guid Id { get; }
        public DateTime CreateDateTime { get; }
        public long CreateAtNo { get; }
    }
}
