/*Ejercicio 12
 * 
    Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de un mensaje "¿Continuar? (S/N)".
    En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones.
    El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */

using System;
using Ejercicio_11;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int acumulador = 0;

            string cadena = "";

            bool continuar = true;

            
            while (continuar)
            {
                Console.WriteLine("\nIngrese un numero\n");
                while (!(Validacion.validarEntero(Console.ReadLine(), out numero)))
                {
                    Console.WriteLine("\nERROR.... Reingrese un numero...\n");
                    
                }
                
                acumulador = acumulador + numero;
                Console.WriteLine("\n¿Continuar? (S/N)\n");
                cadena= Console.ReadLine();

                

                continuar=ValidarRespuesta.ValidaS_N( cadena[0]);
            }

            Console.WriteLine("\nLa sumatoria es : {0}\n",acumulador);

            Console.ReadKey();
        }
    }
}
