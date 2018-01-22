using System.Collections.Generic;
using System.Data.Entity;

namespace docAPI.Data.Contracts
{
    public interface IDataContext
    {
        List<DbSet> Sets { get; }
    }
}
