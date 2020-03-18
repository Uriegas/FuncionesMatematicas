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
    public partial class Hipotenusa : Form
    {
        public Hipotenusa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == "")
            {
                lbl1.Text = ("No se ha ingresado ningún valor");
            }
            else
            {
                double catetoa = 0, catetob = 0, hipotenusa = 0;
                catetoa = Convert.ToDouble(txta.Text);
                catetob = Convert.ToDouble(txtb.Text);
                catetoa = catetoa * catetoa;
                catetob = catetob * catetob;
                hipotenusa = Math.Sqrt(catetoa);
                hipotenusa = hipotenusa + Math.Sqrt(catetob);
                hipotenusa = Math.Sqrt(hipotenusa);
                txtresultado.Text = Convert.ToString(hipotenusa);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            txtb.Clear();
            txta.Clear();
            lbl1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Regresar = new Pitagoras();
            Regresar.Show();
            this.Hide();
        }
        eje obj = new eje();
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
