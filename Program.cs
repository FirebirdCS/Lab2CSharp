using Lab2.Edu.Kinal.Lab.Entities;
using Lab2.Edu.Kinal.Lab.Interfaz;

public class Program
{
    private static List<Persona> listaPersonas = new List<Persona>();
    public static void Main(string[] args)
    {
        Persona alumno1 = new Alumno("4580K", "Flores", "Alvaro", "alvaro@gmail.com", "2016579", 50, "Idioma");
        Persona alumno2 = new Alumno("4580L", "Guevara", "Carlos", "carlos@gmail.com", "2016482", 20, "Ciencias");
        Persona profesor1 = new Profesor("4580J", "Pérez", "Leonardo", "leonardo@gmail.com", "3020254800101", "Profesor de ciencias");

        /* Registro */
        operarRegistro(alumno1);
        operarRegistro(alumno2);
        operarRegistro(profesor1);
        /* Listar Datos */
        listarMisDatos(profesor1);
        /* Registrar la asistencia */
        registrarAsistencia(alumno2);
        /* Eliminar asignatura */
        quitarAsignatura(alumno1, "Idioma");
        /* Lista general de las personas */
        Console.WriteLine("Las personas dentro de la universidad son las siguientes: ");
        listaGeneral(listaPersonas);

    }

    static void operarRegistro(Persona elemento)
    {
        listaPersonas.Add(elemento);
        Console.WriteLine("Se ha añadido a " + elemento);
    }
    static void listarMisDatos(Persona elemento)
    {
        if (elemento is Alumno)
        {
            Alumno auxiliar = (Alumno)elemento;
            auxiliar.listarMisDatos(auxiliar.Carne);
        }
        else if (elemento is Profesor)
        {
            Profesor auxiliar = (Profesor)elemento;
            auxiliar.listarMisDatos(auxiliar.CUI);
        }
    }

    static void quitarAsignatura(Persona elemento, string asignatura)
    {
        ((IOperaciones)elemento).eliminarAsignatura(asignatura);
    }

    static void listaGeneral(List<Persona> personas)
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
    static void registrarAsistencia(Persona elemento)
    {
        foreach (Persona asistencia in listaPersonas)
        {
            if (asistencia.Uuid == elemento.Uuid)
            {
                elemento.TomarAsistencia();
            }
        }
    }

}