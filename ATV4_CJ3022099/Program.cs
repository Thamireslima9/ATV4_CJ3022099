using System;
using System.Drawing;

namespace ATV4_CJ3022099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exer;
            Console.WriteLine("Qual exercício você deseja executar: ");
            Console.WriteLine("Exercício 1 \nExercício 2 \nExercício 3 \nExercício 4 \nExercício 5 \nExercício 6 \nExercicio 7:");
            exer = int.Parse(Console.ReadLine());

            switch (exer)
            {
                case 1:
                    float n, n1, oper, soma, divisão, multiplicação, subtração;

                    Console.WriteLine("Digite dois números (separados por enter), que você deseja executar uma operação matemática: ");
                    n = float.Parse(Console.ReadLine());
                    n1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Escolha qual operação você quer executar: ");
                    Console.WriteLine("1- soma \n2- subtração \n3- multiplicação \n4- divisão");
                    oper = float.Parse(Console.ReadLine());

                    soma = n + n1;
                    subtração = n - n1;
                    divisão = n / n1;
                    multiplicação = n * n1;

                    switch (oper)
                    {
                        case 1:
                            Console.WriteLine("O resultado da sua soma é de: {0}", soma);
                            break;

                        case 2:
                            Console.WriteLine("O resultado da sua soma é de: {0}", subtração);
                            break;

                        case 3:
                            Console.WriteLine("O resultado da sua soma é de: {0}", multiplicação);
                            break;

                        case 4:
                            Console.WriteLine("O resultado da sua soma é de: {0:F2}", divisão);
                            break;

                        default:
                            Console.WriteLine("\nNão é possivel fazer uma operação!");
                            break;
                    }
                    break;

                case 2:
                    //lista 4 (exercicio 1)
                    int semana;

                    Console.WriteLine("Entre com um número que corresponde a um dia da semana (1 a 7): ");
                    semana = int.Parse(Console.ReadLine());

                    switch (semana)
                    {
                        case 1:
                            Console.WriteLine("O dia da semana é domingo");
                            break;

                        case 2:
                            Console.WriteLine("O dia da semana é segunda-feira");
                            break;

                        case 3:
                            Console.WriteLine("\"O dia da semana é terça-feira");
                            break;

                        case 4:
                            Console.WriteLine("\"O dia da semana é quarta-feira");
                            break;

                        case 5:
                            Console.WriteLine("\"O dia da semana é quinta-feira");
                            break;

                        case 6:
                            Console.WriteLine("\"O dia da semana é sexta-feira");
                            break;

                        case 7:
                            Console.WriteLine("\"O dia da semana é sabado");
                            break;

                        default:
                            Console.WriteLine("\nNão é possivel conferir o dia da semana");
                            break;
                    }
                    break;

                case 3:
                    // Lista 4 (exercicio 2)
                    float compra, pagamento;


                    Console.WriteLine("Qual é o valor total de sua compra: ");
                    compra = float.Parse(Console.ReadLine());

                    Console.WriteLine("Como será a forma de pagamento: \n1- À vista em dinheiro. \n2- Pix \n3- Débito \n4- Crédito");
                    pagamento = float.Parse(Console.ReadLine());

                    switch (pagamento)
                    {
                        case 1:
                            compra -= (compra / 100) * 15;
                            Console.WriteLine("O valor final a ser pago de  acordo com  a forma  de pagamento é de: {0}", compra);
                            break;

                        case 2:
                            compra -= (compra / 100) * 10;
                            Console.WriteLine("O valor final a ser pago de  acordo com  a forma  de pagamento é de: {0}", compra);
                            break;

                        case 3:
                            compra += (compra / 100) * 5;
                            Console.WriteLine("O valor final a ser pago de  acordo com  a forma  de pagamento é de: {0}", compra);
                            break;

                        case 4:
                            compra -= (compra / 100) * 10;
                            Console.WriteLine("O valor final a ser pago de  acordo com  a forma  de pagamento é de: {0}", compra);
                            break;

                        default:
                            Console.WriteLine("\nNão é possivel realizar o pagamento.");
                            break;
                    }
                    break;
                case 4:
                    //Lista 4 (Exercicio 3)
                    int mes, dias, ano;


                    Console.WriteLine("Digite o número de um mês (1 a 12): ");
                    mes = int.Parse(Console.ReadLine());



                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine("O mês é janeiro e tem 31 dias.");
                            break;

                        case 2:
                            Console.WriteLine("Qual é o ano: ");
                            ano = int.Parse(Console.ReadLine());
                            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
                            {
                                Console.WriteLine("O mês é fevereiro e tem 29 dias,pois, o ano é bissexto");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("O mês é fevereiro e tem 28 dias");
                                break;
                            }

                        case 3:
                            Console.WriteLine("O mês é março e tem 31 dias.");
                            break;

                        case 4:
                            Console.WriteLine("O mês é abril e tem 30 dias.");
                            break;

                        case 5:
                            Console.WriteLine("O mês é maio e tem 31 dias.");
                            break;

                        case 6:
                            Console.WriteLine("O mês é junho e tem 30 dias.");
                            break;

                        case 7:
                            Console.WriteLine("O mês é julho e tem 31 dias.");
                            break;

                        case 8:
                            Console.WriteLine("O mês é agosto e tem 31 dias.");
                            break;

                        case 9:
                            Console.WriteLine("O mês é setembro e tem 30 dias.");
                            break;

                        case 10:
                            Console.WriteLine("O mês é outubro e tem 31 dias.");
                            break;

                        case 11:
                            Console.WriteLine("O mês é novembro e tem 30 dias.");
                            break;

                        case 12:
                            Console.WriteLine("O mês é dezembro e tem 31 dias.");
                            break;

                        default:
                            Console.WriteLine("\nNão é possivel ler o mês.");
                            break;
                    }
                    break;
                case 5:
                    //Lista 4 (Exercicio 4)

                    int nume1, nume2, carac;

                    Console.WriteLine("Digite dois números inteiros separados por enter: ");
                    nume1 = int.Parse(Console.ReadLine());
                    nume2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite para escolher o caracter que será usado para realizarmos o calculo sobre os numeros digtados: ");
                    Console.WriteLine(" 1 - (+) \n2 - (-) \n3 - (*) \n4 - (/) \n5 - (^) ");
                    carac = int.Parse(Console.ReadLine());

                    switch (carac)
                    {
                        case 1:
                            Console.WriteLine(nume1 + nume2);
                            break;

                        case 2:
                            Console.WriteLine(nume1 - nume2);
                            break;

                        case 3:
                            Console.WriteLine(nume1 * nume2);
                            break;

                        case 4:
                            Console.WriteLine(nume1 / nume2);
                            break;

                        case 5:
                            Console.WriteLine(nume1 - nume2);
                            break;

                        default:
                            Console.WriteLine("\nNão é possivel realizar o calculo.");
                            break;
                    }
                    break;
                case 6:

                    //lista 4 (exercicio 5)
                    double salario, novoSalario, aumento, diferenca;
                    string cargo;

                    Console.WriteLine("Digite o salário do funcionário:");
                    salario = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite o cargo do funcionário:");
                    cargo = (Console.ReadLine());

                    switch (cargo)
                    {
                        case "Professor":
                            aumento = salario * 0.075;
                            break;
                        case "Secretário":
                            aumento = salario * 0.097;
                            break;
                        case "Publicitário":
                            aumento = salario * 0.117;
                            break;
                        case "Jornalista":
                            aumento = salario * 0.089;
                            break;
                        case "Mecânico":
                            aumento = salario * 0.1324;
                            break;
                        case "Estagiário":
                            aumento = salario * 0.104;
                            break;
                        case "Técnico de TI":
                            aumento = salario * 0.146;
                            break;
                        default:
                            aumento = salario * 0.435;
                            break;
                    }

                    novoSalario = salario + aumento;
                    diferenca = novoSalario - salario;

                    Console.WriteLine($"Salário antigo: R$ {salario:F2}");
                    Console.WriteLine($"Novo salário: R$ {novoSalario:F2}");
                    Console.WriteLine($"Diferença: R$ {diferenca:F2}");
                    break;

                case 7:
                //Lista 4 (exercicio 6)
                    int faixa;
                    float salario1;
                    Console.WriteLine("Qual o seu salário?");
                    salario1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a faixa salaríal:" +
                        "\n1 - R$1903,98" +
                        "\n2 - Entre R$ 1.903,99 e R$ 2.826,65" +
                        "\n3 - Entre R$ 2.826,66 e R$ 3.751,05" +
                        "\n4 - Entre R$ 3.751,06 e R$ 4.664,68" +
                        "\n5 - Acima de R$ 4.664,68");
                    faixa = int.Parse(Console.ReadLine());

                    switch (faixa)
                    {
                        case 1:
                            Console.WriteLine("Não precisa pagar imposto");
                            break;
                        case 2:
                            salario1 -= ((salario1 / 100) * 7.5f);
                            Console.WriteLine("O salário líquido é de: {0}", salario1);
                            break;
                        case 3:
                            salario1 -= ((salario1 / 100) * 15);
                            Console.WriteLine("O salário líquido é de: {0}", salario1);
                            break;
                        case 4:
                            salario1 -= ((salario1 / 100) * 22.5f);
                            Console.WriteLine("O salário líquido é de: {0}", salario1);
                            break;
                        case 5:
                            salario1 -= ((salario1 / 100) * 27.5f);
                            Console.WriteLine("O salário líquido é de: {0}", salario1);
                            break;
                    }
                    break;
            }
        }

    }
}
