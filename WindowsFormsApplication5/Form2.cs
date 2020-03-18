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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form area_triangulo = new area_triangulo();
            area_triangulo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form area_cuadrado = new area_cuadrado();
            area_cuadrado.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form area_rectangulo = new area_rectangulo();
            area_rectangulo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form area_circulo = new area_circulo();
            area_circulo.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form area_rombo = new area_rombo();
            area_rombo.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form area_pentagono = new area_pentagono();
            area_pentagono.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form area_trapecio = new area_trapecio();
            area_trapecio.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form area_paralelogramo = new paralelogramo();
            area_paralelogramo.Show();
            this.Hide();
        }
    }
}
