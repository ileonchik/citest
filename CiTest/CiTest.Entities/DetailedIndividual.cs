using System;
using System.Collections.Generic;
using System.Text;
using CiTest.Entities.DatabaseEntities;

namespace CiTest.Entities
{
    public class DetailedIndividual:Individual
    {
        public IList<Contract> Contracts { get; set; }

        public DetailedIndividual(Individual data,IList<Contract> contracts)
        {
            CustomerCodeField = data.customerCodeField;
            FirstNameField = data.firstNameField;
            LastNameField = data.lastNameField;
            GenderField = data.genderField;
            DateOfBirthField = data.dateOfBirthField;
            NationalID = data.NationalID;
            Contracts = contracts;
        }
    }
}
