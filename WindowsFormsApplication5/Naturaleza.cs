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
    public partial class Naturaleza : Form
    {
        public Naturaleza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == "" || txthipotenusa.Text == "")
            {
                lbl1.Text = ("No se ha ingresado ningún valor");
            }
            else
            {
                double catetoa = 0, catetob = 0, hipotenusa = 0, resultado = 0;
                catetoa = Convert.ToDouble(txta.Text);
                catetob = Convert.ToDouble(txtb.Text);
                hipotenusa = Convert.ToDouble(txthipotenusa.Text);
                catetoa = catetoa * catetoa;
                catetob = catetob * catetob;
                hipotenusa = hipotenusa * hipotenusa;
                resultado = catetoa + catetob;
                if (hipotenusa < resultado)
                {
                    txtresultado.Text = ("Triángulo acutángulo");
                }
                else
                {
                    if (hipotenusa > resultado)
                    {
                        txtresultado.Text = ("Triángulo obtusángulo");
                    }
                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            txtresultado.Clear();
            txtb.Clear();
            txta.Clear();
            txthipotenusa.Clear();
            lbl1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Regresar = new Pitagoras();
            Regresar.Show();
            this.Hide();
        }
        eje obj = new eje();

        private void txthipotenusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

    }
}
