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
    public partial class ConversionesGradosMinutosSegundos : Form
    {
        public ConversionesGradosMinutosSegundos()
        {
            InitializeComponent();
        }

        private void ConversionesGradosMinutosSegundos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            if (txtgrad1.Text == "" || txtmin1.Text == "" || txtseg1.Text == "" || txtgrad2.Text == "" || txtmin2.Text == "" || txtseg2.Text == "")
            {
                lbl1.Text = ("No se ingresaron todos los valores");
            }
            else
            {
            int grados1 = 0, grados2 = 0, min1=0,min2=0, seg1=0,seg2=0, sumagrad,sumamin=0,sumaseg=0,divseg=0,divmin=0,res1=0,res2=0;
            grados1 = Convert.ToInt32(txtgrad1.Text);
            grados2 = Convert.ToInt32(txtgrad2.Text);
            min1 = Convert.ToInt32(txtmin1.Text);
            min2 = Convert.ToInt32(txtmin2.Text);
            seg1 = Convert.ToInt32(txtseg1.Text);
            seg2 = Convert.ToInt32(txtseg2.Text);
                sumagrad = grados1 + grados2;
                sumaseg = seg1 + seg2;
                sumamin = min1 + min2;
                if (sumaseg > 60)
                {
                    divseg = sumaseg % 60;
                    res1 = sumaseg / 60;
                    sumamin = sumamin + res1;
                    sumaseg = divseg;
                }
                if (sumamin > 60)
                {
                    divmin = sumamin % 60;
                    res2 = sumamin / 60;
                    sumagrad=sumagrad + res2;
                    sumamin = divmin;
               }
                txtsuma.Text=Convert.ToString(sumagrad +"° " + sumamin+"'' " + sumaseg +"'");
            }

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            if (txtgrad1.Text == "" || txtmin1.Text == "" || txtseg1.Text == "" || txtgrad2.Text == "" || txtmin2.Text == "" || txtseg2.Text == "")
            {
                lbl1.Text = ("No se ingresaron todos los valores");
            }
            else
            {
                int grados1 = 0, grados2 = 0, min1 = 0, min2 = 0, seg1 = 0, seg2 = 0, resgrad, resmin = 0, resseg = 0;
                grados1 = Convert.ToInt32(txtgrad1.Text);
                grados2 = Convert.ToInt32(txtgrad2.Text);
                min1 = Convert.ToInt32(txtmin1.Text);
                min2 = Convert.ToInt32(txtmin2.Text);
                seg1 = Convert.ToInt32(txtseg1.Text);
                seg2 = Convert.ToInt32(txtseg2.Text);
                if (seg1 < seg2)
                {
                    seg1 = seg1 + 60;
                    min1 = min1 - 1;
                    resseg = seg1 - seg2;
                }
                else
                {
                    resseg = seg1 - seg2;
                }
                if (min1 < min2)
                {
                    min1 = min1 + 60;
                    grados1 = grados1 - 1;
                    resmin = min1 - min2;
                }
                else
                {
                    resmin = min1 - min2;
                }
                resgrad = grados1 - grados2;
                txtresta.Text = Convert.ToString(resgrad + "° " + resmin + "'' " + resseg + "'");
            }
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            if (txtgrad3.Text == "" || txtmin3.Text == "" || txtseg3.Text == "" || txtdiv.Text == "")
            {
                lbl1.Text = ("No se ingresaron todos los valores");
            }
            else
            {
                int grados3 = 0, min3 = 0, seg3 = 0, resgrad = 0, resmin = 0, resseg = 0, divisor = 0, res1 = 0, res2 = 0;
                grados3 = Convert.ToInt32(txtgrad3.Text);
                min3 = Convert.ToInt32(txtmin3.Text);
                seg3 = Convert.ToInt32(txtseg3.Text);
                divisor = Convert.ToInt32(txtdiv.Text);
                resgrad = grados3 / divisor;
                res1 = grados3 % divisor;
                res1 = res1 * 60;
                res1 = res1 + min3;
                resmin = res1 / divisor;
                res2 = res1 % divisor;
                res2 = res2 * 60;
                res2 = res2 + seg3;
                resseg = res2 / divisor;
                txtdivision.Text = Convert.ToString(resgrad + "°" + resmin + "''" + resseg + "'");
            }
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
                int grados4 = 0, min4 = 0, seg4 = 0, mult = 0, res1 = 0, res2 = 0, resmin = 0, resseg = 0;
                grados4 = Convert.ToInt32(txtgrad4.Text);
                min4 = Convert.ToInt32(txtmin4.Text);
                seg4 = Convert.ToInt32(txtseg4.Text);
                mult = Convert.ToInt32(txtmulti.Text);
                grados4 = grados4 * mult;
                min4 = min4 * mult;
                seg4 = seg4 * mult;
                resseg = seg4;
                resmin = min4;
                if (seg4 > 60)
                {
                    resseg = seg4 % 60;
                    res1 = seg4 / 60;
                    min4 = min4 + res1;
                }
                else
                {
                    resseg=seg4;
                }
                if (min4 > 60)
                {
                    resmin = min4 % 60;
                    res2 = min4 / 60;
                    grados4 = grados4 + res2;
                }
                else
                {
                    resmin = min4;
                }
                txtmult.Text = Convert.ToString(grados4 + "° " + resmin + "'' " + resseg + "'");
            
        }

        private void btngrados_Click(object sender, EventArgs e)
        {
            if (txtgrad1.Text == "" || txtmin1.Text == "" || txtseg1.Text == "")
            {
                lbl1.Text = ("No se ingresaron todos los valores");
            }
            else
            {
                double grados1 = 0, min1 = 0, seg1 = 0, resmin = 0, resseg = 0, resultado;
                grados1 = Convert.ToDouble(txtgrad1.Text);
                min1 = Convert.ToDouble(txtmin1.Text);
                seg1 = Convert.ToDouble(txtseg1.Text);
                resseg = seg1 / 3600;
                resmin = min1 / 60;
                resultado = grados1 + resmin + resseg;
                txtgrados.Text = Convert.ToString(resultado + "°");
            }
        }

        private void btnminutos_Click(object sender, EventArgs e)
        {
            if (txtgrad1.Text == "" || txtmin1.Text == "" || txtseg1.Text == "")
            {
                lbl1.Text = ("No se ingresaron todos los valores");
            }
            else
            {
                double grados1 = 0, min1 = 0, seg1 = 0, resgrados = 0, resseg = 0, resultado;
                grados1 = Convert.ToDouble(txtgrad1.Text);
                min1 = Convert.ToDouble(txtmin1.Text);
                seg1 = Convert.ToDouble(txtseg1.Text);
                resseg = seg1 / 60;
                resgrados = grados1 * 60;
                resultado = min1 + resgrados + resseg;
                txtmin.Text = Convert.ToString(resultado + "''");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresta.Clear();
            txtdivision.Clear();
            txtgrad1.Clear();
            txtgrad2.Clear();
            txtgrad3.Clear();
            txtgrad4.Clear();
            txtgrados.Clear();
            txtmin.Clear();
            txtmin1.Clear();
            txtmin2.Clear();
            txtmin3.Clear();
            txtmin4.Clear();
            txtmult.Clear();
            txtmulti.Clear();
            txtresta.Clear();
            txtseg1.Clear();
            txtseg2.Clear();
            txtseg3.Clear();
            txtseg4.Clear();
            txtsuma.Clear();
            txtnum.Clear();
            txtdiv.Clear();
            lbl1.Text = "";
            gdminseg.Clear();
        }

        private void btnconversion_Click(object sender, EventArgs e)
        {
            Double CalcularSegundos = 0, GradosRecibidos = 0, grados= 0, residuo = 0, CalcularMin = 0, totalmin = 0, residuomin = 0, totalseg = 0;
            string cadenas, strmin, strseg;
            GradosRecibidos = Convert.ToDouble(txtnum.Text);
            cadenas = Convert.ToString(GradosRecibidos);
            grados = Convert.ToInt32(cadenas.Substring(0, cadenas.IndexOf(".")));
            residuo=Convert.ToDouble(cadenas.Substring(cadenas.IndexOf(".")));

            CalcularMin=residuo*60;
            strmin = Convert.ToString(CalcularMin);
            totalmin=Convert.ToInt32(strmin.Substring(0, strmin.IndexOf(".")));
            residuomin = Convert.ToDouble(strmin.Substring(strmin.IndexOf(".")));


            CalcularSegundos = residuomin * 60;
            strseg = Convert.ToString(CalcularSegundos);
            totalseg = Convert.ToInt32(strseg.Substring(0, strseg.IndexOf(".")));
            gdminseg.Text = Convert.ToString(grados + "°" + totalmin + "''" + totalseg + "'");

        }

        eje obj = new eje();
        private void txtmin1_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtseg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtgrad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtgrad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtmin2_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtseg2_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtsuma_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtresta_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtgrados_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void gdminseg_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtgrad3_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtmin3_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtseg3_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtdiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtdivision_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtgrad4_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtmin4_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtseg4_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtmulti_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void txtmult_KeyPress(object sender, KeyPressEventArgs e)
        {
            obj.ValidarNum(e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



    }
}
