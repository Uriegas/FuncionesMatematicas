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
    public partial class area_rombo : Form
    {
        public area_rombo()
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
            if (diamayor.Text == "" || diamenor.Text == "")
            {
                lbl1.Text = ("No ingresaron todos los datos");
            }
            else
            {
                double mayor = 0, menor = 0, resultado = 0,resultadoper=0,num=0;
                mayor = Convert.ToDouble(diamayor.Text);
                menor = Convert.ToDouble(diamenor.Text);
                resultado = (mayor * menor) / 2;
                num = (mayor * mayor) + (menor * menor);
                resultadoper = (Math.Sqrt(num)*2);
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
            diamayor.Clear();
            diamenor.Clear();
            resultadoarea.Clear();
            txtper.Clear();
            radiom.Checked = false;
            radiocm.Checked = false;
            lbl1.Text = "";
        }

        private void area_rombo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        eje obj = new eje();
        private void diamayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void diamenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
