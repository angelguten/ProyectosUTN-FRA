/*Ejercicio 16
    Crear la clase Alumno de acuerdo al siguiente diagrama:
        


    a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. 
    Colocarle nombre, apellido y legajo a cada uno de ellos.
    
    b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
    
    c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o iguales a 4,
    caso contrario la inicializará con -1. 
    Para darle un valor a la nota final utilice el método de instancia Next de la clase Random.
    
    d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. 
    La nota final se mostrará sólo si es distinto de -1, 
    caso contrario se mostrará la leyenda "Alumno desaprobado".
 */

using System;

namespace Ejercicio_16
{
    class Program
    {       
        static void Main(string[] args)
        {
            Random nota = new Random();
            //Random nota2 = new Random();
            //Random nota3 = new Random();
            //Random nota4 = new Random();
            //Random nota5 = new Random();
            //Random nota6 = new Random();

            //nota.Next(1, 10);

            Console.WriteLine("\nIngreso de notas de Alumnos\n");

            Alumno alumnoUno = new Alumno();
            alumnoUno.apellido = "Guten";
            alumnoUno.nombre = "Ariel";
            alumnoUno.legajo = 111;

            Alumno alumnoDos = new Alumno();
            alumnoDos.apellido = "Meirelles";
            alumnoDos.nombre = "Juliane";
            alumnoDos.legajo = 222;

            Alumno alumnoTres = new Alumno();
            alumnoTres.apellido = "Guten Meirelles";
            alumnoTres.nombre = "Flockosh";
            alumnoTres.legajo = 333;

            //nota.Next(1, 10);

            alumnoUno.Estudiar(nota.Next(-1,10), nota.Next(-1,10));
            alumnoDos.Estudiar(nota.Next(-1,10), nota.Next(-1,10));
            alumnoTres.Estudiar(nota.Next(-1,10), nota.Next(-1,10)) ;

            Console.WriteLine( alumnoUno.Mostrar());
            Console.WriteLine( alumnoDos.Mostrar());
            Console.WriteLine( alumnoTres.Mostrar());
            
            Console.ReadKey();

        }
    }
}
