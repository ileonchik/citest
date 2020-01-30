using CiTest.Common.Interfaces;
using CiTest.Entities.DatabaseEntities;
using CiTest.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CiTest.Database
{
    public class CiTestContext:DbContext,ICiTestContext
    {
        public CiTestContext()
        {
          var  configuration =  ConfigurationService.GetBuilder().Build();
           connectionString = configuration.GetConnectionString("Default");
        }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Individual> Individuals { get; set; }


        private readonly string connectionString;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
