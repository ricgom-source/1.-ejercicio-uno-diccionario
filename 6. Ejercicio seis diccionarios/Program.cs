using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Ejercicio_seis_diccionarios
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Dictionary<int,string> alumnos = new Dictionary<int,string>();

            int carnet;

            alumnos.Add(1221, "Lucas");

            alumnos.Add(4554, "Mario");

            alumnos.Add(7887, "Jose");

            Console.WriteLine("Los alumnos registrados son los siguientes:_ ");

            Console.WriteLine();

            foreach (var item in alumnos)

            {
                Console.WriteLine($"alumno con No. de carnet: {item.Key} , su nombre es: {item.Value}");

                Console.WriteLine();

            }

            Console.WriteLine();

            Console.Write("Ingrese el número de carnet del estudiante que quiera eliminar:_ ");

            carnet = int.Parse(Console.ReadLine());

            alumnos.Remove(carnet);

            Console.WriteLine();

            Console.WriteLine($"usted ha eliminado al alumno con No. de carnet {carnet}");

            Console.WriteLine();

            Console.WriteLine("Los alumnos restantes son:");

            Console.WriteLine();

            foreach(var newitem in alumnos)

            {
                Console.WriteLine($"alumno con No. de carnet: {newitem.Key}, su nombre es: {newitem.Value}");

                Console.WriteLine();


            }

           





        }
    }
}
