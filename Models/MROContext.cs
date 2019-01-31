using Microsoft.EntityFrameworkCore;

namespace MRO_WebApiCore.Models
{
    public class MROContext : DbContext
    {
        public MROContext(DbContextOptions<MROContext> options) : base(options)
        {

        }

        public DbSet<Employee> employees { get; set; }
    }
}