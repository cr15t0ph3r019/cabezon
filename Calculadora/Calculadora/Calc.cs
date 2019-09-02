using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calc : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calc()
        {
            InitializeComponent();
        }
        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMulti obj3 = new Clases.ClsMulti();
        Clases.ClsDiv obj4 = new Clases.ClsDiv();
        Clases.ClsPor obj5 = new Clases.ClsPor();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void N0_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + "0";
        }

        private void N1_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + "1";
        }

        private void N2_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + "2";
        }

        private void N3_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + "3";
        }

        private void N4_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + "4";
        }

        private void N5_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + "5";
        }

        private void N6_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + "6";
        }

        private void N7_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + "7";
        }

        private void N8_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + "8";
        }

        private void N9_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + "9";
        }

        private void PUNTO_Click(object sender, EventArgs e)
        {
            PANTALLA.Text = PANTALLA.Text + ".";
        }

        private void MAS_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(PANTALLA.Text);
            PANTALLA.Clear();
        }

        private void MENOS_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(PANTALLA.Text);
            PANTALLA.Clear();
        }

        private void MULTIPLICACION_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(PANTALLA.Text);
            PANTALLA.Clear();
        }

        private void DIVISION_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(PANTALLA.Text);
            PANTALLA.Clear();
        }

        private void IGUAL_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(PANTALLA.Text);
            double sum;
            double res;
            double mult;
            double div;
            double por;
            switch(operador){
                case "+":
                    sum = obj.suma((primero), (segundo));
                    PANTALLA.Text = sum.ToString();
                    break;

                case "-":
                    res = obj2.resta((primero), (segundo));
                    PANTALLA.Text = res.ToString();
                    break;

                case "*":
                    mult = obj3.M((primero), (segundo));
                    PANTALLA.Text = mult.ToString();
                    break;

                case "/":
                    div = obj4.division((primero), (segundo));
                    PANTALLA.Text = div.ToString();
                    break;

                case "%":
                    por = obj5.porcentaje((primero), (segundo));
                    PANTALLA.Text = por.ToString();
                    break;
                  

            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            PANTALLA.Clear();
        }

        private void BORRAR_Click(object sender, EventArgs e)
        {
            if (PANTALLA.Text.Length == 1)
                PANTALLA.Text = "";
            else
                PANTALLA.Text = PANTALLA.Text.Substring(0, PANTALLA.Text.Length - 1);
        }

        private void PANTALLA_TextChanged(object sender, EventArgs e)
        {

        }

        private void PORCENTAJE_Click(object sender, EventArgs e)
        {
            operador = "%";
            primero = double.Parse(PANTALLA.Text);
            PANTALLA.Clear();
        }
    }
}
