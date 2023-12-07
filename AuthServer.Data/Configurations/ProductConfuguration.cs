using AuthServer.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthServer.Data.Configurations
{
    public class ProductConfuguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(id => id.Id);
            builder.Property(na => na.Name).HasMaxLength(256).IsRequired();
            builder.Property(st => st.Stock).IsRequired();
            builder.Property(pr => pr.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(pr => pr.UserId).IsRequired();
        }
    }
}
