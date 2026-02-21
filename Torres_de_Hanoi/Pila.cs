using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        public Disco Top { get; set; }
        public List<Disco> Elementos { get; set; }

        public Pila()
        {
            Elementos = new List<Disco>();
            Size = 0;
            Top = null;
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            Size++;
            Top = d;
        }

        public Disco pop()
        {
            if(isEmpty()) return null;

            Disco d = Top;
            Elementos.RemoveAt(Size - 1);
            Size--;

            if(Size > 0) Top = Elementos[Size - 1];
            else Top = null;

            return d;
        }

        public bool isEmpty()
        {
            return Size == 0;
        }
    }
}