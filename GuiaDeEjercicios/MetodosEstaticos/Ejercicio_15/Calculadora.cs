using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
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
                    while ((rta != 'S') && (rta != 's') && (rta != 'N') && (rta != 'n'))//si no es ninguna de estas 'letras'
                    {
                        Console.WriteLine("ERROR,..Reingrese la respuesta 'S' o 'N'");
                        cadena = Console.ReadLine();
                        retorno = ValidaS_N(cadena[0]);
                        return retorno;
                    }

                }
            }

            return retorno;
        }

        static bool Validar(double segundoNumero)//Este método devolverá TRUE si el número es distinto de CERO.
        {
            bool retorno = true;


            if (segundoNumero==0)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool ValidarDouble(string cadena, out double numero)
        {
            return (double.TryParse(cadena, out numero));
        }

        public static bool ValidarEntero(string cadena, out int numero)
        {
            return (int.TryParse(cadena, out numero));
        }


        public static bool ValidarChar(char operacion)
        {
           
            bool retorno = true;

            while ((operacion != '+') && (operacion != '-') && (operacion != '*') && (operacion != '/') && ((operacion != 'X') ||((operacion != 'x'))))//si no es ninguna de estas 'letras'
            {
                retorno = false;
            }

            return retorno;
        }

        public static double Calcular(double primerNumero,double segundoNumero, char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':

                    resultado = primerNumero + segundoNumero;

                    break;

                case '-':

                    resultado = primerNumero - segundoNumero;

                    break;

                case '*':

                    resultado = primerNumero * segundoNumero;

                    break;

                case '/':
                    if (Calculadora.Validar(segundoNumero))
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                   
                    break;
                case 'X':


                    break;
            }


            return resultado;
        }
    }
}
