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
            this.components = new System.ComponentModel.Container();
            this.lsbListaPartidas = new System.Windows.Forms.ListBox();
            this.txbNomeNovaPartida = new System.Windows.Forms.TextBox();
            this.lblNomeNovaPartida = new System.Windows.Forms.Label();
            this.lblSenhaNovaPartida = new System.Windows.Forms.Label();
            this.txbSenhaNovaPartida = new System.Windows.Forms.TextBox();
            this.btnCriarNovaPartida = new System.Windows.Forms.Button();
            this.TimerAttListaPartidas = new System.Windows.Forms.Timer(this.components);
            this.btnEntrarNaPartida = new System.Windows.Forms.Button();
            this.txbSenhaPartidaEntrar = new System.Windows.Forms.TextBox();
            this.lblSenhaPartidaEntrar = new System.Windows.Forms.Label();
            this.txbNomeJogador = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbListaPartidas
            // 
            this.lsbListaPartidas.FormattingEnabled = true;
            this.lsbListaPartidas.Location = new System.Drawing.Point(16, 137);
            this.lsbListaPartidas.Name = "lsbListaPartidas";
            this.lsbListaPartidas.Size = new System.Drawing.Size(218, 407);
            this.lsbListaPartidas.TabIndex = 1;
            // 
            // txbNomeNovaPartida
            // 
            this.txbNomeNovaPartida.AccessibleDescription = "";
            this.txbNomeNovaPartida.AccessibleName = "";
            this.txbNomeNovaPartida.Location = new System.Drawing.Point(134, 41);
            this.txbNomeNovaPartida.Name = "txbNomeNovaPartida";
            this.txbNomeNovaPartida.Size = new System.Drawing.Size(100, 20);
            this.txbNomeNovaPartida.TabIndex = 2;
            this.txbNomeNovaPartida.Tag = "";
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
            this.txbSenhaNovaPartida.PasswordChar = '•';
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
            // TimerAttListaPartidas
            // 
            this.TimerAttListaPartidas.Enabled = true;
            this.TimerAttListaPartidas.Interval = 5000;
            this.TimerAttListaPartidas.Tick += new System.EventHandler(this.TimerAttListaPartidas_Tick);
            // 
            // btnEntrarNaPartida
            // 
            this.btnEntrarNaPartida.Location = new System.Drawing.Point(573, 273);
            this.btnEntrarNaPartida.Name = "btnEntrarNaPartida";
            this.btnEntrarNaPartida.Size = new System.Drawing.Size(100, 23);
            this.btnEntrarNaPartida.TabIndex = 7;
            this.btnEntrarNaPartida.Text = "Entrar na Partida";
            this.btnEntrarNaPartida.UseVisualStyleBackColor = true;
            this.btnEntrarNaPartida.Click += new System.EventHandler(this.btnEntrarNaPartida_Click);
            // 
            // txbSenhaPartidaEntrar
            // 
            this.txbSenhaPartidaEntrar.Location = new System.Drawing.Point(608, 247);
            this.txbSenhaPartidaEntrar.Name = "txbSenhaPartidaEntrar";
            this.txbSenhaPartidaEntrar.Size = new System.Drawing.Size(127, 20);
            this.txbSenhaPartidaEntrar.TabIndex = 9;
            // 
            // lblSenhaPartidaEntrar
            // 
            this.lblSenhaPartidaEntrar.AutoSize = true;
            this.lblSenhaPartidaEntrar.Location = new System.Drawing.Point(514, 250);
            this.lblSenhaPartidaEntrar.Name = "lblSenhaPartidaEntrar";
            this.lblSenhaPartidaEntrar.Size = new System.Drawing.Size(88, 13);
            this.lblSenhaPartidaEntrar.TabIndex = 10;
            this.lblSenhaPartidaEntrar.Text = "Senha da partida";
            // 
            // txbNomeJogador
            // 
            this.txbNomeJogador.Location = new System.Drawing.Point(608, 221);
            this.txbNomeJogador.Name = "txbNomeJogador";
            this.txbNomeJogador.Size = new System.Drawing.Size(127, 20);
            this.txbNomeJogador.TabIndex = 11;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(514, 224);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(76, 13);
            this.lblNomeJogador.TabIndex = 12;
            this.lblNomeJogador.Text = "Nome Jogador";
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txbNomeJogador);
            this.Controls.Add(this.lblSenhaPartidaEntrar);
            this.Controls.Add(this.txbSenhaPartidaEntrar);
            this.Controls.Add(this.btnEntrarNaPartida);
            this.Controls.Add(this.btnCriarNovaPartida);
            this.Controls.Add(this.lblSenhaNovaPartida);
            this.Controls.Add(this.txbSenhaNovaPartida);
            this.Controls.Add(this.lblNomeNovaPartida);
            this.Controls.Add(this.txbNomeNovaPartida);
            this.Controls.Add(this.lsbListaPartidas);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmInicial";
            this.Tag = "";
            this.Text = "Cartagena Monteria";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lsbListaPartidas;
        private System.Windows.Forms.TextBox txbNomeNovaPartida;
        private System.Windows.Forms.Label lblNomeNovaPartida;
        private System.Windows.Forms.Label lblSenhaNovaPartida;
        private System.Windows.Forms.TextBox txbSenhaNovaPartida;
        private System.Windows.Forms.Button btnCriarNovaPartida;
        private System.Windows.Forms.Timer TimerAttListaPartidas;
        private System.Windows.Forms.Button btnEntrarNaPartida;
        private System.Windows.Forms.TextBox txbSenhaPartidaEntrar;
        private System.Windows.Forms.Label lblSenhaPartidaEntrar;
        private System.Windows.Forms.TextBox txbNomeJogador;
        private System.Windows.Forms.Label lblNomeJogador;
    }
}

