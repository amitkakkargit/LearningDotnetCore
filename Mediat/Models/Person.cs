using System.ComponentModel.DataAnnotations;

namespace Mediat.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}