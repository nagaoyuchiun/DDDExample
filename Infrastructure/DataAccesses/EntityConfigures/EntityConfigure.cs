using Domains.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccesses.EntityConfigures
{
    public abstract class EntityConfigure<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey("No");
            builder.HasQueryFilter(x => x.DeleteKey == new Guid());

            builder.Property(x => x.No)
                .HasComment("序號")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Id)
                .HasComment("唯一鍵")
                .IsRequired()
                .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Property(x => x.CreateAtNo)
                .HasComment("建立人員")
                .IsRequired()
                .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Property(x => x.CreateDateTime)
                .HasComment("創建日期時間")
                .IsRequired()
                .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            builder.Property(x => x.DeleteKey)
                .HasComment("刪除鍵值")
                .HasDefaultValue(new Guid());

            ConfigureHelper(builder);

        }

        protected abstract void ConfigureHelper(EntityTypeBuilder<T> builder);

    }
}
