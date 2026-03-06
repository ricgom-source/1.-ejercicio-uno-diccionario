using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _1.ejercicio_uno_diccionario
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Dictionary<int,string> idestudiantes = new Dictionary<int,string>();

            idestudiantes.Add(12345, "Ricardo");

            idestudiantes.Add(21367, "Juan");

            idestudiantes.Add(30754, "Carlos");

            idestudiantes.Add(48763, "Otto");

            Console.WriteLine("Usted ha ingresado a la minibase de datos de estudiantes");

            Console.WriteLine();

            Console.WriteLine("Los estudiantes son los siguientes:_");

            foreach(var item in idestudiantes)

            {
                Console.WriteLine();

                Console.WriteLine($"El estudiante con número de carnet {item.Key} es:_ {item.Value} ");

                Console.WriteLine();


            }

            


            }

        }
    }
