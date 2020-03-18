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
    public partial class paralelogramo : Form
    {
        public paralelogramo()
        {
            InitializeComponent();
        }

        private void paralelogramo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form sacar_area = new Form2();
            sacar_area.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtaltura.Text == "" && txtbase.Text == "")
            {
                lbl1.Text = ("No se ha ingresado ningún valor");
            }
            else
            {
                double altura = 0, lado = 0, resultado = 0, resultadoper=0;
                altura = Convert.ToDouble(txtaltura.Text);
                lado = Convert.ToDouble(txtbase.Text);
                resultado = altura * lado;
                resultadoper = (2 * altura) + (2 * lado);
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
            txtbase.Clear();
            txtaltura.Clear();
            resultadoarea.Clear();
            txtper.Clear();
            radiom.Checked = false;
            radiocm.Checked = false;
            lbl1.Text = "";

        }
        eje obj = new eje();
        private void txtbase_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
