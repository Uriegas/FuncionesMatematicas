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
    public partial class Catetoa : Form
    {
        public Catetoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtb.Text == "" || txthipotenusa.Text == "")
            {
                lbl1.Text = ("No se ha ingresado ningún valor");
            }
            else
            {
                double catetoa = 0, catetob = 0, hipotenusa = 0;
                catetob = Convert.ToDouble(txtb.Text);
                hipotenusa = Convert.ToDouble(txthipotenusa.Text);
                catetob = catetob * catetob;
                hipotenusa = hipotenusa * hipotenusa;
                catetoa = Math.Sqrt(catetob);
                catetoa = catetoa + Math.Sqrt(hipotenusa);
                catetoa = Math.Sqrt(catetoa);
                txtresultado.Text = Convert.ToString(catetoa);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            txthipotenusa.Clear();
            txtb.Clear();
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

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
