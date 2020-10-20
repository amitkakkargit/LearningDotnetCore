using System.ComponentModel.DataAnnotations;
namespace testservice.Models
{
    public class Employee
    {
        [Key]
        public  int ID{get;set;}
        public string Ename{get;set;}
        public int Age{get;set;}
    }
}