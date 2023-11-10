using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models{
    [Table("Employee")]
    public class Employee
    {
        [Key]
         public string fname { get; set; }
        public string ID { get; set; }
        public string email { get; set; }
        public int  Age  { get; set; }
    }
}