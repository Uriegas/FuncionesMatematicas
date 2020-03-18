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
    public partial class Ley_de_Coseno : Form
    {
        public Ley_de_Coseno()
        {
            InitializeComponent();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
                //Dos formas posibles de ingresar valores
            //******3 lados*******************************
            //>>>>>>Obtiene un angulo 
            //******2 lados y el ángulo entre ellos*******
            //>>>>>>Obtiene un lado

            //Declaraciones
            double res = 0;
            int count = 0;
            //Contar casillas vacias
            if (aa.Text == "") { count++; }
            if (bb.Text == "") { count++; }
            if (cc.Text == "") { count++; }
            if (angulo11.Text == "") { count++; }

            if (count > 1) 
            {
                resultado.Text = "Ingrese más valores";
            }
            
            else{
                double a;
                double b;
                double c;
                double angulo;

                if (angulo11.Text == "") 
                { 
                    //Calcular para obtener el angulo
                    a = Convert.ToDouble(aa);
                    b = Convert.ToDouble(bb);
                    c = Convert.ToDouble(cc);

                    res = Math.Cos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c));
                }
                else if (aa.Text == "" || bb.Text == "" || cc.Text == "") 
                {
                    a = Convert.ToDouble(aa);
                    b = Convert.ToDouble(bb);
                    c = Convert.ToDouble(cc);
                    angulo = Convert.ToDouble(angulo11);

                    //Calcular para obtener un lado
                    if (aa.Text == "") 
                    { 
                        //Calcular para lado a
                        a = Math.Pow(b, 2) + Math.Pow(c, 2) - (2 * b * c * Math.Cos(angulo));
                    }
                    else if (bb.Text == "")
                    {
                        //Calcular para lado b
                        b = Math.Pow(a, 2) + Math.Pow(c, 2) - (2 * a * c * Math.Cos(angulo));
                    }
                    else 
                    {
                        //Calcular para lado c
                        c = Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * a * b * Math.Cos(angulo));
                    }
                }
                //Imprimir resultado
                resultado.Text = res.ToString();
            }
        }

        private void calcular_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
