using Microsoft.EntityFrameworkCore;

namespace EjemploApiEmpleado.Models
{
    public class EmpleadoContext: DbContext
    {
        public EmpleadoContext (DbContextOptions<EmpleadoContext> options) : base (options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; } = null!;
    }
}
