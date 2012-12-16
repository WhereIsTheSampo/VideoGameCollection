using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VGC.DomainModel;

namespace VGC.DataAccess
{
    public class EFDataContext : DbContext
    {
        public EFDataContext() : base()
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Platform> Platforms { get; set; }

        public DbSet<Label> Labels { get; set; }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>()
                .HasRequired(game => game.Platform)
                .WithMany(platform => platform.Games)
                .HasForeignKey(game => game.LabelId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Game>()
                .HasRequired(game => game.Company)
                .WithMany(company => company.Games)
                .HasForeignKey(game => game.CompanyId)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Game>()
            //    .HasRequired(game => game.Label)
            //    .WithMany(label => label.Games)
            //    .HasForeignKey(game => game.LabelId)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Label>()
            //    .HasRequired(label => label.Platform)
            //    .WithMany(platform => platform.Labels)
            //    .HasForeignKey(label => label.PlatformId)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Platform>()
            //    .HasRequired(platform => platform.Company)
            //    .WithMany(company => company.Platforms)
            //    .HasForeignKey(platform => platform.CompanyId)
            //    .WillCascadeOnDelete(false);
        }
    }
}
