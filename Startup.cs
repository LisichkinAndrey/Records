using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace records
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("customers", new OpenApiInfo { Title = "customers", Version = "v1" });
                c.SwaggerDoc("payments", new OpenApiInfo { Title = "payments", Version = "v1" });
                c.SwaggerDoc("discountcards", new OpenApiInfo { Title = "discountcards", Version = "v1" });

                c.SwaggerDoc("employees", new OpenApiInfo { Title = "employees", Version = "v1" });
                c.SwaggerDoc("sessions", new OpenApiInfo { Title = "sessions", Version = "v1" });
                c.SwaggerDoc("recordtypes", new OpenApiInfo { Title = "recordtypes", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/customers/swagger.json", "customers");
                    c.SwaggerEndpoint("/swagger/payments/swagger.json", "payments");
                    c.SwaggerEndpoint("/swagger/discountcards/swagger.json", "discountcards");

                    c.SwaggerEndpoint("/swagger/employees/swagger.json", "employees");
                    c.SwaggerEndpoint("/swagger/sessions/swagger.json", "sessions");
                    c.SwaggerEndpoint("/swagger/recordtypes/swagger.json", "recordtypes");
                });
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
