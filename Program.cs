using Lab2.Edu.Kinal.Lab.Entities;
public class Sistema
{
    public static void Main(string[] args)
    {
        List<Persona> listaPersonas = new List<Persona>();
        Persona alumno1 = new Alumno("4580K", "Flores", "Alvaro", "alvaro@gmail.com", "2016579", 50, "Idioma");
        Persona alumno2 = new Alumno("4580K", "Flores", "Alvaro", "alvaro@gmail.com", "2016482", 20, "Ciencias");
        Persona profesor1 = new Profesor("4580J", "Flores", "Alvaro", "alvaro@gmail.com", "3020151910101", "Profesor de ciencias");

        listaPersonas.Add(alumno1);
        listaPersonas.Add(alumno2);
        listaPersonas.Add(profesor1);
        QuitarAsignatura(listaPersonas);
    }


    static void listarMisDatos(List<Persona> personas)
    {
        foreach (Persona elemento in personas)
        {
            if (elemento is Alumno)
            {
                ((Alumno)elemento).listarMisDatos("2016579");
            }
            if (elemento is Profesor)
            {
                ((Profesor)elemento).listarMisDatos("3020151910101");
            }
        }
    }

    static void QuitarAsignatura(List<Persona> personas)
    {
        foreach (Persona elemento in personas)
        {
            if (elemento is Alumno)
            {
                ((Alumno)elemento).eliminarAsignatura("Idioma");
            }
        }
    }
    static void ListaGeneral(List<Persona> personas)
    {
        Console.WriteLine($"Información General");
        foreach (Persona elemento in personas)
        {
            if (elemento is Alumno)
            {
                Console.WriteLine($"Datos: {((Alumno)elemento).Carne} {((Alumno)elemento).Asignatura} {elemento.Apellidos} {elemento.Nombres}");
            }
            else if (elemento is Profesor)
            {
                Console.WriteLine($"Datos: {((Profesor)elemento).CUI} {((Profesor)elemento).Cargo}{elemento.Apellidos} {elemento.Nombres}");
            }
        }
    }
    static void RegistrarAsistencia(List<Persona> personas)
    {
        foreach (Persona elemento in personas)
        {
            if (elemento is Alumno)
            {
                ((Alumno)elemento).TomarAsistencia();
            }
            else if (elemento is Profesor)
            {
                ((Profesor)elemento).TomarAsistencia();
            }
        }
    }

}