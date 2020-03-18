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
    public partial class Bisectriz : Form
    {
        public Bisectriz()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Regresar = new Menu();
            Regresar.Show();
            this.Hide();
        }
        eje obj = new eje();
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double var1 = 0, var2 = 0,var3 = 0, var4 = 0, var5 = 0, var6 = 0, g1 = 0, g2 = 0, g3 = 0, g4 = 0, g5 = 0, g6 = 0;
            double totx, totg, totaltemp, resu1 = 0, resu2 = 0, resu3 = 0, resu4 = 0, resu5 = 0, resu6 = 0;
            var1 = Convert.ToDouble(x1.Text);
            var2 = Convert.ToDouble(x2.Text);
            var3 = Convert.ToDouble(x3.Text);
            var4 = Convert.ToDouble(x4.Text);
            var5 = Convert.ToDouble(x5.Text);
            var6 = Convert.ToDouble(x6.Text);
            g1 = Convert.ToDouble(gd1.Text);
            g2 = Convert.ToDouble(gd2.Text);
            g3 = Convert.ToDouble(gd3.Text);
            g4 = Convert.ToDouble(gd4.Text);
            g5 = Convert.ToDouble(gd5.Text);
            g6 = Convert.ToDouble(gd6.Text);
            totx = var1 + var2 + var3 + var4 + var5 + var6;
            totg = g1 + g2 + g3 + g4 + g5 + g6;
            if (totg > 180)
            {
                MessageBox.Show("Este ángulo no puede medir más de 180°", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                totaltemp = (180 - totg) / totx;
                resu1 = (var1 * totaltemp) + g1;
                resu2 = (var2 * totaltemp) + g2;
                resu3 = (var3 * totaltemp) + g3;
                resu4 = (var4 * totaltemp) + g4;
                resu5 = (var5 * totaltemp) + g5;
                resu6 = (var6 * totaltemp) + g6;
                txtres1.Text = resu1 + "°";
                txtres2.Text = resu2 + "°";
                txtres3.Text = resu3 + "°";
                txtres4.Text = resu4 + "°";
                txtres5.Text = resu5 + "°";
                txtres6.Text = resu6 + "°";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x1.Clear();
            x2.Clear();
            x3.Clear();
            x4.Clear();
            x5.Clear();
            x6.Clear();
            txtres1.Clear();
            txtres2.Clear();
            txtres3.Clear();
            txtres4.Clear();
            txtres5.Clear();
            txtres6.Clear();
            gd1.Clear();
            gd2.Clear();
            gd3.Clear();
            gd4.Clear();
            gd5.Clear();
            gd6.Clear();
        }
    }
}
