using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        Random nota = new Random();

        //private sbyte nota1;
        //private sbyte nota2;

        public int nota1;
        public int nota2;

        private int notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        /// <summary>
        ///  El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o iguales a 4,
        ///  caso contrario la inicializará con -1. 
        ///  Para darle un valor a la nota final utilice el método de instancia Next de la clase Random.
        /// </summary>
        public void CalcularFinal()
        {
            if ((nota1 >= 4) && (nota2 >= 4))
            {
                this.notaFinal =(nota1 + nota2) / 2; //nota.Next(-1, 10);
            }
            else
            {
                this.nota1 = -1;
                this.nota2 = -1;
            }
        
        }

        /// <summary>
        ///  Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
        /// </summary>
        /// <param name="notaUno"></param>
        /// <param name="notaDos"></param>
        public void Estudiar(int notaUno, int notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        /// <summary>
        /// El método Mostrar, expondrá en la consola todos los datos de los alumnos. 
        /// La nota final se mostrará sólo si es distinto de -1,
        /// caso contrario se mostrará la leyenda "Alumno desaprobado".
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------------------------------------------");
            sb.AppendLine("DATOS PERSONALES");
            sb.AppendLine("-----------------------------------------------");
            sb.AppendLine(this.apellido);
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.legajo.ToString());
            sb.AppendLine("-----------------------------------------------");
            sb.AppendLine("NOTA FINAL");
            sb.AppendLine("-----------------------------------------------");
            if (this.notaFinal != -1)
            {
                sb.AppendLine(this.notaFinal.ToString());
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            
            return sb.ToString();
        }



    }
}
