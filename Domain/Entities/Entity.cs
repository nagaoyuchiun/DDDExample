using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Entities
{
    public class Entity : IEntity
    {
        public DateTime? UpdateDateTime { get; set; }
        public long? UpdateAtNo { get; set; }
        public bool IsEnabled { get; set; }
        public Guid? DeleteKey { get; private set; }

        public long No { get; }

        public Guid Id { get; set; } 

        public DateTime CreateDateTime { get; set; } 

        public long CreateAtNo { get; set; }

        public void GenerateDeleteKey()
        {
            DeleteKey = Guid.NewGuid();
        }
    }
}
