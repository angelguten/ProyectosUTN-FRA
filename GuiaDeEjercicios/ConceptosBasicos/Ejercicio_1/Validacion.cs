using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Validacion
    {
        public static bool ValidarEnteros(string cadena,out int numero)
        {
            return (int.TryParse(cadena, out numero));
        }
        public static bool ValidarDecimal(string cadena, out float numero)
        {
            return (float.TryParse(cadena, out numero));
        }
        public static bool ValidarDouble(string cadena, out double numero)
        {
            return (double.TryParse(cadena, out numero));
        }
        public static void mensajeReingresoNumero()
        {
            Console.WriteLine("ERROR,..Reingrese el  numero...\n");
        }

    }
}
