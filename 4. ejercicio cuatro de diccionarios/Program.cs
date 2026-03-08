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

                else if (codigo == 01057)


                {

                    Console.WriteLine();

                    Console.WriteLine($"Usted ha ingresado el código postal de la ciudad de:_ {ciudades[01057]}");

                    break;
                }

                else if (codigo == 16001)

                {
                    Console.WriteLine();

                    Console.WriteLine($"Usted ha ingresado el código postal de la ciudad de:_ {ciudades[16001]}");

                    break;

                }

                else if (codigo == 12001)

                {
                    Console.WriteLine();

                    Console.WriteLine($"Usted ha ingresado el código postal de la ciudad de:_ {ciudades[16001]}");

                    break;


                }

                else if (codigo == 03001)

                {
                    Console.WriteLine();

                    Console.WriteLine($"Usted ha ingesado el código postal de la ciudad de:_ {ciudades[03001]}");

                    break;


                }

                else 

                {
                    Console.WriteLine();

                    Console.Clear();

                    Console.WriteLine("Usted no ha ingresado un código postal valido");

                    Console.WriteLine("Precione enter para intentarlo nuevamente");

                    Console.ReadKey();

                    Console.Clear();


                }



            }

            while (codigo >= 0);






        }
    }
}
