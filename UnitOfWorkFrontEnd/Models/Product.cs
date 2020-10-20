using System.ComponentModel.DataAnnotations;

namespace UnitOfWork.Models
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public User User { get; set; }

    }
}