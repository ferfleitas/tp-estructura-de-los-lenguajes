package main

import (
	"fmt"
	"strings"
)

// Estructura Libro con atributos básicos
type Libro struct {
	Titulo    string
	Autor     string
	Anho      int
	Precio    int
	Editorial string
}

// Método String para mostrar información del libro
func (l Libro) String() string {
	return fmt.Sprintf("Título: %s, Autor: %s, Editorial: %s, Año: %d, Precio: %d",
		l.Titulo, l.Autor, l.Editorial, l.Anho, l.Precio)
}

// Función de búsqueda por autor
func busquedaPorAutor(array []Libro, autorBuscado string) {
	var coincidencias []Libro

	for i := 0; i < len(array); i++ {
		if strings.Contains(strings.ToLower(array[i].Autor), strings.ToLower(autorBuscado)) {
			coincidencias = append(coincidencias, array[i])
		}
	}

	if len(coincidencias) > 0 {
		fmt.Printf("\nLibros que contienen al autor: %s\n", autorBuscado)
		for _, libro := range coincidencias {
			fmt.Println(libro.String())
		}
	} else {
		fmt.Printf("\nNo se encontraron registros con el autor: %s\n", autorBuscado)
	}
}

// Función de búsqueda por título
func busquedaPorTitulo(array []Libro, tituloBuscado string) {
	var coincidencias []Libro

	for i := 0; i < len(array); i++ {
		if strings.Contains(strings.ToLower(array[i].Titulo), strings.ToLower(tituloBuscado)) {
			coincidencias = append(coincidencias, array[i])
		}
	}

	if len(coincidencias) > 0 {
		fmt.Printf("\nRegistros que contienen al libro: %s\n", tituloBuscado)
		for _, libro := range coincidencias {
			fmt.Println(libro.String())
		}
	} else {
		fmt.Printf("\nNo se encontraron registros con el libro: %s\n", tituloBuscado)
	}
}

// Función de búsqueda por rango de precio
func busquedaPorPrecio(array []Libro, minimo, maximo int) {
	if minimo > maximo {
		fmt.Println("Rango incorrecto. El mínimo excede al máximo.")
		return
	}

	var coincidencias []Libro

	for i := 0; i < len(array); i++ {
		precio := array[i].Precio
		if precio >= minimo && precio <= maximo {
			coincidencias = append(coincidencias, array[i])
		}
	}

	if len(coincidencias) > 0 {
		fmt.Printf("\nRegistros que contienen el rango de precios [%d - %d]\n", minimo, maximo)
		for _, libro := range coincidencias {
			fmt.Println(libro.String())
		}
	} else {
		fmt.Printf("\nNo se encontraron registros en el rango: [%d - %d]\n", minimo, maximo)
	}
}

func main() {
	// Lista de libros
	listaLibros := []Libro{
		{"La tregua", "Mario Benedetti", 1960, 52000, "Editorial Alfa"},
		{"Pedro Páramo", "Juan Rulfo", 1955, 48000, "Fondo de Cultura Económica"},
		{"Rayuela", "Julio Cortázar", 1963, 73000, "Editorial Sudamericana"},
		{"El túnel", "Ernesto Sabato", 1948, 51000, "Editorial Losada"},
		{"Los detectives salvajes", "Roberto Bolaño", 1998, 82000, "Editorial Anagrama"},
		{"Sobre héroes y tumbas", "Ernesto Sabato", 1961, 69000, "Editorial Losada"},
		{"Santa Evita", "Tomás Eloy Martínez", 1995, 61000, "Editorial Planeta"},
		{"El entenado", "Juan José Saer", 1983, 57000, "Editorial Seix Barral"},
		{"La invención de Morel", "Adolfo Bioy Casares", 1940, 54000, "Editorial Losada"},
		{"El astillero", "Juan Carlos Onetti", 1961, 60000, "Editorial Losada"},
	}

	fmt.Println("LISTA DE LIBROS:")
	for _, libro := range listaLibros {
		fmt.Println(libro.String())
	}

	// Pruebas estáticas
	busquedaPorAutor(listaLibros, "sabato")      // pruebas de búsqueda
	busquedaPorTitulo(listaLibros, "el")         // búsquedas de títulos
	busquedaPorPrecio(listaLibros, 50000, 60000) // debe encontrar varios dentro del rango
	busquedaPorPrecio(listaLibros, 70000, 71000) // sin resultados
	busquedaPorPrecio(listaLibros, 80000, 60000) // rango inválido
}