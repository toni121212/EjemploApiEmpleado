namespace EjemploApiEmpleado.Models
{
    public class Empleado
    {

        public int id { get; set; }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public int NEmpleado { get; set; }

        public DateTime FechaIngreso { get; set; }
        
        public bool Honorarios { get; set; }

    }
}
