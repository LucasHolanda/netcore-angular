﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Examples.Charge.Domain.Aggregates.PersonAggregate;

namespace Examples.Charge.Infra.Data.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person", "dbo").HasKey(t => t.BusinessEntityID);

            builder.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID").IsRequired(true);
            builder.Property(t => t.Name).HasColumnName("Name").IsRequired(true);

            builder.HasData(new Person { BusinessEntityID = 1, Name = "User One" });
            builder.HasData(new Person { BusinessEntityID = 2, Name = "User Two" });
            builder.HasData(new Person { BusinessEntityID = 3, Name = "User Three" });
        }
    }
}
