using System.Threading.Tasks;
using CustomMiddleware.Repository;
using Microsoft.AspNetCore.Http;

namespace CustomMiddleware.CustomMiddleware
{
    public class UserKeyValidatorsMiddleware
    {
        private readonly RequestDelegate _next;
        private IContactsRepository ContactsRepo { get; set; }
        public UserKeyValidatorsMiddleware(RequestDelegate next, IContactsRepository _repo)
        {
            _next = next;
            ContactsRepo = _repo;
        }
        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Headers.Keys.Contains("user-key"))
            {
                context.Response.StatusCode = 400; //Bad Request                
                await context.Response.WriteAsync("User Key is missing");
                return;
            }
            else
            {
                if (!ContactsRepo.CheckValidUserKey(context.Request.Headers["user-key"]))
                {
                    context.Response.StatusCode = 401; //UnAuthorized
                    await context.Response.WriteAsync("Invalid User Key");
                    return;
                }
            }
            await _next.Invoke(context);
        }
    }
}