﻿using EntityLayer.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.EntityTypeConfiguration.Abstract
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(a=>a.ID);

            builder.Property(a => a.OrderDate).IsRequired(true);
            // ModifiedDate nullable
            builder.Property(a => a.ModifiedDate).IsRequired(false);
            // RemovedDate nullable
            builder.Property(a => a.RemovedDate).IsRequired(false);
            // Statu required
            builder.Property(a => a.Statu).IsRequired(true);
        }
    }
}
