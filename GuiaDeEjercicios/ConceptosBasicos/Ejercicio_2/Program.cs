/* Ejercicio_2 
 * 
 * Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
 * Se debe validar que el número sea mayor que cero, 
 * caso contrario, mostrar el mensaje: 
 * "ERROR. 
 * ¡Reingresar número!". 
 * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
 */

using System;
using Ejercicio_1;



namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            double numero = 0;
            Console.WriteLine("Ingrese un numero\n");
            cadena = Console.ReadLine();

            while ((!Validacion.ValidarDouble(cadena, out numero) || numero <= 0))
            {
                //Console.WriteLine("ERROR,..Reingrese el  numero...\n");
                Validacion.mensajeReingresoNumero();
                cadena = Console.ReadLine();
            }

            double cuadrado = 0;
            double cubo = 0;


            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado de {0} es {1}\n",numero,cuadrado);
            Console.WriteLine("El cubo de {0} es {1}\n",numero,cubo);

            Console.ReadKey();
        }
    }
}
