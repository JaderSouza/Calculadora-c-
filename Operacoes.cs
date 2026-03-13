using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Projeto_Calculadora
{
    public class Operacoes
    {
        public double Num1;
        public double Num2;

        public string Adicao() 
        {
            double total = Num1 + Num2;
            return "O resultado da operação soma é: " + total;
        }
        public string Subtracao()
        {
            double total = Num1 - Num2;
            return "O resultado da operação de subtração é: " + total;
        }
        public string Multiplicacao()
        {
            double total = Num1 * Num2;
            return "O resultado da operação de multiplicação é: " + total;
        }
        public string Divisao()
        {
            if (Num2 != 0)
            {
                double total = Num1 / Num2;
                return "O resultado da operação de divisão é: " + total; ;
            }
            else 
            {
                return "Não é possível efetuar divisões por 0";
            }
        }
    }
}
