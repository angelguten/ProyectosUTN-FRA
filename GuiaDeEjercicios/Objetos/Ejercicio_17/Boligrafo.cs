using System;

namespace BoligrafoSpace
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 10;

        private ConsoleColor color;
        private short tinta;

        public ConsoleColor getColor()
        {
            return this.color;
        }
        public short getTinta()
        {
            return this.tinta;
        }

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;//setTinta(tinta);
            this.color = color;
        }

        /// <summary>
        /// Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
        ///  i.tinta será el valor a agregar de tinta, pudiendo ser positivo(cargar tinta) o negativo(gastar tinta)
        ///  
        ///  ii.Se deberá validar que el nivel de tinta 
        ///  quede entre los valores válidos mayor o igual a 0 y menor o igual a cantidadTintaMaxima.
        /// </summary>
        /// <param name="tinta"></param>
        private void setTinta(short tinta)
        {

            short exceso = 0;
            short disponible = this.getTinta();


            if (tinta > 0)// se carga la tinta
            {
                if (((short)(this.tinta + tinta)) <= (cantidadTintaMaxima))
                {
                    this.tinta = (short)(this.tinta + tinta);
                }
                else
                {
                    exceso = (short)(cantidadTintaMaxima - tinta);

                    this.tinta = cantidadTintaMaxima;
                    Console.WriteLine("\nSe cargo el boligrafo al maximo de su capacidad, descartando un excedente de carga de {0}\n", exceso);
                }
            }


            if (tinta < 0)// se gasta tinta
            {
                
                if (((short)(this.tinta + tinta)) >= 0)
                {
                    this.tinta = (short)(this.tinta + tinta);
                }
                else
                {
                    exceso = (short)(this.tinta + tinta);
                    this.tinta = -1;

                    Console.WriteLine("\nSe gasto la totalidad de la tinta del boligrafo, FALTO PINTAR  {0} UNIDADES\n", exceso*(-1));
                    Console.ReadKey();
                }
            }

            
        }


        public void Recarga()
        {
            this.setTinta(cantidadTintaMaxima+1);
        }



        public bool pintar(short gasto, out string dibujo)
        {
            bool retorno = false;

            short disponible = this.getTinta();

            dibujo = "";

            if (disponible > 0)
            {

                short tintaGastada = (short)((-1) * (gasto));
                setTinta(tintaGastada);



                if (this.getTinta() >= 0)
                {
                    for (int i = 0; i < gasto; i++)
                    {
                        dibujo = dibujo + "*";
                    }

                    retorno = true;
                }
                if (this.getTinta() == -1)
                {
                    for (int i = 0; i < disponible; i++)
                    {
                        dibujo = dibujo + "*";
                    }
                    //retorno = true;
                }

            }

            return retorno;
        }

        public bool Validar_char(string cadena)
        {
            bool retorno = true;
            char rta = cadena[0];
         


            if (rta != 'S' && rta != 's' && rta != 'N' && rta != 'n')
            {
                retorno = false;
            }
            return retorno;
        }

        public bool Validar_S(Char rta)
        {
            bool retorno = true;
          

            if ( rta == 'N' || rta == 'n')
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool Validar_charEstatico(string cadena)
        {
            bool retorno = true;
            char rta = cadena[0];

            if (rta != 'S' && rta != 's' && rta != 'N' && rta != 'n' && rta != ' ')
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool Validar_SEstatico(Char rta)
        {
            bool retorno = true;


            if (rta == 'N' || rta == 'n' || rta==' ')
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool TrabajarConBoligrago(Boligrafo unBoligrafo)
        {
            string cadena = "";
            short cantidadPintar = 0;

            bool seguir = true;

            string cadenaPintura = "";

            Console.WriteLine("\nIngrese la cantidad a pintar \n");
            cadena = Console.ReadLine();

            short.TryParse(cadena, out cantidadPintar);

            if (unBoligrafo.pintar(cantidadPintar, out cadenaPintura))
            {
                Console.WriteLine(cadenaPintura);
                Console.WriteLine("\nEl Boligrafo dispone de {0} unidades de tinta\n", unBoligrafo.getTinta());
            }
            else
            {
                Console.WriteLine(cadenaPintura);
                Console.WriteLine("para continuar pintando RECARGUE LA TINTA\n");
            }

            Console.WriteLine("\nDesea seguir pintando? S/N\n");
            cadena = Console.ReadLine();


            while (!(unBoligrafo.Validar_char(cadena)))
            {
                Console.WriteLine("\nDesea seguir pintando? S/N\n");
                cadena = Console.ReadLine();
            }


            seguir = unBoligrafo.Validar_S(cadena[0]);
            if (seguir && unBoligrafo.getTinta() <= 0)
            {
                unBoligrafo.Recarga();
            }

            return seguir;
        }

        public static bool ValidarEntero(string cadena, out int entero)
        {
            return int.TryParse(cadena, out entero);
        }

    }
}
