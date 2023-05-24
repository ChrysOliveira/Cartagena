using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo.Classes
{
    public class Jogador
    {
        private int idJogador;
        private string senhaJogador;
        private string corJogador;
        private List<string> cartasNaMao;
        List<Pirata> piratas;
        static int qtdCartas;

        public Jogador()
        {
        }
        public Jogador(int ID, string Senha, string Cor)
        {
            qtdCartas= 6;
            this.idJogador = ID;
            this.senhaJogador = Senha;
            this.corJogador = Cor;
            piratas = new List<Pirata>();
            for (int i = 0; i < 6; i++)
            {
                Pirata pirata = new Pirata(i);
                piratas.Add(pirata);
            }
        }
        public Jogador(int ID, string cor) //construtor dos oponentes
        {
            qtdCartas= 6;
            this.idJogador = ID;
            this.senhaJogador = cor;
            piratas = new List<Pirata>();
            for (int i = 0; i < 6; i++)
            {
                Pirata pirata = new Pirata(i);
                piratas.Add(pirata);
            }
        }

        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string SenhaJogador { get => senhaJogador; set => senhaJogador = value; }
        public string CorJogador { get => corJogador; set => corJogador = value; }
        public List<string> CartasNaMao { get => cartasNaMao; set => cartasNaMao = value; }

        //public List<Pirata> Piratas { get { return piratas; } }
        public int PirataCasa(int id) { return piratas[id].PosicaoNaLista; }
        public int Id { get { return IdJogador; } }
        public string Senha { get { return Senha; } }
        public string Cor { get { return Cor; } }
        public void ADDCartas(string carta)
        {
            cartasNaMao.Add(carta);
        }
        public string EscolherCarta()
        {
            string cartaEscolhida = cartasNaMao[0];
            cartasNaMao.Remove(cartaEscolhida);
            return cartaEscolhida;
        }
        public int ObterCasaDoPirata(int posicaoDoPirata)
        {
            return piratas[posicaoDoPirata].NumeroDaCasa;
        }
        public void Av_Pirata(int IdPirata, string simbolo, int NovaCasa)
        {
            Jogo.Jogar(IdJogador, Senha, piratas[IdPirata].NumeroDaCasa, simbolo);
            piratas[IdPirata].AvancaPirata(NovaCasa, simbolo);

        }
        public void Volt_Pirata(int IdPirata, int NovaCasa, string NovoSimbolo)
        {
            Jogo.Jogar(IdJogador, Senha, piratas[IdPirata].NumeroDaCasa);
            piratas[IdPirata].VoltarPirata(NovaCasa, NovoSimbolo);


        }
        public void Pular()
        {
            Jogo.Jogar(IdJogador, Senha);
        }
        //funçoes apenas para controlar quantas cartas cada um tem
        //tambem pode servir para a estrategia decidir quando comprar ou nao
        public void ComprouCarta(int Carta)
        {
            qtdCartas += Carta;
        }
        public void GastouCarta()
        {
            qtdCartas --;
        }
    }
}
