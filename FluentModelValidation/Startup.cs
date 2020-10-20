using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentModelValidation.Models;
using FluentModelValidation.Models.Filter;
using System.Reflection;

namespace FluentModelValidation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            // //services.AddSingleton<IValidator<Employee>, EmployeeValidator>();
            // //services.AddMvc().AddFluentValidation();
            // services.AddTransient<IValidator<Employee>, EmployeeValidator>();
            // services.AddControllers().AddFluentValidation();                
            // //  services.AddControllers().AddFluentValidation(fv =>
            // // {
            // //     fv.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // // });
             services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
