using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL19037Guia10Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas, columnas, correcto = 0, incorrecto = 0;

            Console.WriteLine("filas y columnas que desea en la tabla");
            filas = int.Parse(Console.ReadLine());
            columnas = filas;
            
            int[,] tabla = new int[filas, columnas];

            Console.WriteLine("\n");
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    Console.WriteLine("fila {0} columna {1}", (fila + 1), (columna + 1));
                    tabla[fila, columna] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("filas * columnas\n");

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    Console.Write("{0:00}  ", tabla[fila, columna]);
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("columnas * filas\n");

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    Console.Write("{0:00}  ", tabla[columna, fila]);
                }
                Console.WriteLine("\n");
            }

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    if (tabla[fila,columna]==tabla[columna,fila])
                    {
                        correcto += 1;
                    }
                    if (tabla[fila,columna]!=tabla[columna,fila])
                    {
                        incorrecto += 1;
                    }
                }
            }
            Console.WriteLine("correctos {0} incorrectos {1}", correcto, incorrecto);
            Console.ReadKey();
        }
    }
}
