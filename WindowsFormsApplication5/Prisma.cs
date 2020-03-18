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
    public partial class Cilindro : Form
    {
        public Cilindro()
        {
            InitializeComponent();
        }

        private void Prisma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtaltura.Text == "" || txtradio.Text == "")
            {
                lbl1.Text = ("No se ha ingresado ningún valor");
            }
            else
            {
                double altura = 0, radio = 0, resarea = 0, resvolumen = 0, areabase = 0, areaaltura = 0;
                altura = Convert.ToDouble(txtaltura.Text);
                radio = Convert.ToDouble(txtradio.Text);
                areabase = 3.1416 * (radio * radio);
                areaaltura = 2 * (3.1416 * radio * altura);
                resarea = areaaltura + areabase;
                resvolumen = 2 * (areabase * areaaltura);
                txtarea.Text = Convert.ToString(resarea);
                txtvolumen.Text = Convert.ToString(resvolumen);
                lbl2.Text = ("Su unidad está elevado al cuadrado");
                lbl3.Text = ("Su unidad está elevado al cubo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtvolumen.Clear();
            txtradio.Clear();
            txtarea.Clear();
            txtaltura.Clear();
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Regresar = new MenuVolumen();
            Regresar.Show();
            this.Hide();
        }
        eje obj = new eje();
        private void txtaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtradio_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }
    }
}
