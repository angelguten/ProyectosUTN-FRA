/*Ejercicio 2
 * 
 * Un número perfecto es un entero positivo, 
 * que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
 *  
 * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. 
 * 
 * Escribir una aplicación que encuentre los 4 primeros números perfectos. 
 * Nota: Utilizar estructuras repetitivas y selectivas.
 
 
 */

using System;
using Ejercicio_1;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 6;
            int indice = 1;

            int divisor = 0;

            
            int acumuladorDeDivisores = 0;
            int contador = 6;

            bool esDivisor = true;

            for(int i =0;i<4;i++)
            {
                while ((acumuladorDeDivisores != numero) &&(indice < contador))
                {
                    numero = contador;

                    for (indice=1; indice < numero; indice++)
                    {
                        if ((numero%indice)==0)
                        {
                            divisor = indice;
                            acumuladorDeDivisores = acumuladorDeDivisores + divisor;
                        }
                    }

                    acumuladorDeDivisores = 0;
                    contador++;
                }
                Console.WriteLine("\n{0} es un numero perfecto\n", numero);

                divisor = 0;
                
                indice = 1;
            }
        }
    }
}
