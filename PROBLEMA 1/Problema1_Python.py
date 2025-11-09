# Clase alumno con atributos básicos
class Alumno:
    
    def __init__(self, nombre, edad, carrera, promedio):
        self.nombre = nombre
        self.edad = edad
        self.carrera = carrera
        self.promedio = promedio

    def __str__(self):
        return f"Nombre: {self.nombre}, Edad: {self.edad}, Carrera: {self.carrera}, Promedio: {self.promedio}"


# Función Quicksort específicamente para ordenar por promedio
def partir(array, inicio, final):
    pivot = array[final].promedio
    i = inicio - 1
    for j in range(inicio, final):
        if array[j].promedio <= pivot:
            i = i + 1
            (array[i], array[j]) = (array[j], array[i])
    (array[i+1], array[final]) = (array[final], array[i+1])
    return i + 1

def quickSort(array, inicio, final):
    if inicio < final:
        pi = partir(array, inicio, final)
        quickSort(array, inicio, pi - 1)
        quickSort(array, pi + 1, final)


# Función de filtrado por promedio
def filtrarPorPromedio(array, prom=4):
    flag = False
    for alumno in array:
        if alumno.promedio >= prom:
            print(alumno)
            flag = True
    if not flag:
        print(f"No hay alumnos con promedio mayor o igual a {prom}")


# Llamada a función de ordenamiento
def ordernarPorPromedio(array):
    quickSort(array, 0, len(array) - 1)


# Creación de registros
listaAlumnos = [
    Alumno("Fernando", 21, "IIN", 4.12),
    Alumno("Maria", 22, "IIN", 3.95),
    Alumno("Juan", 20, "IMK", 4.50),
    Alumno("Ana", 23, "LCIK", 3.80),
    Alumno("Luis", 21, "ISP", 4.00),
    Alumno("Sofia", 22, "IIN", 4.20),
    Alumno("Carlos", 24, "LEL", 3.70),
    Alumno("Lucia", 20, "IEN", 4.10),
    Alumno("Pedro", 22, "IIN", 3.90),
    Alumno("Valeria", 21, "LCIK", 4.30),
    Alumno("Miguel", 23, "IEN", 3.85),
    Alumno("Camila", 22, "ISP", 4.25),
    Alumno("Jorge", 20, "LGH", 3.95),
    Alumno("Paula", 21, "LGH", 4.05),
    Alumno("Diego", 23, "LGH", 4.15),
    Alumno("Martina", 22, "LGH", 3.90),
    Alumno("Andres", 21, "IEN", 4.35),
    Alumno("Florencia", 24, "ISP", 4.00),
    Alumno("Gabriel", 20, "LCIK", 3.75),
    Alumno("Julieta", 22, "LCIK", 4.40),
    Alumno("Santiago", 23, "IIN", 3.85),
    Alumno("Agustina", 21, "IEL", 4.10),
    Alumno("Emiliano", 22, "IEL", 4.20),
    Alumno("Micaela", 20, "IIN", 3.80),
    Alumno("Tomas", 23, "ICM", 4.05),
]

print("LISTA DE ALUMNOS:")
for alumno in listaAlumnos:
    print(alumno)

print("\nORDENADO POR PROMEDIO ASCENDENTE:")
ordernarPorPromedio(listaAlumnos)
for alumno in listaAlumnos:
    print(alumno)

print("\nFILTRAR POR PROMEDIO")
filtrarPorPromedio(listaAlumnos)

print("\nFILTRAR POR PROMEDIO 4.5")
filtrarPorPromedio(listaAlumnos, 4.5)

print("\nFILTRAR POR PROMEDIO 5")
filtrarPorPromedio(listaAlumnos, 5)
