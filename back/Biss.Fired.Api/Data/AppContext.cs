using Biss.Fired.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Biss.Fired.Api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Models.Fired> Fired { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<MediaType> MediaType { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Models.Fired>()
            .Property(f => f.Name).HasMaxLength(100).IsRequired(true);
            builder.Entity<Models.Fired>()
            .Property(f => f.IP).HasMaxLength(16).IsRequired(true);

            builder.Entity<Media>()
            .Property(m => m.URL).HasMaxLength(300).IsRequired(true);
            builder.Entity<Media>()
            .Property(m => m.Description).HasMaxLength(150).IsRequired(true);
            builder.Entity<Media>()
            .Property(m => m.EmailWarning).HasMaxLength(150);
            builder.Entity<Media>()
            .Property(m => m.IP).HasMaxLength(16).IsRequired(true);

            builder.Entity<MediaType>()
            .Property(m => m.Description).HasMaxLength(60).IsRequired(true);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=F@nT@2306!; TrustServerCertificate=True;Persist Security Info=True;User ID=9263_fired;Initial Catalog=9263_fired;Data Source=bd.asp.hostazul.com.br,3533");
        }
    }

}
