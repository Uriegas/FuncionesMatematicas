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
    public partial class ConversionesRad : Form
    {
        public ConversionesRad()
        {
            InitializeComponent();
        }

        private void gradosarad_Click(object sender, EventArgs e)
        {
            if (Grados.Text == "")
            {
                lbl1.Text = ("No se ha ingresado ningún valor");
            }
            else
            {
                double grad = 0, resultado = 0;
                grad = Convert.ToDouble(Grados.Text);
                resultado = grad * 3.14159 / 180;
                txtresultado.Text = Convert.ToString(resultado + "°");
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            Grados.Clear();
            lbl1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form menu=new Menu();
            menu.Show();
            this.Hide();
        }
        eje obj = new eje();
        private void Grados_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
