namespace CiTest.Entities
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
    public class CurrentBalance {
        
        private decimal valueField;
        
        private CommonCurrency currencyField;
        
        /// <remarks/>
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public CommonCurrency Currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
    }
}