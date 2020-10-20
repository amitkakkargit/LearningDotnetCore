using CustomMiddleware.CustomMiddleware;
using Microsoft.AspNetCore.Builder;

namespace CustomMiddleware.Extension
{
    public static class UserKeyValidatorsExtension
    {
        public static IApplicationBuilder ApplyUserKeyValidation(this IApplicationBuilder app)
        {
            app.UseMiddleware<UserKeyValidatorsMiddleware>();
            return app;
        }
    }
}