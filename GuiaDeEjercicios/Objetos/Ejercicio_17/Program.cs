/*Ejercicio 17
 * 
    Crear la clase Bolígrafo a partir del siguiente diagrama:

    a. La cantidad máxima de tinta para todos los bolígrafos será de 100.
    Generar una constante en el Boligrafo llamada cantidadTintaMaxima donde se guardará dicho valor.

    b. Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo retornarán el valor del mismo).

    c. Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.

        i. tinta será el valor a agregar de tinta, pudiendo ser positivo (cargar tinta) o negativo (gastar tinta)
        ii. Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a 0 y menor o igual a cantidadTintaMaxima.

    d. Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.

    e. En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) 
        y una cantidad inicial de tinta de 100 
        y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
        
    
    f. El método Pintar(short, out string) restará la tinta gastada (reutilizar código SetTinta), 
    sin poder quedar el nivel en negativo, avisando si pudo pintar (nivel de tinta mayor a 0). 
    También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de tinta. 
    O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es 10 "***".
   
    g. Utilizar todos los métodos en el Main.
    
    h. Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.

    Nota: Crear el constructor que crea conveniente. La clase Boligrafo y el Program deben estar en namespaces distintos.

 */


using System;
using BoligrafoSpace;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            short cantidadPintar = 0;

            string cadenaPintura = "";

            Console.WriteLine("\nBOLIGRAFOS\n");

           

            Boligrafo boligrafoAzul = new Boligrafo(10, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(5, ConsoleColor.Red);


           
            bool cambiarDeBoligrafo = true;
            int op = 0;

            while (cambiarDeBoligrafo)
            { 
                bool seguir = true;

                Console.Clear();

                Console.WriteLine("\n1 - BOLIGRAFO AZUL");
                Console.WriteLine("2 - BOLIGRAFO ROJO");
                Console.WriteLine("3 - SALIR\n");

                Console.WriteLine("\nIngrese LA OPCION DE BOLIGRAFO CON QUE DESEA PINTAR\n");
                cadena = Console.ReadLine();
                while (!(Boligrafo.ValidarEntero(cadena, out op)))
                {
                    Console.WriteLine("\nERROR...Reingrese LA OPCION DE BOLIGRAFO CON QUE DESEA PINTAR\n");
                    cadena = Console.ReadLine();
                }
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\nBOLIGRAFO AZUL\n");
                        while (seguir)
                        {
                            Console.Clear();
                            seguir = Boligrafo.TrabajarConBoligrago( boligrafoAzul);
                        }
                            break;

                    case 2:
                        Console.WriteLine("\nBOLIGRAFO ROJO\n");
                        Console.Clear();
                        while (seguir)
                        {
                            seguir = Boligrafo.TrabajarConBoligrago(boligrafoRojo);
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nSALIR\n");
                        Console.Clear();
                        Console.WriteLine("\nDesea seguir pintando? S/N\n");
                        cadena = Console.ReadLine();

                       
                        while (!(Boligrafo.Validar_charEstatico(cadena)))
                        {
                            Console.WriteLine("\nDesea seguir pintando? S/N\n");
                            cadena = Console.ReadLine();
                        }

                        cambiarDeBoligrafo = Boligrafo.Validar_SEstatico(cadena[0]);
                        break;
                }
            }           
        }
     }
}



