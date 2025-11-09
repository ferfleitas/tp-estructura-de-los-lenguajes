package main

import (
	"fmt"
)

// Función para crear una matriz de ceros
func crearMatriz(fila, columna int) [][]float64 {
	mat := make([][]float64, fila)
	for k := 0; k < fila; k++ {
		mat[k] = make([]float64, columna)
	}
	return mat
}

// Función para imprimir una matriz
func imprimirMatriz(mat [][]float64) {
	filas := len(mat)
	for k := 0; k < filas; k++ {
		fmt.Println(mat[k])
	}
	fmt.Println()
}

// Función para sumar dos matrices
func sumarMatrices(A, B [][]float64) [][]float64 {
	filas := len(A)
	columnas := len(A[0])
	resultado := crearMatriz(filas, columnas)

	for i := 0; i < filas; i++ {
		for j := 0; j < columnas; j++ {
			resultado[i][j] = A[i][j] + B[i][j]
		}
	}
	return resultado
}

// Función para multiplicar dos matrices
func multiplicarMatrices(A, B [][]float64) [][]float64 {
	filasA := len(A)
	columnasA := len(A[0])
	filasB := len(B)
	columnasB := len(B[0])

	if columnasA != filasB {
		fmt.Println("Error: el número de columnas de A debe ser igual al número de filas de B")
		return nil
	}

	resultado := crearMatriz(filasA, columnasB)

	for i := 0; i < filasA; i++ {
		for j := 0; j < columnasB; j++ {
			for k := 0; k < columnasA; k++ {
				resultado[i][j] += A[i][k] * B[k][j]
			}
		}
	}
	return resultado
}

func main() {
	// Registros de prueba
	m1 := [][]float64{
		{1.0, 2.0, 3.0},
		{4.0, 5.0, 6.0},
	}

	m2 := [][]float64{
		{1.1, 2.1, 3.1},
		{4.1, 5.1, 6.1},
	}

	m3 := [][]float64{
		{1.1, 2.1},
		{3.0, 4.0},
	}

	m4 := [][]float64{
		{5.2, 6.2},
		{7.0, 8.0},
	}

	fmt.Println("Matriz m1:")
	imprimirMatriz(m1)

	fmt.Println("Matriz m2:")
	imprimirMatriz(m2)

	m5 := sumarMatrices(m1, m2)

	fmt.Println("Resultado de sumar m1+m2:")
	imprimirMatriz(m5)

	fmt.Println("Matriz m3:")
	imprimirMatriz(m3)

	fmt.Println("Matriz m4:")
	imprimirMatriz(m4)

	m6 := multiplicarMatrices(m3, m4)
	if m6 == nil {
		return
	}

	fmt.Println("Resultado de multiplicar m3*m4:")
	imprimirMatriz(m6)
}
