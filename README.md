#  InventoryApp - Sistema de Gestión de Inventario en C# (.NET Console App)

Este es un proyecto personal desarrollado como práctica para afianzar conocimientos en programación orientada a objetos con C#, utilizando el patrón de diseño MVC (Model-View-Controller) y aplicando buenas prácticas de codificación.

##  Características

- Alta, baja, modificación y visualización de productos.
- Control de stock y precios.
- Asignación automática de ID inicial desde 1000.
- Validación de entradas del usuario.
- Separación lógica de responsabilidades (MVC).
- Interfaz por consola clara y estructurada.
- Manejo de excepciones con mensajes amigables.

##  Tecnologías y conceptos aplicados

- Lenguaje: **C#**
- Arquitectura: **MVC**
- Paradigma: **Programación orientada a objetos (POO)**
- Validaciones: entradas del usuario y reglas de negocio.
- Buenas prácticas: separación de lógica, clases específicas por rol, métodos reutilizables.
- Excepciones controladas con try/catch.

## Estructura del proyecto

InventoryApp/
│
├── Models/
│ └── Product.cs // Clase con atributos y métodos del producto
│
├── Views/
│ └── InventoryView.cs // Interfaz por consola: entradas y salidas
│
├── Services/
│ └── InventoryManager.cs // Lógica de negocio y gestión del inventario
│
├── Controllers/
│ └── InventoryController.cs // Controla el flujo del sistema
│
└── Program.cs // Punto de entrada del programa

## Estado del Proyecto

**En desarrollo**

Este proyecto se encuentra en una primera versión funcional. En próximas actualizaciones se planea:

- Persistencia de datos (por archivo JSON o conexión a base de datos MySQL).
- Validaciones más robustas.
- Filtros y ordenamiento de productos.
- Interfaz gráfica (Windows Forms o WPF) como evolución futura.

## Cómo Ejecutar

1. Clonar este repositorio.
2. Abrir el proyecto con Visual Studio.
3. Compilar y ejecutar (`F5` o desde consola).


## Autor

**Kevin Botta**  
Estudiante de Análisis de Sistemas y desarrollador en formación.  

https://www.linkedin.com/in/kevinbotta