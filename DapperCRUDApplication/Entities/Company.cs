
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DapperCRUDApplication.Entities
{
    public class Company
    {


        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Category { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();





    }
}
