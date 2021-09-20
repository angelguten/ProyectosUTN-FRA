using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char rta)
        {
            bool retorno = false;
            string cadena = "";

            if ((rta == 'S') || (rta == 's'))
            {
                retorno = true;
            }
            else
            {
                if (rta == 'N' || rta == 'n')//si es cualquiera de estas 'letras'
                {
                    retorno = false;
                }
                else
                {
                    while((rta != 'S') && (rta != 's') && (rta != 'N') &&( rta != 'n'))//si no es ninguna de estas 'letras'
                    {
                        Console.WriteLine("ERROR,..Reingrese la respuesta 'S' o 'N'");
                        cadena=Console.ReadLine();
                        retorno= ValidaS_N( cadena[0]);
                        return retorno;
                    }
                    
                }
            }

            return retorno;
        }
    }
}
