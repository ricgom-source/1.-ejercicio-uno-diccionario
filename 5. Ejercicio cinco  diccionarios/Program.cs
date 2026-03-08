using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Ejercicio_cinco__diccionarios
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Dictionary<string, string> usuariocontra = new Dictionary<string, string>();

            string usua;

            string contra;

            string us;

            int contreg = 0;

            int opcion;

            do
            {
                Console.WriteLine("Bienvenido a minimenú de Usuarios y contraseñas");

                Console.WriteLine();

                Console.WriteLine("1. registrar usuario y contraseña");

                Console.WriteLine();

                Console.WriteLine("2. Mostrar usuarios y contraseñas registrados");

                Console.WriteLine();

                Console.WriteLine("3. Salir del menú");

                Console.WriteLine();

                Console.Write("Seleccione la opcion que quiera utilizar:_ ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)

                {

                    case 1:

                        Console.Clear();

                        Console.WriteLine("Bienvenido a submenu registrar usuario y contraseña");

                        Console.WriteLine();

                        Console.Write("Ingrese el nombre de usuario que desea registrar:_ ");

                        usua = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Ingrese la contraseña que desea registrar:_ ");

                        contra = Console.ReadLine();

                        usuariocontra.Add(usua, contra);

                        contreg++;

                        Console.WriteLine();

                        Console.WriteLine("Presione la tecla enter para registrar su información");

                        Console.ReadKey();

                        Console.Clear();

                        break;

                    case 2:

                        Console.Clear();

                        if (contreg == 0)

                        {
                            Console.WriteLine("Usted todavia no ha registrado ninguna información");

                            Console.ReadKey();

                            Console.Clear();
                        }

                        else if (contreg > 0)

                        {

                            Console.WriteLine("Bienvenido a submenú mostrar usuarios y contraseñas registrados");

                            Console.WriteLine();

                            Console.Write("Ingrese un nombre de usuario registrado anteriormente para poder mostrar la contraseña:_ ");

                            us = Console.ReadLine();

                            if (usuariocontra.ContainsKey(us))

                            {
                                Console.WriteLine();

                                Console.WriteLine($"La contraseña del usuario {us} es: {usuariocontra[us]}");

                            }

                            Console.WriteLine();

                            Console.WriteLine("Presione enter para salir del submenú");

                            Console.ReadKey();

                            Console.Clear();

                        }

                        break;

                    case 3:

                        Console.Clear();

                        Console.WriteLine("Usted ha salido del menú");

                        break;

                    default:

                        Console.Clear();

                        Console.WriteLine("Usted no ha ingresado una opción valida");

                        Console.WriteLine();

                        Console.WriteLine("Presione enter para intentarlo nuevamente");

                        Console.ReadKey();

                        Console.Clear();


                        break;
                 
                 }


                }

                while (opcion != 3) ;








            
    }


    }

}