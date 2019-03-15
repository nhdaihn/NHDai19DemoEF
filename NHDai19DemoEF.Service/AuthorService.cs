using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHDai19DemoEF.Model;
using NHDai19DemoEF.Service.Infrastructure;
using Store.Data.Infrastructure;

namespace NHDai19DemoEF.Service
{
    public interface IAuthorService : IService<Author>
    {

    }
    public class AuthorService : ServiceBase<Author>, IAuthorService
    {
        public AuthorService(IUnitOfWork unitOfWork, IRepository<Author> repository) : base(unitOfWork, repository)
        {
        }
    }
}
