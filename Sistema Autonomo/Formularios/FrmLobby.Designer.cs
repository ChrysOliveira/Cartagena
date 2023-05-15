namespace Sistema_Autonomo.Formularios
{
    partial class FrmLobby
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
            this.lblListaJogadoresPartida = new System.Windows.Forms.Label();
            this.lsvListaJogadoresPartida = new System.Windows.Forms.ListView();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblCorJogador = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblTituloDadosJogador = new System.Windows.Forms.Label();
            this.TimerAttListaJogadores = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblListaJogadoresPartida
            // 
            this.lblListaJogadoresPartida.AutoSize = true;
            this.lblListaJogadoresPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaJogadoresPartida.Location = new System.Drawing.Point(25, 54);
            this.lblListaJogadoresPartida.Name = "lblListaJogadoresPartida";
            this.lblListaJogadoresPartida.Size = new System.Drawing.Size(186, 24);
            this.lblListaJogadoresPartida.TabIndex = 19;
            this.lblListaJogadoresPartida.Text = "Jogadores na partida";
            // 
            // lsvListaJogadoresPartida
            // 
            this.lsvListaJogadoresPartida.HideSelection = false;
            this.lsvListaJogadoresPartida.Location = new System.Drawing.Point(29, 81);
            this.lsvListaJogadoresPartida.Name = "lsvListaJogadoresPartida";
            this.lsvListaJogadoresPartida.Size = new System.Drawing.Size(182, 358);
            this.lsvListaJogadoresPartida.TabIndex = 18;
            this.lsvListaJogadoresPartida.UseCompatibleStateImageBehavior = false;
            this.lsvListaJogadoresPartida.View = System.Windows.Forms.View.List;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(270, 470);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(540, 80);
            this.btnIniciarPartida.TabIndex = 20;
            this.btnIniciarPartida.Text = "IniciarPartida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblCorJogador
            // 
            this.lblCorJogador.AutoSize = true;
            this.lblCorJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorJogador.Location = new System.Drawing.Point(470, 137);
            this.lblCorJogador.Name = "lblCorJogador";
            this.lblCorJogador.Size = new System.Drawing.Size(52, 25);
            this.lblCorJogador.TabIndex = 27;
            this.lblCorJogador.Text = "Cor:";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJogador.Location = new System.Drawing.Point(470, 99);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(38, 25);
            this.lblIdJogador.TabIndex = 26;
            this.lblIdJogador.Text = "ID:";
            // 
            // lblTituloDadosJogador
            // 
            this.lblTituloDadosJogador.AutoSize = true;
            this.lblTituloDadosJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDadosJogador.Location = new System.Drawing.Point(470, 63);
            this.lblTituloDadosJogador.Name = "lblTituloDadosJogador";
            this.lblTituloDadosJogador.Size = new System.Drawing.Size(184, 25);
            this.lblTituloDadosJogador.TabIndex = 28;
            this.lblTituloDadosJogador.Text = "Suas identidades:";
            // 
            // TimerAttListaJogadores
            // 
            this.TimerAttListaJogadores.Enabled = true;
            this.TimerAttListaJogadores.Interval = 5000;
            this.TimerAttListaJogadores.Tick += new System.EventHandler(this.TimerAttListaJogadores_Tick);
            // 
            // FrmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.lblTituloDadosJogador);
            this.Controls.Add(this.lblCorJogador);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblListaJogadoresPartida);
            this.Controls.Add(this.lsvListaJogadoresPartida);
            this.Name = "FrmLobby";
            this.Text = "FrmLobby";
            this.Load += new System.EventHandler(this.FrmLobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaJogadoresPartida;
        private System.Windows.Forms.ListView lsvListaJogadoresPartida;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblCorJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblTituloDadosJogador;
        private System.Windows.Forms.Timer TimerAttListaJogadores;
    }
}