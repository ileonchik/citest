namespace CiTest.Entities.XmlEntities
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
    public class Contract {
        
        private string contractCodeField;
        
        private ContractData contractDataField;
        
        private Individual[] individualField;
        
        private ContractSubjectRole[] subjectRoleField;
        
        /// <remarks/>
        public string ContractCode {
            get {
                return this.contractCodeField;
            }
            set {
                this.contractCodeField = value;
            }
        }
        
        /// <remarks/>
        public ContractData ContractData {
            get {
                return this.contractDataField;
            }
            set {
                this.contractDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Individual")]
        public Individual[] Individual {
            get {
                return this.individualField;
            }
            set {
                this.individualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubjectRole")]
        public ContractSubjectRole[] SubjectRole {
            get {
                return this.subjectRoleField;
            }
            set {
                this.subjectRoleField = value;
            }
        }
    }
}