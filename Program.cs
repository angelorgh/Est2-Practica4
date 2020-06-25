using System;

namespace Est2_Practica4
{
    class Program
    {
        static void Main(string[] args)
        {   
            int opcion;
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese que ejercicio desea realizar: 1 o 2");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Punto1.Execute();
                            break;
                        case 2:
                            Punto2.Execute();
                            break;
                        default:
                            Console.WriteLine("Ingrese una opcion valida");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese una opción correcta");
                }

            }
        }
    }
}
