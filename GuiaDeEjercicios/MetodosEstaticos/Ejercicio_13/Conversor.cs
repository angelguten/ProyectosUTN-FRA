/*
    string DecimalBinario(int). 
    Convierte un número de entero a binario. 
    
    int BinarioDecimal(string). 
    Convierte un número binario a entero.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string cadena = "";

            int resto = 0;
            int cociente = 3;

            while (cociente != 0)
            {
                cociente=numero/ 2;
                resto = numero % 2;
                numero = cociente;
                cadena = resto + cadena;
            }

            return cadena;
        }
    
         public static int BinarioDecimal(string cadena)
        {
            int numero = 0;
            double n = cadena.Length - 1;
            double acumulador = 0;

            double potencia = 0;

            for (int i=0;i<=n;i++)
            {
                potencia = (n - i);
                int.TryParse(cadena[i].ToString(), out numero);
                acumulador = acumulador + numero *(Math.Pow(2,potencia));
            }
            
            return (int) acumulador;
        }
        public static bool ValidarEntero(string cadena,out int  numero)
        {
            return (int.TryParse(cadena, out numero));
        }

        public static bool ValidaDigito(string cadena)
        {
            bool retorno = true;

            int n = cadena.Length - 1;
            for (int i = 0; i <= n; i++)
            {
                if (cadena[i] != '0' && cadena[i] != '1')
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        public static bool Seguir(char seguir)
        {
            bool retorno = false;

            string cadena = "";

            if (seguir != 'S' && seguir != 's' && seguir != 'N' && seguir != 'n')
            {
                Console.WriteLine("\nERROR..Reingrese si respuesta, S /N\n");
                cadena = Console.ReadLine();

                retorno = Seguir(cadena[0]);
            }
            else
            {
                if (seguir=='S' || seguir=='s')
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            
            }

            return retorno;
        }
    }
    
}

   
