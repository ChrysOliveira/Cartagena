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
    public partial class FrmTemplate : Form
    {
        public FrmTemplate()
        {
            InitializeComponent();
        }

        public void FrmTemplate_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1080, 720);
        }
    }
}
