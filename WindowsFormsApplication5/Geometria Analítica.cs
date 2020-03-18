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
    public partial class Geometria_Analítica : Form
    {
        public Geometria_Analítica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form distanciadospuntos = new Distancia_entre_dos_puntos();
            distanciadospuntos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form puntomedio = new Punto_Medio();
            puntomedio.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form divisionsegmento = new División_de_Segmento();
            divisionsegmento.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form puntorecta = new Distancia_Punto_Recta();
            puntorecta.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
