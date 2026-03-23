using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Ejercicio_siete_diccionarios
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Dictionary<int,string> productos = new Dictionary<int,string>();

            int opcion;

            do
            {

                Console.WriteLine("Bienvenido a la coleccion de productos");

                Console.WriteLine("1. Agregar un producto");

                Console.WriteLine();

                Console.WriteLine("2. Mostrar los productos agregados");

                Console.WriteLine();

                Console.WriteLine("3. Salir del menú");

                Console.WriteLine();

                Console.Write("Ingrese la opción que usted quiere utilizar:_ ");

                opcion = int.Parse(Console.ReadLine());

                switch(opcion)

                {
                    case 1:

                        Console.Clear();

                        Console.WriteLine("Bienvenido a la opcion para agregar productos");

                        Console.WriteLine();

                        Console.Write("Ingrese el código del producto:_ ");

                        int codigo = int.Parse(Console.ReadLine());

                        if (productos.ContainsKey(codigo))

                        {
                            Console.WriteLine("Usted ya ha registrado un producto con este código");

                            Console.ReadKey();

                            Console.Clear();

                            break;


                        }

                        else

                        {



                            Console.WriteLine();

                            Console.Write("Ingrese el nombre del producto:_ ");

                            string nombrepro = Console.ReadLine();

                            Console.WriteLine();

                            productos.Add(codigo, nombrepro);

                            Console.WriteLine("Presione enter para finalizar el registro");

                            Console.ReadKey();

                            Console.Clear();

                        }

                        break;

                    case 2:
                        Console.Clear();

                        Console.WriteLine("Bienvenido a la opcion mostrar productos");

                        Console.WriteLine();

                        Console.WriteLine("Los productos agregados son: ");

                        Console.WriteLine();

                        foreach(var item in productos)

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

            while(opcion != 3) ;










        }
    }
}
