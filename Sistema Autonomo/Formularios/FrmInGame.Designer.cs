namespace Sistema_Autonomo.Formularios
{
    partial class FrmInGame
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
            this.pnlTabuleiro = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblJogadorDaRodada = new System.Windows.Forms.Label();
            this.lblDadosJogadorRodada = new System.Windows.Forms.Label();
            this.pnlJogadorVez = new System.Windows.Forms.Panel();
            this.lsbPiratasJogadorVez = new System.Windows.Forms.ListBox();
            this.lsbCartasJogadorVez = new System.Windows.Forms.ListBox();
            this.lblListaPiratas = new System.Windows.Forms.Label();
            this.lblListaCartas = new System.Windows.Forms.Label();
            this.rdBtnPularVez = new System.Windows.Forms.RadioButton();
            this.rdBtnAvancarPirata = new System.Windows.Forms.RadioButton();
            this.rdBtnRetornarPirata = new System.Windows.Forms.RadioButton();
            this.grpBoxAcoes = new System.Windows.Forms.GroupBox();
            this.TimerAttViewMenus = new System.Windows.Forms.Timer(this.components);
            this.TimerAttDadosTela = new System.Windows.Forms.Timer(this.components);
            this.grpBoxAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabuleiro
            // 
            this.pnlTabuleiro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTabuleiro.Location = new System.Drawing.Point(252, 12);
            this.pnlTabuleiro.Name = "pnlTabuleiro";
            this.pnlTabuleiro.Size = new System.Drawing.Size(1120, 737);
            this.pnlTabuleiro.TabIndex = 0;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(12, 683);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(234, 66);
            this.btnJogar.TabIndex = 8;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblJogadorDaRodada
            // 
            this.lblJogadorDaRodada.AutoSize = true;
            this.lblJogadorDaRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorDaRodada.Location = new System.Drawing.Point(21, 24);
            this.lblJogadorDaRodada.Name = "lblJogadorDaRodada";
            this.lblJogadorDaRodada.Size = new System.Drawing.Size(199, 25);
            this.lblJogadorDaRodada.TabIndex = 4;
            this.lblJogadorDaRodada.Text = "Jogador da rodada:";
            // 
            // lblDadosJogadorRodada
            // 
            this.lblDadosJogadorRodada.AutoSize = true;
            this.lblDadosJogadorRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosJogadorRodada.Location = new System.Drawing.Point(21, 67);
            this.lblDadosJogadorRodada.Name = "lblDadosJogadorRodada";
            this.lblDadosJogadorRodada.Size = new System.Drawing.Size(161, 75);
            this.lblDadosJogadorRodada.TabIndex = 5;
            this.lblDadosJogadorRodada.Text = "retiraressetexto\r\nretiraressetexto\r\nretiraressetexto";
            // 
            // pnlJogadorVez
            // 
            this.pnlJogadorVez.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlJogadorVez.Location = new System.Drawing.Point(12, 12);
            this.pnlJogadorVez.Name = "pnlJogadorVez";
            this.pnlJogadorVez.Size = new System.Drawing.Size(234, 135);
            this.pnlJogadorVez.TabIndex = 0;
            // 
            // lsbPiratasJogadorVez
            // 
            this.lsbPiratasJogadorVez.FormattingEnabled = true;
            this.lsbPiratasJogadorVez.Location = new System.Drawing.Point(12, 392);
            this.lsbPiratasJogadorVez.Name = "lsbPiratasJogadorVez";
            this.lsbPiratasJogadorVez.Size = new System.Drawing.Size(110, 147);
            this.lsbPiratasJogadorVez.TabIndex = 6;
            // 
            // lsbCartasJogadorVez
            // 
            this.lsbCartasJogadorVez.FormattingEnabled = true;
            this.lsbCartasJogadorVez.Location = new System.Drawing.Point(136, 392);
            this.lsbCartasJogadorVez.Name = "lsbCartasJogadorVez";
            this.lsbCartasJogadorVez.Size = new System.Drawing.Size(110, 147);
            this.lsbCartasJogadorVez.TabIndex = 7;
            // 
            // lblListaPiratas
            // 
            this.lblListaPiratas.AutoSize = true;
            this.lblListaPiratas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPiratas.Location = new System.Drawing.Point(32, 369);
            this.lblListaPiratas.Name = "lblListaPiratas";
            this.lblListaPiratas.Size = new System.Drawing.Size(65, 20);
            this.lblListaPiratas.TabIndex = 8;
            this.lblListaPiratas.Text = "Piratas";
            // 
            // lblListaCartas
            // 
            this.lblListaCartas.AutoSize = true;
            this.lblListaCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCartas.Location = new System.Drawing.Point(155, 369);
            this.lblListaCartas.Name = "lblListaCartas";
            this.lblListaCartas.Size = new System.Drawing.Size(62, 20);
            this.lblListaCartas.TabIndex = 9;
            this.lblListaCartas.Text = "Cartas";
            // 
            // rdBtnPularVez
            // 
            this.rdBtnPularVez.AutoSize = true;
            this.rdBtnPularVez.Location = new System.Drawing.Point(6, 22);
            this.rdBtnPularVez.Name = "rdBtnPularVez";
            this.rdBtnPularVez.Size = new System.Drawing.Size(69, 17);
            this.rdBtnPularVez.TabIndex = 9;
            this.rdBtnPularVez.TabStop = true;
            this.rdBtnPularVez.Text = "Pular vez";
            this.rdBtnPularVez.UseVisualStyleBackColor = true;
            // 
            // rdBtnAvancarPirata
            // 
            this.rdBtnAvancarPirata.AutoSize = true;
            this.rdBtnAvancarPirata.Location = new System.Drawing.Point(6, 45);
            this.rdBtnAvancarPirata.Name = "rdBtnAvancarPirata";
            this.rdBtnAvancarPirata.Size = new System.Drawing.Size(94, 17);
            this.rdBtnAvancarPirata.TabIndex = 10;
            this.rdBtnAvancarPirata.TabStop = true;
            this.rdBtnAvancarPirata.Text = "Avancar pirata";
            this.rdBtnAvancarPirata.UseVisualStyleBackColor = true;
            // 
            // rdBtnRetornarPirata
            // 
            this.rdBtnRetornarPirata.AutoSize = true;
            this.rdBtnRetornarPirata.Location = new System.Drawing.Point(6, 68);
            this.rdBtnRetornarPirata.Name = "rdBtnRetornarPirata";
            this.rdBtnRetornarPirata.Size = new System.Drawing.Size(95, 17);
            this.rdBtnRetornarPirata.TabIndex = 11;
            this.rdBtnRetornarPirata.TabStop = true;
            this.rdBtnRetornarPirata.Text = "Retornar pirata";
            this.rdBtnRetornarPirata.UseVisualStyleBackColor = true;
            // 
            // grpBoxAcoes
            // 
            this.grpBoxAcoes.Controls.Add(this.rdBtnRetornarPirata);
            this.grpBoxAcoes.Controls.Add(this.rdBtnPularVez);
            this.grpBoxAcoes.Controls.Add(this.rdBtnAvancarPirata);
            this.grpBoxAcoes.Location = new System.Drawing.Point(12, 569);
            this.grpBoxAcoes.Name = "grpBoxAcoes";
            this.grpBoxAcoes.Size = new System.Drawing.Size(200, 100);
            this.grpBoxAcoes.TabIndex = 0;
            this.grpBoxAcoes.TabStop = false;
            this.grpBoxAcoes.Text = "Acao";
            // 
            // TimerAttViewMenus
            // 
            this.TimerAttViewMenus.Enabled = true;
            this.TimerAttViewMenus.Tick += new System.EventHandler(this.TimerAttViewMenus_Tick);
            // 
            // TimerAttDadosTela
            // 
            this.TimerAttDadosTela.Enabled = true;
            this.TimerAttDadosTela.Interval = 5000;
            this.TimerAttDadosTela.Tick += new System.EventHandler(this.TimerAttDadosTela_Tick);
            // 
            // FrmInGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.grpBoxAcoes);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblListaCartas);
            this.Controls.Add(this.lblListaPiratas);
            this.Controls.Add(this.lsbCartasJogadorVez);
            this.Controls.Add(this.lsbPiratasJogadorVez);
            this.Controls.Add(this.lblDadosJogadorRodada);
            this.Controls.Add(this.lblJogadorDaRodada);
            this.Controls.Add(this.pnlTabuleiro);
            this.Controls.Add(this.pnlJogadorVez);
            this.Name = "FrmInGame";
            this.Text = "FrmInGame";
            this.Load += new System.EventHandler(this.FrmInGame_Load);
            this.grpBoxAcoes.ResumeLayout(false);
            this.grpBoxAcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabuleiro;
        private System.Windows.Forms.Label lblJogadorDaRodada;
        private System.Windows.Forms.Label lblDadosJogadorRodada;
        private System.Windows.Forms.Panel pnlJogadorVez;
        private System.Windows.Forms.ListBox lsbPiratasJogadorVez;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.ListBox lsbCartasJogadorVez;
        private System.Windows.Forms.Label lblListaPiratas;
        private System.Windows.Forms.Label lblListaCartas;
        private System.Windows.Forms.RadioButton rdBtnPularVez;
        private System.Windows.Forms.RadioButton rdBtnAvancarPirata;
        private System.Windows.Forms.RadioButton rdBtnRetornarPirata;
        private System.Windows.Forms.GroupBox grpBoxAcoes;
        private System.Windows.Forms.Timer TimerAttViewMenus;
        private System.Windows.Forms.Timer TimerAttDadosTela;
    }
}