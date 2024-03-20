using System.Drawing;

namespace ATV4_CJ3022099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            float n, n1,oper, soma, divisão, multiplicação, subtração;

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
                    Console.WriteLine("O resultado da sua soma é de: {0}",subtração);
                    break;

                case 3:
                    Console.WriteLine("O resultado da sua soma é de: {0}",multiplicação);
                    break;

                case 4:
                    Console.WriteLine("O resultado da sua soma é de: {0:F2}",divisão);
                    break;

                default:
                    Console.WriteLine("\nNão é possivel fazer uma operação!");
                    break;
            }
            
            //lista 4 (exercicio 1)
            int semana;

            Console.WriteLine("Entre com um número que corresponde a um dia da semana (1 a 7): ");
            semana = int.Parse (Console.ReadLine());

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
            
            // Lista 4 (exercicio 2)
            float compra,pagamento;


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
            */
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
                        Console.WriteLine("O mês é fevereiro e tem 29 dias");
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

        }

    }
}
