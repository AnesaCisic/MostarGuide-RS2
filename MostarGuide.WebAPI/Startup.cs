using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MostarGuide.Model.Requests;
using MostarGuide.WebAPI.Database;
using MostarGuide.WebAPI.Filters;
using MostarGuide.WebAPI.Security;
using MostarGuide.WebAPI.Services;

namespace MostarGuide.WebAPI
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
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MostarGuide API", Version = "v1" });

                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
            });

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ICRUDService<Model.Izleti, IzletiSearchRequest, IzletiUpsertRequest, IzletiUpsertRequest>, IzletService>();
            services.AddScoped<ICRUDService<Model.Kategorije, object, KategorijeUpsertRequest, KategorijeUpsertRequest>, KategorijaService>();
            services.AddScoped<ICRUDService<Model.Termini, TerminiSearchRequest, TerminiUpsertRequest, TerminiUpsertRequest>, TerminService>();
            services.AddScoped<ICRUDService<Model.Sekcije, SekcijeSearchRequest, SekcijeUpsertRequest, SekcijeUpsertRequest>, SekcijaService>();
            services.AddScoped<ICRUDService<Model.Rezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest>, RezervacijaService>();
            services.AddScoped<ICRUDService<Model.KorisniciMob, KorisniciMobSearchRequest, KorisniciMobUpsertRequest, KorisniciMobUpsertRequest>, KorisnikMobService>();
            services.AddScoped<ICRUDService<Model.OcjeneIzleti, OcjeneIzletiSearchRequest, OcjeneIzletiUpsertRequest, OcjeneIzletiUpsertRequest>, OcjenaIzletService>();
            services.AddScoped<ICRUDService<Model.OcjeneSekcije, OcjeneSekcijeSearchRequest, OcjeneSekcijeUpsertRequest, OcjeneSekcijeUpsertRequest>, OcjenaSekcijaService>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Uloge>>();
            services.AddScoped<ICRUDService<Model.Favoriti, FavoritiSearchRequest, FavoritiUpsertRequest, FavoritiUpsertRequest>, FavoritiService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IPreporukaService, PreporukaService>();

            var connection = @"Server=.;Database=IB160037;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<MostarGuideContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
