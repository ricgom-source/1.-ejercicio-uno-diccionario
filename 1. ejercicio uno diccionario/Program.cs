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

            Console.WriteLine(idestudiantes[1]);

            


            }

        }
    }
