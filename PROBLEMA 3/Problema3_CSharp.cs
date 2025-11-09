// Problema 3: Operaciones sobre matrices de registros numéricos 

using System;

class Program
{
    // Problema 3: Operaciones sobre matrices de registros numéricos 
    
    static double[,] CrearMatriz(int filas, int columnas)
    {
        return new double[filas, columnas];
    }

    static void ImprimirMatriz(double[,] mat)
    {
        int filas = mat.GetLength(0);
        int columnas = mat.GetLength(1);
        
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"{mat[i, j]:F2} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static double[,] SumarMatrices(double[,] A, double[,] B)
    {
        int filas = A.GetLength(0);
        int columnas = A.GetLength(1);
        double[,] resultado = CrearMatriz(filas, columnas);
        
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = A[i, j] + B[i, j];
            }
        }
        return resultado;
    }

    static double[,] MultiplicarMatrices(double[,] A, double[,] B)
    {
        int filasA = A.GetLength(0);
        int columnasA = A.GetLength(1);
        int filasB = B.GetLength(0);
        int columnasB = B.GetLength(1);

        if (columnasA != filasB)
        {
            throw new ArgumentException("El número de columnas de A debe ser igual al número de filas de B.");
        }

        double[,] resultado = CrearMatriz(filasA, columnasB);
        
        for (int i = 0; i < filasA; i++)
        {
            for (int j = 0; j < columnasB; j++)
            {
                for (int k = 0; k < columnasA; k++)
                {
                    resultado[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return resultado;
    }

    static void Main(string[] args)
    {
        // Registros de prueba
        double[,] m1 = {
            {1.0, 2.0, 3.0},
            {4.0, 5.0, 6.0}
        };

        double[,] m2 = {
            {1.1, 2.1, 3.1},
            {4.1, 5.1, 6.1}
        };

        double[,] m3 = {
            {1.0, 2.0},
            {3.0, 4.0}
        };

        double[,] m4 = {
            {5.2, 6.2},
            {7.0, 8.0}
        };

        Console.WriteLine("Matriz m1:");
        ImprimirMatriz(m1);

        Console.WriteLine("Matriz m2:");
        ImprimirMatriz(m2);

        double[,] m5 = SumarMatrices(m1, m2);
        Console.WriteLine("Resultado de sumar m1 + m2:");
        ImprimirMatriz(m5);

        Console.WriteLine("Matriz m3:");
        ImprimirMatriz(m3);

        Console.WriteLine("Matriz m4:");
        ImprimirMatriz(m4);

        double[,] m6 = MultiplicarMatrices(m3, m4);
        Console.WriteLine("Resultado de multiplicar m3 * m4:");
        ImprimirMatriz(m6);
    }
}