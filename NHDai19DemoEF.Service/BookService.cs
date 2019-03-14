using NHDai19DemoEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Data.Infrastructure;
using System.Linq.Expressions;
using NHDai19DemoEF.Repository;

namespace NHDai19DemoEF.Service
{
    public interface IBookService : IService<Book>
    {
        IEnumerable<Book> GetAllBooks();
    }
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUnitOfWork unitOfWork;

        public BookService(IUnitOfWork unitOfWork, IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Book, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Book Get(Expression<Func<Book, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetMany(Expression<Func<Book, bool>> where)
        {
            throw new NotImplementedException();
        }

        #region ICategoryService Members

        public void SaveCategory()
        {
            unitOfWork.Commit();
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
