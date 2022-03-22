using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraV5
{
    public partial class Form1 : Form
    {
        static public int opCount = 0;
        static public string operador;
        static public double total, ultNum, antNum;
        static public string ultNumtxt;
        
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }
        
        public void reset()
        {
            opCount = 0;
            total = 0;
            ultNum = 0;
            operador = "";
            textBox1.Text = "0";
            
        }
        
        public void clean()
        { //clean
            textBox1.Text = "0";
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {//nao precisava aparecer aqui
            textBox1.Text = "0";
        }


        private void NumGen(object sender, EventArgs e)
        {// gerador de numero
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == Convert.ToString(total))
            {
                textBox1.Text = "";
            }
            textBox1.Text += (sender as Button).Text;

        }

        private void result(object sender, EventArgs e)
        {//botao de resultado
            var op = new operadores();
            ultNum = Convert.ToDouble(textBox1.Text);
            op.calculo();
            textBox1.Text = ($"{total}");
            opCount = 0;
        }

        private void Clean_Click(object sender, EventArgs e)
        {//clean
            clean();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {//botao  de reset
            reset();
        }

        private void opGen(object sender, EventArgs e)
        {
            operador = (sender as Button).Text;
            opCount++;
            if (ultNum == 0)
            {//feature  de manter o numero 0 na string de texto para nao crashar a caulculadora
                ultNum = Convert.ToDouble(textBox1.Text);
                total = ultNum;
                }
            if (opCount > 1)
            {// feature de mostrar o resultado depois de duas operaçoes seguidas
                result(sender, e); 

            }
            if (ultNum != Convert.ToDouble(textBox1.Text))
            {//feature de "reset" da equaçao quando introduzir um novo numero depois de uma operaçao
                ultNum = Convert.ToDouble(textBox1.Text);
                total = ultNum;
                }
        }
    }
}
