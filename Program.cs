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
            /* try
             {
                 Console.Write("Digite o primeiro número");
                 op.num1 = double.Parse(Console.ReadLine());
                 Console.WriteLine();


                 Console.Write("Digite + para somar, - para subitrair, * para multiplicar e / para dividir e para sair e fechar a calculadora digite 0");
                 string operacao = Console.ReadLine();


                 Console.Write("Digite o segundo número");
                 op.num2 = double.Parse(Console.ReadLine());*/



            while (true)
            {
                try
                {
                    Console.Write("Digite o primeiro número: ");
                    op.num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine();


                    Console.Write("Digite + para somar, - para subitrair, * para multiplicar e / para dividir e para sair e fechar a calculadora digite 0: ");
                    string operacao = Console.ReadLine();
                    if (operacao == "0")
                    {
                        Console.WriteLine("Fechando a Calculadora...");
                        break;
                    }


                    Console.Write("Digite o segundo número: ");
                    op.num2 = double.Parse(Console.ReadLine());

                    {

                        if (operacao == "+")
                        {
                            Console.WriteLine(op.adicao());
                        }
                        else if (operacao == "-")
                        {
                            Console.WriteLine(op.subtracao());
                        }
                        else if (operacao == "*")
                        {
                            Console.WriteLine(op.multiplicacao());
                        }
                        else if (operacao == "/")
                        {
                            Console.WriteLine(op.Divisao());
                        }
                        else
                        {
                            Console.WriteLine("Opção incorreta! Digite uma opção válida");
                        }

                    }

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Formato digitado incorreto!");
                }
                /*Console.Write("Digite o primeiro número");
                op.num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite + para somar, - para subitrair, * para multiplicar e / para dividir e para sair e fechar a calculadora digite 0");
                operacao = Console.ReadLine();
                Console.Write("Digite o segundo número");
                op.num2 = double.Parse(Console.ReadLine());*/
            }

        }
    }
}
