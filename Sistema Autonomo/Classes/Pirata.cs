using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo.Classes
{
    internal class Pirata : Panel
    {
        int idJogador;
        int numeroDaCasa;
        string corPirata;
        string simbolo;
        private int posicaoNaLista;

        public Pirata(int posicaoNaLista)
        {
            NumeroDaCasa = 0;
            this.posicaoNaLista = posicaoNaLista;
        }
        public Pirata()
        {        
        }

        public string CorPirata { get => corPirata; set => corPirata = value; }
        public int IdJogador { get => idJogador; set => idJogador = value; }
        public int NumeroDaCasa { get => numeroDaCasa; set => numeroDaCasa = value; }

        public int PosicaoNaLista { get => posicaoNaLista; }


        public void AvancaPirata(int casa, string simbolo)
        {
            this.NumeroDaCasa = casa;
            this.simbolo = simbolo;
        }

        public void VoltarPirata(int casa, string simbolo)
        {
            this.NumeroDaCasa = casa;
            this.simbolo = simbolo;

        }
    }
}
