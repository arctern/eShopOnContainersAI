﻿using eShopDashboard.EntityModels.Ordering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopDashboard.Infrastructure.Data.Ordering
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems", schema: "Ordering");

            builder.Property(oi => oi.Id)
                .IsRequired(true)
                .ValueGeneratedNever();

            builder.Property(oi => oi.ProductId)
                .IsRequired();

            builder.Property(oi => oi.OrderId)
                .IsRequired();

            //builder.HasOne<Order>()
            //    .WithMany()
            //    .HasForeignKey(oi => oi.OrderId);
        }
    }
}