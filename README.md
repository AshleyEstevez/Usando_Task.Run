# Usando_Task.Run


Este proyecto es un ejemplo práctico del uso de `Task.Run` en C#. El propósito del programa es realizar cálculos de forma asincrónica utilizando tareas para evitar bloquear el hilo principal.

## Descripción

El programa realiza las siguientes operaciones:
1. Utiliza `Task.Run` para ejecutar una tarea en un hilo separado.
2. Calcula la suma de una gran cantidad de números (en este caso, la suma de los primeros 10 millones de números multiplicados por 2).
3. Devuelve el resultado de forma asincrónica y lo imprime en el hilo principal.

El objetivo principal es mostrar cómo `Task.Run` puede utilizarse para operaciones intensivas sin bloquear el flujo del programa.

## Tecnologías

- **Lenguaje:** C#
- **Framework:** .NET 6.0
- **Entorno de desarrollo:** Visual Studio 2022
