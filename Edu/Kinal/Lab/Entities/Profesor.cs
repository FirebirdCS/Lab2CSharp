using Lab2.Edu.Kinal.Lab.Interfaz;
using Lab2.Edu.Kinal.Lab.Entities;

namespace Lab2.Edu.Kinal.Lab.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public Profesor() : base()
        {

        }

        public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
            : base(uuid, apellidos, nombres, email)
        {
            this.CUI = cui;
            this.Cargo = cargo;
        }
        public string CUI { get; set; }

        public string Cargo { get; set; }


        public bool eliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura de " + asignatura + $" del profesor {this.Apellidos} {this.Nombres}");
            return true;
        }


        public void listarMisDatos(string identificador)
        {
            Console.WriteLine($" El profesor con CUI {this.CUI}, apellidos, {this.Apellidos}, nombres, {this.Nombres}, y con cargo {this.Cargo}");
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Asistencia con Cui {this.CUI}");
        }

        override public string ToString()
        {
            return $"El profesor {this.Nombres} {this.Apellidos} con CUI {this.CUI} y con cargo {this.Cargo}";
        }
    }
}