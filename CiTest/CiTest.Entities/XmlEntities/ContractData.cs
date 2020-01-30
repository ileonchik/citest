namespace CiTest.Entities.XmlEntities
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
    public  class ContractData :Common.ContractData
    {
        

        
        private bool realEndDateFieldSpecified;        
        private bool dateAccountOpenedFieldSpecified;  
        private bool nextPaymentDateFieldSpecified;
        private bool dateOfLastPaymentFieldSpecified;
        
        /// <remarks/>
        public ContractPhaseOfContract PhaseOfContract {
            get {
                return this.phaseOfContractField;
            }
            set {
                this.phaseOfContractField = value;
            }
        }
        
        /// <remarks/>
        public ContractDataOriginalAmount OriginalAmount {
            get {
                return this.originalAmountField;
            }
            set {
                this.originalAmountField = value;
            }
        }
        
        /// <remarks/>
        public ContractDataInstallmentAmount InstallmentAmount {
            get {
                return this.installmentAmountField;
            }
            set {
                this.installmentAmountField = value;
            }
        }
        
        /// <remarks/>
        public CurrentBalance CurrentBalance {
            get {
                return this.currentBalanceField;
            }
            set {
                this.currentBalanceField = value;
            }
        }
        
        /// <remarks/>
        public ContractDataOverdueBalance OverdueBalance {
            get {
                return this.overdueBalanceField;
            }
            set {
                this.overdueBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DateOfLastPayment {
            get {
                return this.dateOfLastPaymentField;
            }
            set {
                this.dateOfLastPaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateOfLastPaymentSpecified {
            get {
                return this.dateOfLastPaymentFieldSpecified;
            }
            set {
                this.dateOfLastPaymentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime NextPaymentDate {
            get {
                return this.nextPaymentDateField;
            }
            set {
                this.nextPaymentDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NextPaymentDateSpecified {
            get {
                return this.nextPaymentDateFieldSpecified;
            }
            set {
                this.nextPaymentDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DateAccountOpened {
            get {
                return this.dateAccountOpenedField;
            }
            set {
                this.dateAccountOpenedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateAccountOpenedSpecified {
            get {
                return this.dateAccountOpenedFieldSpecified;
            }
            set {
                this.dateAccountOpenedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime RealEndDate {
            get {
                return this.realEndDateField;
            }
            set {
                this.realEndDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RealEndDateSpecified {
            get {
                return this.realEndDateFieldSpecified;
            }
            set {
                this.realEndDateFieldSpecified = value;
            }
        }
    }
}