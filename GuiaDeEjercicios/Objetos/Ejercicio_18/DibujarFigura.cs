using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class DibujarFigura
    {
        public static void DibujarRectangulo(int anchoDeBase, int altura, int x_Inicio, int y_Inicio)
        {
            int incremento = 0;
            while (incremento < anchoDeBase)
            {
                Console.SetCursorPosition(x_Inicio + incremento, y_Inicio);
                Console.Write("-");
                Console.SetCursorPosition(x_Inicio + incremento, y_Inicio + anchoDeBase);
                Console.Write("-");
                incremento++;
            }
            incremento = 0;
            while (incremento < altura)
            {
                Console.SetCursorPosition(x_Inicio, y_Inicio + incremento);
                Console.Write("|");
                Console.SetCursorPosition(x_Inicio + anchoDeBase, y_Inicio + incremento);
                Console.Write("|");
                incremento++;
            }
        }

        public static bool ValidarEntero(string cadena, out int entero)
        {
            return int.TryParse(cadena, out entero);
        }
    }
}
