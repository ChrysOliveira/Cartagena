using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo.Classes
{
    internal class Tabuleiro
    {
        private int posicaoX, posicaoY;
        private List<string> listaTabuleiro;
        private List<CasaTabuleiro> casasDoTabuleiro;
        private List<Pirata> piratasTabuleiro;
        public Tabuleiro()
        {
            listaTabuleiro = new List<string>();
            CasasDoTabuleiro = new List<CasaTabuleiro>();
            piratasTabuleiro = new List<Pirata>();
        }

        public int PosicaoX { get => posicaoX; set => posicaoX = value; }
        public int PosicaoY { get => posicaoY; set => posicaoY = value; }
        public List<string> ListaTabuleiro { get => listaTabuleiro; set => listaTabuleiro = value; }
        public List<CasaTabuleiro> CasasDoTabuleiro { get => casasDoTabuleiro; set => casasDoTabuleiro = value; }
        public List<Pirata> PiratasTabuleiro { get => piratasTabuleiro; set => piratasTabuleiro = value; }
    }
}
