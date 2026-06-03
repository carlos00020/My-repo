using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                 
                Console.Write("Escoja una opcion: ");

                
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());

                }
                //catch (FormatException convertintop)
                //{
                //    Console.WriteLine("Solo se aceptan valores numericos (1, 2)");
                //    opcion = 5; // Asignar un valor no válido para continuar el bucle
                //}
                //catch(OverflowException convertintop)
                //{
                //    Console.WriteLine("El numero es muy grande o muy pequeño. Solo es posible ingresar el numero 1, 2!");
                //    opcion = 5; // Asignar un valor no válido para continuar el bucle

                //}
                catch(Exception convertintop)
                {
                    Console.WriteLine("Ocurrio un error inesperado: ");
                    opcion = 5; // Asignar un valor no válido para continuar el bucle
                }


            }
            while (opcion != 1 && opcion != 2);

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Sumar");
                    break;
                    case 2:
                    Console.WriteLine("Restar");
                    break;

                    default: Console.WriteLine("Opcion no valida"); break;

            }
        }
    }
}
