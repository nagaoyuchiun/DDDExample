using Domains.Entities;
using Domains.ValueOfObject.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccesses.EntityConfigures
{
    public class SiteEntityConfigure : EntityConfigure<Site>
    {
        protected override void ConfigureHelper(EntityTypeBuilder<Site> builder)
        {
            builder.Property(x => x.DefaultLanguage)
                .HasComment("預設語系")
                .IsRequired()
                .HasDefaultValue(LanguageEnum.ZH_TW);

            builder.Property(x => x.UTC)
                .HasComment("時區")
                .IsRequired()
                .HasMaxLength(3);
        }
    }
}
