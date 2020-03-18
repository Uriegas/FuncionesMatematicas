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
    public partial class area_cuadrado : Form
    {
        public area_cuadrado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form sacararea = new Form2();
            sacararea.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ladocuadrado.Text == "")
            {
                lbl1.Text = ("No se ha ingreso ningún valor");
            }
            else
            {
                //Definición de variables
                double lado = 0, resultado, resultadoperimetro=0;
                lado = Convert.ToDouble(ladocuadrado.Text);
                resultado = lado * lado;
                resultadoperimetro = lado * 4;
                if (radiocm.Checked == true)
                {
                    resultadoarea.Text = Convert.ToString(resultado + "cm²");
                    txtresultado.Text = Convert.ToString(resultado + "cm");
                }
                else
                {
                    if (radiom.Checked == true)
                    {
                        resultadoarea.Text = Convert.ToString(resultado + "m²");
                        txtresultado.Text = Convert.ToString(resultado + "m");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ladocuadrado.Clear();
            resultadoarea.Clear();
            txtresultado.Clear();
            radiom.Checked = false;
            radiocm.Checked = false;
            lbl1.Text = "";
        }

        private void area_cuadrado_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        eje obj = new eje();
        private void ladocuadrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
