using System;
using System.Collections.Generic;
using System.Text;
using CiTest.Entities.XmlEntities;

namespace CiTest.Entities.Common
{
    public class Individual
    {
        internal string customerCodeField;

        internal string firstNameField;

        internal string lastNameField;

        internal Gender genderField;

        internal bool genderFieldSpecified;

        internal System.DateTime dateOfBirthField;

        internal bool dateOfBirthFieldSpecified;


        internal IndividualIdentificationNumbers identificationNumbersField;

    }
}
