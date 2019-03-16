using NHDai19DemoEF.Model;
using NHDai19DemoEF.Repository;
using NHDai19DemoEF.Service.Infrastructure;
using Store.Data.Infrastructure;

namespace NHDai19DemoEF.Service
{
    public interface IAuthorService : IService<Author>
    {

    }
    public class AuthorService : ServiceBase<Author>, IAuthorService
    {
        public AuthorService(IUnitOfWork unitOfWork, IAuthorRepository repository) : base(unitOfWork,repository)
        {
        }
    }
}
