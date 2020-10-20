using Microsoft.EntityFrameworkCore;
namespace daysix.Models
{
    public class MembershipContext : DbContext
    {
        public MembershipContext(DbContextOptions options) : base(options) { }
        public DbSet<Membership> users { get; set; }
        // public  DbSet<TblCities> Cities { get; set; }
        // public  DbSet<TblEmployee> Employee { get; set; }     
    }
}