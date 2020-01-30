using CiTest.Entities.DatabaseEntities;
using Microsoft.EntityFrameworkCore;

namespace CiTest.Common.Interfaces
{
    public interface ICiTestContext
    {
        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Individual> Individuals { get; set; }

    }
}
