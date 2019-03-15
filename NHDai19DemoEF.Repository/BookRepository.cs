using NHDai19DemoEF.Model;
using Store.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHDai19DemoEF.Repository
{
    public interface IBookRepository : IRepository<Book>
    {

    }
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
