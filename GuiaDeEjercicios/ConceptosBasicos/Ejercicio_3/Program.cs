/* Ejercicio_2 
 * 
 *Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola. 
 *Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
 */


using System;
using Ejercicio_1;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            int numero = 0;

            int resto = 0;
            int contador = 0;

            int inicio = 1;
            bool esPrimo = true;

            Console.WriteLine("Ingrese un numero\n");
            cadena = Console.ReadLine();
            
            while ((!Validacion.ValidarEnteros(cadena, out numero) || numero <= 0))
            {
                Console.WriteLine("ERROR,..Reingrese el  numero...\n");
                cadena = Console.ReadLine();
            }

            int fin = 0;

            for(int i=1;i<=numero;i++)
            {
                fin = i;

                while (( inicio <= fin) &&(esPrimo))
                {
                    resto = fin % inicio;// la fucion modulo (a % b) retorna el resto de a / b
                    if (resto==0)
                    {
                        contador++;
                    }
                    if (contador>2)
                    {
                        esPrimo = false;
                    }
                    inicio++;
                }
                if (esPrimo)
                {
                    Console.WriteLine("\n{0} es primo\n",fin);
                }
                inicio = 1;
                contador = 0;
                esPrimo = true;

            }


            Console.ReadKey();
        }
    }
}
