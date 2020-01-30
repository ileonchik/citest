namespace CiTest.Entities.XmlEntities
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/Sample/Data")]
    public partial class IndividualIdentificationNumbers {
        
        private string nationalIDField;
        
        /// <remarks/>
        public string NationalID {
            get {
                return this.nationalIDField;
            }
            set {
                this.nationalIDField = value;
            }
        }
    }
}