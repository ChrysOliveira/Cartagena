namespace Sistema_Autonomo
{
    partial class frmPartida
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblMostrarTabuleiro;
            this.panelQualquer = new System.Windows.Forms.Panel();
            this.HistoricoPartida = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblJogadorVez = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MeusPiratas = new System.Windows.Forms.ListBox();
            this.Cartas = new System.Windows.Forms.ListBox();
            this.btPular = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btJogar = new System.Windows.Forms.Button();
            this.Jogadores = new System.Windows.Forms.ListView();
            this.Tabuleiro = new System.Windows.Forms.Panel();
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.lblTabuleiro = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            lblMostrarTabuleiro = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Tabuleiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMostrarTabuleiro
            // 
            lblMostrarTabuleiro.AutoSize = true;
            lblMostrarTabuleiro.Location = new System.Drawing.Point(35, 50);
            lblMostrarTabuleiro.MaximumSize = new System.Drawing.Size(139, 143);
            lblMostrarTabuleiro.Name = "lblMostrarTabuleiro";
            lblMostrarTabuleiro.Size = new System.Drawing.Size(91, 13);
            lblMostrarTabuleiro.TabIndex = 24;
            lblMostrarTabuleiro.Text = "aqui ta o tabuleiro";
            // 
            // panelQualquer
            // 
            this.panelQualquer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQualquer.Location = new System.Drawing.Point(47, 47);
            this.panelQualquer.Name = "panelQualquer";
            this.panelQualquer.Size = new System.Drawing.Size(146, 169);
            this.panelQualquer.TabIndex = 59;
            this.panelQualquer.Visible = false;
            // 
            // HistoricoPartida
            // 
            this.HistoricoPartida.HideSelection = false;
            this.HistoricoPartida.Location = new System.Drawing.Point(47, 248);
            this.HistoricoPartida.Name = "HistoricoPartida";
            this.HistoricoPartida.Size = new System.Drawing.Size(140, 527);
            this.HistoricoPartida.TabIndex = 53;
            this.HistoricoPartida.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(51, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Histórico de Jogadas";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.Controls.Add(this.lblJogadorVez);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(349, 589);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 240);
            this.panel5.TabIndex = 57;
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.Location = new System.Drawing.Point(20, 40);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(35, 13);
            this.lblJogadorVez.TabIndex = 1;
            this.lblJogadorVez.Text = "label1";
            this.lblJogadorVez.Click += new System.EventHandler(this.lblJogadorVez_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(17, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jogador da Vez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(214, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Jogadores na partida";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MeusPiratas);
            this.groupBox1.Controls.Add(this.Cartas);
            this.groupBox1.Controls.Add(this.btPular);
            this.groupBox1.Controls.Add(this.btVoltar);
            this.groupBox1.Controls.Add(this.btJogar);
            this.groupBox1.Location = new System.Drawing.Point(627, 599);
            this.groupBox1.MinimumSize = new System.Drawing.Size(462, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 188);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // MeusPiratas
            // 
            this.MeusPiratas.FormattingEnabled = true;
            this.MeusPiratas.Location = new System.Drawing.Point(188, 33);
            this.MeusPiratas.Name = "MeusPiratas";
            this.MeusPiratas.Size = new System.Drawing.Size(131, 134);
            this.MeusPiratas.TabIndex = 47;
            this.MeusPiratas.SelectedIndexChanged += new System.EventHandler(this.MeusPiratas_SelectedIndexChanged);
            // 
            // Cartas
            // 
            this.Cartas.FormattingEnabled = true;
            this.Cartas.Location = new System.Drawing.Point(19, 33);
            this.Cartas.Name = "Cartas";
            this.Cartas.Size = new System.Drawing.Size(139, 134);
            this.Cartas.TabIndex = 46;
            this.Cartas.SelectedIndexChanged += new System.EventHandler(this.Cartas_SelectedIndexChanged_1);
            // 
            // btPular
            // 
            this.btPular.Location = new System.Drawing.Point(366, 121);
            this.btPular.Name = "btPular";
            this.btPular.Size = new System.Drawing.Size(85, 36);
            this.btPular.TabIndex = 44;
            this.btPular.Text = "Pular";
            this.btPular.UseVisualStyleBackColor = true;
            this.btPular.Click += new System.EventHandler(this.btPular_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(366, 79);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(85, 36);
            this.btVoltar.TabIndex = 45;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btJogar
            // 
            this.btJogar.Location = new System.Drawing.Point(366, 33);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(85, 40);
            this.btJogar.TabIndex = 43;
            this.btJogar.Text = "Jogar";
            this.btJogar.UseVisualStyleBackColor = true;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // Jogadores
            // 
            this.Jogadores.HideSelection = false;
            this.Jogadores.Location = new System.Drawing.Point(204, 605);
            this.Jogadores.Name = "Jogadores";
            this.Jogadores.Size = new System.Drawing.Size(139, 207);
            this.Jogadores.TabIndex = 54;
            this.Jogadores.UseCompatibleStateImageBehavior = false;
            // 
            // Tabuleiro
            // 
            this.Tabuleiro.Controls.Add(this.btnExibirTabuleiro);
            this.Tabuleiro.Controls.Add(lblMostrarTabuleiro);
            this.Tabuleiro.Controls.Add(this.lblTabuleiro);
            this.Tabuleiro.Location = new System.Drawing.Point(217, 47);
            this.Tabuleiro.Name = "Tabuleiro";
            this.Tabuleiro.Size = new System.Drawing.Size(872, 536);
            this.Tabuleiro.TabIndex = 52;
            this.Tabuleiro.TabStop = true;
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(23, 11);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(139, 23);
            this.btnExibirTabuleiro.TabIndex = 22;
            this.btnExibirTabuleiro.Text = "Exibir tabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = true;
            // 
            // lblTabuleiro
            // 
            this.lblTabuleiro.AutoSize = true;
            this.lblTabuleiro.Location = new System.Drawing.Point(35, 50);
            this.lblTabuleiro.Name = "lblTabuleiro";
            this.lblTabuleiro.Size = new System.Drawing.Size(91, 13);
            this.lblTabuleiro.TabIndex = 21;
            this.lblTabuleiro.Text = "aqui ta o tabuleiro";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(57, 58);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(100, 23);
            this.btnIniciarPartida.TabIndex = 60;
            this.btnIniciarPartida.Text = "IniciarPartida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 852);
            this.Controls.Add(this.panelQualquer);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.HistoricoPartida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Jogadores);
            this.Controls.Add(this.Tabuleiro);
            this.Name = "frmPartida";
            this.Text = "Partida";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Tabuleiro.ResumeLayout(false);
            this.Tabuleiro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelQualquer;
        private System.Windows.Forms.ListView HistoricoPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPular;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.ListView Jogadores;
        private System.Windows.Forms.Panel Tabuleiro;
        private System.Windows.Forms.Button btnExibirTabuleiro;
        private System.Windows.Forms.Label lblTabuleiro;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblJogadorVez;
        private System.Windows.Forms.ListBox MeusPiratas;
        private System.Windows.Forms.ListBox Cartas;
    }
}