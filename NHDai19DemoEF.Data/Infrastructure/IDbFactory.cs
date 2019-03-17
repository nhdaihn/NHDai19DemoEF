using NHDai19DemoEF.Data;
using System;

namespace Store.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        DemoDBContext Init();
    }
}
