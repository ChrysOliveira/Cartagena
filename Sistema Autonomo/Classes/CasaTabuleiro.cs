using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo.Classes
{
    internal class CasaTabuleiro : Panel
    {
        int numeroCasa;
        List<Pirata> piratasDaCasa;
        public CasaTabuleiro(int numeroCasa)
        {
            this.NumeroCasa = numeroCasa;
            piratasDaCasa = new List<Pirata>();
        }
        public int NumeroCasa { get => numeroCasa; private set => numeroCasa = value; }
        internal List<Pirata> PiratasDaCasa { get => piratasDaCasa; set => piratasDaCasa = value; }
    }
}
