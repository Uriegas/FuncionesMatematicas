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
    public partial class Cubo : Form
    {
        public Cubo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtaltura.Text == "" || txtancho.Text == "" || txtlargo.Text == "")
            {
                lbl1.Text = ("No se ha ingresado ningún valor");
            }
            else
            {
                double resultado = 0, altura = 0, largo = 0, ancho = 0, resultadoarea;
                altura = Convert.ToDouble(txtaltura.Text);
                largo = Convert.ToDouble(txtlargo.Text);
                ancho = Convert.ToDouble(txtancho.Text);
                resultado = altura * largo * ancho;
                resultadoarea = 6 * (altura * altura);
                txtresultado.Text = Convert.ToString(resultado);
                textBox1.Text = Convert.ToString(resultadoarea);
                lbl2.Text = ("Sus unidades están elevados al cubo");
                lbl3.Text = ("Sus unidades están elevados al cuadrado");
            }
        }

        private void Cubo_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            txtlargo.Clear();
            txtancho.Clear();
            txtaltura.Clear();
            textBox1.Clear();
            lbl1.Text = "";
            lbl2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Regresar = new MenuVolumen();
            Regresar.Show();
            this.Hide();
        }
        eje obj = new eje();
        private void txtlargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
