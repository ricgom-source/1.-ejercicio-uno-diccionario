using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ejercicio_de_diccionarios
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Dictionary<int, string> empleados = new Dictionary<int, string>();

            int opcion;

            do
            {

                Console.WriteLine("Bienvenido al sistema de la empresa de Mcdonalss");

                Console.WriteLine();

                Console.WriteLine("1. Agregar nuevo empleado");

                Console.WriteLine();

                Console.WriteLine("2. Mostrar los empleados activos");

                Console.WriteLine();

                Console.WriteLine("3. Modificar nombre de empleado");

                Console.WriteLine();

                Console.WriteLine("4. Salir del menú");

                Console.WriteLine();

                Console.Write("Ingrese la opción que usted quiere utilizar:_ ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)

                {
                    case 1:

                        Console.Clear();

                        Console.WriteLine("Bienvenido a la opcion para registrar nuevo empleado");

                        Console.WriteLine();

                        Console.Write("Ingrese el número de carnet del empleado:_ ");

                        int codigo = int.Parse(Console.ReadLine());

                        if (empleados.ContainsKey(codigo))

                        {
                            Console.WriteLine("Usted ya ha registrado un empleado con este número de carnet");

                            Console.ReadKey();

                            Console.Clear();

                            break;


                        }

                        else

                        {



                            Console.WriteLine();

                            Console.Write("Ingrese el nombre del empleado:_ ");

                            string nombre = Console.ReadLine();

                            Console.WriteLine();

                            empleados.Add(codigo, nombre);

                            Console.WriteLine("Presione enter para finalizar el registro");

                            Console.ReadKey();

                            Console.Clear();

                        }

                        break;


                    case 2:

                        Console.Clear();

                        Console.WriteLine("Bienvenido a la opcion de mostrar empleados activos");

                        Console.WriteLine();

                        Console.WriteLine("Los empleados activos son: ");

                        Console.WriteLine();

                        foreach (var item in empleados)

                        {

                            Console.WriteLine(item.Value);

                            Console.WriteLine();

                        }

                        Console.WriteLine();

                        Console.WriteLine("Si ya termino de leer, presione enter para cerrar esta ventana");

                        Console.ReadKey();

                        Console.Clear();



                        break;

                    case 3:

                        Console.Clear();

                        Console.WriteLine("Bienvenido a la opcion de modificar nombre de empleado");

                        Console.WriteLine();

                        Console.Write("Ingrese el número de carnet del empleado: ");

                        codigo = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        Console.Write("Ingrese el nuevo nombre del empleado:_ ");

                        string nuevonombre = Console.ReadLine();

                        empleados[codigo] = nuevonombre;

                        Console.WriteLine();

                        Console.WriteLine("Presione enter para finalizar la acción");

                        Console.ReadKey();

                        Console.Clear();


                        break;

                    case 4:

                        Console.Clear();

                        Console.WriteLine("Usted ha salido del menu");

                        break;





                    default:

                        Console.Clear();

                        Console.WriteLine("Usted no ha ingresado una opcion valida");

                        Console.WriteLine();

                        Console.WriteLine("Presione enter para volver a intentarlo");

                        Console.ReadKey();

                        Console.Clear();


                        break;




                }



            }

            while (opcion != 4);






        }
    }
}
