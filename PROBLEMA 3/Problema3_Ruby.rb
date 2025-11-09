# Problema 3: Operaciones sobre matrices de registros numéricos 

def crear_matriz(fila, columna)
  mat = []
  fila.times do
    mat << Array.new(columna, 0.0)
  end
  mat
end

def imprimir_matriz(mat)
  filas = mat.length
  filas.times do |k|
    puts mat[k].inspect
  end
  puts
end

def sumar_matrices(a, b)
  filas = a.length
  columnas = a[0].length
  resultado = crear_matriz(filas, columnas)
  filas.times do |i|
    columnas.times do |j|
      resultado[i][j] = a[i][j] + b[i][j]
    end
  end
  resultado
end

def multiplicar_matrices(a, b)
  filas_a = a.length
  columnas_a = a[0].length
  filas_b = b.length
  columnas_b = b[0].length
  
  if columnas_a != filas_b
    raise "El número de columnas de A debe ser igual al número de filas de B."
  end
  
  resultado = crear_matriz(filas_a, columnas_b)
  filas_a.times do |i|
    columnas_b.times do |j|
      columnas_a.times do |k|
        resultado[i][j] += a[i][k] * b[k][j]
      end
    end
  end
  resultado
end

# Registros de prueba
m1 = [[1.0, 2.0, 3.0],
      [4.0, 5.0, 6.0]]

m2 = [[1.1, 2.1, 3.1],
      [4.1, 5.1, 6.1]]

m3 = [[1.0, 2.0],
      [3.0, 4.0]]

m4 = [[5.2, 6.2],
      [7.0, 8.0]]

puts "Matriz m1:"
imprimir_matriz(m1)

puts "Matriz m2:"
imprimir_matriz(m2)

m5 = sumar_matrices(m1, m2)

puts "Resultado de sumar m1+m2:"
imprimir_matriz(m5)

puts "Matriz m3:"
imprimir_matriz(m3)

puts "Matriz m4:"
imprimir_matriz(m4)

m6 = multiplicar_matrices(m3, m4)

puts "Resultado de multiplicar m3*m4:"
imprimir_matriz(m6)