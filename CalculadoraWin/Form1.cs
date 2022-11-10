using System.Globalization;

namespace CalculadoraWin
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        int check = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }else
            {
                MessageBox.Show("Informe um valor para efetuar a adição!!");
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MUL")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "SQT")
            {
                double sqrt = Math.Sqrt(float.Parse(txtResultado.Text));
                txtResultado.Text = sqrt.ToString();
            }
            else if (operacao == "POT")
            {
                txtResultado.Text = Convert.ToString(Math.Pow((double)valor1, 2));
            }
            else if (operacao == "FRA")
            {
                txtResultado.Text = Convert.ToString(1 / valor1);
            }
            else if (operacao == "POR")
            {
                txtResultado.Text = Convert.ToString((valor1 / 100) * valor2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração!!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") 
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MUL";
                lblOperacao.Text = "x";
            } else
            {
               MessageBox.Show("Informe um valor para efetuar a multiplicação!!");
            }
        } 

    private void button17_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            } else
            {
               MessageBox.Show("Informe um valor para efetuar a divisão!!");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int lenght = txtResultado.TextLength - 1;
            string text = txtResultado.Text;
            txtResultado.Clear();
            for (int i = 0; i < lenght; i++)
                txtResultado.Text = txtResultado.Text + text[i];
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                txtResultado.Text = "";
                operacao = "SQT";
                lblOperacao.Text = "√";
            } else
            {
                MessageBox.Show("Informe um valor para efetuar a raiz quadrada!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResultado.TextLength > 0)
            {
                string text = txtResultado.Text;
                if (check == 1)
                {
                    txtResultado.Text = "-" + txtResultado.Text;
                    check = 2;
                }
                else if (check == 2)
                {
                    int lenght = txtResultado.TextLength; txtResultado.Clear();
                    for (int i = 1; i < lenght; i++) { txtResultado.Text = txtResultado.Text + text[i]; }
                    check = 1;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "POT";
                lblOperacao.Text = "x²";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a potência!!");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "FRA";
                lblOperacao.Text = "1/x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a fração!!");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "POR";
                lblOperacao.Text = "%";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a porcentagem!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
        }
    }
}