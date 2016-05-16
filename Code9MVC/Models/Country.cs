using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code9MVC.Models
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string Currency { get; set; }

        public double Area { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public string FlagImageFilePath { get; set; }
    }
}