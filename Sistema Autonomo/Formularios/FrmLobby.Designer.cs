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
            this.lsvListaJogadoresPartida = new System.Windows.Forms.ListView();
            this.lblIdJogadorCriado = new System.Windows.Forms.Label();
            this.lblCorCriada = new System.Windows.Forms.Label();
            this.lblSenhaCriada = new System.Windows.Forms.Label();
            this.lblListaJogadoresPartida = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvListaJogadoresPartida
            // 
            this.lsvListaJogadoresPartida.HideSelection = false;
            this.lsvListaJogadoresPartida.Location = new System.Drawing.Point(125, 50);
            this.lsvListaJogadoresPartida.Name = "lsvListaJogadoresPartida";
            this.lsvListaJogadoresPartida.Size = new System.Drawing.Size(121, 153);
            this.lsvListaJogadoresPartida.TabIndex = 16;
            this.lsvListaJogadoresPartida.UseCompatibleStateImageBehavior = false;
            this.lsvListaJogadoresPartida.View = System.Windows.Forms.View.List;
            // 
            // lblIdJogadorCriado
            // 
            this.lblIdJogadorCriado.AutoSize = true;
            this.lblIdJogadorCriado.Location = new System.Drawing.Point(25, 50);
            this.lblIdJogadorCriado.Name = "lblIdJogadorCriado";
            this.lblIdJogadorCriado.Size = new System.Drawing.Size(57, 13);
            this.lblIdJogadorCriado.TabIndex = 13;
            this.lblIdJogadorCriado.Text = "Id jogador:";
            // 
            // lblCorCriada
            // 
            this.lblCorCriada.AutoSize = true;
            this.lblCorCriada.Location = new System.Drawing.Point(25, 95);
            this.lblCorCriada.Name = "lblCorCriada";
            this.lblCorCriada.Size = new System.Drawing.Size(26, 13);
            this.lblCorCriada.TabIndex = 14;
            this.lblCorCriada.Text = "Cor:";
            // 
            // lblSenhaCriada
            // 
            this.lblSenhaCriada.AutoSize = true;
            this.lblSenhaCriada.Location = new System.Drawing.Point(25, 73);
            this.lblSenhaCriada.Name = "lblSenhaCriada";
            this.lblSenhaCriada.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCriada.TabIndex = 15;
            this.lblSenhaCriada.Text = "Senha:";
            // 
            // lblListaJogadoresPartida
            // 
            this.lblListaJogadoresPartida.AutoSize = true;
            this.lblListaJogadoresPartida.Location = new System.Drawing.Point(131, 34);
            this.lblListaJogadoresPartida.Name = "lblListaJogadoresPartida";
            this.lblListaJogadoresPartida.Size = new System.Drawing.Size(106, 13);
            this.lblListaJogadoresPartida.TabIndex = 17;
            this.lblListaJogadoresPartida.Text = "Jogadores na partida";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(339, 62);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(100, 23);
            this.btnIniciarPartida.TabIndex = 18;
            this.btnIniciarPartida.Text = "IniciarPartida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // FrmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 357);
            this.Controls.Add(this.lsvListaJogadoresPartida);
            this.Controls.Add(this.lblIdJogadorCriado);
            this.Controls.Add(this.lblCorCriada);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblSenhaCriada);
            this.Controls.Add(this.lblListaJogadoresPartida);
            this.Name = "FrmLobby";
            this.Text = "frmLobby";
            this.Load += new System.EventHandler(this.FrmLobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvListaJogadoresPartida;
        private System.Windows.Forms.Label lblIdJogadorCriado;
        private System.Windows.Forms.Label lblCorCriada;
        private System.Windows.Forms.Label lblSenhaCriada;
        private System.Windows.Forms.Label lblListaJogadoresPartida;
        private System.Windows.Forms.Button btnIniciarPartida;
    }
}