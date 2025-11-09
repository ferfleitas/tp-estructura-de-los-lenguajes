# Problema 2: Búsqueda secuencial con validación en estructuras de datos 
class Libro:
    
    def __init__(self, titulo, autor, anho, precio, editorial):
        self.titulo = titulo
        self.autor = autor
        self.anho = anho
        self.precio = precio
        self.editorial = editorial
    
    def __str__(self):
        return f"Titulo: {self.titulo}, Autor: {self.autor}, Editorial: {self.editorial}, Año: {self.anho}, Precio: {self.precio}"

def busquedaPorPrecio(array):
    minimo = int(input("Ingrese el minimo:"))
    maximo = int(input("Ingrese el maximo:"))
    if (minimo > maximo):
        print("Rango incorrecto. El mínimo excede al máximo.")
    coincidencias = []
    for libro in array:
        if(minimo <= libro.precio and libro.precio <= maximo):
            coincidencias.append(libro)

    if coincidencias:
        print(f"\nRegistros que contienen el rango de precios [{minimo} - {maximo}]")
        for k in coincidencias: print(k)
    else:
        print(f"\nNo se encontraron registros en el rango: [{minimo} - {maximo}]")

def busquedaPorAutor(array):
    autor = input("Ingrese el nombre del autor: ")
    coincidencias = []

    for libro in array:
        if autor.lower() in libro.autor.lower():
            coincidencias.append(libro)

    if coincidencias:
        print(f"\nLibros que contienen al autor: {autor}")
        for k in coincidencias: print(k)
    else:
        print(f"\nNo se encontraron registros con el autor: {autor}")

def busquedaPorTitulo(array):
    titulo = input("Ingrese el titulo del libro: ")
    coincidencias = []

    for libro in array:
        if titulo.lower() in libro.titulo.lower():
            coincidencias.append(libro)

    if coincidencias:
        print(f"\nRegistros que contienen al libro: {titulo}")
        for k in coincidencias: print(k)
    else:
        print(f"\nNo se encontraron registros con el libro: {titulo}")

def busqueda(array, opcion):
    if(len(array) == 0):
        print("La lista de libros está vacía.")
    if (opcion == "1"):
        busquedaPorAutor(array)
    elif (opcion == "2"):
        busquedaPorTitulo(array)
    elif(opcion == "3"):
        busquedaPorPrecio(array)

listaLibros = []

listaLibros.append(Libro("La tregua", "Mario Benedetti", 1960, 52000, "Editorial Alfa"))
listaLibros.append(Libro("Pedro Páramo", "Juan Rulfo", 1955, 48000, "Fondo de Cultura Económica"))
listaLibros.append(Libro("Rayuela", "Julio Cortázar", 1963, 73000, "Editorial Sudamericana"))
listaLibros.append(Libro("El túnel", "Ernesto Sabato", 1948, 51000, "Editorial Losada"))
listaLibros.append(Libro("Los detectives salvajes", "Roberto Bolaño", 1998, 82000, "Editorial Anagrama"))
listaLibros.append(Libro("Sobre héroes y tumbas", "Ernesto Sabato", 1961, 69000, "Editorial Losada"))
listaLibros.append(Libro("Santa Evita", "Tomás Eloy Martínez", 1995, 61000, "Editorial Planeta"))
listaLibros.append(Libro("El entenado", "Juan José Saer", 1983, 57000, "Editorial Seix Barral"))
listaLibros.append(Libro("La invención de Morel", "Adolfo Bioy Casares", 1940, 54000, "Editorial Losada"))
listaLibros.append(Libro("El astillero", "Juan Carlos Onetti", 1961, 60000, "Editorial Losada"))

print("LISTA DE LIBROS: ")
for libro in listaLibros: print(libro)

print("\nBUSQUEDA POR:")
print("1. Autor")
print("2. Título del libro")
print("3. Rango de precios")

opcion = input("Ingrese su opción: ")
busqueda(listaLibros, opcion)