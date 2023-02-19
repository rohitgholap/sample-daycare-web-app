using System;
using System.Data;
using System.Threading.Tasks;

namespace Daycare.Repository
{
    public interface IDapperContext
    {
        Task<IDbConnection> CreateConnection();
    }
}

