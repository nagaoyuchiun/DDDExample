using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public interface IEntity : IIdentifiable
    {
        public DateTime? UpdateDateTime { get; set; }
        public long? UpdateAtNo { get; set; }
        public bool IsEnabled { get; set; }
        public Guid? DeleteKey { get; }

        public void GenerateDeleteKey();
    }
}
