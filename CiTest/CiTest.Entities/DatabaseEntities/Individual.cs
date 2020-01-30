using System.ComponentModel.DataAnnotations;

namespace CiTest.Entities.DatabaseEntities
{
    public class Individual
    {
        [Key]
        public string CustomerCode { get; set; }

    }
}
