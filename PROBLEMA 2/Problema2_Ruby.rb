# Problema 2: Búsqueda secuencial con validación en estructuras de datos 

class Libro
  attr_accessor :titulo, :autor, :anho, :precio, :editorial

  def initialize(titulo, autor, anho, precio, editorial)
    @titulo = titulo
    @autor = autor
    @anho = anho
    @precio = precio
    @editorial = editorial
  end

  def to_s
    "Título: #{@titulo}, Autor: #{@autor}, Editorial: #{@editorial}, Año: #{@anho}, Precio: #{@precio}"
  end
end

def busqueda_por_autor(array, autor_buscado)
  coincidencias = []

  array.each do |libro|
    if libro.autor.downcase.include?(autor_buscado.downcase)
      coincidencias << libro
    end
  end

  if coincidencias.length > 0
    puts "\nLibros que contienen al autor: #{autor_buscado}"
    coincidencias.each do |libro|
      puts libro.to_s
    end
  else
    puts "\nNo se encontraron registros con el autor: #{autor_buscado}"
  end
end

def busqueda_por_titulo(array, titulo_buscado)
  coincidencias = []

  array.each do |libro|
    if libro.titulo.downcase.include?(titulo_buscado.downcase)
      coincidencias << libro
    end
  end

  if coincidencias.length > 0
    puts "\nRegistros que contienen al libro: #{titulo_buscado}"
    coincidencias.each do |libro|
      puts libro.to_s
    end
  else
    puts "\nNo se encontraron registros con el libro: #{titulo_buscado}"
  end
end

def busqueda_por_precio(array, minimo, maximo)
  if minimo > maximo
    puts "Rango incorrecto. El mínimo excede al máximo."
    return
  end

  coincidencias = []

  array.each do |libro|
    precio = libro.precio
    if precio >= minimo && precio <= maximo
      coincidencias << libro
    end
  end

  if coincidencias.length > 0
    puts "\nRegistros que contienen el rango de precios [#{minimo} - #{maximo}]"
    coincidencias.each do |libro|
      puts libro.to_s
    end
  else
    puts "\nNo se encontraron registros en el rango: [#{minimo} - #{maximo}]"
  end
end

# Lista de libros
lista_libros = [
  Libro.new("La tregua", "Mario Benedetti", 1960, 52000, "Editorial Alfa"),
  Libro.new("Pedro Páramo", "Juan Rulfo", 1955, 48000, "Fondo de Cultura Económica"),
  Libro.new("Rayuela", "Julio Cortázar", 1963, 73000, "Editorial Sudamericana"),
  Libro.new("El túnel", "Ernesto Sabato", 1948, 51000, "Editorial Losada"),
  Libro.new("Los detectives salvajes", "Roberto Bolaño", 1998, 82000, "Editorial Anagrama"),
  Libro.new("Sobre héroes y tumbas", "Ernesto Sabato", 1961, 69000, "Editorial Losada"),
  Libro.new("Santa Evita", "Tomás Eloy Martínez", 1995, 61000, "Editorial Planeta"),
  Libro.new("El entenado", "Juan José Saer", 1983, 57000, "Editorial Seix Barral"),
  Libro.new("La invención de Morel", "Adolfo Bioy Casares", 1940, 54000, "Editorial Losada"),
  Libro.new("El astillero", "Juan Carlos Onetti", 1961, 60000, "Editorial Losada")
]

puts "LISTA DE LIBROS:"
lista_libros.each do |libro|
  puts libro.to_s
end

# Pruebas estáticas
busqueda_por_autor(lista_libros, "sabato")      # pruebas de busqueda
busqueda_por_titulo(lista_libros, "el")         # busquedas de títulos
busqueda_por_precio(lista_libros, 50000, 60000) # debe encontrar varios dentro del rango
busqueda_por_precio(lista_libros, 70000, 71000) # sin resultados
busqueda_por_precio(lista_libros, 80000, 60000) # rango inválido