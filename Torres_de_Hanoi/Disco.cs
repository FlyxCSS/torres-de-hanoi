using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        // Propiedades
        private int valor;

        // Constructor
        public Disco(int valor)
        {
            this.valor = valor;
        }

        // Métodos
        public int GetValor()
        {
            return valor;
        }
        public override string ToString()
        {
            return valor.ToString();
        }


    }
}
