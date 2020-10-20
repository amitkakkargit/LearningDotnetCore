using MediatR;
using System.Threading.Tasks;
using System.Threading;
using Mediat.Query;
using Mediat.Models;

namespace Mediat.Handlers
{
    public class PersonHandler : IRequestHandler<GetPersonSearch, Person>
    {
        public PersonHandler()
        {
            
        }
        public Task<Person> Handle(GetPersonSearch request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}