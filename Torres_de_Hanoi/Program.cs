using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // título 
            Console.Write("\nPractica 1, Torres de Hanoi");
            Console.Write("\n3 torres");

            //leemos el número de discos con validación
            int n;
            while (true)
            {
                Console.Write("\nIntroduce el número de discos: ");
                string entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out n) || n < 1)
                {
                    Console.WriteLine("Error: introduce un número entero positivo.");
                    continue;
                }
                break;
            }

            Console.Write("\nHas seleccionado " + n + " discos");

            // leemos la opción de iterativo o recursivo
            Console.Write("\nIndica I para iterativo o R para recursivo: ");
            String opcion = Console.ReadLine();


            // Crear las torres como pilas
            Pila INI = new Pila();
            Pila AUX = new Pila();
            Pila FIN = new Pila();  

            // Inicializar la torre INI con los discos ingresados
            for (int i = n; i >= 1; i--)
            {
                INI.push(new Disco(i));
            }
            // Variable para contar los movimientos
            int movimientos = 0;



            // Resolver el problema de las Torres de Hanoi según la opción seleccionada
            if (opcion == "I" || opcion == "i")
            {
                Console.WriteLine("\n--- Resolviendo con algoritmo ITERATIVO ---\n");
                movimientos = Hanoi.iterativo(n, INI, AUX, FIN);
            }
            else if (opcion =="R" || opcion == "r")
            {
                Console.WriteLine("\n--- Resolviendo con algoritmo RECURSIVO ---\n");
                Hanoi.mostrar_estado(INI, AUX, FIN, movimientos); // Mostrar estado inicial
                Hanoi.recursivo(n, INI, AUX, FIN, ref movimientos);
            }
            else // Opción no válida
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            // Mostrar el número total de movimientos realizados y el mínimo esperado
            Console.WriteLine("\nNúmero total de movimientos: " + movimientos);
            Console.WriteLine("Movimientos mínimos esperados: " + (Math.Pow(2, n) - 1));

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
