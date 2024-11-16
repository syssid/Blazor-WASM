using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> emps { get; set; }
    }
}
