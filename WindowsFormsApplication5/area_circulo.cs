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
    public partial class area_circulo : Form
    {
        public area_circulo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form calcular_area = new Form2();
            calcular_area.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdiametro.Text == "")
            {
                lbl1.Text = ("No se ha ingreso ningún valor");
            }
            else
            {
                double diacirculo = 0, resultado = 0, resultadoperimetro=0;
                diacirculo = Convert.ToDouble(txtdiametro.Text);
                resultado = 3.1416 * (diacirculo * diacirculo);
                resultadoperimetro = diacirculo * 3.1416;
                if (radiocm.Checked == true)
                {
                    txtresultado.Text = Convert.ToString(resultado + "cm²");
                    txtperimetro.Text = Convert.ToString(resultadoperimetro + "cm");
                }
                else
                {
                    if (radiom.Checked == true)
                    {
                        txtresultado.Text = Convert.ToString(resultado + "m²");
                        txtperimetro.Text = Convert.ToString(resultadoperimetro + "m");
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtdiametro.Clear();
            txtresultado.Clear();
            txtperimetro.Clear();
            radiom.Checked = false;
            radiocm.Checked = false;
            lbl1.Text = "";
        }

        eje obj = new eje();
        private void txtdiametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }


    }
}
