using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{

        static void Main(string[] args)
        {
        List<string> historicoContas = new List<string>();
            while (true)
            {

                Console.WriteLine("Escolha a operação desejada (+,-,*,/) ou digite 'leave' para sair do loop ");
                string operador = Console.ReadLine();
           
                if (operador.Equals("leave", StringComparison.CurrentCultureIgnoreCase))
                break;

                Console.WriteLine("Digite o primeiro número: ");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
            
                Console.WriteLine("Digite o segundo número: ");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());
             
                decimal resultado = 0;

                switch (operador)
                {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                        Console.WriteLine("Erro! Divisão por 0!");
                    break;

                default:
                    Console.WriteLine("Operador inválido");
                    break;
                }
              
              
                string operacaoNome = "";
                switch (operador)
                {
                    case "+":
                        operacaoNome = "Adição";
                        DataPresentation(historicoContas, resultado, operacaoNome);
                        break;

                    case "-":
                        operacaoNome = "Subtração";
                        DataPresentation(historicoContas, resultado, operacaoNome);
                        break;

                    case "*":
                        operacaoNome = "Multiplicação";
                        DataPresentation(historicoContas, resultado, operacaoNome);
                        break;

                    case "/":
                        operacaoNome = "Divisão";
                        DataPresentation(historicoContas, resultado, operacaoNome);
                        break;
                    default:
                    break;
                }
              
          

            Console.WriteLine();
            }

            foreach (string info in historicoContas)
            {
            Console.WriteLine(info);
            }

        }
                static void DataPresentation(List<string> historicoContas, decimal resultado, string operacaoNome)
                {
                    string ResultadoParImpar = (resultado % 2 == 0) ? "é par!" : "é ímpar!";
                    string ResultadoPrimo = IsPrimo(resultado) ? "é primo!" : "não é primo!";

                    string info = $" Operação: {operacaoNome};\n Resultado: {resultado};\n O número: {ResultadoParImpar}; \n O número: {ResultadoPrimo}; \n Data: {DateTime.Now}\n";

                    historicoContas.Add(info);

                    Console.WriteLine($"Resultado: {resultado}");
                    Console.WriteLine($"O resultado {ResultadoParImpar} e {ResultadoPrimo}.");
                    Console.WriteLine($"Operação registrada no histórico.");
                }

                static bool IsPrimo(decimal numero)
                {
                    if (numero <= 1) 
                    return false;

                    for (int i = 2; i < (decimal)Math.Sqrt((double)(numero)); i++)
                    {
                        if (numero % i == 0)
                        return false;
                    }

                    return true;
                }

}