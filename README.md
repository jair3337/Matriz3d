# Matriz 3D

## Generalidades

- Se realiza proyecto bajo capas separando los diferentes elementos en una capa Domain que contiene los objetos DTO
- Se trabaja bajo una persistencia en memoria con una variable estática (Variable de clase) para que los valores se mantengan
- se trabaja una capa de services que contendrá los servicios que la capa de presentación (UI) consumirá mediante servicios en Angular JS


## Descrpción del proyecto

El desarrollo se basa en la prueba "Cube Summation" cuya url es la sigueinte: 

https://www.hackerrank.com/challenges/cube-summation/problem

Una matríz inicializada en cero, se debe poder actualizar cierto vector con un valor específico y despues, al consultar por un rango de
vectores, sumar los valores guardados en la matriz

___


## Cómo se realizó

Se trabajó en una matríz en una capa Domain, a su vez se gestionó mediante servicios las diferentes necesidades de esta, (Instanciar 
e iniciar la matriz, actualizar un vector específico, obtener la suma de ciertos rangos todos mediante servicios API)

La capa de presentación cuenta con Angular 1.6 que consume los servicios expuestos en el proyecto Services, mediante los Services de Angular
inyectados a un controlador.

La vista contiene:

- 1 input que ingresa un valor entero para inicializar la matríz N
- 1 input para gestionar la cantidad de casos
- 1 select para seleccionar el tipo de query que se quiere ejecutar (Update, Query)
- 4 input number para incluir los valores de x, y, z y un valor al momento de actualizar un vector
- 6 input number para incluir el rango de valores en la matriz generada

