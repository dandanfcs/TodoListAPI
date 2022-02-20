using LojaDeMateriais.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoListAPI.Repository;
using TodoListAPI.Repository.Interface;
using TodoListAPI.Services;

namespace TodoListAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Meu Swagger", Version = "v1" });
            });
            services.AddControllers();

            services.AddCors();

            services.AddDbContext<ApplicationContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("ApplicationContext"),
                 builder => builder.MigrationsAssembly("todolist")));
            

            services.AddTransient<ITarefaRepository, TarefaRepository>();
            services.AddTransient<ITarefaService, TarefaService>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            string urlOrigin = "http://localhost:3000/";

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Meu Swagger v1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(opt => {
                opt.WithOrigins(urlOrigin);
                opt.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
               
                });

            app.UseAuthorization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
