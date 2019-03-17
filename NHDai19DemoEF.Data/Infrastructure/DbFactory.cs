using NHDai19DemoEF.Data;

namespace Store.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        DemoDBContext dbContext;

        public DemoDBContext Init()
        {
            return dbContext ?? (dbContext = new DemoDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
