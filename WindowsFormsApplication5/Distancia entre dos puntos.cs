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
    public partial class Distancia_entre_dos_puntos : Form
    {
        public Distancia_entre_dos_puntos()
        {
            InitializeComponent();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            /*double xis1, xis2, yis1, yis2;
            if (x1.Text == "" || x2.Text == "" || y1.Text == "" || y2.Text == "")
            {
                resultado.Text = "Ingrese un valor válido porfavor";
            }
            else 
            {
                double distancia;
                xis1 = Convert.ToDouble(x1.Text);
                xis2 = Convert.ToDouble(x2.Text);
                yis1 = Convert.ToDouble(y1.Text);
                yis2 = Convert.ToDouble(y2.Text);

                distancia = Math.Sqrt(Math.Pow((xis2 - xis1), 2) + Math.Pow((yis2 - yis1), 2));
                resultado.Text = distancia.ToString();
            }
            */
        }

        eje obj = new eje();
        private void x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void x2_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void y2_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Regresar = new Geometria_Analítica();
            Regresar.Show();
            this.Hide();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double xis1, xis2, yis1, yis2;
            if (x1.Text == "" || x2.Text == "" || y1.Text == "" || y2.Text == "")
            {
                resultado.Text = "Ingrese un valor válido porfavor";
            }
            else
            {
                double distancia;
                xis1 = Convert.ToDouble(x1.Text);
                xis2 = Convert.ToDouble(x2.Text);
                yis1 = Convert.ToDouble(y1.Text);
                yis2 = Convert.ToDouble(y2.Text);

                distancia = Math.Sqrt(Math.Pow((xis2 - xis1), 2) + Math.Pow((yis2 - yis1), 2));
                resultado.Text = distancia.ToString();
            }
        }

        private void x1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void y1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
