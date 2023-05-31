using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo.Classes
{
    public class CasaTabuleiro : Panel
    {
        private int numeroCasa;
        private List<Pirata> piratasDaCasa;
        private string simbolo;

        public CasaTabuleiro(int numeroCasa)
        {
            this.NumeroCasa = numeroCasa;
            this.piratasDaCasa = new List<Pirata>();
            this.simbolo = "";
        }
        public CasaTabuleiro(int numeroCasa, string simbolo)
        {
            this.NumeroCasa = numeroCasa;
            this.piratasDaCasa = new List<Pirata>();
            this.simbolo = simbolo;
        }
        public int NumeroCasa { get => numeroCasa; private set => numeroCasa = value; }
        public string Simbolo { get => simbolo; set => simbolo = value; }
        internal List<Pirata> PiratasDaCasa { get => piratasDaCasa; set => piratasDaCasa = value; }
    }
}
