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
    public partial class MenuVolumen : Form
    {
        public MenuVolumen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form paralepipedo =new Paralepipedo();
            paralepipedo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form calcularcubo = new Cubo();
            calcularcubo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form cilindro = new Cilindro();
            cilindro.Show();
            this.Hide();
        }

        private void MenuVolumen_Load(object sender, EventArgs e)
        {

        }

    }
}
