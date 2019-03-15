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
    public interface IPublisherService : IService<Publisher>
    {

    }
    public class PublisherService : ServiceBase<Publisher>, IPublisherService
    {
        public PublisherService(IUnitOfWork unitOfWork, IRepository<Publisher> repository) : base(unitOfWork, repository)
        {
        }
    }
}
