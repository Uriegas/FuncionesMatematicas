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
    public partial class area_pentagono : Form
    {
        public area_pentagono()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form sacar_area = new Form2();
            sacar_area.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ladopent.Text == "" || apotemares.Text == "")
            {
                lbl1.Text = ("No se ha ingresado ningún valor");
            }
            else
            {
                double lado = 0, apotema = 0, resultado = 0, perimetro = 0,resultadoperimetro=0;
                lado = Convert.ToDouble(ladopent.Text);
                apotema = Convert.ToDouble(apotemares.Text);
                perimetro = 5 * lado;
                resultado = (perimetro * apotema) / 2;
                resultadoperimetro = lado * 5;
                if (radiocm.Checked == true)
                {
                    resultadoarea.Text = Convert.ToString(resultado + "cm²");
                    txtper.Text = Convert.ToString(resultadoperimetro + "cm");
                }
                else
                {
                    if (radiom.Checked == true)
                    {
                        resultadoarea.Text = Convert.ToString(resultado + "m²");
                        txtper.Text = Convert.ToString(resultadoperimetro + "m");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            apotemares.Clear();
            ladopent.Clear();
            resultadoarea.Clear();
            txtper.Clear();
            radiom.Checked = false;
            radiocm.Checked = false;
            lbl1.Text = "";
        }
        eje obj = new eje();
        private void ladopent_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void apotemares_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
