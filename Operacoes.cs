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
        public double total;

        public string adicao(double num1, double num2) 
        {
            
            double total = num1 + num2;
            return "O resultado da operação soma é: " + total;
        }
        public string subtracao(double num1, double num2)
        {
            double total = num1 - num2;
            return "O resultado da operação de subtração é: " + total;
        }
        public string multiplicacao(double num1, double num2)
        {
            double total = num1 * num2;
            return "O resultado da operação de multiplicação é: " + total;
        }
        public string Divisao(double num1, double num2)
        {
            if (num1 > num2)
            {
                double total = num1 / num2;
                return "O resultado da operação de divisão é: " + total; ;
            }
            else 
            {
                Console.WriteLine("Não é possível efetuar divisões por 0");
            }
        }
    }
}
