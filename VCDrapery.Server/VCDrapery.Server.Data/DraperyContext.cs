using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VCDrapery.Server.Data
{
    public class DraperyContext : DbContext, IDatabaseContext
    {
        public DraperyContext(DbContextOptions<DraperyContext> options) : base(options)
        {

        }

        public DbSet<Models.Customers> Customers { get; set; }
        //public DbSet<Models.Fabric> Fabric { get; set; }
        public DbSet<Models.QuoteLineItem> QuoteLineItems { get; set; }
        public DbSet<Models.Quote> Quote { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Models.Quote>(entity =>
            {
                entity.HasMany(x => x.LineItems).WithOne(x => x.Quote).HasForeignKey(x => x.QuoteId);
                entity.HasOne(x => x.Customer).WithMany(x => x.Quotes).HasForeignKey(x => x.CustomerId);
            });
            model.Entity<Models.QuoteLineItem>(entity =>
            {
                entity.HasOne(x => x.Quote).WithMany(x => x.LineItems).HasForeignKey(x => x.QuoteId);
            });
            model.Entity<Models.Customers>(entity =>
            {
                entity.HasMany(x => x.Quotes).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId);
            });
        }
      
    }
}
