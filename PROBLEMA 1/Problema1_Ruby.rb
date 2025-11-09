# Problema 1: Clasificación y filtrado de registros 

class Alumno
  attr_accessor :nombre, :edad, :carrera, :promedio

  def initialize(nombre, edad, carrera, promedio)
    @nombre = nombre
    @edad = edad
    @carrera = carrera
    @promedio = promedio
  end

  def to_s
    "Nombre: #{@nombre}, Edad: #{@edad}, Carrera: #{@carrera}, Promedio: #{@promedio}"
  end
end

# Función quicksort para promedio
def partir(array, inicio, final)
  pivot = array[final].promedio
  i = inicio - 1

  (inicio...final).each do |j|
    if array[j].promedio <= pivot
      i += 1
      array[i], array[j] = array[j], array[i]
    end
  end
  array[i + 1], array[final] = array[final], array[i + 1]
  i + 1
end

def quick_sort(array, inicio, final)
  if inicio < final
    pi = partir(array, inicio, final)
    quick_sort(array, inicio, pi - 1)
    quick_sort(array, pi + 1, final)
  end
end

# Filtrar por promedio (default >= 4)
def filtrar_por_promedio(array, prom = 4)
  flag = false
  array.each do |alumno|
    if alumno.promedio >= prom
      puts alumno.to_s
      flag = true
    end
  end
  puts "No hay alumnos con promedio mayor o igual a #{prom}" unless flag
end

# Ordenar lista por promedio ascendente
def ordenar_por_promedio(array)
  quick_sort(array, 0, array.length - 1)
end

# Lista de alumnos
lista_alumnos = [
  Alumno.new("Fernando", 21, "IIN", 3.69),
  Alumno.new("Marcos", 21, "IEK", 5),
  Alumno.new("Juan", 20, "IMK", 4.50),
  Alumno.new("Ana", 23, "LCIK", 3.80),
  Alumno.new("Luis", 21, "ISP", 4.00),
  Alumno.new("Sofia", 22, "IIN", 4.20),
  Alumno.new("Carlos", 24, "LEL", 3.70),
  Alumno.new("Lucia", 20, "IEN", 4.10),
  Alumno.new("Pedro", 22, "IIN", 3.90),
  Alumno.new("Valeria", 21, "LCIK", 4.30),
  Alumno.new("Miguel", 23, "IEN", 3.85),
  Alumno.new("Camila", 22, "ISP", 4.25),
  Alumno.new("Jorge", 20, "LGH", 3.95),
  Alumno.new("Paula", 21, "LGH", 4.05),
  Alumno.new("Diego", 23, "LGH", 4.15),
  Alumno.new("Martina", 22, "LGH", 3.90),
  Alumno.new("Andres", 21, "IEN", 4.35),
  Alumno.new("Florencia", 24, "ISP", 4.00),
  Alumno.new("Gabriel", 20, "LCIK", 3.75),
  Alumno.new("Julieta", 22, "LCIK", 4.40),
  Alumno.new("Santiago", 23, "IIN", 3.85),
  Alumno.new("Agustina", 21, "IEL", 4.10),
  Alumno.new("Emiliano", 22, "IEL", 4.20),
  Alumno.new("Micaela", 20, "IIN", 3.80),
  Alumno.new("Tomas", 23, "ICM", 4.05)
]

# Imprimir lista original
puts "LISTA DE ALUMNOS:"
lista_alumnos.each { |alumno| puts alumno.to_s }

# Ordenar por promedio
puts "\nORDENADO POR PROMEDIO ASCENDENTE:"
ordenar_por_promedio(lista_alumnos)
lista_alumnos.each { |alumno| puts alumno.to_s }

# Filtrar por promedio
puts "\nFILTRAR POR PROMEDIO >= 4"
filtrar_por_promedio(lista_alumnos)

puts "\nFILTRAR POR PROMEDIO >= 4.5"
filtrar_por_promedio(lista_alumnos, 4.5)

puts "\nFILTRAR POR PROMEDIO >= 5"
filtrar_por_promedio(lista_alumnos, 5)