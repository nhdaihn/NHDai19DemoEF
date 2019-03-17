using Store.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NHDai19DemoEF.Service.Infrastructure
{
    public abstract class ServiceBase<T> : IService<T> where T : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IRepository<T> _repository;

        public ServiceBase(IUnitOfWork unitOfWork, IRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            _repository.Delete(where);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return _repository.Get(where);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return _repository.GetMany(where);
        }
      
        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
