using EntityLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class wallContext:DbContext
    {
        public wallContext(DbContextOptions<wallContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //primary keys
            modelBuilder.Entity<userinfo>()
                .HasKey(c => c.id);
            modelBuilder.Entity<userprofile>()
                .HasKey(c => c.id);

            //one-to-one relationships
            modelBuilder.Entity<user>()
                .HasOne(c => c.userinfo)
                .WithOne(c => c.user)
                .HasForeignKey<userinfo>(c => c.id);
            modelBuilder.Entity<user>()
                .HasOne(c => c.userprofile)
                .WithOne(c => c.user)
                .HasForeignKey<userprofile>(c => c.id);

            //one-to-many relationships
            modelBuilder.Entity<post>()
                .HasOne(c => c.user)
                .WithMany(d=> d.posts)
                .HasForeignKey(m => m.userid);

        }

        public DbSet<user> users { get; set; }
        public DbSet<userinfo> userinfos { get; set; }
        public DbSet<userprofile> userprofiles { get; set; }
        public DbSet<post> posts { get; set; }
    }
}
