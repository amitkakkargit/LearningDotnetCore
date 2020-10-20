using Mediat.Models;
using MediatR;
namespace Mediat.Query
{
    //Query Model using CQS Pattern
    public class GetPersonSearch : IRequest<Person> //Response
    {
        public GetPersonSearch(int id)
        {
            Id = id; //Mapper
        }
        public int Id { get; set; }
    }
}