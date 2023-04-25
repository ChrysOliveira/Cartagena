using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo
{
    public partial class Partida : Form
    {
        public Partida()
        {
            InitializeComponent();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            panelQualquer.Visible = true;
        }

        
    }
}
