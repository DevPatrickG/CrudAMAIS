using Microsoft.EntityFrameworkCore;

namespace CRUDAppAMAIS.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set;}
    }
}
