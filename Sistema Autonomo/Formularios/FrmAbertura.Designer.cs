namespace Sistema_Autonomo.Formularios
{
    partial class FrmAbertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbertura));
            this.btnEntrarNoJogo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnEntrarNoJogo
            // 
            this.btnEntrarNoJogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrarNoJogo.BackgroundImage")));
            this.btnEntrarNoJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntrarNoJogo.Location = new System.Drawing.Point(517, 590);
            this.btnEntrarNoJogo.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntrarNoJogo.Name = "btnEntrarNoJogo";
            this.btnEntrarNoJogo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEntrarNoJogo.Size = new System.Drawing.Size(365, 84);
            this.btnEntrarNoJogo.TabIndex = 0;
            this.btnEntrarNoJogo.Click += new System.EventHandler(this.btnEntrarNoJogo_Click);
            this.btnEntrarNoJogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEntrarNoJogo_MouseDown);
            this.btnEntrarNoJogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEntrarNoJogo_MouseUp);
            // 
            // FrmAbertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.btnEntrarNoJogo);
            this.DoubleBuffered = true;
            this.Name = "FrmAbertura";
            this.Text = "FrmAbertura";
            this.Load += new System.EventHandler(this.FrmAbertura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnEntrarNoJogo;
    }
}