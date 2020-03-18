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
    public partial class Distancia_Punto_Recta : Form
    {
        public Distancia_Punto_Recta()
        {
            InitializeComponent();
        }
        private void resultado_Click(object sender, EventArgs e)
        {
            /*double xis1, yis1, a, b, c;
            if (x1.Text == "" || y1.Text == "" || rectaA.Text == "" || rectaB.Text == "" || rectaC.Text == "")
            {
                resultado.Text = "Ingrese un valor válido porfavor";
            }
            else
            {
                double distancia;
                double divisor;//para combrobar que divisor = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) != 0
                xis1 = Convert.ToDouble(x1.Text);
                yis1 = Convert.ToDouble(y1.Text);
                a = Convert.ToDouble(rectaA.Text);
                b = Convert.ToDouble(rectaB.Text);
                c = Convert.ToDouble(rectaC.Text);
                divisor = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                if (divisor != 0)
                {
                    distancia = (a * xis1) + (b * yis1) + c;
                    resultado.Text = distancia.ToString();
                }
                else {
                    resultado.Text = "Error (división entre 0)";
                }
            }*/
        }

        eje obj = new eje();
        private void x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void rectaA_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void rectaB_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void rectaC_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }



        private void calcular_Click(object sender, EventArgs e)
        {
            double xis1, yis1, a, b, c;
            if (x1.Text == "" || y1.Text == "" || rectaA.Text == "" || rectaB.Text == "" || rectaC.Text == "")
            {
                resultado.Text = "Ingrese un valor válido porfavor";
            }
            else
            {
                double distancia;
                double divisor;//para combrobar que divisor = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) != 0
                xis1 = Convert.ToDouble(x1.Text);
                yis1 = Convert.ToDouble(y1.Text);
                a = Convert.ToDouble(rectaA.Text);
                b = Convert.ToDouble(rectaB.Text);
                c = Convert.ToDouble(rectaC.Text);
                divisor = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                if (divisor != 0)
                {
                    distancia = Math.Abs((a * xis1) + (b * yis1) + c);
                    resultado.Text = distancia.ToString();
                }
                else
                {
                    resultado.Text = "Error (división entre 0)";
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form Regresar = new Geometria_Analítica();
            Regresar.Show();
            this.Hide();
        }
    }
}