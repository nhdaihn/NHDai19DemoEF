using NHDai19DemoEF.Model;
using Store.Data.Infrastructure;

namespace NHDai19DemoEF.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {

    }
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
