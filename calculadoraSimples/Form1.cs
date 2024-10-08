using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraSimples
{
    public partial class Form1 : Form
    {

        private decimal valorInic = 0.0m, valorSegun = 0.0m, resul = 0.0m;
        private string operador = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblTela.Text == "0")
            {
                lblTela.Text = "0";
            }
            else
            {
                lblTela.Text += "0";
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!lblTela.Text.Contains(","))
            {
                lblTela.Text += ",";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblTela.Text == "0")
            {
                lblTela.Text = "1";
            }
            else
            {
                lblTela.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblTela.Text == "0")
            {
                lblTela.Text = "2";
            }
            else
            {
                lblTela.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblTela.Text == "0")
            {
                lblTela.Text = "3";
            }
            else
            {
                lblTela.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblTela.Text == "0")
            {
                lblTela.Text = "4";
            }
            else
            {
                lblTela.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblTela.Text == "0")
            {
                lblTela.Text = "5";
            }
            else
            {
                lblTela.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblTela.Text == "0")
            {
                lblTela.Text = "6";
            }
            else
            {
                lblTela.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblTela.Text == "0")
            {
                lblTela.Text = "7";
            }
            else
            {
                lblTela.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblTela.Text == "0")
            {
                lblTela.Text = "8";
            }
            else
            {
                lblTela.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblTela.Text == "0")
            {
                lblTela.Text = "9";
            }
            else
            {
                lblTela.Text += "9";
            }
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            if (lblTela.Text.Contains("-"))
            {
                lblTela.Text = lblTela.Text.Trim('-');
            }
            else
            {
                lblTela.Text = "-" + lblTela.Text;
            }
        }

        private void btnAdi_Click(object sender, EventArgs e)
        {
            valorInic = decimal.Parse(lblTela.Text);
            lblTela.Text = "";
            operador = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            valorInic = decimal.Parse(lblTela.Text);
            lblTela.Text = "";
            operador = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            valorInic = decimal.Parse(lblTela.Text);
            lblTela.Text = "";
            operador = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            valorInic = decimal.Parse(lblTela.Text);
            lblTela.Text = "";
            operador = "/";
        }

        private void btnPorcen_Click(object sender, EventArgs e)
        {
            valorInic = decimal.Parse(lblTela.Text);
            lblTela.Text = "";
            operador = "%";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case "+":
                    valorSegun = decimal.Parse(lblTela.Text);
                    resul = valorInic + valorSegun;
                    lblTela.Text = resul.ToString();
                    break;

                case "-":
                    valorSegun = decimal.Parse(lblTela.Text);
                    resul = valorInic - valorSegun;
                    lblTela.Text = resul.ToString();
                    break;

                case "*":
                    valorSegun = decimal.Parse(lblTela.Text);
                    resul = valorInic * valorSegun;
                    lblTela.Text = resul.ToString();
                    break;

                case "/":
                    valorSegun = decimal.Parse(lblTela.Text);
                    resul = valorInic / valorSegun;
                    lblTela.Text = resul.ToString();
                    break;

                case "%":
                    valorSegun = decimal.Parse(lblTela.Text);
                    resul = valorInic * (valorSegun/100);
                    lblTela.Text = resul.ToString();
                    break;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            valorInic = 0.0m;
            valorSegun = 0.0m;
            lblTela.Text = "0";
        }
    }
}
