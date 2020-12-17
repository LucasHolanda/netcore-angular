using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Examples.Charge.Domain.Aggregates.PersonAggregate;

namespace Examples.Charge.Infra.Data.Configuration
{
    public class PhoneNumberTypeConfiguration : IEntityTypeConfiguration<PhoneNumberType>
    {
        public void Configure(EntityTypeBuilder<PhoneNumberType> builder)
        {
            //builder.Ignore(b => b.DomainEvents);

            //builder.ToTable("PhoneNumberType", "dbo").HasKey(t => t.PhoneNumberTypeID);
            builder.ToTable("PhoneNumberType", "dbo").HasKey(t => t.BusinessEntityID);

            //builder.Property(t => t.Id).HasColumnName("BusinessEntityID").IsRequired(true);
            builder.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID").IsRequired(true);
            builder.Property(t => t.Name).HasColumnName("Name").IsRequired(true);

            builder.HasData(new PhoneNumberType { BusinessEntityID = 1, Name = "Local phone"  });
            builder.HasData(new PhoneNumberType { BusinessEntityID = 2, Name = "Cellphone" });
            // builder.HasData(new PhoneNumberType { PhoneNumberTypeID = 1, Name = "Local phone"  });
            // builder.HasData(new PhoneNumberType { PhoneNumberTypeID = 2, Name = "Cellphone" });

        }
    }
}
