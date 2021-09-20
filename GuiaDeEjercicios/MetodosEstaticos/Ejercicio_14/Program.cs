/*Ejercicio 14
 Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que 
realicen el cálculo del área que corresponda:

a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)

El ingreso de los datos como la visualización se deberán realizar desde el método Main().

*/
using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado = 0;
            double b = 0;
            double altura = 0;
            double radio = 0;

            double numero = 0;
            string cadena = "";

            int op = 0;
            bool seguir = true;
            

            while (seguir)
            {
                Console.Clear();

                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine("\n1 - CUADRADO\n");
                Console.WriteLine("\n2 - TRIANGULO\n");
                Console.WriteLine("\n3 - CIRCUNFERENCIA\n");

                Console.WriteLine("\n4 - SALIR\n");
                Console.WriteLine("\n------------------------------\n");

                Console.WriteLine("\n\nIngrese el nummero de la operacion que desea realizar\n\n");


                while (!(CalculoDeArea.ValidarEntero(Console.ReadLine(), out op)))
                {
                    Console.WriteLine("\nERROR,...Reingrese el numero de operacion\n");
                }

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n1 - CUADRADO\n");

                        Console.WriteLine("\nIngrese un lado\n");

                        while (!(CalculoDeArea.ValidarDouble(Console.ReadLine(), out lado)))
                        {
                            Console.WriteLine("\nERROR.... Reingrese un numero...\n");

                        }

                        numero = CalculoDeArea.CalcularCuadrado(lado);

                        Console.WriteLine("\nEl CUADRADO de lado {0} tiene un AREA de  {1} \n",lado,numero);

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n2 - TRIANGULO\n");

                        Console.WriteLine("\nIngrese LA BASE DEL TRIANGULO\n");

                        while (!(CalculoDeArea.ValidarDouble(Console.ReadLine(), out b)))
                        {
                            Console.WriteLine("\nERROR.... Reingrese un numero...\n");

                        }

                        Console.WriteLine("\nIngrese LA ALTURA DEL TRIANGULO\n");

                        while (!(CalculoDeArea.ValidarDouble(Console.ReadLine(), out altura)))
                        {
                            Console.WriteLine("\nERROR.... Reingrese un numero...\n");

                        }

                        numero = CalculoDeArea.CalcularTriangulo(b,altura);

                        Console.WriteLine("\nEl TRIANGULO de base {0} y altura {1} tiene un AREA de  {2} \n", b, altura,numero);

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n1 - CIRCUNFERENCIA\n");

                        Console.WriteLine("\nIngrese el RADIO\n");

                        while (!(CalculoDeArea.ValidarDouble(Console.ReadLine(), out radio)))
                        {
                            Console.WriteLine("\nERROR.... Reingrese un numero...\n");

                        }

                        numero = CalculoDeArea.CalcularCirculo(radio);

                        Console.WriteLine("\nLa CIRCUNFERENCIA de radio {0} tiene un AREA de  {1} \n", radio, numero);

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n3 - SALIR\n");

                        Console.WriteLine("\nDesea seguir? S/N\n");
                        cadena = Console.ReadLine();
                        seguir = CalculoDeArea.ValidaS_N(cadena[0]);

                        break;


                    default:
                        break;
                }
                Console.ReadKey();
            }



        }
    }
}
