using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Threading.Tasks;

namespace Daycare.Repository
{
    public class DapperContext : IDapperContext
    {
        private readonly IConfiguration Configuration;
        private readonly string ConnectionString;

        public DapperContext(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = configuration.GetConnectionString("SqlConnection");
        }

        public async Task<IDbConnection> CreateConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            return await Task.FromResult(connection);
        }
    }
}

