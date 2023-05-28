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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLobby));
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.TimerAttListaJogadores = new System.Windows.Forms.Timer(this.components);
            this.lsvListaJogadoresPartida = new System.Windows.Forms.ListBox();
            this.btnIniciarPartida = new System.Windows.Forms.Panel();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblCorJogador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(96)))), ((int)(((byte)(56)))));
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.ForeColor = System.Drawing.Color.White;
            this.lblNomeJogador.Location = new System.Drawing.Point(384, 349);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(68, 25);
            this.lblNomeJogador.TabIndex = 28;
            this.lblNomeJogador.Text = "Nome";
            // 
            // TimerAttListaJogadores
            // 
            this.TimerAttListaJogadores.Enabled = true;
            this.TimerAttListaJogadores.Interval = 5000;
            this.TimerAttListaJogadores.Tick += new System.EventHandler(this.TimerAttListaJogadores_Tick);
            // 
            // lsvListaJogadoresPartida
            // 
            this.lsvListaJogadoresPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(140)))));
            this.lsvListaJogadoresPartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvListaJogadoresPartida.FormattingEnabled = true;
            this.lsvListaJogadoresPartida.Location = new System.Drawing.Point(20, 86);
            this.lsvListaJogadoresPartida.Name = "lsvListaJogadoresPartida";
            this.lsvListaJogadoresPartida.Size = new System.Drawing.Size(316, 650);
            this.lsvListaJogadoresPartida.TabIndex = 29;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarPartida.BackgroundImage")));
            this.btnIniciarPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIniciarPartida.Location = new System.Drawing.Point(374, 681);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(0);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIniciarPartida.Size = new System.Drawing.Size(991, 52);
            this.btnIniciarPartida.TabIndex = 30;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            this.btnIniciarPartida.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIniciarPartida_MouseDown);
            this.btnIniciarPartida.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIniciarPartida_MouseUp);
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(96)))), ((int)(((byte)(56)))));
            this.lblIdJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJogador.ForeColor = System.Drawing.Color.White;
            this.lblIdJogador.Location = new System.Drawing.Point(384, 474);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(29, 25);
            this.lblIdJogador.TabIndex = 31;
            this.lblIdJogador.Text = "id";
            // 
            // lblCorJogador
            // 
            this.lblCorJogador.AutoSize = true;
            this.lblCorJogador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(96)))), ((int)(((byte)(56)))));
            this.lblCorJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorJogador.ForeColor = System.Drawing.Color.White;
            this.lblCorJogador.Location = new System.Drawing.Point(384, 599);
            this.lblCorJogador.Name = "lblCorJogador";
            this.lblCorJogador.Size = new System.Drawing.Size(46, 25);
            this.lblCorJogador.TabIndex = 32;
            this.lblCorJogador.Text = "Cor";
            // 
            // FrmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.lblCorJogador);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lsvListaJogadoresPartida);
            this.Controls.Add(this.lblNomeJogador);
            this.DoubleBuffered = true;
            this.Name = "FrmLobby";
            this.Text = "FrmLobby";
            this.Load += new System.EventHandler(this.FrmLobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Timer TimerAttListaJogadores;
        private System.Windows.Forms.ListBox lsvListaJogadoresPartida;
        private System.Windows.Forms.Panel btnIniciarPartida;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblCorJogador;
    }
}