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
    public partial class Punto_Medio : Form
    {
        public Punto_Medio()
        {
            InitializeComponent();
        }

        private void resultado_Click(object sender, EventArgs e)
        {/*
            double xis1, xis2, yis1, yis2;
            if (x1.Text == "" || x2.Text == "" || y1.Text == "" || y2.Text == "")
            {
                resultado.Text = "Ingrese un valor válido porfavor";
            }
            else
            {
                double px;
                double py;
                xis1 = Convert.ToDouble(x1.Text);
                xis2 = Convert.ToDouble(x2.Text);
                yis1 = Convert.ToDouble(y1.Text);
                yis2 = Convert.ToDouble(y2.Text);

                px = (xis1 + xis2) / 2;
                py = (yis1 + yis2) / 2;
                resultado.Text = px.ToString() + ", " + py.ToString();
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

        private void Calcular_Click(object sender, EventArgs e)
        {
            double xis1, xis2, yis1, yis2;
            if (x1.Text == "" || x2.Text == "" || y1.Text == "" || y2.Text == "")
            {
                resultado.Text = "Ingrese un valor válido porfavor";
            }
            else
            {
                double px;
                double py;
                xis1 = Convert.ToDouble(x1.Text);
                xis2 = Convert.ToDouble(x2.Text);
                yis1 = Convert.ToDouble(y1.Text);
                yis2 = Convert.ToDouble(y2.Text);
               

            /*
                //codigo para buscar un / en el textbox
                int position = 0;
                string dividend = null;
                string divisor = null;
                double res = 0;
                double dividen = 0;
                double diviso = 0;
                for (int i = 0; i < x1.Text.Length; ++i) 
                {
                    if (x1.Text[i] == '/')
                    {
                        position = i;
                        break;
                    }
                    else { continue; }
                }
                for (int i = 0; i < position; ++i) 
                {
                    dividend += x1.Text[i];
                }
                for (int count = (position+1); count<x1.Text.Length; ++count)
                {
                    divisor += x1.Text[count];
                }

                dividen = Convert.ToDouble(dividend);
                diviso = Convert.ToDouble(divisor);
                res = dividen / diviso;
                resultado.Text = res.ToString();
            */

                //Codigo anterior si jala
                px = (xis1 + xis2) / 2;
                py = (yis1 + yis2) / 2;
                resultado.Text = px.ToString() + ", " + py.ToString();
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
