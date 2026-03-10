using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Projeto_Calculadora
{
    public class Operacoes
    {
        public double num1;
        public double num2;

        public string adicao() 
        {
            double total = num1 + num2;
            return "O resultado da operação soma é: " + total;
        }
        public string subtracao()
        {
            double total = num1 - num2;
            return "O resultado da operação de subtração é: " + total;
        }
        public string multiplicacao()
        {
            double total = num1 * num2;
            return "O resultado da operação de multiplicação é: " + total;
        }
        public string Divisao()
        {
            if (num1 > num2)
            {
                double total = num1 / num2;
                return "O resultado da operação de divisão é: " + total; ;
            }
            else 
            {
                return "Não é possível efetuar divisões por 0";
            }
        }
    }
}
