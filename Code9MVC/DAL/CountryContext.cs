using Code9MVC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Code9MVC.DAL
{
    public class CountryContext : DbContext
    {
        public CountryContext() : base("CountryContext")
        {

        }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}