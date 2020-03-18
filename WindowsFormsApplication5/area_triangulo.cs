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
    public partial class area_triangulo : Form
    {
        public area_triangulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sacararea = new Form2();
            sacararea.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void area_triangulo_Load(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (textaltura.Text == "" || textbase.Text == "")
            {
                lbl1.Text = ("No se ingresaron todos los valores");
            }
            else
            {
                //Definición de variables
                double lado = 0, altura = 0, resultado = 0, resultadoper=0;
                lado = Convert.ToDouble(textbase.Text);
                altura = Convert.ToDouble(textaltura.Text);
                resultado = (lado * altura) / 2;
                resultadoper = (lado * 2) + altura;
                if (radiocm.Checked == true)
                {
                    resultadoarea.Text = Convert.ToString(resultado + "cm²");
                    txtper.Text = Convert.ToString(resultadoper + "cm");
                }
                else
                {
                    if (radiom.Checked == true)
                    {
                        resultadoarea.Text = Convert.ToString(resultado + "m²");
                        txtper.Text = Convert.ToString(resultadoper + "m");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textaltura.Clear();
            textbase.Clear();
            resultadoarea.Clear();
            radiom.Checked = false;
            radiocm.Checked = false;
            txtper.Clear();
            lbl1.Text = "";
        }
        eje obj = new eje();
        private void textbase_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
