using Lambda;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lista estudiantes");
        List<Estudiante> Estudiantes = new List<Estudiante>();
        {
            Estudiantes.Add(new Estudiante("Raul", 17, 70.9));
            Estudiantes.Add(new Estudiante("Luis", 21, 64.4));
            Estudiantes.Add(new Estudiante("Carlos", 15, 61.7));
            Estudiantes.Add(new Estudiante("Jacob", 17, 88.5));
            Estudiantes.Add(new Estudiante("Joe", 20, 90.8));

        };
        var Mayor_Edad = Estudiantes.Where(i => i.Edad > 18).ToList();
        Console.WriteLine("Mayores de edad estudiantes");
        Mayor_Edad.ForEach(i => Console.WriteLine($"Nombre {i.Nombre}, Edad {i.Edad}, Nota {i.Nota}"));      
        double Nota_alta = Estudiantes.Max(i => i.Nota);
        var estudiantenotaAlta = Estudiantes.First(i => i.Nota == Nota_alta);
        Console.WriteLine("Estudiante con nota mas alta:");
        Console.WriteLine($"Estudiante {estudiantenotaAlta.Nombre}, edad {estudiantenotaAlta.Edad}, nota {estudiantenotaAlta.Nota}");
        var estudiantesordenaods = Estudiantes.OrderBy(i => i.Nombre).ToList();
        Console.WriteLine("Estudiantes ordenados");
        estudiantesordenaods.ForEach(i => Console.WriteLine($"nombre {i.Nombre}, edad {i.Edad}, nota {i.Nota}"));
        double promedionotas = Estudiantes.Average(i => i.Nota);
        Console.WriteLine($"Promedio de los estudiantes {promedionotas}");
        {
            Console.WriteLine("Guia del maestro Christopher Larios");
            Console.WriteLine("LAMBDA programacion 1");
            Func<int, int, int> suma = (a, b) => a + b;
            Console.WriteLine(suma(3, 4));
            Func<double, double> produc = x => x * x;
            Console.WriteLine(produc(10));
            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine(isTooLong(10, "programacion1"));
            Action<int> mayorEdad = n =>
            {
                Boolean ME = (n > 18) ? true : false;
                Console.WriteLine($"Es mayor de edad");

            };
            mayorEdad(15);
            Action<string> saludar = _ => Console.WriteLine("saludar");
            saludar("ignorando");

        }

    }

}
