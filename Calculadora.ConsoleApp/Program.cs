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
//Nossa calculadora deve gerar a tabuada de multiplicação para um determinado número [v]


using System.Drawing;
using System.Runtime.Serialization.Formatters;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            { //comandos do C#, estrutura de repetição, do-while

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

                    #region montando a tabuada com "While"
                    //int numero = 1;

                    //while (numero <= 10)
                    //{
                    //    int resultadoMultiplicacao = tabuada * numero;

                    //    Console.WriteLine( tabuada + " x " + numero + " = " + 
                    //        resultadoMultiplicacao );

                    //    //incremento
                    //    numero = numero + 1;
                    //}
                    #endregion

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

                #region verifica o tipo de operação utilizando "if-else if"
                //bool ehAdicao = operacao == "1";
                //bool ehSubtracao = operacao == "2";
                //bool ehMultiplicacao = operacao == "3";
                //bool ehDivisao = operacao == "4";

                //if (ehAdicao) //comandos do C#, estrutura de decisão, if-else, if, if-elseif, switch
                //{
                //    resultado = primeiroNumero + segundoNumero;
                //}

                //else if (ehSubtracao)
                //{
                //    resultado = primeiroNumero - segundoNumero;
                //}

                //else if (ehMultiplicacao)
                //{
                //    resultado = primeiroNumero * segundoNumero;
                //}

                //else if (ehDivisao)
                //{
                //    while (segundoNumero == 0)
                //    {
                //        Console.WriteLine("Segundo número não pode ser ZERO, tente novamente");

                //        Console.ReadLine();

                //        Console.Write("Digite o segundo número: ");

                //        segundoNumero = Convert.ToInt32(Console.ReadLine());
                //    }

                //    resultado = primeiroNumero / segundoNumero;
                //}
                #endregion

                decimal resultadoFormatado = Math.Round(resultado, 2);

                Console.WriteLine("O resultado da operação é: " + resultadoFormatado); //concatenar                

                Console.ReadLine();

            } while (true);
        }
    }
}