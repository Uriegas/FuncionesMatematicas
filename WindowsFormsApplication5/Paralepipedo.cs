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
    public partial class Paralepipedo : Form
    {
        public Paralepipedo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (txtaltura.Text == "" || txtancho.Text == "" || txtlargo.Text == "")
            {
                lbl1.Text = ("No se ha ingresado ningún valor");
            }
            else
            {
                double largo = 0, ancho = 0, altura = 0, resvolumen = 0, resarea = 0;
                altura = Convert.ToDouble(txtaltura.Text);
                largo = Convert.ToDouble(txtlargo.Text);
                ancho = Convert.ToDouble(txtancho.Text);
                resarea = 2*((largo*ancho) + (largo*altura)+(ancho*altura));
                resvolumen = largo*ancho*altura;
                txtvolumen.Text = Convert.ToString(resvolumen);
                txtarea.Text = Convert.ToString(resarea);
                lbl2.Text = ("Tu unidad está  elevado al cubo");
                 lbl3.Text=("Tu unidad está elevado al cuadrado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtancho.Clear();
            txtarea.Clear();
            txtlargo.Clear();
            txtvolumen.Clear();
            lbl1.Text="";
            lbl2.Text="";
            lbl3.Text="";
        }

        private void button3_Click(object sender, EventArgs e)
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
