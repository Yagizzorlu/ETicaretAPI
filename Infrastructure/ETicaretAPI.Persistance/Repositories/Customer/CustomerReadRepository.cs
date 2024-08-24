using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository  //Bu sınıfın içinde Customer'a özel ReadRepository'nin içinde tüm methodlar uygulanır. Interface ise CustomerReadRepository concrete nesnesinin abstractionu dır. DependencyInjection da talep ederken bu interface gerekli. İlkini koymamızı sağlayan interface idir. Interface i doğrulatan da ilkidir.
    {
        public CustomerReadRepository(ETicaretAPIDbContext context) : base(context) //ReadRepository bizden context parametresi istiyor. Bu sınıfın constructor ında bunu vermek gerekiyor.
        {
        }
    }
}
