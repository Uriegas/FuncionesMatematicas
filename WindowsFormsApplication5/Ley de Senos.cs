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
    public partial class Ley_de_Senos : Form
    {
        public Ley_de_Senos()
        {
            InitializeComponent();
        }

        private void resultado_Click(object sender, EventArgs e)
        {/*
            double a;
            double b;
            double c;
            double angulo1;
            double angulo2;
            double angulo3;
            double res=0;
            
            a = Convert.ToDouble(aa.Text);
            b = Convert.ToDouble(bb.Text);
            c = Convert.ToDouble(cc.Text);
            angulo1 = Convert.ToDouble(angulo11.Text);
            angulo2 = Convert.ToDouble(angulo22.Text);
            angulo3 = Convert.ToDouble(angulo33.Text);

            if (a == 0)
            {
                //to get a
                res = (Math.Sin(angulo1) * b) / Math.Sin(angulo2);
            }
            else if (b == 0) 
            {
                //to get b
                res = (Math.Sin(angulo2) * a) / Math.Sin(angulo1);
            }
            else if (angulo1 == 0)
            {
                //to get angulo1
                res = Math.Sinh((Math.Sin(angulo2) * a) / b);
            }
            else if (angulo2 == 0)
            {
                //to get angulo2
                res = Math.Sinh((Math.Sin(angulo1) * b) / a);
            }*/
            /*
            //to get a
            res = (Math.Sin(angulo1)*b)/Math.Sin(angulo2);
            //to get b
            res = (Math.Sin(angulo2)*a)/Math.Sin(angulo1);
            //to get angulo1
            res = Math.Sinh((Math.Sin(angulo2)*a)/b);
            //to get angulo2
            res = Math.Sinh((Math.Sin(angulo1)*b)/a);
            
            resultado.Text = res.ToString();*/
        }
        private void regresar_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }
        eje obj = new eje();
        private void aa_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
        private void bb_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
        private void angulo11_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
        private void angulo22_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            double angulo1;
            double angulo2;
            double angulo3;
            double res = 0;

            a = Convert.ToDouble(aa.Text);
            b = Convert.ToDouble(bb.Text);
            c = Convert.ToDouble(cc.Text);
            angulo1 = Convert.ToDouble(angulo11.Text);
            angulo2 = Convert.ToDouble(angulo22.Text);
            angulo3 = Convert.ToDouble(angulo33.Text);

            if (a == 0)
            {
                //to get a
                res = (Math.Sin(angulo1) * b) / Math.Sin(angulo2);
            }
            else if (b == 0)
            {
                //to get b
                res = (Math.Sin(angulo2) * a) / Math.Sin(angulo1);
            }
            else if (angulo1 == 0)
            {
                //to get angulo1
                res = Math.Sinh((Math.Sin(angulo2) * a) / b);
            }
            else if (angulo2 == 0)
            {
                //to get angulo2
                res = Math.Sinh((Math.Sin(angulo1) * b) / a);
            }
            resultado.Text = res.ToString();
        }
    }
}
