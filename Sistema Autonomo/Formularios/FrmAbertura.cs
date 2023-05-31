using Sistema_Autonomo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo.Formularios
{
    public partial class FrmAbertura : Form
    {
        public FrmAbertura()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmAbertura_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1400, 800);
        }

        private void btnEntrarNoJogo_Click(object sender, EventArgs e)
        {
            FrmPartidas frmPartidas = new FrmPartidas();
            this.Hide();
            frmPartidas.ShowDialog();
            this.Show();
        }

        private void btnEntrarNoJogo_MouseDown(object sender, MouseEventArgs e)
        {
            btnEntrarNoJogo.BackgroundImage = Properties.Resources.BOTAOENTRARBRANCO;
        }

        private void btnEntrarNoJogo_MouseUp(object sender, MouseEventArgs e)
        {
            btnEntrarNoJogo.BackgroundImage = Properties.Resources.BOTAOENTRARPRETO;
        }
    }
}
