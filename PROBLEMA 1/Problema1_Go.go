// Problema 1: Clasificación y filtrado de registros 
package main

import (
	"fmt"
)

// Estructura Alumno con atributos básicos
type Alumno struct {
	nombre   string
	edad     int
	carrera  string
	promedio float64
}

// Método String para imprimir Alumno
func (a Alumno) String() string {
	return fmt.Sprintf("Nombre: %s, Edad: %d, Carrera: %s, Promedio: %.2f", 
		a.nombre, a.edad, a.carrera, a.promedio)
}

// Función Quicksort para ordenar por promedio
func partir(array []Alumno, inicio, final int) int {
	pivot := array[final].promedio
	i := inicio - 1

	for j := inicio; j < final; j++ {
		if array[j].promedio <= pivot {
			i++
			array[i], array[j] = array[j], array[i]
		}
	}
	array[i+1], array[final] = array[final], array[i+1]
	return i + 1
}

func quickSort(array []Alumno, inicio, final int) {
	if inicio < final {
		pi := partir(array, inicio, final)
		quickSort(array, inicio, pi-1)
		quickSort(array, pi+1, final)
	}
}

// Función de filtrado por promedio
func filtrarPorPromedio(array []Alumno, prom float64) {
	flag := false
	for _, alumno := range array {
		if alumno.promedio >= prom {
			fmt.Println(alumno)
			flag = true
		}
	}
	if !flag {
		fmt.Printf("No hay alumnos con promedio mayor o igual a %.2f\n", prom)
	}
}

// Función para ordenar por promedio
func ordenarPorPromedio(array []Alumno) {
	quickSort(array, 0, len(array)-1)
}

func main() {
	// Creación de registros
	listaAlumnos := []Alumno{
		{"Fernando", 21, "IIN", 4.12},
		{"Marcos", 21, "IEK", 5.00},
		{"Juan", 20, "IMK", 4.50},
		{"Ana", 23, "LCIK", 3.80},
		{"Luis", 21, "ISP", 4.00},
		{"Sofia", 22, "IIN", 4.20},
		{"Carlos", 24, "LEL", 3.70},
		{"Lucia", 20, "IEN", 4.10},
		{"Pedro", 22, "IIN", 3.90},
		{"Valeria", 21, "LCIK", 4.30},
		{"Miguel", 23, "IEN", 3.85},
		{"Camila", 22, "ISP", 4.25},
		{"Jorge", 20, "LGH", 3.95},
		{"Paula", 21, "LGH", 4.05},
		{"Diego", 23, "LGH", 4.15},
		{"Martina", 22, "LGH", 3.90},
		{"Andres", 21, "IEN", 4.35},
		{"Florencia", 24, "ISP", 4.00},
		{"Gabriel", 20, "LCIK", 3.75},
		{"Julieta", 22, "LCIK", 4.40},
		{"Santiago", 23, "IIN", 3.85},
		{"Agustina", 21, "IEL", 4.10},
		{"Emiliano", 22, "IEL", 4.20},
		{"Micaela", 20, "IIN", 3.80},
		{"Tomas", 23, "ICM", 4.05},
	}

	fmt.Println("LISTA DE ALUMNOS:")
	for _, alumno := range listaAlumnos {
		fmt.Println(alumno)
	}

	fmt.Println("\nORDENADO POR PROMEDIO ASCENDENTE:")
	ordenarPorPromedio(listaAlumnos)
	for _, alumno := range listaAlumnos {
		fmt.Println(alumno)
	}

	fmt.Println("\nFILTRAR POR PROMEDIO")
	filtrarPorPromedio(listaAlumnos, 4.0)

	fmt.Println("\nFILTRAR POR PROMEDIO 4.5")
	filtrarPorPromedio(listaAlumnos, 4.5)

	fmt.Println("\nFILTRAR POR PROMEDIO 5")
	filtrarPorPromedio(listaAlumnos, 5.0)
}