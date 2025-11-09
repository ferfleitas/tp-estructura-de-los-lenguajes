# Trabajo Práctico: Estructura de los Lenguajes de Programación

## Descripción del Proyecto

Este proyecto es un trabajo práctico académico de la **Universidad Nacional de Asunción - Facultad Politécnica** para el curso de **Estructura de los Lenguajes**. Su objetivo principal es familiarizar a los estudiantes con diferentes lenguajes de programación, permitiendo comparar cómo se manejan conceptos fundamentales como:

- Sentencias de asignación
- Control de flujo
- Tipos de datos
- Subrutinas/Funciones
- Control de errores
- Estructuras de datos compuestas

## Objetivos de Aprendizaje

- Explicar los conceptos y usos de diferentes lenguajes de programación
- Aplicar criterios y características para evaluar lenguajes de programación
- Comparar estructuras de control en distintos lenguajes
- Identificar características particulares que hacen especial a cada lenguaje
- Comprender la implementación de algoritmos clásicos en múltiples lenguajes

## Lenguajes Utilizados

El proyecto ha sido implementado en los siguientes lenguajes:

| Lenguaje             | Versión | Uso                                      |
| -------------------- | -------- | ---------------------------------------- |
| **Python**     | 3.x      | Programación orientada a objetos        |
| **C#**         | .NET     | Desarrollo con tipos estrictos           |
| **Go**         | 1.x      | Lenguaje compilado con performance       |
| **JavaScript** | ES6+     | Ejecución en entorno de Node.js         |
| **Ruby**       | 2.x/3.x  | Lenguaje dinámico con sintaxis elegante |

## Estructura del Proyecto

```
tp-estructura-de-los-lenguajes/
├── PROBLEMA 1/
│   ├── Problema1_Python.py
│   ├── Problema1_CSharp.cs
│   ├── Problema1_Go.go
│   ├── Problema1_JavaScript.js
│   └── Problema1_Ruby.rb
├── PROBLEMA 2/
│   ├── Problema2_Python.py
│   ├── Problema2_CSharp.cs
│   ├── Problema2_Go.go
│   ├── Problema2_JavaScript.js
│   └── Problema2_Ruby.rb
├── PROBLEMA 3/
│   ├── Problema3_Python.py
│   ├── Problema3_CSharp.cs
│   ├── Problema3_Go.go
│   ├── Problema3_JavaScript.js
│   └── Problema3_Ruby.rb
├── README.md
└── leame.txt
```

## Problemas Implementados

### **Problema 1: Clasificación y Filtrado de Registros**

#### Descripción

Implementación de un sistema de gestión de registros de estudiantes con funcionalidades de ordenamiento y filtrado.

#### Características

- Creación de registros con múltiples atributos (nombre, edad, carrera, promedio académico)
- Algoritmo de ordenamiento personalizado basado en QuickSort
- Ordenamiento por promedio académico en orden ascendente
- Filtrado de registros según criterios específicos (promedio mínimo)
- Manejo de casos sin coincidencias
- **No utiliza funciones integradas** de ordenamiento ni filtrado

#### Conceptos Demostrados

- Estructuras de datos compuestas (objetos/clases)
- Acceso a atributos múltiples
- Control de flujo (bucles, condicionales)
- Algoritmos de ordenamiento
- Métodos/Funciones

---

### **Problema 2: Búsqueda Secuencial con Validación**

#### Descripción

Sistema de búsqueda avanzada en estructuras de datos complejas con manejo robusto de errores.

#### Características

- Definición de estructuras complejas (libros con múltiples campos)
- Implementación de búsqueda secuencial personalizada
- Búsqueda flexible con múltiples criterios
- Control de errores comprensivo:
  - Manejo de lista vacía
  - Validación de resultados no encontrados
  - Mensajes de error descriptivos
- **No utiliza funciones integradas** de búsqueda

#### Conceptos Demostrados

- Estructuras de datos complejas
- Control de flujo condicional
- Manejo de excepciones/errores
- Búsqueda algoritmica
- Validación de entrada

---

### **Problema 3: Operaciones sobre Matrices**

#### Descripción

Implementación manual de operaciones matemáticas sobre matrices de números decimales.

#### Características

- Creación de matrices con dimensiones compatibles
- Suma de matrices (misma dimensión)
- Multiplicación de matrices (dimensiones compatibles)
- Verificación automática de compatibilidad dimensional
- Manejo de errores para dimensiones incompatibles
- **Sin uso de librerías externas** de álgebra lineal (NumPy, etc.)

#### Conceptos Demostrados

- Estructuras de datos bidimensionales (matrices)
- Algoritmos matemáticos
- Control de flujo anidado
- Validación de datos
- Operaciones complejas multi-nivel

---

