using System.ComponentModel.DataAnnotations.Schema;

namespace Code9MVC.Models
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        public string PostalCode { get; set; }
        
        public virtual Country Country { get; set; }
    }
}