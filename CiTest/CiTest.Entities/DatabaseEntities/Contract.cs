using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using CiTest.Entities.XmlEntities;
using ContractData = CiTest.Entities.Common.ContractData;

namespace CiTest.Entities.DatabaseEntities
{
    public class Contract:ContractData
    {
        public Contract()
        {
        }


        //TODO:It could be better to use AutoMapper for this
        public Contract(XmlEntities.Contract xmlData)
        {
            var data = xmlData.ContractData;
            ContractCode = xmlData.ContractCode;
            phaseOfContractField = data.phaseOfContractField;
            originalAmountField = data.originalAmountField;
            installmentAmountField = data.installmentAmountField;
            currentBalanceField = data.currentBalanceField;
            overdueBalanceField = data.overdueBalanceField;
            dateAccountOpenedField = data.dateAccountOpenedField;
            dateOfLastPaymentField = data.dateOfLastPaymentField;
            realEndDateField = data.realEndDateField;
            nextPaymentDateField = data.nextPaymentDateField;
            Individuals = xmlData.Individual.
                Select(i => new Individual((Common.Individual) i)).ToList();
        }
         

        [Key]
        public string ContractCode { get; set; }

        public List<Individual> Individuals { get; set; }

        public ContractPhaseOfContract PhaseOfContractField
        {
            get => phaseOfContractField;
            set => phaseOfContractField = value;
        }

        public decimal OriginalAmount
        {
            get => originalAmountField.Value;
            set => originalAmountField.Value = value;
        }

        public string OriginalAmountCurrency
        {
            get => originalAmountField.Currency.ToString();
            set => originalAmountField.Currency = Enum.Parse<CommonCurrency>(value);
        }



        public CommonCurrency InstallmentAmountField
        {
            get => installmentAmountField.Currency;
            set => installmentAmountField.Currency = value;
        }

        public decimal CurrentBalance
        {
            get => currentBalanceField.Value;
            set => currentBalanceField.Value = value;
        }

        public CommonCurrency CurrentBalanceCurrency
        {
            get => currentBalanceField.Currency;
            set => currentBalanceField.Currency = value;
        }

        public decimal OverdueBalance
        {
            get => overdueBalanceField.Value;
            set => overdueBalanceField.Value = value;
        }

        public CommonCurrency OverdueBalanceCurrency
        {
            get => overdueBalanceField.Currency;
            set => overdueBalanceField.Currency = value;
        }

        public DateTime DateOfLastPaymentField
        {
            get => dateOfLastPaymentField;
            set => dateOfLastPaymentField = value;
        }

        public DateTime NextPaymentDateField
        {
            get => nextPaymentDateField;
            set => nextPaymentDateField = value;
        }

        public DateTime DateAccountOpenedField
        {
            get => dateAccountOpenedField;
            set => dateAccountOpenedField = value;
        }

        public DateTime RealEndDateField
        {
            get => realEndDateField;
            set => realEndDateField = value;
        }
    }
}
