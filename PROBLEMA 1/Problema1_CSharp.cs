// Problema 1: Clasificación y filtrado de registros 

using System;
using System.Collections.Generic;

class Alumno
{
    public string Nombre { get; }
    public int Edad { get; }
    public string Carrera { get; }
    public double Promedio { get; }

    public Alumno(string nombre, int edad, string carrera, double promedio)
    {
        Nombre = nombre;
        Edad = edad;
        Carrera = carrera;
        Promedio = promedio;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}, Carrera: {Carrera}, Promedio: {Promedio}";
    }
}

class Program
{
    static void Main()
    {
        List<Alumno> listaAlumnos = new List<Alumno>
        {
            new Alumno("Fernando", 21, "IIN", 3.69),
            new Alumno("Marcos", 21, "IEK", 5),
            new Alumno("Juan", 20, "IMK", 4.50),
            new Alumno("Ana", 23, "LCIK", 3.80),
            new Alumno("Luis", 21, "ISP", 4.00),
            new Alumno("Sofia", 22, "IIN", 4.20),
            new Alumno("Carlos", 24, "LEL", 3.70),
            new Alumno("Lucia", 20, "IEN", 4.10),
            new Alumno("Pedro", 22, "IIN", 3.90),
            new Alumno("Valeria", 21, "LCIK", 4.30),
            new Alumno("Miguel", 23, "IEN", 3.85),
            new Alumno("Camila", 22, "ISP", 4.25),
            new Alumno("Jorge", 20, "LGH", 3.95),
            new Alumno("Paula", 21, "LGH", 4.05),
            new Alumno("Diego", 23, "LGH", 4.15),
            new Alumno("Martina", 22, "LGH", 3.90),
            new Alumno("Andres", 21, "IEN", 4.35),
            new Alumno("Florencia", 24, "ISP", 4.00),
            new Alumno("Gabriel", 20, "LCIK", 3.75),
            new Alumno("Julieta", 22, "LCIK", 4.40),
            new Alumno("Santiago", 23, "IIN", 3.85),
            new Alumno("Agustina", 21, "IEL", 4.10),
            new Alumno("Emiliano", 22, "IEL", 4.20),
            new Alumno("Micaela", 20, "IIN", 3.80),
            new Alumno("Tomas", 23, "ICM", 4.05)
        };

        Console.WriteLine("LISTA DE ALUMNOS:");
        foreach (var alumno in listaAlumnos)
            Console.WriteLine(alumno);

        Console.WriteLine("\nORDENADO POR PROMEDIO ASCENDENTE:");
        OrdenarPorPromedio(listaAlumnos);
        foreach (var alumno in listaAlumnos)
            Console.WriteLine(alumno);

        Console.WriteLine("\nFILTRAR POR PROMEDIO >= 4");
        FiltrarPorPromedio(listaAlumnos, 4);

        Console.WriteLine("\nFILTRAR POR PROMEDIO >= 4.5");
        FiltrarPorPromedio(listaAlumnos, 4.5);

        Console.WriteLine("\nFILTRAR POR PROMEDIO >= 5");
        FiltrarPorPromedio(listaAlumnos, 5);
    }

    static void OrdenarPorPromedio(List<Alumno> lista)
    {
        QuickSort(lista, 0, lista.Count - 1);
    }

    static void QuickSort(List<Alumno> lista, int inicio, int fin)
    {
        if (inicio < fin)
        {
            int pi = Partir(lista, inicio, fin);
            QuickSort(lista, inicio, pi - 1);
            QuickSort(lista, pi + 1, fin);
        }
    }

    static int Partir(List<Alumno> lista, int inicio, int fin)
    {
        double pivot = lista[fin].Promedio;
        int i = inicio - 1;

        for (int j = inicio; j < fin; j++)
        {
            if (lista[j].Promedio <= pivot)
            {
                i++;
                var temp = lista[i];
                lista[i] = lista[j];
                lista[j] = temp;
            }
        }

        var temp2 = lista[i + 1];
        lista[i + 1] = lista[fin];
        lista[fin] = temp2;

        return i + 1;
    }

    static void FiltrarPorPromedio(List<Alumno> lista, double minPromedio)
    {
        bool encontrado = false;
        foreach (var alumno in lista)
        {
            if (alumno.Promedio >= minPromedio)
            {
                Console.WriteLine(alumno);
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine($"No hay alumnos con promedio mayor o igual a {minPromedio}");
        }
    }
}
