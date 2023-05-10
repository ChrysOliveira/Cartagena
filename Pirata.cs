using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo
{
    public class Pirata
    {
        private int casa;
        private int posicaoNaLista;
        string simbolo;

        public Pirata(int posicaoNaLista)
        {
            casa = 0;
            this.posicaoNaLista = posicaoNaLista;
        }




        public int Casa
        {
            get { return casa; }
            set { casa = value; }
        }

        public int PosicaoNaLista
        {
            get { return posicaoNaLista; }
        }

        public void AvancaPirata(int casa, string simbolo)
        {
            this.casa = casa;
            this.simbolo = simbolo;
        }

        public void VoltarPirata(int casa, string simbolo)
        {
            this.casa = casa;
            this.simbolo = simbolo;

        }
    }
}
