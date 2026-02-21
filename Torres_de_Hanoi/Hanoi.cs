using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.isEmpty())
            {
                Disco d = b.pop();
                a.push(d);
            }
            else if (b.isEmpty())
            {
                Disco d = a.pop();
                b.push(d);
            }
            else if (a.Top.GetValor() < b.Top.GetValor())
            {
                Disco d = a.pop();
                b.push(d);
            }
            else
            {
                Disco d = b.pop();
                a.push(d);
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            if (n % 2 == 0) //impar
            {
                while(fin.Size != n)
                {
                    mover_disco(ini, fin);
                    movimientos++;
                    if (fin.Size == n) break;

                    mover_disco(ini, aux);
                    movimientos++;
                    if (fin.Size == n) break;

                    mover_disco(aux, fin);
                    movimientos++;
                }
            }
            else //par
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, aux);
                    movimientos++;
                    if (fin.Size == n) break;

                    mover_disco(ini, fin);
                    movimientos++;
                    if (fin.Size == n) break;

                    mover_disco(aux, fin);
                    movimientos++;
                }
            }
            return movimientos;
        }
    }
}