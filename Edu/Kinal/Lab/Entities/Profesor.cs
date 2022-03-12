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
            if ("Idioma" == this.Cargo)
            {
                string viejoCargo = Cargo;
                this.Cargo = "";
                Console.WriteLine($"El profesor {this.Nombres} ya no tiene el cargo " + viejoCargo);
                return true;
            }
            else
            {
                Console.WriteLine($"Esta asignatura no existe");
                return false;
            }
        }


        public void listarMisDatos(string identificador)
        {
            string cuiEncontrado = identificador;
            if (this.CUI == cuiEncontrado)
            {
                Console.WriteLine($"El profesor {this.Nombres} {this.Apellidos} con carné {this.CUI} y con cargo {this.Cargo}");
            }
            else
            {
                Console.WriteLine("Este profesor no existe");
            }
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