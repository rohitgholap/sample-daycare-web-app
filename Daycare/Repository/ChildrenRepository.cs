using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Daycare.Repository.Entities;
using Dapper;

namespace Daycare.Repository
{
    public class ChildrenRepository : IChildrenRepository
    {
        private readonly IDapperContext Context;

        public ChildrenRepository(IDapperContext context)
        {
            Context = context;
        }

        public async Task<List<Children>> GetChildren()
        {
            var query = "select * from Children;";
            try
            {
                using(var connection = await Context.CreateConnection())
                {
                    var result = await connection.QueryAsync<Children>(query);
                    return result.AsList();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}

