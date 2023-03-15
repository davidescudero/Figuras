// crear una interface de tipo figura para asignar lados y calcular areas y crear las clases y metodos necesarios
using Figura;

Cuadrado cuadrado = new Cuadrado();
Triangulo triangulo = new Triangulo(10,5);



cuadrado.alto = 10;
cuadrado.ancho = 10;



Console.WriteLine("El area del cuadrado es "+ cuadrado.area());
Console.WriteLine("El area del triangulo es "+ triangulo.area());