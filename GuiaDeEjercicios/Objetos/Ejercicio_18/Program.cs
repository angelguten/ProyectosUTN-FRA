using System;
using Geometria;

namespace GeometriaPrueba

{
    class Program
    {
        static void Main(string[] args)
        {
            int anchoDeBase=0;
            int altura=0;
            int x_Inicio=0;
            int y_Inicio=0;
            int x_Fin = 0;
            int y_Fin = 0;

            string cadena = "";
            int numero = 0;


            Console.WriteLine("RECTANGULO");

            Console.WriteLine("\nIngrese el primer punto de la base\n");
            cadena = Console.ReadLine();

            while (!(DibujarFigura.ValidarEntero(cadena, out numero)))
            {
                Console.WriteLine("\nERROR..Reingrese el primer punto de la base\n");
                cadena = Console.ReadLine();
            }
            x_Inicio = numero;

            Console.WriteLine("\nIngrese el segundo punto de la base\n");
            cadena = Console.ReadLine();

            while (!(DibujarFigura.ValidarEntero(cadena, out numero)))
            {
                Console.WriteLine("\nERROR..Reingrese el segundo punto de la base\n");
                cadena = Console.ReadLine();
            }
            y_Inicio = numero;

            Console.WriteLine("\nIngrese el primer punto de la altura\n");
            cadena = Console.ReadLine();

            while (!(DibujarFigura.ValidarEntero(cadena, out numero)))
            {
                Console.WriteLine("\nERROR..Reingrese el primer punto de la altura\n");
                cadena = Console.ReadLine();
            }
            x_Fin = numero;

            Console.WriteLine("\nIngrese el segundo punto de la altura\n");
            cadena = Console.ReadLine();

            while (!(DibujarFigura.ValidarEntero(cadena, out numero)))
            {
                Console.WriteLine("\nIngrese el primer punto de la altura\n");
                cadena = Console.ReadLine();
            }
            y_Fin = numero;

            Rectangulo unRectangulo = new Rectangulo(new Punto(x_Inicio, y_Inicio), new Punto(x_Fin, y_Fin));

            anchoDeBase = (int)unRectangulo.BaseRectangulo;

            Console.Clear();

            DibujarFigura.DibujarRectangulo(anchoDeBase, (int)unRectangulo.AlturaRectangulo, x_Inicio, y_Inicio);

            Console.ReadKey();
        }
    }
}
