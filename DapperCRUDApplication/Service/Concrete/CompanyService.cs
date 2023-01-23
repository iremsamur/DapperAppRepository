using Dapper;
using DapperCRUDApplication.Entities;
using DapperCRUDApplication.Service.Abstract;
using DapperCRUDApplication.Settings;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DapperCRUDApplication.Service.Concrete
{
    public class CompanyService : ICompanyService
    {
        private readonly DapperContext _dapperContext;

        public CompanyService(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var query = "Select * from Companies";
            using (var connection = _dapperContext.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(query);
                return companies.ToList();
            }
        }
    }
}
