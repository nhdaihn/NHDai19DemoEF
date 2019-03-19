using NHDai19DemoEF.Model;
using Store.Data.Infrastructure;

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
