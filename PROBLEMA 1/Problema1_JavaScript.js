// Problema 1: Clasificación y filtrado de registros 

class Alumno {
  constructor(nombre, edad, carrera, promedio) {
    this.nombre = nombre;
    this.edad = edad;
    this.carrera = carrera;
    this.promedio = promedio;
  }

  toString() {
    return `Nombre: ${this.nombre}, Edad: ${this.edad}, Carrera: ${this.carrera}, Promedio: ${this.promedio}`;
  }
}

// Función quicksort para promedio
function partir(array, inicio, final) {
  const pivot = array[final].promedio;
  let i = inicio - 1;

  for (let j = inicio; j < final; j++) {
    if (array[j].promedio <= pivot) {
      i++;
      [array[i], array[j]] = [array[j], array[i]];
    }
  }
  [array[i + 1], array[final]] = [array[final], array[i + 1]];
  return i + 1;
}

function quickSort(array, inicio, final) {
  if (inicio < final) {
    const pi = partir(array, inicio, final);
    quickSort(array, inicio, pi - 1);
    quickSort(array, pi + 1, final);
  }
}

// Filtrar por promedio (default ≥ 4)
function filtrarPorPromedio(array, prom = 4) {
  let flag = false;
  for (const alumno of array) {
    if (alumno.promedio >= prom) {
      console.log(alumno.toString());
      flag = true;
    }
  }
  if (!flag) {
    console.log(`No hay alumnos con promedio mayor o igual a ${prom}`);
  }
}

// Ordenar lista por promedio ascendente
function ordenarPorPromedio(array) {
  quickSort(array, 0, array.length - 1);
}


// Lista de alumnos
const listaAlumnos = [
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
];

// Imprimir lista original
console.log("LISTA DE ALUMNOS:");
listaAlumnos.forEach(alumno => console.log(alumno.toString()));

// Ordenar por promedio
console.log("\nORDENADO POR PROMEDIO ASCENDENTE:");
ordenarPorPromedio(listaAlumnos);
listaAlumnos.forEach(alumno => console.log(alumno.toString()));

// Filtrar por promedio
console.log("\nFILTRAR POR PROMEDIO >= 4");
filtrarPorPromedio(listaAlumnos);

console.log("\nFILTRAR POR PROMEDIO >= 4.5");
filtrarPorPromedio(listaAlumnos, 4.5);

console.log("\nFILTRAR POR PROMEDIO >= 5");
filtrarPorPromedio(listaAlumnos, 5);
