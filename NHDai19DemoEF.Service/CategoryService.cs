using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHDai19DemoEF.Model;
using NHDai19DemoEF.Repository;
using NHDai19DemoEF.Service.Infrastructure;
using Store.Data.Infrastructure;

namespace NHDai19DemoEF.Service
{
    public interface ICategoryService : IService<Category>
    {

    }
    public class CategoryService : ServiceBase<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, ICategoryRepository repository) : base(unitOfWork, repository)
        {
        }
    }
}
