using EntityLayer.Entities.Concrete;
using EntityLayer.EntityTypeConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.EntityTypeConfiguration.Concrete
{
    public class OrderMap : BaseMap<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(a => a.CompanyName).HasMaxLength(100).IsRequired(true);
            builder.Property(a => a.ProductionName).HasMaxLength(100).IsRequired(true);
            base.Configure(builder);
        }
    }
}
