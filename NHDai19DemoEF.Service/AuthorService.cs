using NHDai19DemoEF.Model;
using NHDai19DemoEF.Repository;
using NHDai19DemoEF.Service.Infrastructure;
using Store.Data.Infrastructure;
using System.Collections.Generic;

namespace NHDai19DemoEF.Service
{
	public interface IAuthorService : IService<Author>
	{
		IEnumerable<Author> SearchAuthorByName(string keySearch);
	}
	public class AuthorService : ServiceBase<Author>, IAuthorService
	{
		private readonly IAuthorRepository _authorRepository;
		public AuthorService(IUnitOfWork unitOfWork, IAuthorRepository repository, IAuthorRepository authorRepository) : base(unitOfWork, repository)
		{
			_authorRepository = authorRepository;
		}

		public IEnumerable<Author> SearchAuthorByName(string keySearch)
		{
			return _authorRepository.SearchAuthorByName(keySearch);
		}
	}
}
