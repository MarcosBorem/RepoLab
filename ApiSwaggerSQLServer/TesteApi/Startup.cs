using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteApi.Data;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;




namespace TesteApi
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "APIUsuarios", Version = "v1", });
            });
            
            services.AddDbContext<TesteApiContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("TesteApiContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                //redireciona direto para o swagger
                c.RoutePrefix = string.Empty;
                //endpoint
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "APIUsuarios");
            });
                                         

            app.UseHttpsRedirection();

            app.UseAuthentication();
            

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
