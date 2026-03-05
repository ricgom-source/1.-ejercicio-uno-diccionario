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

            idestudiantes.Add(1, "Ricardo");

            idestudiantes.Add(2, "Juan");

            idestudiantes.Add(3, "Carlos");

            idestudiantes.Add(4, "Otto");

            Console.WriteLine("Usted ha ingresado a la minibase de datos de estudiantes");

            Console.WriteLine();

            Console.Write("Ingrese el id del estudiante que usted quiera para ver su nombre:");

            int ing = int.Parse(Console.ReadLine());

            foreach (var item in idestudiantes)

            {

                if (ing < 0 || ing > 4)

                {

                    Console.WriteLine();

                    Console.WriteLine("Usted no ha ingresado un dato valido");

                    Console.ReadKey();

                    Console.Clear();

                    break;

                }

                else if (ing == 1)

                {

                    Console.WriteLine();

                    Console.WriteLine($"El estudiante con numero de carnet {1}, su nombre es:{item.Value} ");

                }


            }





        }
    }
}
