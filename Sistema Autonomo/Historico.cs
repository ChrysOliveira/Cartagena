using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo
{
    internal class Historico
    {
        private string _historico;
        private List<string> jogadasFeitas;

        public Historico(String retorno)
        {
            this._historico= retorno;
            TratarHistorico();
        }

        private void TratarHistorico()
        {
            if (_historico != null && _historico != "")
            {
                List<string> histo = _historico
                    .Replace("\r", "").Split('\n').ToList();


                foreach (string item in histo)
                {

                    string[] partes = item.Split(':'); // Divide o item em duas partes separadas por ":"
                    string idJogador = partes[0].Trim(); // A primeira parte é a descrição do evento
                    string jogadaN = partes[1].Trim(); // A segunda parte é a hora em que o evento ocorreu
                    string simbolo = partes[2].Trim();
                    string origem = partes[3].Trim();
                    string destino = partes[4].Trim();

                    jogadasFeitas = new List<string>(new[] { idJogador, jogadaN, simbolo, origem, destino });



                }
            }
        }

        private void CompararNovasJogadas()
        {
            List<string> NovoHistorico = new List<string>();
            IEnumerable<string> NovasJogadas = NovoHistorico.Except(jogadasFeitas);
        }



        
    }
}
