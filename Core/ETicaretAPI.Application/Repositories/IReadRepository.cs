using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> method); //özel tanımlı fonksiyona verilen şart ifadesi doğru olan datalar sorgulanıp getirilecek.
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);  //FirstOrDefault ın asenkron fonksiyonunu kullanacak.
        Task<T> GetByIdAsync(string id);

    }
}
