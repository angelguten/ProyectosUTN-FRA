/*  Ejercicio 11
 *  
    Realizar una clase llamada Validacion que posea un método estático llamado Validar, 
    que posea la siguiente firma: bool Validar(int valor, int min, int max):

    a. valor: dato a validar
    b. min y max: rango en el cual deberá estar la variable valor.

    Pedir al usuario que ingrese 10 números enteros. 
    Validar con el método desarrollado anteriormente que esten dentro del rango -100 y 100. 
    Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio. Nota: 
    Utilizar variables escalares, NO utilizar vectores.
 
 
 */

using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int valorTope = 3;

            int numero = 0;
            int minimo = 0;
            int maximo = 0;

            int acumulador = 0;
            float promedio = 0;


            for (int i = 0; i < valorTope; i++)
            {
                Console.WriteLine("\nIngrese un numero...\n");
               

                while ((!Validacion.validarEntero(Console.ReadLine(), out numero))
                        || !(Validacion.Validar(numero, -100, 100)))
                {
                    Console.WriteLine("\nERROR.... Reingrese un numero...\n");   
                }

                acumulador = acumulador + numero;

                if (i == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }

            }

            promedio = acumulador / valorTope;
            Console.WriteLine("\nMinimo : {0}\n", minimo);
            Console.WriteLine("\nMaximo : {0}\n", maximo);
            Console.WriteLine("\nPromedio : {0} \n",promedio);

            Console.ReadKey();
            
        }
    }
}
