using Contacts.DataAccessLayer;
using Contacts.Services.Contacts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Contacts.DataAccessLayer.Entities;

namespace Contacts.WebAPI
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
            // Connect to database
            services.AddDbContext<ContactDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("MyConnection"));
            });

            // Create policy with options
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.
                    WithOrigins("https://localhost:4200")
                    //AllowAnyOrigin()
                    .WithMethods("GET")
                    .AllowAnyHeader()
                    //.WithExposedHeaders("Access-Control-Allow-Origin", "*")
                    .AllowCredentials());
            });

            services.AddControllers();

            // DI
            services.AddScoped<DbContext, ContactDbContext>();
            services.AddTransient<IContactService, ContactService>();

            services.AddRouting();
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

            // Global policy
            app.UseCors("AllowOrigin");

            app.UseAuthorization();

            // Return Access-Control-Allow-Origin (global CORS)
            app.UseMiddleware<MyMiddleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
