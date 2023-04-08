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
            this.PainelLoob = new System.Windows.Forms.Panel();
            this.painelJogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Controles_Cris = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabuleiro = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Cartas = new System.Windows.Forms.CheckedListBox();
            this.piratas = new System.Windows.Forms.CheckedListBox();
            this.btJogar = new System.Windows.Forms.Button();
            this.btPular = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.Jogadores = new System.Windows.Forms.ListView();
            this.PainelLoob.SuspendLayout();
            this.painelJogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Controles_Cris.SuspendLayout();
            this.Tabuleiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultarVez
            // 
            this.btnConsultarVez.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultarVez.Location = new System.Drawing.Point(38, 22);
            this.btnConsultarVez.MinimumSize = new System.Drawing.Size(100, 23);
            this.btnConsultarVez.Name = "btnConsultarVez";
            this.btnConsultarVez.Size = new System.Drawing.Size(106, 23);
            this.btnConsultarVez.TabIndex = 0;
            this.btnConsultarVez.Text = "Listar Partidas";
            this.btnConsultarVez.UseVisualStyleBackColor = true;
            this.btnConsultarVez.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lsbListaPartidas
            // 
            this.lsbListaPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbListaPartidas.FormattingEnabled = true;
            this.lsbListaPartidas.Location = new System.Drawing.Point(34, 55);
            this.lsbListaPartidas.MinimumSize = new System.Drawing.Size(170, 225);
            this.lsbListaPartidas.Name = "lsbListaPartidas";
            this.lsbListaPartidas.Size = new System.Drawing.Size(176, 225);
            this.lsbListaPartidas.TabIndex = 1;
            // 
            // txbNomeNovaPartida
            // 
            this.txbNomeNovaPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNomeNovaPartida.Location = new System.Drawing.Point(138, 8);
            this.txbNomeNovaPartida.MinimumSize = new System.Drawing.Size(100, 20);
            this.txbNomeNovaPartida.Name = "txbNomeNovaPartida";
            this.txbNomeNovaPartida.Size = new System.Drawing.Size(113, 20);
            this.txbNomeNovaPartida.TabIndex = 2;
            this.txbNomeNovaPartida.TextChanged += new System.EventHandler(this.txbNomeNovaPartida_TextChanged);
            // 
            // lblNomeNovaPartida
            // 
            this.lblNomeNovaPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeNovaPartida.AutoSize = true;
            this.lblNomeNovaPartida.Location = new System.Drawing.Point(17, 11);
            this.lblNomeNovaPartida.MaximumSize = new System.Drawing.Size(115, 13);
            this.lblNomeNovaPartida.MinimumSize = new System.Drawing.Size(112, 13);
            this.lblNomeNovaPartida.Name = "lblNomeNovaPartida";
            this.lblNomeNovaPartida.Size = new System.Drawing.Size(112, 13);
            this.lblNomeNovaPartida.TabIndex = 3;
            this.lblNomeNovaPartida.Text = "Nome da nova partida";
            // 
            // lblSenhaNovaPartida
            // 
            this.lblSenhaNovaPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenhaNovaPartida.AutoSize = true;
            this.lblSenhaNovaPartida.Location = new System.Drawing.Point(17, 36);
            this.lblSenhaNovaPartida.MaximumSize = new System.Drawing.Size(115, 13);
            this.lblSenhaNovaPartida.MinimumSize = new System.Drawing.Size(115, 13);
            this.lblSenhaNovaPartida.Name = "lblSenhaNovaPartida";
            this.lblSenhaNovaPartida.Size = new System.Drawing.Size(115, 13);
            this.lblSenhaNovaPartida.TabIndex = 5;
            this.lblSenhaNovaPartida.Text = "Senha da nova partida";
            // 
            // txbSenhaNovaPartida
            // 
            this.txbSenhaNovaPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSenhaNovaPartida.Location = new System.Drawing.Point(138, 33);
            this.txbSenhaNovaPartida.MinimumSize = new System.Drawing.Size(100, 20);
            this.txbSenhaNovaPartida.Name = "txbSenhaNovaPartida";
            this.txbSenhaNovaPartida.Size = new System.Drawing.Size(113, 20);
            this.txbSenhaNovaPartida.TabIndex = 4;
            // 
            // btnCriarNovaPartida
            // 
            this.btnCriarNovaPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarNovaPartida.Location = new System.Drawing.Point(138, 59);
            this.btnCriarNovaPartida.MaximumSize = new System.Drawing.Size(113, 25);
            this.btnCriarNovaPartida.MinimumSize = new System.Drawing.Size(100, 23);
            this.btnCriarNovaPartida.Name = "btnCriarNovaPartida";
            this.btnCriarNovaPartida.Size = new System.Drawing.Size(113, 25);
            this.btnCriarNovaPartida.TabIndex = 6;
            this.btnCriarNovaPartida.Text = "Criar Partida";
            this.btnCriarNovaPartida.UseVisualStyleBackColor = true;
            this.btnCriarNovaPartida.Click += new System.EventHandler(this.btnCriarNovaPartida_Click);
            // 
            // btnEntrarNaPartida
            // 
            this.btnEntrarNaPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrarNaPartida.Location = new System.Drawing.Point(111, 80);
            this.btnEntrarNaPartida.MaximumSize = new System.Drawing.Size(100, 25);
            this.btnEntrarNaPartida.MinimumSize = new System.Drawing.Size(100, 25);
            this.btnEntrarNaPartida.Name = "btnEntrarNaPartida";
            this.btnEntrarNaPartida.Size = new System.Drawing.Size(100, 25);
            this.btnEntrarNaPartida.TabIndex = 7;
            this.btnEntrarNaPartida.Text = "Entrar na Partida";
            this.btnEntrarNaPartida.UseVisualStyleBackColor = true;
            this.btnEntrarNaPartida.Click += new System.EventHandler(this.btnEntrarNaPartida_Click);
            // 
            // lblIdPartidaCriada
            // 
            this.lblIdPartidaCriada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdPartidaCriada.AutoSize = true;
            this.lblIdPartidaCriada.Location = new System.Drawing.Point(17, 103);
            this.lblIdPartidaCriada.MinimumSize = new System.Drawing.Size(104, 13);
            this.lblIdPartidaCriada.Name = "lblIdPartidaCriada";
            this.lblIdPartidaCriada.Size = new System.Drawing.Size(104, 13);
            this.lblIdPartidaCriada.TabIndex = 8;
            this.lblIdPartidaCriada.Text = "Id da partida criada: ";
            this.lblIdPartidaCriada.Click += new System.EventHandler(this.lblIdPartidaCriada_Click);
            // 
            // lblSenhaPartidaEntrar
            // 
            this.lblSenhaPartidaEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenhaPartidaEntrar.AutoSize = true;
            this.lblSenhaPartidaEntrar.Location = new System.Drawing.Point(17, 51);
            this.lblSenhaPartidaEntrar.MinimumSize = new System.Drawing.Size(88, 13);
            this.lblSenhaPartidaEntrar.Name = "lblSenhaPartidaEntrar";
            this.lblSenhaPartidaEntrar.Size = new System.Drawing.Size(88, 13);
            this.lblSenhaPartidaEntrar.TabIndex = 10;
            this.lblSenhaPartidaEntrar.Text = "Senha da partida";
            // 
            // txbSenhaPartidaEntrar
            // 
            this.txbSenhaPartidaEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbSenhaPartidaEntrar.Location = new System.Drawing.Point(111, 48);
            this.txbSenhaPartidaEntrar.MinimumSize = new System.Drawing.Size(127, 20);
            this.txbSenhaPartidaEntrar.Name = "txbSenhaPartidaEntrar";
            this.txbSenhaPartidaEntrar.Size = new System.Drawing.Size(127, 20);
            this.txbSenhaPartidaEntrar.TabIndex = 9;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(17, 25);
            this.lblNomeJogador.MinimumSize = new System.Drawing.Size(76, 13);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(76, 13);
            this.lblNomeJogador.TabIndex = 12;
            this.lblNomeJogador.Text = "Nome Jogador";
            // 
            // txbNomeJogador
            // 
            this.txbNomeJogador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbNomeJogador.Location = new System.Drawing.Point(111, 22);
            this.txbNomeJogador.MinimumSize = new System.Drawing.Size(127, 20);
            this.txbNomeJogador.Name = "txbNomeJogador";
            this.txbNomeJogador.Size = new System.Drawing.Size(127, 20);
            this.txbNomeJogador.TabIndex = 11;
            // 
            // lblIdJogadorCriado
            // 
            this.lblIdJogadorCriado.AutoSize = true;
            this.lblIdJogadorCriado.Location = new System.Drawing.Point(99, 80);
            this.lblIdJogadorCriado.Name = "lblIdJogadorCriado";
            this.lblIdJogadorCriado.Size = new System.Drawing.Size(57, 13);
            this.lblIdJogadorCriado.TabIndex = 13;
            this.lblIdJogadorCriado.Text = "Id jogador:";
            // 
            // lblCorCriada
            // 
            this.lblCorCriada.AutoSize = true;
            this.lblCorCriada.Location = new System.Drawing.Point(99, 125);
            this.lblCorCriada.Name = "lblCorCriada";
            this.lblCorCriada.Size = new System.Drawing.Size(26, 13);
            this.lblCorCriada.TabIndex = 14;
            this.lblCorCriada.Text = "Cor:";
            // 
            // lblSenhaCriada
            // 
            this.lblSenhaCriada.AutoSize = true;
            this.lblSenhaCriada.Location = new System.Drawing.Point(99, 103);
            this.lblSenhaCriada.Name = "lblSenhaCriada";
            this.lblSenhaCriada.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCriada.TabIndex = 15;
            this.lblSenhaCriada.Text = "Senha:";
            // 
            // lsvListaJogadoresPartida
            // 
            this.lsvListaJogadoresPartida.HideSelection = false;
            this.lsvListaJogadoresPartida.Location = new System.Drawing.Point(199, 80);
            this.lsvListaJogadoresPartida.Name = "lsvListaJogadoresPartida";
            this.lsvListaJogadoresPartida.Size = new System.Drawing.Size(121, 153);
            this.lsvListaJogadoresPartida.TabIndex = 16;
            this.lsvListaJogadoresPartida.UseCompatibleStateImageBehavior = false;
            this.lsvListaJogadoresPartida.View = System.Windows.Forms.View.List;
            // 
            // lblListaJogadoresPartida
            // 
            this.lblListaJogadoresPartida.AutoSize = true;
            this.lblListaJogadoresPartida.Location = new System.Drawing.Point(205, 64);
            this.lblListaJogadoresPartida.Name = "lblListaJogadoresPartida";
            this.lblListaJogadoresPartida.Size = new System.Drawing.Size(106, 13);
            this.lblListaJogadoresPartida.TabIndex = 17;
            this.lblListaJogadoresPartida.Text = "Jogadores na partida";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(413, 92);
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
            this.lblCartasNaMao.Location = new System.Drawing.Point(18, 49);
            this.lblCartasNaMao.Name = "lblCartasNaMao";
            this.lblCartasNaMao.Size = new System.Drawing.Size(0, 13);
            this.lblCartasNaMao.TabIndex = 19;
            // 
            // btnExibirCartasEmMao
            // 
            this.btnExibirCartasEmMao.Location = new System.Drawing.Point(228, 341);
            this.btnExibirCartasEmMao.Name = "btnExibirCartasEmMao";
            this.btnExibirCartasEmMao.Size = new System.Drawing.Size(139, 23);
            this.btnExibirCartasEmMao.TabIndex = 20;
            this.btnExibirCartasEmMao.Text = "Exibir cartas em mao";
            this.btnExibirCartasEmMao.UseVisualStyleBackColor = true;
            this.btnExibirCartasEmMao.Click += new System.EventHandler(this.btnExibirCartasEmMao_Click);
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(148, 37);
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
            this.lblTabuleiro.Location = new System.Drawing.Point(173, 49);
            this.lblTabuleiro.Name = "lblTabuleiro";
            this.lblTabuleiro.Size = new System.Drawing.Size(0, 13);
            this.lblTabuleiro.TabIndex = 21;
            // 
            // btnJogadorVez
            // 
            this.btnJogadorVez.Location = new System.Drawing.Point(27, 41);
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
            this.lblJogadorVez.Location = new System.Drawing.Point(331, 52);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(0, 13);
            this.lblJogadorVez.TabIndex = 24;
            // 
            // btnPularVez
            // 
            this.btnPularVez.Location = new System.Drawing.Point(337, 115);
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
            this.lblInfoAcoes.Location = new System.Drawing.Point(387, 90);
            this.lblInfoAcoes.Name = "lblInfoAcoes";
            this.lblInfoAcoes.Size = new System.Drawing.Size(42, 13);
            this.lblInfoAcoes.TabIndex = 26;
            this.lblInfoAcoes.Text = "Acoes";
            // 
            // btnMoverPirataRetornar
            // 
            this.btnMoverPirataRetornar.Location = new System.Drawing.Point(337, 204);
            this.btnMoverPirataRetornar.Name = "btnMoverPirataRetornar";
            this.btnMoverPirataRetornar.Size = new System.Drawing.Size(139, 23);
            this.btnMoverPirataRetornar.TabIndex = 28;
            this.btnMoverPirataRetornar.Text = "Retornar pirata";
            this.btnMoverPirataRetornar.UseVisualStyleBackColor = true;
            this.btnMoverPirataRetornar.Click += new System.EventHandler(this.btnMoverPirataRetornar_Click);
            // 
            // txbPosicaoRetornar
            // 
            this.txbPosicaoRetornar.Location = new System.Drawing.Point(337, 178);
            this.txbPosicaoRetornar.Name = "txbPosicaoRetornar";
            this.txbPosicaoRetornar.Size = new System.Drawing.Size(139, 20);
            this.txbPosicaoRetornar.TabIndex = 29;
            this.txbPosicaoRetornar.TextChanged += new System.EventHandler(this.txbPosicaoRetornar_TextChanged);
            // 
            // lblPosicaoRetornar
            // 
            this.lblPosicaoRetornar.AutoSize = true;
            this.lblPosicaoRetornar.Location = new System.Drawing.Point(284, 185);
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
            this.btnExibirHistorico.Location = new System.Drawing.Point(39, 184);
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
            this.lblSimboloAvancar.Location = new System.Drawing.Point(284, 308);
            this.lblSimboloAvancar.Name = "lblSimboloAvancar";
            this.lblSimboloAvancar.Size = new System.Drawing.Size(45, 13);
            this.lblSimboloAvancar.TabIndex = 35;
            this.lblSimboloAvancar.Text = "simbolo:";
            // 
            // txbSimboloAvancar
            // 
            this.txbSimboloAvancar.Location = new System.Drawing.Point(337, 301);
            this.txbSimboloAvancar.Name = "txbSimboloAvancar";
            this.txbSimboloAvancar.Size = new System.Drawing.Size(139, 20);
            this.txbSimboloAvancar.TabIndex = 34;
            // 
            // btnAvancarPirata
            // 
            this.btnAvancarPirata.Location = new System.Drawing.Point(337, 327);
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
            this.lblPosicaoAvancar.Location = new System.Drawing.Point(284, 282);
            this.lblPosicaoAvancar.Name = "lblPosicaoAvancar";
            this.lblPosicaoAvancar.Size = new System.Drawing.Size(47, 13);
            this.lblPosicaoAvancar.TabIndex = 37;
            this.lblPosicaoAvancar.Text = "posicao:";
            // 
            // txbPosicaoAvancar
            // 
            this.txbPosicaoAvancar.Location = new System.Drawing.Point(337, 275);
            this.txbPosicaoAvancar.Name = "txbPosicaoAvancar";
            this.txbPosicaoAvancar.Size = new System.Drawing.Size(139, 20);
            this.txbPosicaoAvancar.TabIndex = 36;
            // 
            // PainelLoob
            // 
            this.PainelLoob.BackColor = System.Drawing.SystemColors.Control;
            this.PainelLoob.Controls.Add(this.painelJogo);
            this.PainelLoob.Controls.Add(this.lsvListaJogadoresPartida);
            this.PainelLoob.Controls.Add(this.lblIdJogadorCriado);
            this.PainelLoob.Controls.Add(this.lblCorCriada);
            this.PainelLoob.Controls.Add(this.lblSenhaCriada);
            this.PainelLoob.Controls.Add(this.lblListaJogadoresPartida);
            this.PainelLoob.Controls.Add(this.btnIniciarPartida);
            this.PainelLoob.Location = new System.Drawing.Point(12, 10);
            this.PainelLoob.Name = "PainelLoob";
            this.PainelLoob.Size = new System.Drawing.Size(930, 606);
            this.PainelLoob.TabIndex = 38;
            this.PainelLoob.Visible = false;
            this.PainelLoob.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelLoob_Paint);
            // 
            // painelJogo
            // 
            this.painelJogo.Controls.Add(this.Jogadores);
            this.painelJogo.Controls.Add(this.btVoltar);
            this.painelJogo.Controls.Add(this.btPular);
            this.painelJogo.Controls.Add(this.btJogar);
            this.painelJogo.Controls.Add(this.piratas);
            this.painelJogo.Controls.Add(this.Cartas);
            this.painelJogo.Controls.Add(this.listView1);
            this.painelJogo.Controls.Add(this.Tabuleiro);
            this.painelJogo.Controls.Add(this.Controles_Cris);
            this.painelJogo.Controls.Add(this.btnExibirCartasEmMao);
            this.painelJogo.Controls.Add(this.lblCartasNaMao);
            this.painelJogo.Controls.Add(this.lblTabuleiro);
            this.painelJogo.Controls.Add(this.btnJogadorVez);
            this.painelJogo.Controls.Add(this.lblJogadorVez);
            this.painelJogo.Location = new System.Drawing.Point(26, 31);
            this.painelJogo.Name = "painelJogo";
            this.painelJogo.Size = new System.Drawing.Size(901, 557);
            this.painelJogo.TabIndex = 19;
            this.painelJogo.Visible = false;
            this.painelJogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblNomeJogador);
            this.panel1.Controls.Add(this.btnEntrarNaPartida);
            this.panel1.Controls.Add(this.txbNomeJogador);
            this.panel1.Controls.Add(this.lblSenhaPartidaEntrar);
            this.panel1.Controls.Add(this.txbSenhaPartidaEntrar);
            this.panel1.Location = new System.Drawing.Point(345, 41);
            this.panel1.MinimumSize = new System.Drawing.Size(258, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 136);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNomeNovaPartida);
            this.panel2.Controls.Add(this.txbNomeNovaPartida);
            this.panel2.Controls.Add(this.txbSenhaNovaPartida);
            this.panel2.Controls.Add(this.lblIdPartidaCriada);
            this.panel2.Controls.Add(this.lblSenhaNovaPartida);
            this.panel2.Controls.Add(this.btnCriarNovaPartida);
            this.panel2.Location = new System.Drawing.Point(31, 41);
            this.panel2.MaximumSize = new System.Drawing.Size(258, 136);
            this.panel2.MinimumSize = new System.Drawing.Size(258, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 136);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConsultarVez);
            this.panel3.Controls.Add(this.lsbListaPartidas);
            this.panel3.Location = new System.Drawing.Point(31, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 308);
            this.panel3.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(345, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 308);
            this.panel4.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pode colocar uma imagem qualquer aqui";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Controles_Cris
            // 
            this.Controles_Cris.Controls.Add(this.label2);
            this.Controles_Cris.Controls.Add(this.btnPularVez);
            this.Controles_Cris.Controls.Add(this.lblInfoAcoes);
            this.Controles_Cris.Controls.Add(this.txbPosicaoRetornar);
            this.Controles_Cris.Controls.Add(this.lblPosicaoAvancar);
            this.Controles_Cris.Controls.Add(this.lblPosicaoRetornar);
            this.Controles_Cris.Controls.Add(this.btnMoverPirataRetornar);
            this.Controles_Cris.Controls.Add(this.txbPosicaoAvancar);
            this.Controles_Cris.Controls.Add(this.btnExibirHistorico);
            this.Controles_Cris.Controls.Add(this.btnAvancarPirata);
            this.Controles_Cris.Controls.Add(this.txbSimboloAvancar);
            this.Controles_Cris.Controls.Add(this.lblSimboloAvancar);
            this.Controles_Cris.Location = new System.Drawing.Point(99, 518);
            this.Controles_Cris.Name = "Controles_Cris";
            this.Controles_Cris.Size = new System.Drawing.Size(557, 389);
            this.Controles_Cris.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Aqui esta os Controles que o Cris fez, depois precisa passar o codigo para os nov" +
    "os conrtoles";
            // 
            // Tabuleiro
            // 
            this.Tabuleiro.Controls.Add(this.btnExibirTabuleiro);
            this.Tabuleiro.Location = new System.Drawing.Point(182, 61);
            this.Tabuleiro.Name = "Tabuleiro";
            this.Tabuleiro.Size = new System.Drawing.Size(712, 274);
            this.Tabuleiro.TabIndex = 39;
            this.Tabuleiro.TabStop = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(140, 223);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Cartas
            // 
            this.Cartas.FormattingEnabled = true;
            this.Cartas.Location = new System.Drawing.Point(228, 371);
            this.Cartas.Name = "Cartas";
            this.Cartas.Size = new System.Drawing.Size(139, 124);
            this.Cartas.TabIndex = 41;
            // 
            // piratas
            // 
            this.piratas.FormattingEnabled = true;
            this.piratas.Location = new System.Drawing.Point(436, 371);
            this.piratas.Name = "piratas";
            this.piratas.Size = new System.Drawing.Size(148, 124);
            this.piratas.TabIndex = 42;
            // 
            // btJogar
            // 
            this.btJogar.Location = new System.Drawing.Point(642, 371);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(85, 40);
            this.btJogar.TabIndex = 43;
            this.btJogar.Text = "Jogar";
            this.btJogar.UseVisualStyleBackColor = true;
            // 
            // btPular
            // 
            this.btPular.Location = new System.Drawing.Point(642, 459);
            this.btPular.Name = "btPular";
            this.btPular.Size = new System.Drawing.Size(85, 36);
            this.btPular.TabIndex = 44;
            this.btPular.Text = "Pular";
            this.btPular.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(642, 417);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(85, 36);
            this.btVoltar.TabIndex = 45;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // Jogadores
            // 
            this.Jogadores.HideSelection = false;
            this.Jogadores.Location = new System.Drawing.Point(27, 322);
            this.Jogadores.Name = "Jogadores";
            this.Jogadores.Size = new System.Drawing.Size(139, 163);
            this.Jogadores.TabIndex = 46;
            this.Jogadores.UseCompatibleStateImageBehavior = false;
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 677);
            this.Controls.Add(this.PainelLoob);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(687, 579);
            this.Name = "frmInicial";
            this.Text = "Cartagena Monteria";
            this.PainelLoob.ResumeLayout(false);
            this.PainelLoob.PerformLayout();
            this.painelJogo.ResumeLayout(false);
            this.painelJogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Controles_Cris.ResumeLayout(false);
            this.Controles_Cris.PerformLayout();
            this.Tabuleiro.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PainelLoob;
        private System.Windows.Forms.Panel painelJogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView Jogadores;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btPular;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.CheckedListBox piratas;
        private System.Windows.Forms.CheckedListBox Cartas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel Tabuleiro;
        private System.Windows.Forms.Panel Controles_Cris;
        private System.Windows.Forms.Label label2;
    }
}

