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
    public partial class CatetoB : Form
    {
        public CatetoB()
        {
            InitializeComponent();
        }

        private void CatetoB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txta.Text == "" || txthipotenusa.Text == "")
            {
                lbl1.Text = ("No se ha ingresado ningún valor");
            }
            else
            {
                double catetoa = 0, catetob = 0, hipotenusa = 0;
                catetoa = Convert.ToDouble(txta.Text);
                hipotenusa = Convert.ToDouble(txthipotenusa.Text);
                catetoa = catetoa * catetoa;
                hipotenusa = hipotenusa * hipotenusa;

                catetob = Math.Sqrt(catetoa);
                catetob = catetob + Math.Sqrt(hipotenusa);
                catetob = Math.Sqrt(catetob);
                txtresultado.Text = Convert.ToString(catetob);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            txthipotenusa.Clear();
            txta.Clear();
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
    }
}