## Cómo Ejecutar los Programas

Consulta el archivo `leame.txt` para instrucciones detalladas de instalación y ejecución de cada lenguaje.

### Resumen Rápido

#### **Python**

```bash
python Problema1_Python.py
```

#### **C#**

```bash
# Crear proyecto (primera vez)
dotnet new console -n MiApp
cd MiApp

# Ejecutar
dotnet run
```

#### **Go**

```bash
go run Problema1_Go.go
```

#### **JavaScript**

```bash
node Problema1_JavaScript.js
```

#### **Ruby**

```bash
ruby Problema1_Ruby.rb
```

### Alternativa en Línea

Para ejecutar sin instalación local, utiliza compiladores online:

- [OnlineGDB](https://www.onlinegdb.com/)
- [Go Playground](https://go.dev/play/)
- [Try Ruby](https://try.ruby-lang.org/)

## Comparación de Lenguajes

### Criterios de Evaluación (Sebesta)

| Criterio                         | Python    | C#        | Go        | JavaScript | Ruby      |
| -------------------------------- | --------- | --------- | --------- | ---------- | --------- |
| **Facilidad de Uso**       | Muy Alto  | Alto      | Medio     | Alto       | Muy Alto  |
| **Eficiencia**             | Medio     | Muy Alto  | Muy Alto  | Medio      | Bajo      |
| **Expresividad**           | Muy Alto  | Alto      | Medio     | Alto       | Muy Alto  |
| **Abstracción**           | Muy Alto  | Muy Alto  | Medio     | Alto       | Muy Alto  |
| **Verificación de Tipos** | Dinámica | Estática | Estática | Dinámica  | Dinámica |

### Características Particulares

#### **Python**

- Sintaxis intuitiva y legible
- Tipado dinámico y flexible
- Rica comunidad científica
- Ideal para prototipado rápido

#### **C#**

- Tipado fuerte y seguro
- Excelente ecosistema .NET
- Alto rendimiento
- Manejo robusto de excepciones

#### **Go**

- Compilado, muy rápido
- Sintaxis limpia y simple
- Excelente para concurrencia
- Performance excepcional

#### **JavaScript**

- Ejecución en cualquier navegador/Node.js
- Amplia comunidad de desarrollo
- Tipado dinámico flexible
- Ecosistema npm masivo

#### **Ruby**

- Sintaxis elegante y expresiva
- Enfoque en productividad
- Código limpio y legible
- Más lento que lenguajes compilados

## Observaciones y Conclusiones

### Hallazgos Principales

1. **Tipado Dinámico vs Estático**: Python, Ruby y JavaScript ofrecen flexibilidad, mientras que C# y Go ofrecen seguridad en tiempo de compilación.
2. **Orientación a Objetos**: Todos los lenguajes implementan POO de manera efectiva, pero con diferentes enfoques filosóficos.
3. **Control de Flujo**: Go y C# tienen estructura más rigurosa; Python y Ruby son más permisivos.
4. **Performance**: Go y C# demuestran superioridad en velocidad de ejecución; Python es más lento pero más legible.
5. **Expresividad del Código**: Ruby y Python logran los algoritmos más concisos; Go favorece la claridad explícita.

## Notas Importantes

- **Trabajo Individual**: Este proyecto fue realizado completamente desde cero sin copias directas
- Se utilizaron tutoriales como referencia, pero todo el código es original
- Se documentó el aprendizaje de cada lenguaje
- Se cumplieron todos los requisitos sin usar funciones integradas prohibidas

## Referencias

- Sebesta, R. W. (2019). *Concepts of Programming Languages* (12th ed.). Pearson.
- Documentación oficial de cada lenguaje
- Tutorial de Python: https://docs.python.org/3/
- Tutorial de C#: https://learn.microsoft.com/en-us/dotnet/csharp/
- Tutorial de Go: https://go.dev/doc/
- Tutorial de JavaScript: https://developer.mozilla.org/en-US/docs/Web/JavaScript/
- Tutorial de Ruby: https://ruby-doc.org/

## Reflexión Final

Este proyecto permitió una experiencia práctica y comparativa valiosa. **Python destaca por su balance entre legibilidad y funcionalidad**, siendo ideal para desarrollo rápido. **Ruby es igualmente expresivo pero menos popular en la industria**. **Go impresiona por su rendimiento y simplicidad** en la sintaxis. **C# es muy completo** con un ecosistema robusto. **JavaScript es indispensable** en desarrollo web.

La elección del lenguaje depende del contexto: educativo (Python), empresarial (C#), sistemas (Go), web (JavaScript) o prototipado rápido (Ruby).

---

**Autor**: Fernando Fleitas
**Curso**: Estructura de los Lenguajes - Facultad Politécnica - UNA
**Año**: 2025
