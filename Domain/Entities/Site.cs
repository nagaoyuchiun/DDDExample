using Domains.ValueOfObject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Entities
{
    public class Site : Entity
    {
        public LanguageEnum DefaultLanguage {  get; set; }
        public int UTC {  get; set; }
    }
}
