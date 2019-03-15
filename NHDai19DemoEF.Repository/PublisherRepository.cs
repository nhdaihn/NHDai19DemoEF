using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHDai19DemoEF.Model;
using Store.Data.Infrastructure;

namespace NHDai19DemoEF.Repository
{
    public interface IPublisherRepository : IRepository<Publisher>
    {

    }
    class PublisherRepository : RepositoryBase<Publisher>, IPublisherRepository
    {
        public PublisherRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
