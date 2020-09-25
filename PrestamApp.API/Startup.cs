using System.Reflection;
using AutoMapper;
using FluentValidation.AspNetCore;
using MediatR;
using MediatR.Pipeline;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using PrestamApp.API.Filters;
using PrestamApp.Application.Contacts.Commands.CreateContact;
using PrestamApp.Application.Contacts.Queries.GetContactList;
using PrestamApp.Application.Infrastructure;
using PrestamApp.Application.Infrastructure.AutoMapper;
using PrestamApp.Application.Interfaces;
using PrestamApp.Infrastructure;
using PrestamApp.Persistence;
using Swashbuckle.AspNetCore.Swagger;

namespace PrestamApp.API
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
      // Add AutoMapper
      services.AddAutoMapper(typeof(AutoMapperProfile).GetTypeInfo().Assembly);

      // Add framework services.
      services.AddTransient<INotificationService, NotificationService>();

      // Add MediatR
      services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
      services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
      services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
      services.AddMediatR(typeof(GetContactListQueryHandler).GetTypeInfo().Assembly);

      services.AddDbContextPool<PrestamAppDbContext>(options =>
     options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                          x => x.UseNetTopologySuite()));

      services.AddMvcCore(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
                   .AddApiExplorer()
                   .AddAuthorization()
                   .AddJsonFormatters(options => options.ContractResolver = new CamelCasePropertyNamesContractResolver())
                   .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateContactCommandValidator>())
                   .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

      
      // Register the Swagger generator, defining 1 or more Swagger documents
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new Info { Title = "PRESTAM_APP API", Version = "v1" });
      });

            services.AddCors(options =>
            {
                options.AddPolicy("default", policy =>
                {
                    policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
                });
            });

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

        // Enable middleware to serve generated Swagger as a JSON endpoint.
      app.UseSwagger();

      // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
      // specifying the Swagger JSON endpoint.
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "MRV PRESTAM_APP V1");
        c.RoutePrefix = string.Empty;
      });

            //app.UseHttpsRedirection();
            app.UseCors("default");
      app.UseMvc();
    }
  }
}
