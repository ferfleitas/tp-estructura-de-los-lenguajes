# Problema 3: Operaciones sobre matrices de registros numéricos 

def crearMatriz(fila, columna):
    mat = []
    for k in range(fila):
        mat.append([0.0] * columna)
    return mat

def imprimirMatriz(mat):
    filas = len(mat)
    for k in range(filas):
        print(mat[k])
    print()

def sumarMatrices(A, B):
    filas = len(A)
    columnas = len(A[0])
    resultado = crearMatriz(filas, columnas)
    for i in range(filas):
        for j in range(columnas):
            resultado[i][j] = A[i][j] + B[i][j]
    return resultado

def multiplicarMatrices(A, B):
    filas_A = len(A)
    columnas_A = len(A[0])
    filas_B = len(B)
    columnas_B = len(B[0])
    if columnas_A != filas_B:
        raise ValueError("El número de columnas de A debe ser igual al número de filas de B.")
    resultado = crearMatriz(filas_A, columnas_B)
    for i in range(filas_A):
        for j in range(columnas_B):
            for k in range(columnas_A):
                resultado[i][j] += A[i][k] * B[k][j]
    return resultado

# Registros de prueba
m1 = [[1.0, 2.0, 3.0],
      [4.0, 5.0, 6.0]] 
m2 = [[1.1, 2.1, 3.1],
      [4.1, 5.1, 6.1]]

m3 = [[1.0, 2.0],
      [3.0, 4.0]]

m4 = [[5.2, 6.2],
      [7.0, 8.0]]

print("Matriz m1:")
imprimirMatriz(m1)

print("Matriz m2:")
imprimirMatriz(m2)

m5 = sumarMatrices(m1,m2)

print("Resultado de sumar m1+m2:")
imprimirMatriz(m5)

print("Matriz m3:")
imprimirMatriz(m3)

print("Matriz m4:")
imprimirMatriz(m4)

m6 = multiplicarMatrices(m3, m4)

print("Resultado de multiplicar m3*m4:")
imprimirMatriz(m6)


