using Projeto_Calculadora;
using System;
using System.Globalization;


namespace Projeto_calculadora
{
    class Calculadora
    {
        public static void Main(string[] args)
        {
            LogicaCalculadora();
        }
        static void LogicaCalculadora()
        {
            //Operacoes Ops = new Operacoes();
            Operacoes op = new Operacoes();
            //Operacoes n1 = new Operacoes();
            //Operacoes n2 = new Operacoes();
            Console.Write("Digite o primeiro número");
            op.num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite + para somar, - para subitrair, * para multiplicar e / para dividir e para sair e fechar a calculadora digite 0");
            string operacao = Console.ReadLine();
            Console.Write("Digite o segundo número");
            op.num2 = double.Parse(Console.ReadLine());

            while (operacao != "0")
            {
                if (operacao == "+")
                {
                    op.adicao();
                }
                else if (operacao == "-")
                {
                    op.subtracao();
                }
                else if (operacao == "*")
                {
                    op.multiplicacao();
                }
                else if (operacao == "/")
                {
                    op.Divisao();
                }
                else 
                {
                    Console.WriteLine("Opção incorreta! Digite uma opção válida");
                }

                Console.Write("Digite o primeiro número");
                op.num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite + para somar, - para subitrair, * para multiplicar e / para dividir e para sair e fechar a calculadora digite 0");
                operacao = Console.ReadLine();
                Console.Write("Digite o segundo número");
                op.num2 = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("A calculadora será fechada...");
        }
    }
}
