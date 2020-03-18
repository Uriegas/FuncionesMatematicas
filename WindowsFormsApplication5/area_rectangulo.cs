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
    public partial class area_rectangulo : Form
    {
        public area_rectangulo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form sacararea = new Form2();
            sacararea.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (basetext.Text == "" || alturatext.Text == "")
            {
                lbl1.Text = ("No ha ingresado ningún valor");
            }
            else
            {
                double base1 = 0, altura = 0, resultado = 0, resultadoper=0;
                base1 = Convert.ToDouble(basetext.Text);
                altura = Convert.ToDouble(alturatext.Text);
                resultado = (base1 * altura);
                resultadoper = (2 * altura) + (2 * base1);
                if (radiocm.Checked == true)
                {
                    resultadoarea.Text = Convert.ToString(resultado + "cm²");
                    txtper.Text = Convert.ToString(resultadoper + "cm");
                }
                else
                {
                    if (radiometros.Checked == true)
                    {
                        resultadoarea.Text = Convert.ToString(resultado + "m²");
                        txtper.Text = Convert.ToString(resultadoper + "m");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            basetext.Clear();
            alturatext.Clear();
            resultadoarea.Clear();
            txtper.Clear();
            radiometros.Checked = false;
            radiocm.Checked = false;
            lbl1.Text = "";
        }

        private void area_rectangulo_Load(object sender, EventArgs e)
        {

        }
        eje obj = new eje();
        private void basetext_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void alturatext_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
