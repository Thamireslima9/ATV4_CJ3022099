namespace ATV4_CJ3022099
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    Console.WriteLine(soma);
                    break;

                case 2:
                    Console.WriteLine(subtração);
                    break;

                case 3:
                    Console.WriteLine(multiplicação);
                    break;

                case 4:
                    Console.WriteLine(divisão);
                    break;

                default:
                    Console.WriteLine("\nNão é possivel fazer uma operação!");
                    break;
            }
            
        }
    }
}
