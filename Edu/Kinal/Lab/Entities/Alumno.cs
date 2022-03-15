using Lab2.Edu.Kinal.Lab.Interfaz;

namespace Lab2.Edu.Kinal.Lab.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }

        public int NumeroCreditos { get; set; }

        public string Asignatura { get; set; }
        public Alumno() : base()
        {
        }

        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos, string asignatura)
            : base(uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
            this.Asignatura = asignatura;
        }


        public override void TomarAsistencia()
        {
            Console.WriteLine($"Asistencia con carné {this.Carne}");
        }

        override public string ToString()
        {
            return $"el alumno {this.Nombres} {this.Apellidos} con carné {this.Carne} y con créditos {this.NumeroCreditos}";
        }

        public void listarMisDatos(string identificador)
        {
            Console.WriteLine($" El alumno con carné {this.Carne}, apellidos, {this.Apellidos}, nombres, {this.Nombres}, y con {this.NumeroCreditos} créditos");
        }

        public bool eliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura {this.Asignatura} de {this.Apellidos} {this.Nombres}, Perdera la cantidad de creditos de {this.NumeroCreditos}");
            return true;
        }
    }
}