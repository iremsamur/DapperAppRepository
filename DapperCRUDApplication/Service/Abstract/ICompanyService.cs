using DapperCRUDApplication.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperCRUDApplication.Service.Abstract
{
    public interface ICompanyService
    {
        public Task<IEnumerable<Company>> GetCompanies();
    }
}
