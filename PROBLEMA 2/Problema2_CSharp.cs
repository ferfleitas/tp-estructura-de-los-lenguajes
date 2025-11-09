// Problema 2: Búsqueda secuencial con validación en estructuras de datos 

using System;
using System.Collections.Generic;

class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Anho { get; set; }
    public double Precio { get; set; }
    public string Editorial { get; set; }

    public Libro(string titulo, string autor, int anho, double precio, string editorial)
    {
        Titulo = titulo;
        Autor = autor;
        Anho = anho;
        Precio = precio;
        Editorial = editorial;
    }

    public override string ToString()
    {
        return $"Título: {Titulo}, Autor: {Autor}, Editorial: {Editorial}, Año: {Anho}, Precio: {Precio}";
    }
}

class Program
{
    static void BusquedaPorAutor(List<Libro> lista, string autorBuscado)
    {
        List<Libro> coincidencias = new List<Libro>();

        foreach (var libro in lista)
        {   
            // comparación de strings
            if (libro.Autor.IndexOf(autorBuscado, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                coincidencias.Add(libro);
            }
        }

        if (coincidencias.Count > 0)
        {
            Console.WriteLine($"\nLibros que contienen al autor: {autorBuscado}");
            foreach (var libro in coincidencias)
            {
                Console.WriteLine(libro);
            }
        }
        else
        {
            Console.WriteLine($"\nNo se encontraron registros con el autor: {autorBuscado}");
        }
    }

    static void BusquedaPorTitulo(List<Libro> lista, string tituloBuscado)
    {
        List<Libro> coincidencias = new List<Libro>();

        foreach (var libro in lista)
        {
            if (libro.Titulo.IndexOf(tituloBuscado, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                coincidencias.Add(libro);
            }
        }

        if (coincidencias.Count > 0)
        {
            Console.WriteLine($"\nRegistros que contienen al libro: {tituloBuscado}");
            foreach (var libro in coincidencias)
            {
                Console.WriteLine(libro);
            }
        }
        else
        {
            Console.WriteLine($"\nNo se encontraron registros con el libro: {tituloBuscado}");
        }
    }

    static void BusquedaPorPrecio(List<Libro> lista, double minimo, double maximo)
    {
        if (minimo > maximo)
        {
            Console.WriteLine("Rango incorrecto. El mínimo excede al máximo.");
            return;
        }

        List<Libro> coincidencias = new List<Libro>();

        foreach (var libro in lista)
        {
            if (libro.Precio >= minimo && libro.Precio <= maximo)
            {
                coincidencias.Add(libro);
            }
        }

        if (coincidencias.Count > 0)
        {
            Console.WriteLine($"\nRegistros que contienen el rango de precios [{minimo} - {maximo}]");
            foreach (var libro in coincidencias)
            {
                Console.WriteLine(libro);
            }
        }
        else
        {
            Console.WriteLine($"\nNo se encontraron registros en el rango: [{minimo} - {maximo}]");
        }
    }

    static void Main()
    {
        List<Libro> listaLibros = new List<Libro>
        {
            new Libro("La tregua", "Mario Benedetti", 1960, 52000, "Editorial Alfa"),
            new Libro("Pedro Páramo", "Juan Rulfo", 1955, 48000, "Fondo de Cultura Económica"),
            new Libro("Rayuela", "Julio Cortázar", 1963, 73000, "Editorial Sudamericana"),
            new Libro("El túnel", "Ernesto Sabato", 1948, 51000, "Editorial Losada"),
            new Libro("Los detectives salvajes", "Roberto Bolaño", 1998, 82000, "Editorial Anagrama"),
            new Libro("Sobre héroes y tumbas", "Ernesto Sabato", 1961, 69000, "Editorial Losada"),
            new Libro("Santa Evita", "Tomás Eloy Martínez", 1995, 61000, "Editorial Planeta"),
            new Libro("El entenado", "Juan José Saer", 1983, 57000, "Editorial Seix Barral"),
            new Libro("La invención de Morel", "Adolfo Bioy Casares", 1940, 54000, "Editorial Losada"),
            new Libro("El astillero", "Juan Carlos Onetti", 1961, 60000, "Editorial Losada")
        };

        Console.WriteLine("LISTA DE LIBROS:");
        foreach (var libro in listaLibros)
        {
            Console.WriteLine(libro);
        }

        // Pruebas estáticas
        BusquedaPorAutor(listaLibros, "sabato");
        BusquedaPorTitulo(listaLibros, "el");
        BusquedaPorPrecio(listaLibros, 50000, 60000);
        BusquedaPorPrecio(listaLibros, 70000, 71000);
        BusquedaPorPrecio(listaLibros, 80000, 60000);
    }
}
