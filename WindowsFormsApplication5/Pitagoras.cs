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
    public partial class Pitagoras : Form
    {
        public Pitagoras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form hipotenusa = new Hipotenusa();
            hipotenusa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form catetob = new CatetoB();
            catetob.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form catetoa = new Catetoa();
            catetoa.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Naturaleza = new Naturaleza();
            Naturaleza.Show();
            this.Hide();
        }
    }
}
