using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagement.Models
{
    public class PMSContext : DbContext
    {
        public PMSContext()
        {

        }

        public PMSContext(DbContextOptions<PMSContext> options) 
            : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(x => x.FirstName).IsRequired().HasMaxLength(64);

                entity.Property(x => x.LastName).IsRequired().HasMaxLength(64);

                entity.Property(x => x.EmailAddress).IsRequired().HasMaxLength(256);

                entity.Property(x => x.Mobile).HasMaxLength(14);

                entity.Property(x => x.Password).HasMaxLength(2048);

                entity.Property(x => x.Salt).HasMaxLength(1024);

                entity.Property(x => x.DateCreated).HasColumnType("datetime").HasDefaultValueSql("(getdate())");

                entity.Property(x => x.DateUpdated).HasColumnType("datetime");

                entity.Property(x => x.status).HasDefaultValueSql("((1))");














            });
        }
    }
}
