namespace Sistema_Autonomo.Formularios
{
    partial class FrmPartidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartidas));
            this.lsbListaPartidas = new System.Windows.Forms.ListBox();
            this.txbNomeNovaPartida = new System.Windows.Forms.TextBox();
            this.TimerAttListaPartidas = new System.Windows.Forms.Timer(this.components);
            this.txbSenhaNovaPartida = new System.Windows.Forms.TextBox();
            this.btnCriarNovaPartida = new System.Windows.Forms.Panel();
            this.txbNomeJogador = new System.Windows.Forms.TextBox();
            this.txbSenhaPartidaEntrar = new System.Windows.Forms.TextBox();
            this.btnEntrarNaPartida = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lsbListaPartidas
            // 
            this.lsbListaPartidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(140)))));
            this.lsbListaPartidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbListaPartidas.FormattingEnabled = true;
            this.lsbListaPartidas.Location = new System.Drawing.Point(20, 86);
            this.lsbListaPartidas.Name = "lsbListaPartidas";
            this.lsbListaPartidas.Size = new System.Drawing.Size(316, 650);
            this.lsbListaPartidas.TabIndex = 1;
            // 
            // txbNomeNovaPartida
            // 
            this.txbNomeNovaPartida.AccessibleDescription = "";
            this.txbNomeNovaPartida.AccessibleName = "";
            this.txbNomeNovaPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(96)))), ((int)(((byte)(56)))));
            this.txbNomeNovaPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomeNovaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeNovaPartida.ForeColor = System.Drawing.Color.White;
            this.txbNomeNovaPartida.Location = new System.Drawing.Point(371, 511);
            this.txbNomeNovaPartida.Name = "txbNomeNovaPartida";
            this.txbNomeNovaPartida.Size = new System.Drawing.Size(292, 28);
            this.txbNomeNovaPartida.TabIndex = 2;
            this.txbNomeNovaPartida.Tag = "";
            // 
            // TimerAttListaPartidas
            // 
            this.TimerAttListaPartidas.Enabled = true;
            this.TimerAttListaPartidas.Interval = 5000;
            this.TimerAttListaPartidas.Tick += new System.EventHandler(this.TimerAttListaPartidas_Tick);
            // 
            // txbSenhaNovaPartida
            // 
            this.txbSenhaNovaPartida.AccessibleDescription = "";
            this.txbSenhaNovaPartida.AccessibleName = "";
            this.txbSenhaNovaPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(96)))), ((int)(((byte)(56)))));
            this.txbSenhaNovaPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSenhaNovaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaNovaPartida.ForeColor = System.Drawing.Color.White;
            this.txbSenhaNovaPartida.Location = new System.Drawing.Point(371, 617);
            this.txbSenhaNovaPartida.Name = "txbSenhaNovaPartida";
            this.txbSenhaNovaPartida.Size = new System.Drawing.Size(292, 28);
            this.txbSenhaNovaPartida.TabIndex = 13;
            this.txbSenhaNovaPartida.Tag = "";
            // 
            // btnCriarNovaPartida
            // 
            this.btnCriarNovaPartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCriarNovaPartida.BackgroundImage")));
            this.btnCriarNovaPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCriarNovaPartida.Location = new System.Drawing.Point(370, 681);
            this.btnCriarNovaPartida.Margin = new System.Windows.Forms.Padding(0);
            this.btnCriarNovaPartida.Name = "btnCriarNovaPartida";
            this.btnCriarNovaPartida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCriarNovaPartida.Size = new System.Drawing.Size(298, 52);
            this.btnCriarNovaPartida.TabIndex = 14;
            this.btnCriarNovaPartida.Click += new System.EventHandler(this.btnCriarNovaPartida_Click);
            this.btnCriarNovaPartida.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCriarNovaPartida_MouseDown);
            this.btnCriarNovaPartida.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCriarNovaPartida_MouseUp);
            // 
            // txbNomeJogador
            // 
            this.txbNomeJogador.AccessibleDescription = "";
            this.txbNomeJogador.AccessibleName = "";
            this.txbNomeJogador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(96)))), ((int)(((byte)(56)))));
            this.txbNomeJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeJogador.ForeColor = System.Drawing.Color.White;
            this.txbNomeJogador.Location = new System.Drawing.Point(717, 511);
            this.txbNomeJogador.Name = "txbNomeJogador";
            this.txbNomeJogador.Size = new System.Drawing.Size(635, 28);
            this.txbNomeJogador.TabIndex = 15;
            this.txbNomeJogador.Tag = "";
            // 
            // txbSenhaPartidaEntrar
            // 
            this.txbSenhaPartidaEntrar.AccessibleDescription = "";
            this.txbSenhaPartidaEntrar.AccessibleName = "";
            this.txbSenhaPartidaEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(96)))), ((int)(((byte)(56)))));
            this.txbSenhaPartidaEntrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSenhaPartidaEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenhaPartidaEntrar.ForeColor = System.Drawing.Color.White;
            this.txbSenhaPartidaEntrar.Location = new System.Drawing.Point(717, 617);
            this.txbSenhaPartidaEntrar.Name = "txbSenhaPartidaEntrar";
            this.txbSenhaPartidaEntrar.Size = new System.Drawing.Size(635, 28);
            this.txbSenhaPartidaEntrar.TabIndex = 16;
            this.txbSenhaPartidaEntrar.Tag = "";
            // 
            // btnEntrarNaPartida
            // 
            this.btnEntrarNaPartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrarNaPartida.BackgroundImage")));
            this.btnEntrarNaPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntrarNaPartida.Location = new System.Drawing.Point(716, 679);
            this.btnEntrarNaPartida.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntrarNaPartida.Name = "btnEntrarNaPartida";
            this.btnEntrarNaPartida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEntrarNaPartida.Size = new System.Drawing.Size(636, 52);
            this.btnEntrarNaPartida.TabIndex = 15;
            this.btnEntrarNaPartida.Click += new System.EventHandler(this.btnEntrarNaPartida_Click);
            this.btnEntrarNaPartida.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEntrarNaPartida_MouseDown);
            this.btnEntrarNaPartida.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEntrarNaPartida_MouseUp);
            // 
            // FrmPartidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.btnEntrarNaPartida);
            this.Controls.Add(this.txbSenhaPartidaEntrar);
            this.Controls.Add(this.txbNomeJogador);
            this.Controls.Add(this.btnCriarNovaPartida);
            this.Controls.Add(this.txbSenhaNovaPartida);
            this.Controls.Add(this.txbNomeNovaPartida);
            this.Controls.Add(this.lsbListaPartidas);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmPartidas";
            this.Tag = "";
            this.Text = "Cartagena Monteria";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lsbListaPartidas;
        private System.Windows.Forms.TextBox txbNomeNovaPartida;
        private System.Windows.Forms.Timer TimerAttListaPartidas;
        private System.Windows.Forms.TextBox txbSenhaNovaPartida;
        private System.Windows.Forms.Panel btnCriarNovaPartida;
        private System.Windows.Forms.TextBox txbNomeJogador;
        private System.Windows.Forms.TextBox txbSenhaPartidaEntrar;
        private System.Windows.Forms.Panel btnEntrarNaPartida;
    }
}

