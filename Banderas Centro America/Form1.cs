using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banderas_Centro_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/David Ocaña/Documents/Banderas Centro America/" + Paises + ".png";
        }

        private void Paises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
