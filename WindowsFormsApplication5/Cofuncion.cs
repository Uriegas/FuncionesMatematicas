using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Cofuncion : Form
    {
        public Cofuncion()
        {
            InitializeComponent();
        }

        private void funcion_SelectedIndexChanged(object sender, EventArgs e)
        {/*
            String mensaje;
            mensaje = funcion.GetItemText(funcion.SelectedItem);
            if (mensaje.CompareTo("Seno") == 0) {
                resultado.Text = ("Coseno");
            }
            else if (mensaje.CompareTo("Coseno") == 0) {
                resultado.Text = ("Seno");
            }
            else if (mensaje.CompareTo("Tangente") == 0)
            {
                resultado.Text = ("Cotangente");
            }
            else if (mensaje.CompareTo("Cotangente") == 0)
            {
                resultado.Text = ("Tangente");
            }
            else if (mensaje.CompareTo("Cosecante") == 0)
            {
                resultado.Text = ("Secante");
            }
            else if (mensaje.CompareTo("Secante") == 0)
            {
                resultado.Text = ("Cosecante");
            }*/
            //resultado.Text=(mensaje);
           // Math.Cos(
        }

        private void medida_TextChanged(object sender, EventArgs e)
        {
           
        }
        eje obj = new eje();
        private void medida_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double angulo;
            String mensaje;
            mensaje = funcion.GetItemText(funcion.SelectedItem);
            if (medida.Text == "" || funcion.GetItemText(funcion.SelectedItem) == "")
            {
                Advertencia.Text = "No ha ingresado ningun valor";
                resultado.Text = "";
            }
            else
            {
                angulo = Convert.ToDouble(medida.Text);

                if (mensaje.CompareTo("Seno") == 0)
                {
                    Advertencia.Text = "";
                    angulo = Math.Cos(angulo);
                    resultado.Text = ("Coseno " + angulo);
                }
                else if (mensaje.CompareTo("Coseno") == 0)
                {
                    Advertencia.Text = "";
                    angulo = Math.Sin(angulo);
                    resultado.Text = ("Seno " + angulo);
                }
                else if (mensaje.CompareTo("Tangente") == 0)
                {
                    Advertencia.Text = "";
                    angulo = Math.Tanh(angulo);
                    resultado.Text = ("Cotangente " + angulo);
                }
                else if (mensaje.CompareTo("Cotangente") == 0)
                {
                    Advertencia.Text = "";
                    angulo = Math.Tan(angulo);
                    resultado.Text = ("Tangente " + angulo);
                }
                else if (mensaje.CompareTo("Cosecante") == 0)
                {
                    Advertencia.Text = "";
                    angulo = Math.Cosh(angulo);
                    resultado.Text = ("Secante " + angulo);
                }
                else if (mensaje.CompareTo("Secante") == 0)
                {
                    Advertencia.Text = "";
                    angulo = Math.Sinh(angulo);
                    resultado.Text = ("Cosecante " + angulo);
                }
            }
        }
    }
}
