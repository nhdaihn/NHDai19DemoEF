using NHDai19DemoEF.Model;
using Store.Data.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace NHDai19DemoEF.Repository
{
    public interface IAuthorRepository : IRepository<Author>
    {
		IEnumerable<Author> SearchAuthorByName(string keySearch);
    }
    public class AuthorRepository:RepositoryBase<Author>,IAuthorRepository
    {
        public AuthorRepository(IDbFactory dbFactory):base(dbFactory)
        {
            
        }

		public IEnumerable<Author> SearchAuthorByName(string keySearch)
		{
			var listAuthor = DbContext.Authors.Where(x => x.AuthorName.Contains(keySearch)).ToList();
			return listAuthor;
		}
	}
}
