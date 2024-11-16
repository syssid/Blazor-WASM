using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        [MaxLength(10), MinLength(10)]
        public  string Phone { get; set; }
        [EmailAddress]
        public  string Email { get; set; }
        public  string Address { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
