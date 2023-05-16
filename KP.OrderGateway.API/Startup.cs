using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KP.OrderGateway.DBModel.NewKpiEntity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using IdentityModel;
using Newtonsoft.Json.Serialization;
using KP.OrderGateway.DBModel.KPVirtualStockEntity;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;

namespace KP.OrderGateway.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddDbContext<KPIMNPOSMAContext>(options => options.UseSqlServer(Configuration.GetConnectionString("NewKpiDB")));
            services.AddDbContext<DBModel.CustomerDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CustomerDataDb")));
            services.AddDbContext<KPVirtualStockContext>(options => options.UseSqlServer(Configuration.GetConnectionString("VirtualStockDb")));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IConfiguration>(Configuration);
            services
               .AddAuthentication("Bearer")
               .AddIdentityServerAuthentication(options =>
               {
                   options.Authority = Configuration.GetConnectionString("UrlAuthorize");// "https://kpservices.kingpower.com/portal/developer/identityserverapi"; //"https://localhost:6001";
                   options.RequireHttpsMetadata = false;
                   options.ApiName = "kingpower.api";
                   options.CacheDuration = TimeSpan.FromMinutes(60); // that's the default 10 
               });

            services
                 .AddMvcCore()
                 .AddAuthorization();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "KP.OrderGateway.API", Version = "v1" });

                var basePath = AppContext.BaseDirectory;
                var xmlPath = "";

                xmlPath = Path.Combine(basePath, "KP.OrderGateway.API.xml");
                c.IncludeXmlComments(xmlPath);
                xmlPath = Path.Combine(basePath, "KP.OrderGateway.ServiceModel.xml");
                c.IncludeXmlComments(xmlPath);
            });

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                      builder =>
                      {
                          builder.AllowAnyOrigin()
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
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

            app.UseCors("AllowAllHeaders");
            app.UseHttpsRedirection();
            app.UseAuthentication();
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "KP.OrderGateway.API V1.0 (Asp.net core 2.2)");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();


            var provider = new FileExtensionContentTypeProvider();
            provider.Mappings[".apk"] = "application/vnd.android.package-archive";

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "update")),
                RequestPath = "/update",
                ContentTypeProvider = provider
            });
        }
    }
}
