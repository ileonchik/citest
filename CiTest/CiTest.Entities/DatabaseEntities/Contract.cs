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
        }

        public Contract(XmlEntities.Contract xmlData, List<Individual> individuals) : this(xmlData)
        {
            Individuals = individuals;
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
            set
            {
                if (originalAmountField == null)
                {
                    originalAmountField = new ContractDataOriginalAmount();
                }
                originalAmountField.Value = value;
            }

        }

        public CommonCurrency OriginalAmountCurrency
        {
            get => originalAmountField.Currency;
            set
            {
                if (originalAmountField == null)
                {
                    originalAmountField = new ContractDataOriginalAmount();
                }
                originalAmountField.Currency = value;
            }
        }



        public decimal InstallmentAmount
        {
            get => installmentAmountField.Value;
            set
            {
                if (installmentAmountField == null)
                {
                    installmentAmountField = new ContractDataInstallmentAmount();
                }
                installmentAmountField.Value = value;
            }

        }

        public CommonCurrency InstallmentAmountCurrency
        {
            get => installmentAmountField.Currency;
            set
            {
                if (installmentAmountField == null)
                {
                    installmentAmountField = new ContractDataInstallmentAmount();
                }
                installmentAmountField.Currency = value;
            }

        }

        public decimal CurrentBalance
        {
            get => currentBalanceField.Value;
            set
            {
                if (currentBalanceField == null)
                {
                    currentBalanceField = new CurrentBalance();
                }
                currentBalanceField.Value = value;
            }
        }

        public CommonCurrency CurrentBalanceCurrency
        {
            get => currentBalanceField.Currency;
            set
            {
                if (currentBalanceField == null)
                {
                    currentBalanceField = new CurrentBalance();
                }
                currentBalanceField.Currency = value;
            }
        }

        public decimal OverdueBalance
        {
            get => overdueBalanceField.Value;
            set
            {
                if (overdueBalanceField == null)
                {
                    overdueBalanceField = new ContractDataOverdueBalance();
                }
                overdueBalanceField.Value = value;
            } 
        }

        public CommonCurrency OverdueBalanceCurrency
        {
            get => overdueBalanceField.Currency;
            set
            {
                if (overdueBalanceField == null)
                {
                    overdueBalanceField = new ContractDataOverdueBalance();
                }
                overdueBalanceField.Currency = value;
            }
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
