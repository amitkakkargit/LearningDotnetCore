using System.ComponentModel.DataAnnotations;
namespace daysix.Models
{
    public class Membership
    {        
        [Key]
        public string username { get; set; }
        public string password { get; set; }
        public int age{get;set;}        
    }
}