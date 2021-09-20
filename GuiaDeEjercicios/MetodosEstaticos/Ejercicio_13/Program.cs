/*Ejercicio 13
 
    Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): 
    
    string DecimalBinario(int). 
    Convierte un número de entero a binario. 
    
    int BinarioDecimal(string). 
    Convierte un número binario a entero.
   
    NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
 
 
 */

using System;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool seguir = true;
            string cadena = "";
            int numero = 0;

            bool esBinario = false;

            while (seguir)
            {
                Console.Clear();

                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine("\n1 - BINARIO ---->DECIMAL\n");
                Console.WriteLine("\n2 - DECIMAL ---->BINARIO\n");
                Console.WriteLine("\n3 - SALIR\n");
                Console.WriteLine("\n------------------------------\n");
           
                Console.WriteLine("\n\nIngrese el nummero de la operacion que desea realizar\n\n");
                while (!(Conversor.ValidarEntero(Console.ReadLine(),out numero)))
                {
                    Console.WriteLine("\nERROR,...Reingrese el numero de operacion\n");
                }

                switch (numero)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n1 - BINARIO---- > DECIMAL\n");
                        Console.WriteLine("\n\nIngrese el nummero BINARIO que desea CONVERTIR A DECIMAL\n\n");
                        cadena = Console.ReadLine();

                        while (!Conversor.ValidaDigito(cadena))
                        {
                            Console.WriteLine("\n\nERROR..Reingrese el nummero BINARIO que desea CONVERTIR A DECIMAL, USANDO SOLAMENTE 1 y O\n\n");
                            cadena = Console.ReadLine();
                        }

                        numero=Conversor.BinarioDecimal(cadena);

                        Console.WriteLine("\n el numero {0} Binario se expresa como el numero decimal {1} \n",cadena,numero);

                    break;
                    
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n2 - DECIMAL ---->BINARIO\n");

                        Console.WriteLine("\n\nIngrese el nummero DECIMAL que desea CONVERTIR A BINARIO\n\n");
                        cadena = Console.ReadLine();

                        while (!Conversor.ValidarEntero(cadena,out numero))
                        {
                            Console.WriteLine("\n\nERROR..Reingrese el nummero DECIMAL que desea CONVERTIR A BINARIO\n\n");
                            cadena = Console.ReadLine();
                        }

                        cadena = Conversor.DecimalBinario(numero);

                        Console.WriteLine("\n el numero {0} decimal se expresa como el numero Binario {1} \n",numero ,cadena);

                        break;
                    
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n3 - SALIR\n");

                        Console.WriteLine("\nDesea seguir? S/N\n");
                        cadena = Console.ReadLine();
                        seguir = Conversor.Seguir( cadena[0]);

                        break;


                    default:
                        break;
                }
                Console.ReadKey();
            }
            

        }
    }
}
