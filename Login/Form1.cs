using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAcep_Click(object sender, EventArgs e)
        {
            if (TxtboxUsuario.Text == "Mario" && textBoxContra.Text == "Usuario36" )
            {
                MessageBox.Show("Ingresado");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Icorrecto Pruebe de Nuevo...");
                TxtboxUsuario.Text = "";
                textBoxContra.Text = "";
            }
                              
        }
    }
}
