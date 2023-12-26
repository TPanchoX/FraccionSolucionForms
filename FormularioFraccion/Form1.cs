using LibreriaFraccionForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioFraccion
{
    public partial class Calculadora : Form
    {
        int vnum = 0;
        int vdem = 0;
        Fraccion f1final = new Fraccion();
        Fraccion f2final = new Fraccion();
        Fraccion f1Respuesta = new Fraccion();


        public Calculadora()
        {
            InitializeComponent();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void lbln1_Click(object sender, EventArgs e)
        {

        }

        private void lbld1_Click(object sender, EventArgs e)
        {

        }

        private void lbln2_Click(object sender, EventArgs e)
        {

        }

        private void lbld2_Click(object sender, EventArgs e)
        {

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            vnum = 0;
            vdem = 0;
            nudNumerador.Value = 0;
            nudDenominador.Value = 0;
            lbln1.Text = "n1";
            lbld1.Text = "d1";
            lbln2.Text = "n2";
            lbld2.Text = "d2";
            lblnr.Text = "nr";
            lbldr.Text = "dr";
            rbtFraccion1.Checked = false;
            rbtFraccion2.Checked = false;
            Fraccion frestar = new Fraccion();
            f1Respuesta = frestar;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            f1Respuesta = f1final.sumar(f2final);
            lblnr.Text = f1Respuesta.getNum().ToString();
            lbldr.Text = f1Respuesta.getDen().ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            f1Respuesta = f1final.restar(f2final);
            lblnr.Text = f1Respuesta.getNum().ToString();
            lbldr.Text = f1Respuesta.getDen().ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            f1Respuesta = f1final.multiplicar(f2final);
            lblnr.Text = f1Respuesta.getNum().ToString();
            lbldr.Text = f1Respuesta.getDen().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f1Respuesta = f1final.dividir(f2final);
            lblnr.Text = f1Respuesta.getNum().ToString();
            lbldr.Text = f1Respuesta.getDen().ToString();
        }

        private void rbtFraccion1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFraccion1.Checked == true) 
            {
                vnum = (int)nudNumerador.Value;
                vdem = (int)nudDenominador.Value;
                Fraccion f1 = new Fraccion(vnum, vdem);
                f1final = f1;
                lbln1.Text = f1.getNum().ToString();
                lbld1.Text = f1.getDen().ToString();
                //MessageBox.Show(f1.getNum().ToString() + "/" + f1.getDen().ToString());
            }
        }

        private void rbtFraccion2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtFraccion2.Checked == true) 
            {
                vnum = (int)nudNumerador.Value;
                vdem = (int)nudDenominador.Value;
                Fraccion f2 = new Fraccion(vnum, vdem);
                f2final = f2;
                lbln2.Text = f2.getNum().ToString();
                lbld2.Text = f2.getDen().ToString();
                //MessageBox.Show(f2.getNum().ToString() + "/" + f2.getDen().ToString());
            }
        }
    }
}
