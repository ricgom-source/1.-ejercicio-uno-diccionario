using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ejercicio_cuatro_de_diccionarios
{
    internal class Program
    {
        static void Main(string[] args)


        {

            Dictionary<int, string> ciudades = new Dictionary<int, string>();

            int codigo;

            ciudades.Add(09001, "Quetzaltenango");

            ciudades.Add(01057, "Mixco");

            ciudades.Add(16001, "Cobán");

            ciudades.Add(12001, "San Marcos");

            ciudades.Add(03001, "Antigua Guatemala");

            do
            {

                Console.Write("Ingrese un código postal de alguna ciudad conocida de Guatemala:_ ");

                codigo = int.Parse(Console.ReadLine());

                if (codigo == 09001)

                {
                    Console.WriteLine();

                    Console.WriteLine($"Usted ha ingresado el código postal de la ciudad de :_ {ciudades[09001]}");

                    break;


                }



            }

            while (codigo >= 0);






        }
    }
}
