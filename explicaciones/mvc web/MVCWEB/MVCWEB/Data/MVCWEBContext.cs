using Microsoft.EntityFrameworkCore;
using MVCWEB.Models;

namespace MVCWEB.Data
{
    public class MVCWEBContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public MVCWEBContext(DbContextOptions<MVCWEBContext> options) : base(options)
        {

        }
    }
}
