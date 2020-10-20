using Microsoft.EntityFrameworkCore;
using UnitOfWork.Models;
namespace UnitOfWork.UOW
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}