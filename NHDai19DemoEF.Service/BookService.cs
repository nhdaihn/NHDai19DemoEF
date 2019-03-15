using NHDai19DemoEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Data.Infrastructure;
using System.Linq.Expressions;
using NHDai19DemoEF.Repository;
using NHDai19DemoEF.Service.Infrastructure;

namespace NHDai19DemoEF.Service
{
    public interface IBookService : IService<Book>
    {
    }
    public class BookService : ServiceBase<Book>, IBookService
    {
        public BookService(IUnitOfWork unitOfWork,IBookRepository repository) : base(unitOfWork,repository)
        {
        }
    }
}
