

using System.ComponentModel.DataAnnotations;

namespace DapperCRUDApplication.Entities
{
    public class Employee
    {

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position{ get; set; }

        public int CompanyId { get; set; }

    }
}
