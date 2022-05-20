using System;
using System.Windows.Forms;

namespace Calculadora_inf319
{
    public partial class Form1 : Form
    {
        String operador;
        double a = 0;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text += ((Button)sender).Text;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "";
            a = 0;
        }
        private void btnsuma_Click(object sender, EventArgs e)
        {
           a = a + Convert.ToSingle(Pantalla.Text);
            Pantalla.Text = "";
            operador = "+";
        }
       

        private void btnresta_Click(object sender, EventArgs e)
        {
            a = a - Convert.ToSingle(Pantalla.Text);
            Pantalla.Text = "";
            operador = "-";
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            a = a * Convert.ToSingle(Pantalla.Text);
            Pantalla.Text = "";
            operador = "*";

        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            a = a / Convert.ToSingle(Pantalla.Text);
            Pantalla.Text = "";
            operador = "/";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                Pantalla.Text = Convert.ToString(a + Convert.ToSingle(Pantalla.Text));
            }
            else if (operador == "-")
            {
                Pantalla.Text = Convert.ToString(a - Convert.ToSingle(Pantalla.Text));
            }           
            else if (operador == "*")
            {
               Pantalla.Text = Convert.ToString(a * Convert.ToSingle(Pantalla.Text));
            }                       
            else if (operador == "/")
            {
                Pantalla.Text = Convert.ToString(a / Convert.ToSingle(Pantalla.Text));
            }
        }
    }
}
