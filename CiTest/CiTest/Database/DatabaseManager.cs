using System;
using System.Collections.Generic;
using System.Linq;
using CiTest.Common.Interfaces;
using CiTest.Entities.DatabaseEntities;
using Contract = CiTest.Entities.XmlEntities.Contract;

namespace CiTest.Database
{
    public class DatabaseManager
    {

        public CiTestContext Context
        {
            get;
        }

        private static readonly object instanceLoker = new Object();
        private DatabaseManager(CiTestContext context)
        {
            Context = context;
        }

        private static DatabaseManager instance;
        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLoker)
                    {
                        if (instance == null)
                            instance = new DatabaseManager(new CiTestContext());
                    }
                }

                return instance;
            }
        }

        public void Insert(IList<Contract> contracts)
        {

            foreach (Contract contract in contracts)
            {
                //It's not clear what to do if contract is a duplicate
                if (!Context.Contracts.Any(i => i.ContractCode == contract.ContractCode))
                {
                    var individuals = new List<Entities.DatabaseEntities.Individual>();
                    foreach (var individual in contract.Individual)
                    {
                        var item = Context.Individuals.FirstOrDefault(i =>
                            i.CustomerCodeField == individual.CustomerCode);
                        if (item == null)
                        {
                            item = new Individual(individual);
                            Context.Individuals.Add(item);
                        }

                        individuals.Add(item);
                        Context.Contracts.Add(new Entities.DatabaseEntities.Contract(contract, individuals));
                    }
                }
            }

            Context.SaveChanges();
        }
    }
}
