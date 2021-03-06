using Microsoft.EntityFrameworkCore;
using Facebook.Entities;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Data.EntityFramework
{
    //    public class ApplicationDbContext : DbContext
    //    {
    //        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    //        { }
    //        public ApplicationDbContext() : base("ApplicationDbContext")
    //        { }
    //        public virtual DbSet<AccountUserInfoEntities> User { get; set; }
    //        public virtual DbSet<PostEntities> Post { get; set; }
    //    }

    public class ApplicationDbContext : DbContext

    {

        private static string ConnectionString

        {

            get

            {
                return "Data Source = DESKTOP-NH3GHKD\\SQLEXPRESS; Initial Catalog = Facebook; Integrated Security = SSPI;";

            }

        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public ApplicationDbContext(DbContextOptions<DbContext> options)

            : base(options)

        { }

        public virtual DbSet<AccountUserInfoEntities> User { get; set; }
        public virtual DbSet<PostEntities> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PostEntities>().HasOne(e => e.User);
            base.OnModelCreating(builder);
        }

        public ApplicationDbContext()

        {

        }

        public void SetConnectionString()

        {

        }

    }

}