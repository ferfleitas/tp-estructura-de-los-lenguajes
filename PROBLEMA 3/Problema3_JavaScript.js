// Problema 3: Operaciones sobre matrices de registros numéricos 

function crearMatriz(filas, columnas) {
    const mat = [];
    for (let i = 0; i < filas; i++) {
        mat.push(new Array(columnas).fill(0.0));
    }
    return mat;
}

function imprimirMatriz(mat) {
    for (let fila of mat) {
        console.log(fila);
    }
    console.log();
}

function sumarMatrices(A, B) {
    const filas = A.length;
    const columnas = A[0].length;
    const resultado = crearMatriz(filas, columnas);
    for (let i = 0; i < filas; i++) {
        for (let j = 0; j < columnas; j++) {
            resultado[i][j] = A[i][j] + B[i][j];
        }
    }
    return resultado;
}

function multiplicarMatrices(A, B) {
    const filasA = A.length;
    const columnasA = A[0].length;
    const filasB = B.length;
    const columnasB = B[0].length;

    if (columnasA !== filasB) {
        throw new Error("El número de columnas de A debe ser igual al número de filas de B.");
    }

    const resultado = crearMatriz(filasA, columnasB);
    for (let i = 0; i < filasA; i++) {
        for (let j = 0; j < columnasB; j++) {
            for (let k = 0; k < columnasA; k++) {
                resultado[i][j] += A[i][k] * B[k][j];
            }
        }
    }
    return resultado;
}

// Registros de prueba
const m1 = [
    [1.0, 2.0, 3.0],
    [4.0, 5.0, 6.0]
];

const m2 = [
    [1.1, 2.1, 3.1],
    [4.1, 5.1, 6.1]
];

const m3 = [
    [1.0, 2.0],
    [3.0, 4.0]
];

const m4 = [
    [5.2, 6.2],
    [7.0, 8.0]
];

console.log("Matriz m1:");
imprimirMatriz(m1);

console.log("Matriz m2:");
imprimirMatriz(m2);

const m5 = sumarMatrices(m1, m2);
console.log("Resultado de sumar m1 + m2:");
imprimirMatriz(m5);

console.log("Matriz m3:");
imprimirMatriz(m3);

console.log("Matriz m4:");
imprimirMatriz(m4);

const m6 = multiplicarMatrices(m3, m4);
console.log("Resultado de multiplicar m3 * m4:");
imprimirMatriz(m6);
