using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular(string operacao)
        {
            double leftOperand, rightOperand;

            double.TryParse(txtVal1.Text, out leftOperand);
            double.TryParse(txtVal2.Text, out rightOperand);

            double resultado;
            switch (operacao)
            {
                case "+" :
                    resultado = leftOperand + rightOperand;
                    break;

                case "-":
                    resultado = leftOperand - rightOperand;
                    break;

                case "*":
                    resultado = leftOperand * rightOperand;
                    break;

                case "/":
                    resultado = leftOperand / rightOperand;
                    break;

                default:
                    resultado = 0;
                    break;
            }

            lblResultado.Text = resultado.ToString();


        }

        private void FazCalculo_Click(object sender, EventArgs e)
        {
            Calcular((sender as Button).Text.Trim());
        }

        private void txtVal1_Click(object sender, EventArgs e)
        {

        }
    }
}
