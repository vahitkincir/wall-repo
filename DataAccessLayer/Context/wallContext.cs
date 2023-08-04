using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class wallContext :DbContext
    {
        public wallContext(DbContextOptions<wallContext> options):base(options)
        {

        }

        public DbSet<user> users { get; set; }

        public DbSet<userprofile> userprofiles { get; set; }

        public DbSet<userinfo> userinfos { get; set; }

        public DbSet<post> posts { get; set; }

    }
}
