using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.DTO
{
    public class LoginInfoDTO
    {
        public required string SiteLanguage { get; set; }
        public string? SiteManage { get; set; }
    }
}
