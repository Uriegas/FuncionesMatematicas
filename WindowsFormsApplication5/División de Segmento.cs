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
    public partial class División_de_Segmento : Form
    {
        public División_de_Segmento()
        {
            InitializeComponent();
        }

        private void resultado_Click(object sender, EventArgs e)
        {/*
            double xis1, xis2, yis1, yis2, r;
            if (x1.Text == "" || x2.Text == "" || y1.Text == "" || y2.Text == "" || razon.Text == "")
            {
                resultado.Text = "Ingrese un valor válido porfavor";
            }
            else
            {
                double px;
                double py; //para comprobar que r+1 != 0
                xis1 = Convert.ToDouble(x1.Text);
                xis2 = Convert.ToDouble(x2.Text);
                yis1 = Convert.ToDouble(y1.Text);
                yis2 = Convert.ToDouble(y2.Text);
                r = Convert.ToDouble(razon.Text);
                if (r == -1)
                {
                    resultado.Text = "Operación no valida (r = -1)";
                }
                else {
                    px = xis1 + (xis2 * r) / (r + 1);
                    py = yis1 + (yis2 * r) / (r + 1);
                    resultado.Text = px.ToString() + ", " + py.ToString();
                }
                
            }*/
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

        private void razon_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form regresar = new Geometria_Analítica();
            regresar.Show();
            this.Hide();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double xis1, xis2, yis1, yis2, r;
            if (x1.Text == "" || x2.Text == "" || y1.Text == "" || y2.Text == "" || razon.Text == "")
            {
                resultado.Text = "Ingrese un valor válido porfavor";
            }
            else
            {
                double px;
                double py; //para comprobar que r+1 != 0
                xis1 = Convert.ToDouble(x1.Text);
                xis2 = Convert.ToDouble(x2.Text);
                yis1 = Convert.ToDouble(y1.Text);
                yis2 = Convert.ToDouble(y2.Text);
                r = Convert.ToDouble(razon.Text);
                if (r == -1)
                {
                    resultado.Text = "Operación no valida (r = -1)";
                }
                else
                {
                    px = xis1 + (xis2 * r) / (r + 1);
                    py = yis1 + (yis2 * r) / (r + 1);
                    resultado.Text = px.ToString() + ", " + py.ToString();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form regresar = new Geometria_Analítica();
            regresar.Show();
            this.Hide();
        }
    }
}
