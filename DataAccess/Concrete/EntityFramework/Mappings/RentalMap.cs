using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class RentalMap : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable(@"Rentals", "dbo");

            builder.HasKey("Id");

            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.CarId).HasColumnName("CarId");
            builder.Property(c => c.CustomerId).HasColumnName("CustomerId");
            builder.Property(c => c.RentDate).HasColumnName("RentDate");
            builder.Property(c => c.ReturnDate).HasColumnName("ReturnDate");
        }
    }
}
