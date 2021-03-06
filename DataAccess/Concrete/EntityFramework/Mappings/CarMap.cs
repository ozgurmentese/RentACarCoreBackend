using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable(@"Cars", "dbo");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.BrandId).HasColumnName("BrandId");
            builder.Property(c => c.ColorId).HasColumnName("ColorId");
            builder.Property(c => c.CarName).HasColumnName("Name");
            builder.Property(c => c.ModelYear).HasColumnName("ModelYear");
            builder.Property(c => c.DailyPrice).HasColumnName("DailyPrice");
            builder.Property(c => c.Description).HasColumnName("Description");
            builder.Property(c => c.EnginePower).HasColumnName("EnginePower");
            builder.Property(c => c.FuelType).HasColumnName("FuelType");
            builder.Property(c => c.GearType).HasColumnName("GearType");
        }
    }
}
