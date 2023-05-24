using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo.Classes
{
    public class Historico
    {
        private string _historico;
        private List<string> jogadasFeitas;

        //vou escrever como estou planejando dei uma reformulada acho que algumas coisas vao ter que mudar
        List<string> historicoCompleto; //[idJogador, nºJogada, simbolo, posição origem, posição destino]
        List<string> novohistorico;   //aqui vai ser usado para salvar o historico novo, atualizado no inicio da vez
        List<Jogador> jogador; //para atualizar quantas cartas cada um tem

        public Historico(String retorno)
        {
            this._historico = retorno;
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

                    string[] partes = item.Split(':'); 
                    string idJogador = partes[0].Trim(); 
                    string jogadaN = partes[1].Trim(); 
                    string simbolo = partes[2].Trim();
                    string origem = partes[3].Trim();
                    string destino = partes[4].Trim();

                    jogadasFeitas = new List<string>(new[] { idJogador, jogadaN, simbolo, origem, destino });



                }
            }
        }
        private void CompararNovasJogadas() // pega o historico novo, compara com o antigo e tira o que ja foi feito pra ficar apenas com as novas jgadas
        {
            List<string> NovoHistorico = new List<string>();
            IEnumerable<string> NovasJogadas = NovoHistorico.Except(jogadasFeitas);
        }
        private void JogadasPorJogador()
        {
            //pegar as novas jogadas e tem que separar por idJogador 
            //to pensando em criar diferentes listas com as jogadas de cada jogador e chamar a função que conta as cartas

        }
        private void EleComprou()
        {
            //comparar as jogadas de cada jogador e retorna em quais ele comprou
        }
        private void QuantoComprou()
        {
            //aqui eu preciso pegar o retorno de EleComprou e analizar com o tabuleiro antigo para saber se comprou 1 ou 2 cartas
            //e ja atualiza em quantas cartas ele tem
        }
        //deixei anotado minhas ideias para vc poder me ajudar a programar isso
    }
}
