using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV5
{
    internal class operadores : Form1
    {
        public void calculo()
        {

            switch (operador)
            {
                case "+":
                    total = ultNum + total;
                    break;
                case "-":
                    total = total - ultNum;
                    break;
                case "*":
                    total = ultNum * total;
                    break;
                case "/":
                    total = total / ultNum;
                    break;
            }
        }
    }
}
