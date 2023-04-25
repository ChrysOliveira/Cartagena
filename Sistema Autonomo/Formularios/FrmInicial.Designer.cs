namespace Sistema_Autonomo.Formularios
{
    partial class FrmInicial
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
            this.lblHistorico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultarVez
            // 
            this.btnConsultarVez.Location = new System.Drawing.Point(50, 225);
            this.btnConsultarVez.MinimumSize = new System.Drawing.Size(100, 23);
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
            this.lsbListaPartidas.Location = new System.Drawing.Point(46, 258);
            this.lsbListaPartidas.MinimumSize = new System.Drawing.Size(170, 225);
            this.lsbListaPartidas.Name = "lsbListaPartidas";
            this.lsbListaPartidas.Size = new System.Drawing.Size(170, 225);
            this.lsbListaPartidas.TabIndex = 1;
            // 
            // txbNomeNovaPartida
            // 
            this.txbNomeNovaPartida.Location = new System.Drawing.Point(164, 48);
            this.txbNomeNovaPartida.MinimumSize = new System.Drawing.Size(100, 20);
            this.txbNomeNovaPartida.Name = "txbNomeNovaPartida";
            this.txbNomeNovaPartida.Size = new System.Drawing.Size(100, 20);
            this.txbNomeNovaPartida.TabIndex = 2;
            // 
            // lblNomeNovaPartida
            // 
            this.lblNomeNovaPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeNovaPartida.AutoSize = true;
            this.lblNomeNovaPartida.Location = new System.Drawing.Point(43, 51);
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
            this.lblSenhaNovaPartida.Location = new System.Drawing.Point(43, 76);
            this.lblSenhaNovaPartida.MaximumSize = new System.Drawing.Size(115, 13);
            this.lblSenhaNovaPartida.MinimumSize = new System.Drawing.Size(115, 13);
            this.lblSenhaNovaPartida.Name = "lblSenhaNovaPartida";
            this.lblSenhaNovaPartida.Size = new System.Drawing.Size(115, 13);
            this.lblSenhaNovaPartida.TabIndex = 5;
            this.lblSenhaNovaPartida.Text = "Senha da nova partida";
            // 
            // txbSenhaNovaPartida
            // 
            this.txbSenhaNovaPartida.Location = new System.Drawing.Point(164, 73);
            this.txbSenhaNovaPartida.MinimumSize = new System.Drawing.Size(100, 20);
            this.txbSenhaNovaPartida.Name = "txbSenhaNovaPartida";
            this.txbSenhaNovaPartida.Size = new System.Drawing.Size(100, 20);
            this.txbSenhaNovaPartida.TabIndex = 4;
            // 
            // btnCriarNovaPartida
            // 
            this.btnCriarNovaPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarNovaPartida.Location = new System.Drawing.Point(164, 99);
            this.btnCriarNovaPartida.MaximumSize = new System.Drawing.Size(113, 25);
            this.btnCriarNovaPartida.MinimumSize = new System.Drawing.Size(100, 23);
            this.btnCriarNovaPartida.Name = "btnCriarNovaPartida";
            this.btnCriarNovaPartida.Size = new System.Drawing.Size(100, 25);
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
            this.btnEntrarNaPartida.Location = new System.Drawing.Point(416, 109);
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
            this.lblIdPartidaCriada.Location = new System.Drawing.Point(43, 143);
            this.lblIdPartidaCriada.MinimumSize = new System.Drawing.Size(104, 13);
            this.lblIdPartidaCriada.Name = "lblIdPartidaCriada";
            this.lblIdPartidaCriada.Size = new System.Drawing.Size(104, 13);
            this.lblIdPartidaCriada.TabIndex = 8;
            this.lblIdPartidaCriada.Text = "Id da partida criada: ";
            // 
            // lblSenhaPartidaEntrar
            // 
            this.lblSenhaPartidaEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenhaPartidaEntrar.AutoSize = true;
            this.lblSenhaPartidaEntrar.Location = new System.Drawing.Point(322, 80);
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
            this.txbSenhaPartidaEntrar.Location = new System.Drawing.Point(416, 77);
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
            this.lblNomeJogador.Location = new System.Drawing.Point(322, 54);
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
            this.txbNomeJogador.Location = new System.Drawing.Point(416, 51);
            this.txbNomeJogador.MinimumSize = new System.Drawing.Size(127, 20);
            this.txbNomeJogador.Name = "txbNomeJogador";
            this.txbNomeJogador.Size = new System.Drawing.Size(127, 20);
            this.txbNomeJogador.TabIndex = 11;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Location = new System.Drawing.Point(646, 258);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(0, 13);
            this.lblHistorico.TabIndex = 32;
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 540);
            this.Controls.Add(this.btnConsultarVez);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.lsbListaPartidas);
            this.Controls.Add(this.lblNomeNovaPartida);
            this.Controls.Add(this.btnEntrarNaPartida);
            this.Controls.Add(this.txbNomeJogador);
            this.Controls.Add(this.lblSenhaPartidaEntrar);
            this.Controls.Add(this.txbNomeNovaPartida);
            this.Controls.Add(this.txbSenhaPartidaEntrar);
            this.Controls.Add(this.txbSenhaNovaPartida);
            this.Controls.Add(this.lblIdPartidaCriada);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.lblSenhaNovaPartida);
            this.Controls.Add(this.btnCriarNovaPartida);
            this.MinimumSize = new System.Drawing.Size(687, 579);
            this.Name = "FrmInicial";
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
        private System.Windows.Forms.Label lblHistorico;
    }
}

