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
            this.Jogadores = new System.Windows.Forms.ListView();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btPular = new System.Windows.Forms.Button();
            this.btJogar = new System.Windows.Forms.Button();
            this.piratas = new System.Windows.Forms.CheckedListBox();
            this.Cartas = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.btnExibirCartasEmMao = new System.Windows.Forms.Button();
            this.lblCartasNaMao = new System.Windows.Forms.Label();
            this.btnJogadorVez = new System.Windows.Forms.Button();
            this.lblJogadorVez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jogadores
            // 
            this.Jogadores.HideSelection = false;
            this.Jogadores.Location = new System.Drawing.Point(75, 315);
            this.Jogadores.Name = "Jogadores";
            this.Jogadores.Size = new System.Drawing.Size(139, 163);
            this.Jogadores.TabIndex = 46;
            this.Jogadores.UseCompatibleStateImageBehavior = false;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(690, 410);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(85, 36);
            this.btVoltar.TabIndex = 45;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // btPular
            // 
            this.btPular.Location = new System.Drawing.Point(690, 452);
            this.btPular.Name = "btPular";
            this.btPular.Size = new System.Drawing.Size(85, 36);
            this.btPular.TabIndex = 44;
            this.btPular.Text = "Pular";
            this.btPular.UseVisualStyleBackColor = true;
            // 
            // btJogar
            // 
            this.btJogar.Location = new System.Drawing.Point(690, 364);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(85, 40);
            this.btJogar.TabIndex = 43;
            this.btJogar.Text = "Jogar";
            this.btJogar.UseVisualStyleBackColor = true;
            // 
            // piratas
            // 
            this.piratas.FormattingEnabled = true;
            this.piratas.Location = new System.Drawing.Point(484, 364);
            this.piratas.Name = "piratas";
            this.piratas.Size = new System.Drawing.Size(148, 124);
            this.piratas.TabIndex = 42;
            // 
            // Cartas
            // 
            this.Cartas.FormattingEnabled = true;
            this.Cartas.Location = new System.Drawing.Point(276, 364);
            this.Cartas.Name = "Cartas";
            this.Cartas.Size = new System.Drawing.Size(139, 124);
            this.Cartas.TabIndex = 41;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(75, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(140, 223);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnExibirTabuleiro
            // 
            this.btnExibirTabuleiro.Location = new System.Drawing.Point(276, 37);
            this.btnExibirTabuleiro.Name = "btnExibirTabuleiro";
            this.btnExibirTabuleiro.Size = new System.Drawing.Size(139, 23);
            this.btnExibirTabuleiro.TabIndex = 22;
            this.btnExibirTabuleiro.Text = "Exibir tabuleiro";
            this.btnExibirTabuleiro.UseVisualStyleBackColor = true;
            // 
            // btnExibirCartasEmMao
            // 
            this.btnExibirCartasEmMao.Location = new System.Drawing.Point(276, 334);
            this.btnExibirCartasEmMao.Name = "btnExibirCartasEmMao";
            this.btnExibirCartasEmMao.Size = new System.Drawing.Size(139, 23);
            this.btnExibirCartasEmMao.TabIndex = 20;
            this.btnExibirCartasEmMao.Text = "Exibir cartas em mao";
            this.btnExibirCartasEmMao.UseVisualStyleBackColor = true;
            // 
            // lblCartasNaMao
            // 
            this.lblCartasNaMao.AutoSize = true;
            this.lblCartasNaMao.Location = new System.Drawing.Point(66, 42);
            this.lblCartasNaMao.Name = "lblCartasNaMao";
            this.lblCartasNaMao.Size = new System.Drawing.Size(0, 13);
            this.lblCartasNaMao.TabIndex = 19;
            // 
            // btnJogadorVez
            // 
            this.btnJogadorVez.Location = new System.Drawing.Point(75, 34);
            this.btnJogadorVez.Name = "btnJogadorVez";
            this.btnJogadorVez.Size = new System.Drawing.Size(139, 23);
            this.btnJogadorVez.TabIndex = 23;
            this.btnJogadorVez.Text = "Vez de quem?";
            this.btnJogadorVez.UseVisualStyleBackColor = true;
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.Location = new System.Drawing.Point(379, 45);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(0, 13);
            this.lblJogadorVez.TabIndex = 24;
            // 
            // FrmInGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 498);
            this.Controls.Add(this.btnExibirTabuleiro);
            this.Controls.Add(this.Jogadores);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btPular);
            this.Controls.Add(this.lblJogadorVez);
            this.Controls.Add(this.btJogar);
            this.Controls.Add(this.btnJogadorVez);
            this.Controls.Add(this.piratas);
            this.Controls.Add(this.Cartas);
            this.Controls.Add(this.lblCartasNaMao);
            this.Controls.Add(this.btnExibirCartasEmMao);
            this.Name = "FrmInGame";
            this.Text = "frmInGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView Jogadores;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btPular;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.CheckedListBox piratas;
        private System.Windows.Forms.CheckedListBox Cartas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnExibirTabuleiro;
        private System.Windows.Forms.Button btnExibirCartasEmMao;
        private System.Windows.Forms.Label lblCartasNaMao;
        private System.Windows.Forms.Button btnJogadorVez;
        private System.Windows.Forms.Label lblJogadorVez;
    }
}