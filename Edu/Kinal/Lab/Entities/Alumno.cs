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
            return $"El alumno {this.Nombres} {this.Apellidos} con carné {this.Carne} y con créditos {this.NumeroCreditos}";
        }

        public void listarMisDatos(string identificador)
        {
            string carneEncontrado = identificador;
            if (this.Carne == carneEncontrado)
            {
                Console.WriteLine($"El alumno {this.Nombres} {this.Apellidos} con carné {this.Carne} y con créditos {this.NumeroCreditos}");
            }
            else
            {
                Console.WriteLine("Este alumno no tiene este carné");
            }
        }

        public bool eliminarAsignatura(string asignatura)
        {
            string viejaAsignatura = asignatura;
            if (this.Asignatura == asignatura)
            {
                this.NumeroCreditos = 0;
                Console.WriteLine($"El alumno {this.Nombres} ya no tiene el curso  {this.Asignatura}  y tiene {this.NumeroCreditos} créditos");
                return true;
            }
            else
            {
                Console.WriteLine($"Esta asignatura no existe");
                return false;
            }
        }
    }
}