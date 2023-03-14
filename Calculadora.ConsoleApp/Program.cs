//Requisito 01
//Nossa calculadora deve ter a possibilidade de somar dois números [v]

//Requisito 02
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma [v]

//Requisito 03
//Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração [v]

//Requisito 04
//Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática [v]

//Requisito 05
//Nossa calculadora deve realizar as operações com "0" [v]

//Requisito 06
//Nossa calculadora deve validar a opções do menu [v]

//Requisito 07
//Nossa calculadora deve realizar as operações com números com duas casas decimais [v]

//Requisito 08
//Nossa calculadora deve gerar a tabuada de multiplicação para um determinado número e apresentar numa visualização "rubro-negra" [v]

//Requisito 09

/** Nossa calculadora deve permitir visualizar as operações já realizadas [v]
 * 
 *  Critérios:
 *      1 - A descrição da operação realizada deve aparecer assim, exemplo:
 *          2 + 2 = 4
 *          10 - 5 = 5
 */

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * tipos de variaveis que aprendemos
             * string, string[], int, int[], decimal, decimal[], bool, bool[], double, double[], char, char[]
             */

            string[] descricoesOperacao = new string[100]; //declaração e inicialização de arrays

            int quantidadeOperacoesRealizadas = 0;

            do
            {

                Console.Clear();

                Console.WriteLine("Calculadora Top 2023");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");
                Console.WriteLine("Digite 5 para Gerar Tabuada");
                Console.WriteLine("Digite 6 para Visualizar as operações realizadas");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao != "6"
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
                        int resto = i % 2;
                        if (resto == 0)
                            Console.BackgroundColor = ConsoleColor.Red;
                        else
                            Console.BackgroundColor = ConsoleColor.Black;

                        int resultadoMultiplicacao = tabuada * i;

                        Console.WriteLine(tabuada + " x " + i + " = " + resultadoMultiplicacao);
                    }

                    Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    continue;
                }

                if (operacao == "6")
                {
                    //visualizar as operações

                    for (int i = 0; i < descricoesOperacao.Length; i++) //quantidadeOperacoesRealizadas
                    {
                        if (descricoesOperacao[i] != null)
                            Console.WriteLine(descricoesOperacao[i]);                        
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

                string sinalOperacao = "";

                switch (operacao)
                {
                    case "1": sinalOperacao = "+"; break;
                    case "2": sinalOperacao = "-" ; break;
                    case "3": sinalOperacao = "*"; break;
                    case "4": sinalOperacao = "/"; break;

                    default:
                        break;
                }

                descricoesOperacao[quantidadeOperacoesRealizadas] = primeiroNumero + " " + sinalOperacao + " " + segundoNumero + " = " + resultadoFormatado;

                Console.WriteLine("O resultado da operação é: " + resultadoFormatado); //concatenar                

                Console.ReadLine();

                quantidadeOperacoesRealizadas++;

            } while (true);
        }
    }
}