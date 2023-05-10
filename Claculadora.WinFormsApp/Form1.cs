using System.Globalization;

namespace Claculadora.WinFormsApp
{
    public partial class Form1 : Form
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public string Operacao { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void buttonAdicao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") { 

                Valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                Operacao = "SOMA";
                label1.Text = "+";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                Valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                Operacao = "SUB";
                label1.Text = "-";
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                Valor2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (Operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(Valor1 + Valor2);
                }
                else if (Operacao == "SUB")
                {
                    txtResultado.Text = Convert.ToString(Valor1 - Valor2);
                }
                else if (Operacao == "MULT")
                {
                    txtResultado.Text = Convert.ToString(Valor1 * Valor2);
                }
                else if (Operacao == "DIV")
                {
                    txtResultado.Text = Convert.ToString(Valor1 / Valor2);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                Valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                Operacao = "MULT";
                label1.Text = "*";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                Valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                Operacao = "DIV";
                label1.Text = "/";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            Valor1 = 0;
            Valor2 = 0;
            label1.Text = "";
        }
    }
}