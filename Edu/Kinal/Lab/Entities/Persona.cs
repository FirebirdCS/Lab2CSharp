namespace Lab2.Edu.Kinal.Lab.Entities
{
    public abstract class Persona
    {
        public Persona()
        {

        }

        public Persona(string uuid, string apellidos, string nombres, string email)
        {
            this.Uuid = uuid;
            this.Apellidos = apellidos;
            this.Nombres = nombres;
            this.Email = email;
        }
        public string Uuid { get; set; }
        public string Apellidos { get; set; }

        public string Nombres { get; set; }

        public string Email { get; set; }

        public abstract void TomarAsistencia();
    }
}