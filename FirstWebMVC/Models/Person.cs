using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Persons")]
    public class Person 
    {
        [Key]
        public string fname { get; set; }
        public string ID { get; set; }
        public string Address { get; set; }
    }
}