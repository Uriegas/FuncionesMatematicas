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
    public partial class AreaSombreada : Form
    {
        public AreaSombreada()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radiofig2.Checked == true)
            {
                if (txtcuad.Text == "")
                {
                    lbl1.Text = ("Ingrese valores");
                }
                else
                {
                    double lado = 0, resultado = 0, rescirculo = 0, rescuadrado = 0;
                    lado = Convert.ToDouble(txtcuad.Text);
                    rescuadrado = (lado * lado) * 2;
                    rescirculo = (3.1416 * (lado * lado)) / 2;
                    resultado = rescuadrado + rescirculo;
                    txtres.Text = Convert.ToString(resultado);
                }

            }
            else
            {
                lbl1.Text = ("Ingrese valores");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radiofig1.Checked == true)
            {
                if (txtcuadrado.Text == "" || txtcirculo.Text == "")
                {
                    lbl1.Text = ("Ingrese valores");
                }
                else
                {
                    double lado = 0, resultado, resultadocirculo = 0, radio = 0, total = 0;
                    lado = Convert.ToDouble(txtcuadrado.Text);
                    radio = Convert.ToDouble(txtcirculo.Text);
                    resultado = lado * lado;
                    resultadocirculo = 3.1416 * (radio * radio);
                    total = resultado - resultadocirculo;
                    total=Math.Abs(total);
                    txtresultado.Text = Convert.ToString(total);
                }
            }
            else
            {
                lbl1.Text = ("Ingrese valores");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radiofig3.Checked == true)
            {
                if (txtlargo.Text == "" || txtancho.Text == "")
                {
                    lbl1.Text = ("Ingrese valores");
                }
                else
                {
                    double largo=0, ancho=0, resrectangulo=0, rescirculo=0, resultado = 0;
                    largo = Convert.ToDouble(txtlargo.Text);
                    ancho = Convert.ToDouble(txtancho.Text);
                    resrectangulo = largo * ancho;
                    rescirculo = 3.1416 * (ancho * ancho);
                    resultado = resrectangulo - rescirculo;
                    resultado = Math.Abs(resultado);
                    txtresu.Text = Convert.ToString(resultado);
                }
            }
            else
            {
                lbl1.Text = ("Ingrese valores");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radiofig4.Checked == true)
            {
                if (txtcuadrado1.Text=="" || txtbase.Text=="" || txtaltura.Text=="" ||txtlargorec.Text=="" || txtrecancho.Text=="")
                {
                    lbl1.Text = ("Ingrese valores");
                }
                else
                {
                    double ladocuadrado = 0, base1 = 0, altura = 0, largo1 = 0, ancho1 = 0, rescuadrado = 0, restriangulo = 0, resrectangulo = 0, resultado = 0;
                    ladocuadrado = Convert.ToDouble(txtcuadrado1.Text);
                    base1 = Convert.ToDouble(txtbase.Text);
                    altura = Convert.ToDouble(txtaltura.Text);
                    largo1 = Convert.ToDouble(txtlargorec.Text);
                    ancho1 = Convert.ToDouble(txtrecancho.Text);
                    rescuadrado = ladocuadrado * ladocuadrado;
                    restriangulo = (base1 * altura) / 2;
                    resrectangulo = largo1 * ancho1;
                    resultado = rescuadrado + restriangulo + resrectangulo;
                    txtresultado1.Text = Convert.ToString(resultado);

                }
            }
            else
            {
                lbl1.Text = ("Ingrese valores");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtresultado1.Clear();
            txtresultado.Clear();
            txtresu.Clear();
            txtres.Clear();
            txtrecancho.Clear();
            txtlargorec.Clear();
            txtlargo.Clear();
            txtcuadrado1.Clear();
            txtcuadrado.Clear();
            txtcuad.Clear();
            txtcirculo.Clear();
            txtbase.Clear();
            txtancho.Clear();
            txtaltura.Clear();
            lbl1.Text = "";
            radiofig1.Checked = false;
            radiofig2.Checked = false;
            radiofig3.Checked = false;
            radiofig4.Checked = false;
        }
        eje obj = new eje();
        private void txtcuadrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtcirculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtresultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
