namespace Sistema_Autonomo
{
    partial class frmInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsultarVez = new System.Windows.Forms.Button();
            this.lsbListaPartidas = new System.Windows.Forms.ListBox();
            this.txbNomeNovaPartida = new System.Windows.Forms.TextBox();
            this.lblNomeNovaPartida = new System.Windows.Forms.Label();
            this.lblSenhaNovaPartida = new System.Windows.Forms.Label();
            this.txbSenhaNovaPartida = new System.Windows.Forms.TextBox();
            this.btnCriarNovaPartida = new System.Windows.Forms.Button();
            this.btnEntrarNaPartida = new System.Windows.Forms.Button();
            this.lblIdPartidaCriada = new System.Windows.Forms.Label();
            this.lblSenhaPartidaEntrar = new System.Windows.Forms.Label();
            this.txbSenhaPartidaEntrar = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txbNomeJogador = new System.Windows.Forms.TextBox();
            this.lblIdJogadorCriado = new System.Windows.Forms.Label();
            this.lblCorCriada = new System.Windows.Forms.Label();
            this.lblSenhaCriada = new System.Windows.Forms.Label();
            this.lsvListaJogadoresPartida = new System.Windows.Forms.ListView();
            this.lblListaJogadoresPartida = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblCartasNaMao = new System.Windows.Forms.Label();
            this.btnExibirCartasEmMao = new System.Windows.Forms.Button();
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.lblTabuleiro = new System.Windows.Forms.Label();
            this.btnJogadorVez = new System.Windows.Forms.Button();
            this.lblJogadorVez = new System.Windows.Forms.Label();
            this.btnPularVez = new System.Windows.Forms.Button();
            this.lblInfoAcoes = new System.Windows.Forms.Label();
            this.btnMoverPirataRetornar = new System.Windows.Forms.Button();
            this.txbPosicaoRetornar = new System.Windows.Forms.TextBox();
            this.lblPosicaoRetornar = new System.Windows.Forms.Label();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.btnExibirHistorico = new System.Windows.Forms.Button();
            this.lblSimboloAvancar = new System.Windows.Forms.Label();
            this.txbSimboloAvancar = new System.Windows.Forms.TextBox();
            this.btnAvancarPirata = new System.Windows.Forms.Button();
            this.lblPosicaoAvancar = new System.Windows.Forms.Label();
            this.txbPosicaoAvancar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConsultarVez
            // 
            this.btnConsultarVez.Location = new System.Drawing.Point(72, 249);
            this.btnConsultarVez.Name = "btnConsultarVez";
            this.btnConsultarVez.Size = new System.Drawing.Size(100, 23);
            this.btnConsultarVez.TabIndex = 0;
            this.btnConsultarVez.Text = "Listar Partidas";
            this.btnConsultarVez.UseVisualStyleBackColor = true;
            this.btnConsultarVez.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lsbListaPartidas
            // 
            this.lsbListaPartidas.FormattingEnabled = true;
            this.lsbListaPartidas.Location = new System.Drawing.Point(16, 161);
            this.lsbListaPartidas.Name = "lsbListaPartidas";
            this.lsbListaPartidas.Size = new System.Drawing.Size(218, 82);
            this.lsbListaPartidas.TabIndex = 1;
            // 
            // txbNomeNovaPartida
            // 
            this.txbNomeNovaPartida.Location = new System.Drawing.Point(134, 41);
            this.txbNomeNovaPartida.Name = "txbNomeNovaPartida";
            this.txbNomeNovaPartida.Size = new System.Drawing.Size(100, 20);
            this.txbNomeNovaPartida.TabIndex = 2;
            // 
            // lblNomeNovaPartida
            // 
            this.lblNomeNovaPartida.AutoSize = true;
            this.lblNomeNovaPartida.Location = new System.Drawing.Point(13, 44);
            this.lblNomeNovaPartida.Name = "lblNomeNovaPartida";
            this.lblNomeNovaPartida.Size = new System.Drawing.Size(112, 13);
            this.lblNomeNovaPartida.TabIndex = 3;
            this.lblNomeNovaPartida.Text = "Nome da nova partida";
            // 
            // lblSenhaNovaPartida
            // 
            this.lblSenhaNovaPartida.AutoSize = true;
            this.lblSenhaNovaPartida.Location = new System.Drawing.Point(13, 69);
            this.lblSenhaNovaPartida.Name = "lblSenhaNovaPartida";
            this.lblSenhaNovaPartida.Size = new System.Drawing.Size(115, 13);
            this.lblSenhaNovaPartida.TabIndex = 5;
            this.lblSenhaNovaPartida.Text = "Senha da nova partida";
            // 
            // txbSenhaNovaPartida
            // 
            this.txbSenhaNovaPartida.Location = new System.Drawing.Point(134, 66);
            this.txbSenhaNovaPartida.Name = "txbSenhaNovaPartida";
            this.txbSenhaNovaPartida.Size = new System.Drawing.Size(100, 20);
            this.txbSenhaNovaPartida.TabIndex = 4;
            // 
            // btnCriarNovaPartida
            // 
            this.btnCriarNovaPartida.Location = new System.Drawing.Point(134, 92);
            this.btnCriarNovaPartida.Name = "btnCriarNovaPartida";
            this.btnCriarNovaPartida.Size = new System.Drawing.Size(100, 23);
            this.btnCriarNovaPartida.TabIndex = 6;
            this.btnCriarNovaPartida.Text = "Criar Partida";
            this.btnCriarNovaPartida.UseVisualStyleBackColor = true;
            this.btnCriarNovaPartida.Click += new System.EventHandler(this.btnCriarNovaPartida_Click);
            // 
            // btnEntrarNaPartida
            // 
            this.btnEntrarNaPartida.Location = new System.Drawing.Point(72, 334);
            this.btnEntrarNaPartida.Name = "btnEntrarNaPartida";
            this.btnEntrarNaPartida.Size = new System.Drawing.Size(100, 23);
            this.btnEntrarNaPartida.TabIndex = 7;
            this.btnEntrarNaPartida.Text = "Entrar na Partida";
            this.btnEntrarNaPartida.UseVisualStyleBackColor = true;
            this.btnEntrarNaPartida.Click += new System.EventHandler(this.btnEntrarNaPartida_Click);
            // 
            // lblIdPartidaCriada
            // 
            this.lblIdPartidaCriada.AutoSize = true;
            this.lblIdPartidaCriada.Location = new System.Drawing.Point(16, 129);
            this.lblIdPartidaCriada.Name = "lblIdPartidaCriada";
            this.lblIdPartidaCriada.Size = new System.Drawing.Size(104, 13);
            this.lblIdPartidaCriada.TabIndex = 8;
            this.lblIdPartidaCriada.Text = "Id da partida criada: ";
            // 
            // lblSenhaPartidaEntrar
            // 
            this.lblSenhaPartidaEntrar.AutoSize = true;
            this.lblSenhaPartidaEntrar.Location = new System.Drawing.Point(13, 311);
            this.lblSenhaPartidaEntrar.Name = "lblSenhaPartidaEntrar";
            this.lblSenhaPartidaEntrar.Size = new System.Drawing.Size(88, 13);
            this.lblSenhaPartidaEntrar.TabIndex = 10;
            this.lblSenhaPartidaEntrar.Text = "Senha da partida";
            // 
            // txbSenhaPartidaEntrar
            // 
            this.txbSenhaPartidaEntrar.Location = new System.Drawing.Point(107, 308);
            this.txbSenhaPartidaEntrar.Name = "txbSenhaPartidaEntrar";
            this.txbSenhaPartidaEntrar.Size = new System.Drawing.Size(127, 20);
            this.txbSenhaPartidaEntrar.TabIndex = 9;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(13, 285);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(76, 13);
            this.lblNomeJogador.TabIndex = 12;
            this.lblNomeJogador.Text = "Nome Jogador";
            // 
            // txbNomeJogador
            // 
            this.txbNomeJogador.Location = new System.Drawing.Point(107, 282);
            this.txbNomeJogador.Name = "txbNomeJogador";
            this.txbNomeJogador.Size = new System.Drawing.Size(127, 20);
            this.txbNomeJogador.TabIndex = 11;
            // 
            // lblIdJogadorCriado
            // 
            this.lblIdJogadorCriado.AutoSize = true;
            this.lblIdJogadorCriado.Location = new System.Drawing.Point(13, 388);
            this.lblIdJogadorCriado.Name = "lblIdJogadorCriado";
            this.lblIdJogadorCriado.Size = new System.Drawing.Size(57, 13);
            this.lblIdJogadorCriado.TabIndex = 13;
            this.lblIdJogadorCriado.Text = "Id jogador:";
            // 
            // lblCorCriada
            // 
            this.lblCorCriada.AutoSize = true;
            this.lblCorCriada.Location = new System.Drawing.Point(13, 433);
            this.lblCorCriada.Name = "lblCorCriada";
            this.lblCorCriada.Size = new System.Drawing.Size(26, 13);
            this.lblCorCriada.TabIndex = 14;
            this.lblCorCriada.Text = "Cor:";
            // 
            // lblSenhaCriada
            // 
            this.lblSenhaCriada.AutoSize = true;
            this.lblSenhaCriada.Location = new System.Drawing.Point(13, 411);
            this.lblSenhaCriada.Name = "lblSenhaCriada";
            this.lblSenhaCriada.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCriada.TabIndex = 15;
            this.lblSenhaCriada.Text = "Senha:";
            // 
            // lsvListaJogadoresPartida
            // 
            this.lsvListaJogadoresPartida.HideSelection = false;
            this.lsvListaJogadoresPartida.Location = new System.Drawing.Point(113, 388);
            this.lsvListaJogadoresPartida.Name = "lsvListaJogadoresPartida";
            this.lsvListaJogadoresPartida.Size = new System.Drawing.Size(121, 58);
            this.lsvListaJogadoresPartida.TabIndex = 16;
            this.lsvListaJogadoresPartida.UseCompatibleStateImageBehavior = false;
            this.lsvListaJogadoresPartida.View = System.Windows.Forms.View.List;
            // 
            // lblListaJogadoresPartida
            // 
            this.lblListaJogadoresPartida.AutoSize = true;
            this.lblListaJogadoresPartida.Location = new System.Drawing.Point(119, 372);
            this.lblListaJogadoresPartida.Name = "lblListaJogadoresPartida";
            this.lblListaJogadoresPartida.Size = new System.Drawing.Size(106, 13);
            this.lblListaJogadoresPartida.TabIndex = 17;
            this.lblListaJogadoresPartida.Text = "Jogadores na partida";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(72, 474);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(100, 23);
            this.btnIniciarPartida.TabIndex = 18;
            this.btnIniciarPartida.Text = "IniciarPartida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblCartasNaMao
            // 
            this.lblCartasNaMao.AutoSize = true;
            this.lblCartasNaMao.Location = new System.Drawing.Point(333, 70);
            this.lblCartasNaMao.Name = "lblCartasNaMao";
            this.lblCartasNaMao.Size = new System.Drawing.Size(0, 13);
            this.lblCartasNaMao.TabIndex = 19;
            // 
            // btnExibirCartasEmMao
            // 
            this.btnExibirCartasEmMao.Location = new System.Drawing.Point(336, 38);
            this.btnExibirCartasEmMao.Name = "btnExibirCartasEmMao";
            this.btnExibirCartasEmMao.Size = new System.Drawing.Size(139, 23);
            this.btnExibirCartasEmMao.TabIndex = 20;
            this.btnExibirCartasEmMao.Text = "Exibir cartas em mao";
            this.btnExibirCartasEmMao.UseVisualStyleBackColor = true;
            this.btnExibirCartasEmMao.Click += new System.EventHandler(this.btnExibirCartasEmMao_Click);
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(491, 38);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(139, 23);
            this.btnExibirTabuleiro.TabIndex = 22;
            this.btnExibirTabuleiro.Text = "Exibir tabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = true;
            this.btnExibirTabuleiro.Click += new System.EventHandler(this.btnExibirTabuleiro_Click);
            // 
            // lblTabuleiro
            // 
            this.lblTabuleiro.AutoSize = true;
            this.lblTabuleiro.Location = new System.Drawing.Point(488, 70);
            this.lblTabuleiro.Name = "lblTabuleiro";
            this.lblTabuleiro.Size = new System.Drawing.Size(0, 13);
            this.lblTabuleiro.TabIndex = 21;
            // 
            // btnJogadorVez
            // 
            this.btnJogadorVez.Location = new System.Drawing.Point(649, 38);
            this.btnJogadorVez.Name = "btnJogadorVez";
            this.btnJogadorVez.Size = new System.Drawing.Size(139, 23);
            this.btnJogadorVez.TabIndex = 23;
            this.btnJogadorVez.Text = "Vez de quem?";
            this.btnJogadorVez.UseVisualStyleBackColor = true;
            this.btnJogadorVez.Click += new System.EventHandler(this.btnJogadorVez_Click);
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.Location = new System.Drawing.Point(646, 73);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(0, 13);
            this.lblJogadorVez.TabIndex = 24;
            // 
            // btnPularVez
            // 
            this.btnPularVez.Location = new System.Drawing.Point(920, 56);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(139, 23);
            this.btnPularVez.TabIndex = 25;
            this.btnPularVez.Text = "Pular vez";
            this.btnPularVez.UseVisualStyleBackColor = true;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // lblInfoAcoes
            // 
            this.lblInfoAcoes.AutoSize = true;
            this.lblInfoAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAcoes.Location = new System.Drawing.Point(970, 31);
            this.lblInfoAcoes.Name = "lblInfoAcoes";
            this.lblInfoAcoes.Size = new System.Drawing.Size(42, 13);
            this.lblInfoAcoes.TabIndex = 26;
            this.lblInfoAcoes.Text = "Acoes";
            // 
            // btnMoverPirataRetornar
            // 
            this.btnMoverPirataRetornar.Location = new System.Drawing.Point(920, 145);
            this.btnMoverPirataRetornar.Name = "btnMoverPirataRetornar";
            this.btnMoverPirataRetornar.Size = new System.Drawing.Size(139, 23);
            this.btnMoverPirataRetornar.TabIndex = 28;
            this.btnMoverPirataRetornar.Text = "Retornar pirata";
            this.btnMoverPirataRetornar.UseVisualStyleBackColor = true;
            this.btnMoverPirataRetornar.Click += new System.EventHandler(this.btnMoverPirataRetornar_Click);
            // 
            // txbPosicaoRetornar
            // 
            this.txbPosicaoRetornar.Location = new System.Drawing.Point(920, 119);
            this.txbPosicaoRetornar.Name = "txbPosicaoRetornar";
            this.txbPosicaoRetornar.Size = new System.Drawing.Size(139, 20);
            this.txbPosicaoRetornar.TabIndex = 29;
            this.txbPosicaoRetornar.TextChanged += new System.EventHandler(this.txbPosicaoRetornar_TextChanged);
            // 
            // lblPosicaoRetornar
            // 
            this.lblPosicaoRetornar.AutoSize = true;
            this.lblPosicaoRetornar.Location = new System.Drawing.Point(867, 126);
            this.lblPosicaoRetornar.Name = "lblPosicaoRetornar";
            this.lblPosicaoRetornar.Size = new System.Drawing.Size(47, 13);
            this.lblPosicaoRetornar.TabIndex = 30;
            this.lblPosicaoRetornar.Text = "posicao:";
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(646, 258);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(0, 13);
            this.lblHistorico.TabIndex = 32;
            // 
            // btnExibirHistorico
            // 
            this.btnExibirHistorico.Location = new System.Drawing.Point(649, 223);
            this.btnExibirHistorico.Name = "btnExibirHistorico";
            this.btnExibirHistorico.Size = new System.Drawing.Size(139, 23);
            this.btnExibirHistorico.TabIndex = 31;
            this.btnExibirHistorico.Text = "Exibir historico";
            this.btnExibirHistorico.UseVisualStyleBackColor = true;
            this.btnExibirHistorico.Click += new System.EventHandler(this.btnExibirHistorico_Click);
            // 
            // lblSimboloAvancar
            // 
            this.lblSimboloAvancar.AutoSize = true;
            this.lblSimboloAvancar.Location = new System.Drawing.Point(867, 249);
            this.lblSimboloAvancar.Name = "lblSimboloAvancar";
            this.lblSimboloAvancar.Size = new System.Drawing.Size(45, 13);
            this.lblSimboloAvancar.TabIndex = 35;
            this.lblSimboloAvancar.Text = "simbolo:";
            // 
            // txbSimboloAvancar
            // 
            this.txbSimboloAvancar.Location = new System.Drawing.Point(920, 242);
            this.txbSimboloAvancar.Name = "txbSimboloAvancar";
            this.txbSimboloAvancar.Size = new System.Drawing.Size(139, 20);
            this.txbSimboloAvancar.TabIndex = 34;
            // 
            // btnAvancarPirata
            // 
            this.btnAvancarPirata.Location = new System.Drawing.Point(920, 268);
            this.btnAvancarPirata.Name = "btnAvancarPirata";
            this.btnAvancarPirata.Size = new System.Drawing.Size(139, 23);
            this.btnAvancarPirata.TabIndex = 33;
            this.btnAvancarPirata.Text = "Avancar pirata";
            this.btnAvancarPirata.UseVisualStyleBackColor = true;
            this.btnAvancarPirata.Click += new System.EventHandler(this.btnAvancarPirata_Click);
            // 
            // lblPosicaoAvancar
            // 
            this.lblPosicaoAvancar.AutoSize = true;
            this.lblPosicaoAvancar.Location = new System.Drawing.Point(867, 223);
            this.lblPosicaoAvancar.Name = "lblPosicaoAvancar";
            this.lblPosicaoAvancar.Size = new System.Drawing.Size(47, 13);
            this.lblPosicaoAvancar.TabIndex = 37;
            this.lblPosicaoAvancar.Text = "posicao:";
            // 
            // txbPosicaoAvancar
            // 
            this.txbPosicaoAvancar.Location = new System.Drawing.Point(920, 216);
            this.txbPosicaoAvancar.Name = "txbPosicaoAvancar";
            this.txbPosicaoAvancar.Size = new System.Drawing.Size(139, 20);
            this.txbPosicaoAvancar.TabIndex = 36;
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 624);
            this.Controls.Add(this.lblPosicaoAvancar);
            this.Controls.Add(this.txbPosicaoAvancar);
            this.Controls.Add(this.lblSimboloAvancar);
            this.Controls.Add(this.txbSimboloAvancar);
            this.Controls.Add(this.btnAvancarPirata);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.btnExibirHistorico);
            this.Controls.Add(this.lblPosicaoRetornar);
            this.Controls.Add(this.txbPosicaoRetornar);
            this.Controls.Add(this.btnMoverPirataRetornar);
            this.Controls.Add(this.lblInfoAcoes);
            this.Controls.Add(this.btnPularVez);
            this.Controls.Add(this.lblJogadorVez);
            this.Controls.Add(this.btnJogadorVez);
            this.Controls.Add(this.btnExibirTabuleiro);
            this.Controls.Add(this.lblTabuleiro);
            this.Controls.Add(this.btnExibirCartasEmMao);
            this.Controls.Add(this.lblCartasNaMao);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblListaJogadoresPartida);
            this.Controls.Add(this.lsvListaJogadoresPartida);
            this.Controls.Add(this.lblSenhaCriada);
            this.Controls.Add(this.lblCorCriada);
            this.Controls.Add(this.lblIdJogadorCriado);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txbNomeJogador);
            this.Controls.Add(this.lblSenhaPartidaEntrar);
            this.Controls.Add(this.txbSenhaPartidaEntrar);
            this.Controls.Add(this.lblIdPartidaCriada);
            this.Controls.Add(this.btnEntrarNaPartida);
            this.Controls.Add(this.btnCriarNovaPartida);
            this.Controls.Add(this.lblSenhaNovaPartida);
            this.Controls.Add(this.txbSenhaNovaPartida);
            this.Controls.Add(this.lblNomeNovaPartida);
            this.Controls.Add(this.txbNomeNovaPartida);
            this.Controls.Add(this.lsbListaPartidas);
            this.Controls.Add(this.btnConsultarVez);
            this.Name = "frmInicial";
            this.Text = "Cartagena Monteria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarVez;
        private System.Windows.Forms.ListBox lsbListaPartidas;
        private System.Windows.Forms.TextBox txbNomeNovaPartida;
        private System.Windows.Forms.Label lblNomeNovaPartida;
        private System.Windows.Forms.Label lblSenhaNovaPartida;
        private System.Windows.Forms.TextBox txbSenhaNovaPartida;
        private System.Windows.Forms.Button btnCriarNovaPartida;
        private System.Windows.Forms.Button btnEntrarNaPartida;
        private System.Windows.Forms.Label lblIdPartidaCriada;
        private System.Windows.Forms.Label lblSenhaPartidaEntrar;
        private System.Windows.Forms.TextBox txbSenhaPartidaEntrar;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txbNomeJogador;
        private System.Windows.Forms.Label lblIdJogadorCriado;
        private System.Windows.Forms.Label lblCorCriada;
        private System.Windows.Forms.Label lblSenhaCriada;
        private System.Windows.Forms.ListView lsvListaJogadoresPartida;
        private System.Windows.Forms.Label lblListaJogadoresPartida;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblCartasNaMao;
        private System.Windows.Forms.Button btnExibirCartasEmMao;
        private System.Windows.Forms.Button btnExibirTabuleiro;
        private System.Windows.Forms.Label lblTabuleiro;
        private System.Windows.Forms.Button btnJogadorVez;
        private System.Windows.Forms.Label lblJogadorVez;
        private System.Windows.Forms.Button btnPularVez;
        private System.Windows.Forms.Label lblInfoAcoes;
        private System.Windows.Forms.Button btnMoverPirataRetornar;
        private System.Windows.Forms.TextBox txbPosicaoRetornar;
        private System.Windows.Forms.Label lblPosicaoRetornar;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Button btnExibirHistorico;
        private System.Windows.Forms.Label lblSimboloAvancar;
        private System.Windows.Forms.TextBox txbSimboloAvancar;
        private System.Windows.Forms.Button btnAvancarPirata;
        private System.Windows.Forms.Label lblPosicaoAvancar;
        private System.Windows.Forms.TextBox txbPosicaoAvancar;
    }
}

