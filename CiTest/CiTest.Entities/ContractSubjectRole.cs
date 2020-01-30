namespace CiTest.Entities
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
    public partial class ContractSubjectRole {
        
        private string customerCodeField;
        
        private CommonRoleOfCustomer roleOfCustomerField;
        
        private SubjectRoleGuaranteeAmount guaranteeAmountField;
        
        /// <remarks/>
        public string CustomerCode {
            get {
                return this.customerCodeField;
            }
            set {
                this.customerCodeField = value;
            }
        }
        
        /// <remarks/>
        public CommonRoleOfCustomer RoleOfCustomer {
            get {
                return this.roleOfCustomerField;
            }
            set {
                this.roleOfCustomerField = value;
            }
        }
        
        /// <remarks/>
        public SubjectRoleGuaranteeAmount GuaranteeAmount {
            get {
                return this.guaranteeAmountField;
            }
            set {
                this.guaranteeAmountField = value;
            }
        }
    }
}