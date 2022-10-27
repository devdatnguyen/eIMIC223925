using eIMIC2325.Data.Entities;
using eIMIC2325.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eIMIC2325.Data.Configurations
{
    public class CategoryCafiguration : IEntityTypeConfiguration <Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Catagories");
            builder.HasKey(x => x.Id);
            //Tự động tăng lên 1
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);

        }
    }
}
