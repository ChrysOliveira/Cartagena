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

        public string CorPirata { get => corPirata; set => corPirata = value; }
        public int IdJogador { get => idJogador; set => idJogador = value; }
        public int NumeroDaCasa { get => numeroDaCasa; set => numeroDaCasa = value; }
    }
}
