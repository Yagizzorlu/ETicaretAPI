using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistance.Repositories;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICustomerReadRepository,  CustomerReadRepository>();   //AddDbContext ile eklediğiniz context hangi lifetime a sahipse aynı çalışma şeklinde repository servislerini eklemek daha sağlıklıdır.
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository,     OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository,    OrderWriteRepository>();
            services.AddScoped<IProductReadRepository,   ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,  ProductWriteRepository>();
        }
    }
}
