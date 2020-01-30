using System;
using System.Collections.Generic;
using System.Text;
using CiTest.Entities.XmlEntities;

namespace CiTest.Entities.Common
{
    public class ContractData
    {
        internal ContractPhaseOfContract phaseOfContractField;

        internal ContractDataOriginalAmount originalAmountField;

        internal ContractDataInstallmentAmount installmentAmountField;

        internal CurrentBalance currentBalanceField;

        internal ContractDataOverdueBalance overdueBalanceField;

        internal System.DateTime dateOfLastPaymentField;



        internal System.DateTime nextPaymentDateField;



        internal System.DateTime dateAccountOpenedField;


        internal System.DateTime realEndDateField;
    }
}
