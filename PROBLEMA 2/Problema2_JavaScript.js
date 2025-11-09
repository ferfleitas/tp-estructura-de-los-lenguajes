// Problema 2: Búsqueda secuencial con validación en estructuras de datos 
class Libro {
    constructor(titulo, autor, anho, precio, editorial) {
        this.titulo = titulo;
        this.autor = autor;
        this.anho = anho;
        this.precio = precio;
        this.editorial = editorial;
    }

    toString() {
        return `Título: ${this.titulo}, Autor: ${this.autor}, Editorial: ${this.editorial}, Año: ${this.anho}, Precio: ${this.precio}`;
    }
}

function busquedaPorAutor(array, autorBuscado) {
    const coincidencias = [];

    for (let i = 0; i < array.length; i++) {
        if (array[i].autor.toLowerCase().includes(autorBuscado.toLowerCase())) {
            coincidencias.push(array[i]);
        }
    }

    if (coincidencias.length > 0) {
        console.log(`\nLibros que contienen al autor: ${autorBuscado}`);
        for (let libro of coincidencias) {
            console.log(libro.toString());
        }
    } else {
        console.log(`\nNo se encontraron registros con el autor: ${autorBuscado}`);
    }
}

function busquedaPorTitulo(array, tituloBuscado) {
    const coincidencias = [];

    for (let i = 0; i < array.length; i++) {
        if (array[i].titulo.toLowerCase().includes(tituloBuscado.toLowerCase())) {
            coincidencias.push(array[i]);
        }
    }

    if (coincidencias.length > 0) {
        console.log(`\nRegistros que contienen al libro: ${tituloBuscado}`);
        for (let libro of coincidencias) {
            console.log(libro.toString());
        }
    } else {
        console.log(`\nNo se encontraron registros con el libro: ${tituloBuscado}`);
    }
}

function busquedaPorPrecio(array, minimo, maximo) {
    if (minimo > maximo) {
        console.log("Rango incorrecto. El mínimo excede al máximo.");
        return;
    }

    const coincidencias = [];

    for (let i = 0; i < array.length; i++) {
        const precio = array[i].precio;
        if (precio >= minimo && precio <= maximo) {
            coincidencias.push(array[i]);
        }
    }

    if (coincidencias.length > 0) {
        console.log(`\nRegistros que contienen el rango de precios [${minimo} - ${maximo}]`);
        for (let libro of coincidencias) {
            console.log(libro.toString());
        }
    } else {
        console.log(`\nNo se encontraron registros en el rango: [${minimo} - ${maximo}]`);
    }
}

// Lista de libros
const listaLibros = [
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
];

console.log("LISTA DE LIBROS:");
for (let libro of listaLibros) {
    console.log(libro.toString());
}

// Pruebas estáticas
busquedaPorAutor(listaLibros, "sabato");      // pruebas de busqueda
busquedaPorTitulo(listaLibros, "el");         // busquedas de títulos
busquedaPorPrecio(listaLibros, 50000, 60000); // debe encontrar varios dentro del rango
busquedaPorPrecio(listaLibros, 70000, 71000); // sin resultados
busquedaPorPrecio(listaLibros, 80000, 60000); // rango inválido
