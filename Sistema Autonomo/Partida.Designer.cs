namespace Sistema_Autonomo
{
    partial class Partida
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
            System.Windows.Forms.Label lblMostrarVez;
            this.panelQualquer = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblJogadorVez = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btPular = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.Cartas = new System.Windows.Forms.CheckedListBox();
            this.piratas = new System.Windows.Forms.CheckedListBox();
            this.btJogar = new System.Windows.Forms.Button();
            this.Jogadores = new System.Windows.Forms.ListView();
            this.Tabuleiro = new System.Windows.Forms.Panel();
            this.btnExibirTabuleiro = new System.Windows.Forms.Button();
            this.lblTabuleiro = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            lblMostrarVez = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Tabuleiro.SuspendLayout();
            this.SuspendLayout();
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 248);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(140, 313);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.panel5.Location = new System.Drawing.Point(387, 373);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 188);
            this.panel5.TabIndex = 57;
            // 
            // lblJogadorVez
            // 
            this.lblJogadorVez.AutoSize = true;
            this.lblJogadorVez.Location = new System.Drawing.Point(17, 33);
            this.lblJogadorVez.MaximumSize = new System.Drawing.Size(150, 142);
            this.lblJogadorVez.Name = "lblJogadorVez";
            this.lblJogadorVez.Size = new System.Drawing.Size(35, 13);
            this.lblJogadorVez.TabIndex = 1;
            this.lblJogadorVez.Text = "label6";
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
            this.label3.Location = new System.Drawing.Point(217, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Jogadores na partida";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btPular);
            this.groupBox1.Controls.Add(this.btVoltar);
            this.groupBox1.Controls.Add(this.Cartas);
            this.groupBox1.Controls.Add(this.piratas);
            this.groupBox1.Controls.Add(this.btJogar);
            this.groupBox1.Location = new System.Drawing.Point(565, 373);
            this.groupBox1.MinimumSize = new System.Drawing.Size(502, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 188);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btPular
            // 
            this.btPular.Location = new System.Drawing.Point(366, 121);
            this.btPular.Name = "btPular";
            this.btPular.Size = new System.Drawing.Size(85, 36);
            this.btPular.TabIndex = 44;
            this.btPular.Text = "Pular";
            this.btPular.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(366, 79);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(85, 36);
            this.btVoltar.TabIndex = 45;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // Cartas
            // 
            this.Cartas.FormattingEnabled = true;
            this.Cartas.Location = new System.Drawing.Point(20, 33);
            this.Cartas.Name = "Cartas";
            this.Cartas.Size = new System.Drawing.Size(139, 124);
            this.Cartas.TabIndex = 41;
            // 
            // piratas
            // 
            this.piratas.FormattingEnabled = true;
            this.piratas.Location = new System.Drawing.Point(194, 33);
            this.piratas.Name = "piratas";
            this.piratas.Size = new System.Drawing.Size(148, 124);
            this.piratas.TabIndex = 42;
            // 
            // btJogar
            // 
            this.btJogar.Location = new System.Drawing.Point(366, 33);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(85, 40);
            this.btJogar.TabIndex = 43;
            this.btJogar.Text = "Jogar";
            this.btJogar.UseVisualStyleBackColor = true;
            // 
            // Jogadores
            // 
            this.Jogadores.HideSelection = false;
            this.Jogadores.Location = new System.Drawing.Point(217, 396);
            this.Jogadores.Name = "Jogadores";
            this.Jogadores.Size = new System.Drawing.Size(139, 163);
            this.Jogadores.TabIndex = 54;
            this.Jogadores.UseCompatibleStateImageBehavior = false;
            // 
            // Tabuleiro
            // 
            this.Tabuleiro.Controls.Add(this.btnExibirTabuleiro);
            this.Tabuleiro.Controls.Add(lblMostrarVez);
            this.Tabuleiro.Controls.Add(this.lblTabuleiro);
            this.Tabuleiro.Location = new System.Drawing.Point(217, 47);
            this.Tabuleiro.Name = "Tabuleiro";
            this.Tabuleiro.Size = new System.Drawing.Size(850, 307);
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
            // lblMostrarVez
            // 
            lblMostrarVez.AutoSize = true;
            lblMostrarVez.Location = new System.Drawing.Point(35, 50);
            lblMostrarVez.MaximumSize = new System.Drawing.Size(139, 143);
            lblMostrarVez.Name = "lblMostrarVez";
            lblMostrarVez.Size = new System.Drawing.Size(91, 13);
            lblMostrarVez.TabIndex = 24;
            lblMostrarVez.Text = "aqui ta o tabuleiro";
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
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 789);
            this.Controls.Add(this.panelQualquer);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Jogadores);
            this.Controls.Add(this.Tabuleiro);
            this.Name = "Partida";
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblJogadorVez;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPular;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.CheckedListBox Cartas;
        private System.Windows.Forms.CheckedListBox piratas;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.ListView Jogadores;
        private System.Windows.Forms.Panel Tabuleiro;
        private System.Windows.Forms.Button btnExibirTabuleiro;
        private System.Windows.Forms.Label lblTabuleiro;
        private System.Windows.Forms.Button btnIniciarPartida;
    }
}