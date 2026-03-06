using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ejercicio_tres_diccionarios
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Dictionary<string,double> nombreynota = new Dictionary<string,double>();

            nombreynota.Add("Juan", 88.56);

            nombreynota.Add("Roberto", 78.70);

            nombreynota.Add("Lucas", 67.85);

            nombreynota.Add("Carlos", 90.84);

            string nomb;

            Console.Write("Ingrese el nombre del estudiante del cual quiere ver la nota:_ ");

            nomb = Console.ReadLine();

            Console.WriteLine();

            if (nomb=="Juan")

            {

                Console.WriteLine($"La nota de 'Juan' es de:_ {nombreynota["Juan"]} puntos");

            }

            else if (nomb == "Roberto")

            {

                Console.WriteLine($"La nota de 'Roberto' es de:_ {nombreynota["Roberto"]} puntos");

            }

            else if (nomb == "Lucas")

            {

                Console.WriteLine($"La nota de 'Lucas' es de:_ {nombreynota["Lucas"]} puntos");

            }





        }
    }
}
