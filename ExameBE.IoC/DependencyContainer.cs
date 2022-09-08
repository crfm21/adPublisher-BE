using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ExameBE.Infrastructure.Context;
using ExameBE.Domain.Contract;
using ExameBE.Services;
using ExameBE.Infrastructure.Repository;

namespace ExameBE.IoC
{
    public class DependencyContainer
    {
        public static void ServicesInjection(IServiceCollection services, IConfiguration Configuration)
        {
            RegisterDbContext(services, Configuration);
            RegisterRepositories(services);
            RegisterServices(services);
        }

        public static void RegisterDbContext(IServiceCollection services, IConfiguration Configuration)
        {
            var conn = Configuration.GetConnectionString("myconn");
            services.AddDbContext<MainContext>(item => item.UseSqlServer(conn));

        }

        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped(typeof(IAnuncioRepository), typeof(AnuncioRepository));
        }

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IAnuncioServices, AnuncioServices>();
        }


    }
}
