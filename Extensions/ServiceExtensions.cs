using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Repositories.Utils;
using spa.Repository.Interface;
using spaenlinea.Services.Interface;
using spaenlinea.Repository.Interface;
using spaenlinea.Services;
using spaenlinea.Repository;
using AutoMapper;
using spaenlinea.Logger.Interface;
using spaenlinea.Logger;
using spa.Repository.Data;
using spaenlinea.Profiles;

namespace GenericProjectBase.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }
        //Automapper
        public static void AutoMapperConfiguration(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Profiles());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        //Logger
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        //Database configuration
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["SqlConnection:ConnectionString"];
            services.AddDbContext<RepositoryContext>(o => o.UseSqlServer(connectionString));
        }

        //Inyect all the interfaces with classes
        public static void ConfigureClasesWithInterfaces(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddScoped<IAlumnoService, AlumnoService>();
            services.AddScoped<IRepositoryAlumno, AlumnoRepository>();
            services.AddScoped<IAlumnoService, AlumnoService>();
            services.AddScoped<IRepositoryAlumno, AlumnoRepository>();
        }
    }

}
