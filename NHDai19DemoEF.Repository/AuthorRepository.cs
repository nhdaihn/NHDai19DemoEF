using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHDai19DemoEF.Model;
using Store.Data.Infrastructure;

namespace NHDai19DemoEF.Repository
{
    public interface IAuthorRepository : IRepository<Author>
    {

    }
    public class AuthorRepository:RepositoryBase<Author>,IAuthorRepository
    {
        public AuthorRepository(IDbFactory dbFactory):base(dbFactory)
        {
            
        }
    }
}
