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
            Console.Write("Introduce el número de discos: ");
            int n = int.Parse(Console.ReadLine());
            
            // Pilas para las torres
            Pila INI = new Pila();
            Pila AUX = new Pila();
            Pila FIN = new Pila();  

            // Inicializar la torre INI con los discos ingresados
            for (int i = n; i >= 1; i--)
            {
                INI.push(new Disco(i));
            }
            // Mostrar el estado inicial de las torres
            int movimientos = Hanoi.iterativo(n, INI, FIN, AUX);
            Console.WriteLine("Número total de movimientos: " + movimientos);
            Console.WriteLine("Movimientos mínimos esperados: " + (Math.Pow(2, n) - 1));

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
