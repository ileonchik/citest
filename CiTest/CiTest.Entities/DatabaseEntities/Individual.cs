using System;
using System.ComponentModel.DataAnnotations;
using CiTest.Entities.XmlEntities;

namespace CiTest.Entities.DatabaseEntities
{
    public class Individual:Common.Individual
    {
        public Individual()
        {
        }

        public Individual(Common.Individual data)
        {
            CustomerCodeField = data.customerCodeField;
            FirstNameField = data.firstNameField;
            LastNameField = data.lastNameField;
            GenderField = data.genderField;
            DateOfBirthField = data.dateOfBirthField;
            NationalID= data.identificationNumbersField.NationalID;
        }

        [Key]
        public string CustomerCodeField { get; set; }

        public string NationalID { get; set; }

        public string FirstNameField
        {
            get => firstNameField;
            set => firstNameField = value;
        }

        public string LastNameField
        {
            get => lastNameField;
            set => lastNameField = value;
        }

        public Gender GenderField
        {
            get => genderField;
            set => genderField = value;
        }

        public DateTime DateOfBirthField
        {
            get => dateOfBirthField;
            set => dateOfBirthField = value;
        }
    }
}
