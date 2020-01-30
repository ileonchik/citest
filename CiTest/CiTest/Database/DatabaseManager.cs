using System;
using System.Collections.Generic;
using System.Linq;
using CiTest.Common.Interfaces;
using CiTest.Entities.XmlEntities;

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
            Context.Contracts.AddRange(contracts.Select(i=>new Entities.DatabaseEntities.Contract(i)));
            Context.SaveChanges();
        }
    }
}
