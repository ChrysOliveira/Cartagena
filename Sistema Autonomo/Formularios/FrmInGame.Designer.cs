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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInGame));
            this.pnlTabuleiro = new System.Windows.Forms.Panel();
            this.lblDadosJogadorRodada = new System.Windows.Forms.Label();
            this.lsbPiratasJogadorVez = new System.Windows.Forms.ListBox();
            this.lsbCartasJogadorVez = new System.Windows.Forms.ListBox();
            this.rdBtnPularVez = new System.Windows.Forms.RadioButton();
            this.rdBtnAvancarPirata = new System.Windows.Forms.RadioButton();
            this.rdBtnRetornarPirata = new System.Windows.Forms.RadioButton();
            this.grpBoxAcoes = new System.Windows.Forms.GroupBox();
            this.rdAvancoInicial = new System.Windows.Forms.RadioButton();
            this.TimerAttViewMenus = new System.Windows.Forms.Timer(this.components);
            this.TimerAttDadosTela = new System.Windows.Forms.Timer(this.components);
            this.btnJogar = new System.Windows.Forms.Panel();
            this.grpBoxAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabuleiro
            // 
            this.pnlTabuleiro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTabuleiro.Location = new System.Drawing.Point(358, 12);
            this.pnlTabuleiro.Name = "pnlTabuleiro";
            this.pnlTabuleiro.Size = new System.Drawing.Size(1013, 735);
            this.pnlTabuleiro.TabIndex = 0;
            // 
            // lblDadosJogadorRodada
            // 
            this.lblDadosJogadorRodada.AutoSize = true;
            this.lblDadosJogadorRodada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(140)))));
            this.lblDadosJogadorRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosJogadorRodada.ForeColor = System.Drawing.Color.Black;
            this.lblDadosJogadorRodada.Location = new System.Drawing.Point(31, 66);
            this.lblDadosJogadorRodada.Name = "lblDadosJogadorRodada";
            this.lblDadosJogadorRodada.Size = new System.Drawing.Size(161, 75);
            this.lblDadosJogadorRodada.TabIndex = 5;
            this.lblDadosJogadorRodada.Text = "retiraressetexto\r\nretiraressetexto\r\nretiraressetexto";
            // 
            // lsbPiratasJogadorVez
            // 
            this.lsbPiratasJogadorVez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(96)))), ((int)(((byte)(56)))));
            this.lsbPiratasJogadorVez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbPiratasJogadorVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbPiratasJogadorVez.ForeColor = System.Drawing.Color.White;
            this.lsbPiratasJogadorVez.FormattingEnabled = true;
            this.lsbPiratasJogadorVez.ItemHeight = 16;
            this.lsbPiratasJogadorVez.Location = new System.Drawing.Point(184, 225);
            this.lsbPiratasJogadorVez.Name = "lsbPiratasJogadorVez";
            this.lsbPiratasJogadorVez.Size = new System.Drawing.Size(140, 128);
            this.lsbPiratasJogadorVez.TabIndex = 6;
            // 
            // lsbCartasJogadorVez
            // 
            this.lsbCartasJogadorVez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(96)))), ((int)(((byte)(56)))));
            this.lsbCartasJogadorVez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbCartasJogadorVez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCartasJogadorVez.ForeColor = System.Drawing.Color.White;
            this.lsbCartasJogadorVez.FormattingEnabled = true;
            this.lsbCartasJogadorVez.ItemHeight = 16;
            this.lsbCartasJogadorVez.Location = new System.Drawing.Point(18, 225);
            this.lsbCartasJogadorVez.Name = "lsbCartasJogadorVez";
            this.lsbCartasJogadorVez.Size = new System.Drawing.Size(140, 128);
            this.lsbCartasJogadorVez.TabIndex = 7;
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
            this.grpBoxAcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(140)))));
            this.grpBoxAcoes.Controls.Add(this.rdAvancoInicial);
            this.grpBoxAcoes.Controls.Add(this.rdBtnRetornarPirata);
            this.grpBoxAcoes.Controls.Add(this.rdBtnPularVez);
            this.grpBoxAcoes.Controls.Add(this.rdBtnAvancarPirata);
            this.grpBoxAcoes.Location = new System.Drawing.Point(27, 388);
            this.grpBoxAcoes.Name = "grpBoxAcoes";
            this.grpBoxAcoes.Size = new System.Drawing.Size(304, 167);
            this.grpBoxAcoes.TabIndex = 0;
            this.grpBoxAcoes.TabStop = false;
            this.grpBoxAcoes.Text = "Acao";
            // 
            // rdAvancoInicial
            // 
            this.rdAvancoInicial.AutoSize = true;
            this.rdAvancoInicial.Location = new System.Drawing.Point(6, 91);
            this.rdAvancoInicial.Name = "rdAvancoInicial";
            this.rdAvancoInicial.Size = new System.Drawing.Size(95, 17);
            this.rdAvancoInicial.TabIndex = 12;
            this.rdAvancoInicial.TabStop = true;
            this.rdAvancoInicial.Text = "Retornar pirata";
            this.rdAvancoInicial.UseVisualStyleBackColor = true;
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
            // btnJogar
            // 
            this.btnJogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJogar.BackgroundImage")));
            this.btnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJogar.Location = new System.Drawing.Point(16, 672);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(0);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnJogar.Size = new System.Drawing.Size(330, 76);
            this.btnJogar.TabIndex = 9;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            this.btnJogar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogar_MouseDown);
            this.btnJogar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogar_MouseUp);
            // 
            // FrmInGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1383, 759);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.grpBoxAcoes);
            this.Controls.Add(this.lsbCartasJogadorVez);
            this.Controls.Add(this.lsbPiratasJogadorVez);
            this.Controls.Add(this.lblDadosJogadorRodada);
            this.Controls.Add(this.pnlTabuleiro);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Label lblDadosJogadorRodada;
        private System.Windows.Forms.ListBox lsbPiratasJogadorVez;
        private System.Windows.Forms.ListBox lsbCartasJogadorVez;
        private System.Windows.Forms.RadioButton rdBtnPularVez;
        private System.Windows.Forms.RadioButton rdBtnAvancarPirata;
        private System.Windows.Forms.RadioButton rdBtnRetornarPirata;
        private System.Windows.Forms.GroupBox grpBoxAcoes;
        private System.Windows.Forms.Timer TimerAttViewMenus;
        private System.Windows.Forms.Timer TimerAttDadosTela;
        private System.Windows.Forms.Panel btnJogar;
        private System.Windows.Forms.RadioButton rdAvancoInicial;
    }
}