namespace CiTest.Entities.XmlEntities
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
    public class Individual :Common.Individual
    {
        

        
        private IndividualIdentificationNumbers identificationNumbersField;
        
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
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public Gender Gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenderSpecified {
            get {
                return this.genderFieldSpecified;
            }
            set {
                this.genderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DateOfBirth {
            get {
                return this.dateOfBirthField;
            }
            set {
                this.dateOfBirthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateOfBirthSpecified {
            get {
                return this.dateOfBirthFieldSpecified;
            }
            set {
                this.dateOfBirthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IndividualIdentificationNumbers IdentificationNumbers {
            get {
                return this.identificationNumbersField;
            }
            set {
                this.identificationNumbersField = value;
            }
        }
    }
}