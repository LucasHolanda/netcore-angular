using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Examples.Charge.Domain.Aggregates.PersonAggregate;

namespace Examples.Charge.Infra.Data.Configuration
{
    public class PhoneNumberTypeConfiguration : IEntityTypeConfiguration<PhoneNumberType>
    {
        public void Configure(EntityTypeBuilder<PhoneNumberType> builder)
        {            
            builder.ToTable("PhoneNumberType", "dbo").HasKey(t => t.BusinessEntityID);

            builder.Property(t => t.BusinessEntityID).HasColumnName("BusinessEntityID").IsRequired(true);
            builder.Property(t => t.Name).HasColumnName("Name").IsRequired(true);

            builder.HasData(new PhoneNumberType { BusinessEntityID = 1, Name = "Local phone"  });
            builder.HasData(new PhoneNumberType { BusinessEntityID = 2, Name = "Cellphone" });
        }
    }
}
