namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            { 

                #region Menu
                Console.Clear();

                Console.WriteLine("Calculadora Top 2023");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");
                Console.WriteLine("Digite 5 para Gerar Tabuada");

                Console.WriteLine("Digite S para sair");

                #endregion

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" 
                    && operacao != "S" && operacao != "s")
                {
                    Console.WriteLine("Operacao inválida, tente novamente...");
                    Console.ReadLine();
                    continue;
                }

                if (operacao == "5")
                {
                    Console.Write("Digite o número para gerar a tabuada: ");

                    int tabuada = Convert.ToInt32(Console.ReadLine()); //5              

                    for (int i = 1; i <= 10; i++) //i = i + 1 
                    {
                        int resultadoMultiplicacao = tabuada * i;
                        
                        Console.WriteLine(tabuada + " x " + i + " = " + resultadoMultiplicacao );
                    }                  

                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine();

                Console.Write("Digite o primeiro número: ");

                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o segundo número: ");

                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                switch (operacao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;
                    case "2": resultado = primeiroNumero - segundoNumero; break;
                    case "3": resultado = primeiroNumero * segundoNumero; break;
                    case "4": 
                        {
                            while (segundoNumero == 0)
                            {
                                Console.WriteLine("Segundo número não pode ser ZERO, tente novamente");

                                Console.ReadLine();

                                Console.Write("Digite o segundo número: ");

                                segundoNumero = Convert.ToInt32(Console.ReadLine());
                            }

                            resultado = primeiroNumero / segundoNumero; 
                            break; 
                        }

                    default:
                        break;
                }

                decimal resultadoFormatado = Math.Round(resultado, 2);

                Console.WriteLine("O resultado da operação é: " + resultadoFormatado); //concatenar                

                Console.ReadLine();

            } while (true);
        }
    }
}