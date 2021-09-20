/* Ejercicio_1 
 * 
 * Ingresar 5 números por consola, guardándolos en una variable escalar. 
 * Luego calcular y mostrar: 
 * el valor máximo, el valor mínimo y el promedio.
 */


using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            float numeroDecimal = 0;
            string cantidadNumero = "";
           

            float minimo = 0;
            float maximo = 0;
            float promedio = 0;

            float acumulador = 0;

            bool esPrimero = true;

            Console.WriteLine("¿Cuantos numeros desea ingresar?\n");
            cantidadNumero = Console.ReadLine();

            while ((!Validacion.ValidarEnteros(cantidadNumero, out numero) || numero<=0))
            {
                Console.WriteLine("ERROR,..Reingrese la cantidad de numeros que desea ingresar...\n");
                cantidadNumero = Console.ReadLine();
            }

            for (int i =1;i<=numero;i++)
            {
                Console.WriteLine("Ingrese el {0}° numero\n",i);
               

                while (!Validacion.ValidarDecimal(Console.ReadLine(), out numeroDecimal))
                {
                    Console.WriteLine("ERROR,..Reingrese el {0}° numero...\n",i);
                }



                if (esPrimero)
                {
                    maximo = numeroDecimal;
                    minimo = numeroDecimal;
                    esPrimero = false;
                }
                else if(numeroDecimal < minimo)
                    {
                        minimo = numeroDecimal;
                    }
                    if(numeroDecimal > maximo)
                     {
                         maximo = numeroDecimal;
                     }

                acumulador = acumulador + numeroDecimal;

            }

            promedio = acumulador / numero;

            Console.WriteLine("\nEl maximo es: {0,10:#,###}",maximo);
            Console.WriteLine("\nEl minimo es: {0,10:#,###}", minimo);
            Console.WriteLine("\nEl PROMEDIO es: {0,10:###,####.##}", promedio);

            Console.ReadKey();
        }
        
    }
}
