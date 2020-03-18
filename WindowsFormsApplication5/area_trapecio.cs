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
    public partial class area_trapecio : Form
    {
        public area_trapecio()
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
            if (bmayor.Text == "" || bmenor.Text == "")
            {
                lbl1.Text = ("No se ingresaron todos los datos");
            }
            else
            {
            double baseM = 0, basem = 0, h = 0, resultado = 0, resultadoper=0;
            baseM = Convert.ToDouble(bmayor.Text);
            basem = Convert.ToDouble(bmenor.Text);
            h = Convert.ToDouble(altura.Text);
            resultado = ((baseM * basem) * h) / 2;
            resultadoper = (2 * baseM) + (2 * basem);
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

        private void button3_Click(object sender, EventArgs e)
        {
            bmayor.Clear();
            bmenor.Clear();
            altura.Clear();
            txtper.Clear();
            resultadoarea.Clear();
            radiocm.Checked = false;
            radiom.Checked = false;
            lbl1.Text = "";
        }

        private void area_trapecio_Load(object sender, EventArgs e)
        {

        }
        eje obj = new eje();
        private void bmayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void bmenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }


    }
}
