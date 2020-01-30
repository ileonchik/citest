using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CiTest.Common.Interfaces;
using CiTest.Entities.XmlEntities;


namespace CiTest.Services
{
    public class DatabaseService
    {
        private ICiTestContext context;

        public DatabaseService(ICiTestContext context)
        {
            this.context = context;
        }

        public void Insert(IList<Contract> contracts)
        {
            context.Contracts.AddRange(contracts.Select(i=>new Entities.DatabaseEntities.Contract(i)));
        }
    }
}
