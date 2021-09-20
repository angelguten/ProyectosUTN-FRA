/*Ejercicio 15
    Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

    Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar 
    (pulsando el caracter +, -, * ó /). 
    El usuario decidirá cuándo finalizar el programa. 
    
    Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

    a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática. 
    El método devolverá el resultado de la operación.

    b. Validar (privado): Recibirá como parámetro el segundo número. 
    Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
    Este método devolverá TRUE si el número es distinto de CERO.
*/
using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double primerNumero = 0;
            double segundoNumero = 0;
            char operacion = ' ';

            double resultado = 0;
            string cadena = "";

            char opcion = ' ';
            bool seguir = true;

            while (seguir)
            {
                Console.Clear();

                Console.WriteLine("\n------------------------------\n");
                Console.WriteLine("\n*  SUMA\n");
                Console.WriteLine("\n+  RESTA\n");
                Console.WriteLine("\n-  MULTIPLICACION\n");
                Console.WriteLine("\n/  DIVISION\n");

                Console.WriteLine("\nX - SALIR\n");
                Console.WriteLine("\n------------------------------\n");



                Console.WriteLine("\n\nIngrese el primer numero\n\n");


                while (!(Calculadora.ValidarDouble(Console.ReadLine(), out primerNumero)))
                {
                    Console.WriteLine("\nERROR,...Reingrese el primer numero\n");
                }


                Console.WriteLine("\n\nIngrese la operacion que desea realizar\n\n");

                cadena = Console.ReadLine();
                operacion = cadena[0];

                while (!(Calculadora.ValidarChar(operacion)))
                {
                    Console.WriteLine("ERROR,..Reingrese la operacion '+' , '-', '*', '/' ,'X' ");
                    cadena = Console.ReadLine();
                    operacion = cadena[0];

                }

               
                    Console.WriteLine("\n\nIngrese el segundo numero\n\n");

                    if (operacion == '/')
                    {
                        while (!(Calculadora.ValidarDouble(Console.ReadLine(), out segundoNumero)) && (segundoNumero > 0))
                        {
                            Console.WriteLine("\nERROR,...Reingrese el segundo numero\n");
                        }
                    }
                    else
                    {
                        while (!(Calculadora.ValidarDouble(Console.ReadLine(), out segundoNumero)))
                        {
                            Console.WriteLine("\nERROR,...Reingrese el segundo numero\n");
                        }
                    }

                    switch (operacion)
                    {
                        case '+':

                            Console.Clear();
                            Console.WriteLine("\n1 - SUMA\n");


                            resultado = Calculadora.Calcular(primerNumero, segundoNumero, operacion);
                            Console.WriteLine("({0}) {1} ({2}) = ({3})", primerNumero, operacion, segundoNumero, resultado);
                            break;
                        case '-':

                            Console.Clear();
                            Console.WriteLine("\n1 - RESTA\n");



                            resultado = Calculadora.Calcular(primerNumero, segundoNumero, operacion);
                            Console.WriteLine("({0}) {1} ({2}) = ({3})", primerNumero, operacion, segundoNumero, resultado);

                            break;

                        case '*':
                            Console.Clear();
                            Console.WriteLine("\n1 - MULTIPLICACION\n");

                            resultado = Calculadora.Calcular(primerNumero, segundoNumero, operacion);
                            Console.WriteLine("({0}) {1} ({2}) = ({3})", primerNumero, operacion, segundoNumero, resultado);
                            break;

                        case '/':

                            Console.Clear();
                            Console.WriteLine("\n1 - DIVISION\n");



                            resultado = Calculadora.Calcular(primerNumero, segundoNumero, operacion);
                            Console.WriteLine("({0}) {1} ({2}) = ({3})", primerNumero, operacion, segundoNumero, resultado);

                            break;

                        case 'X':
                            Console.Clear();
                            Console.WriteLine("\n3 - SALIR\n");

                            Console.WriteLine("\nDesea seguir? S/N\n");
                            cadena = Console.ReadLine();
                            seguir = Calculadora.ValidaS_N(cadena[0]);

                            break;

                    }
                    Console.WriteLine("\nDesea seguir? S/N\n");
                    cadena = Console.ReadLine();
                    seguir = Calculadora.ValidaS_N(cadena[0]);

                

            }
        }
    }
}
