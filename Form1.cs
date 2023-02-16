using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contacto x;
            x = new Contacto();
            x.Nombre = txtNombre.Text;
            x.Telefono = txtTelefono.Text;
            x.FechaNacimiento = DateTime.Parse("2003/01/01");

            Imprimir.Text = "Tu nombre es " + x.Nombre + ", tienes " + x.Edad + " años, y tu número de teléfono es " + x.Telefono + ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
