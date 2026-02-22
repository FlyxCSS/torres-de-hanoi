using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*Metodos de la clase hanoi*/
        public static void mover_disco(Pila a, Pila b)
        {
            if (a.isEmpty() && b.isEmpty())
            {
                return; // nada que mover
            }

            if (a.isEmpty())
            {
                Disco d = b.pop();
                if (d != null) a.push(d);
            }
            else if (b.isEmpty())
            {
                Disco d = a.pop();
                if (d != null) b.push(d);
            }
            else if (!a.isEmpty() && !b.isEmpty() && a.Top != null && b.Top != null && a.Top.GetValor() < b.Top.GetValor())
            {
                Disco d = a.pop();
                if (d != null) b.push(d);
            }
            else
            {
                Disco d = b.pop();
                if (d != null) a.push(d);
            }
        }

        //----------------------
        //Metodo Iterativo
        //----------------------
        public static int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            mostrar_estado(ini, aux, fin, movimientos);
            if (n % 2 == 0) //par
            {
                while(fin.Size != n)
                {
                    mover_disco(ini, aux);
                    movimientos++;
                    mostrar_estado(ini, aux, fin, movimientos);
                    if (fin.Size == n) break;

                    mover_disco(ini, fin);
                    movimientos++;
                    mostrar_estado(ini, aux, fin, movimientos);
                    if (fin.Size == n) break;

                    mover_disco(aux, fin);
                    movimientos++;
                    mostrar_estado(ini, aux, fin, movimientos);
                }
            }
            else //impar
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, fin);
                    movimientos++;
                    mostrar_estado(ini, aux, fin, movimientos);
                    if (fin.Size == n) break;

                    mover_disco(ini, aux);
                    movimientos++;
                    mostrar_estado(ini, aux, fin, movimientos);
                    if (fin.Size == n) break;

                    mover_disco(aux, fin);
                    movimientos++;
                    mostrar_estado(ini, aux, fin, movimientos);
                }
            }
            return movimientos;
        }

        //----------------------
        //Metodo Recursivo
        //----------------------

        public static void recursivo(int n, Pila INI, Pila AUX, Pila FIN, ref int movimientos)
        {
            if (n == 1)
            { //Mover el disco de INI a FIN
                mover_disco(INI, FIN);
                movimientos++;
                mostrar_estado(INI, AUX, FIN, movimientos);
            }
            else
            {
                //Mover n-1 discos de INI a AUX usando FIN como auxiliar
                recursivo(n - 1, INI, FIN, AUX, ref movimientos);
                //Mover el disco restante de INI a FIN
                mover_disco(INI, FIN);
                movimientos++;
                mostrar_estado(INI, AUX, FIN, movimientos);
                //Mover n-1 discos de AUX a FIN usando INI como auxiliar
                recursivo(n - 1, AUX, INI, FIN, ref movimientos);
            }
        }



        //----------------------
        //Metodo para mostrar el estado de las torre en cada movimiento
        //----------------------
        public static void mostrar_estado(Pila INI, Pila AUX, Pila FIN, int movimiento)
        {

            if (movimiento == 0)
            { 
                Console.WriteLine("\nSituación inicial");
            }
            else
            {
                Console.WriteLine("\nSituación tras el movimiento " + movimiento);
            }

        Console.Write("Torre INI: ");
            foreach (Disco d in INI.Elementos)
                Console.Write(d.GetValor() + " ");
            Console.WriteLine();

            Console.Write("Torre AUX: ");
            foreach (Disco d in AUX.Elementos)
                Console.Write(d.GetValor() + " ");
            Console.WriteLine();

            Console.Write("Torre FIN: ");
            foreach (Disco d in FIN.Elementos)
                Console.Write(d.GetValor() + " ");
            Console.WriteLine();
        }

    }
}