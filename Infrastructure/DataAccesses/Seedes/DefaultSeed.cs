using Domains.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccesses.Seedes
{
    public static class DefaultSeed
    {
        public static void SetSiteDefaultData(this ModelBuilder builder,IUserContext userContext)
        {
            builder.Entity<Site>().HasData(new Site
            {
                DefaultLanguage = Domains.ValueOfObject.Enum.LanguageEnum.ZH_TW,
                UpdateAtNo = userContext.UserNo,
                UTC = 8
            });
        }
    }
}
