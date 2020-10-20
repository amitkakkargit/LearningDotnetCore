using Microsoft.EntityFrameworkCore;
using testservice.Models;
namespace testservice.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions dbOptions):base (dbOptions)
        {
        }
        DbSet<Employee> Employee{get;set;}
    }
}