using CiTest.Entities.DatabaseEntities;
using CiTest.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CiTest.Database
{
    public class CiTestContext:DbContext
    {
        private IConfiguration configuration;
        public CiTestContext()
        {
           configuration =  ConfigurationService.GetBuilder().Build();
           connectionString = configuration.GetConnectionString("Default");
        }

        public DbSet<Contract> Contracts { get; set; }

        private readonly string connectionString;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
