using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class CarImageMap : IEntityTypeConfiguration<CarImage>
    {
        public void Configure(EntityTypeBuilder<CarImage> builder)
        {
            builder.ToTable(@"CarImages", "dbo");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.CarId).HasColumnName("CarId");
            builder.Property(c => c.ImagePath).HasColumnName("ImagePath");
            builder.Property(c => c.Date).HasColumnName("Date");

        }
    }
}
