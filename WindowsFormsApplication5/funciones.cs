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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void Funciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sacararea = new Form2();
            sacararea.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ConversionesRad = new ConversionesRad();
            ConversionesRad.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Conversiones = new ConversionesGradosMinutosSegundos();
            Conversiones.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Figuras = new AreaSombreada();
            Figuras.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Regresar = new MenuVolumen();
            Regresar.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form pitagoras = new Pitagoras();
            pitagoras.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form bisectriz = new Bisectriz();
            bisectriz.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form cofucion = new Cofuncion();
            cofucion.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form leydesenos = new Ley_de_Senos();
            leydesenos.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form leydecosenos = new Ley_de_Coseno();
            leydecosenos.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form identidades = new Identidades_Trigonometricas();
            identidades.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form geometria = new Geometria_Analítica();
            geometria.Show();
            this.Hide();
        }
    }
}
