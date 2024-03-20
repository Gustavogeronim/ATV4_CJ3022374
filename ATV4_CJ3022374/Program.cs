namespace ATV4_CJ3022374
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, resultado, op;

            Console.WriteLine("digite o primeio numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite 1 para multiplicação");
            Console.WriteLine("digite 2 para divisão");
            Console.WriteLine("digite 3 para soma");
            Console.WriteLine("digite 4 para subtração");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    resultado = n1 * n2;
                    Console.WriteLine(resultado);
                    break;
                case 2:
                    resultado = n1 / n2;
                    Console.WriteLine(resultado);
                    break;
                case 3:
                    resultado = n1 + n2;
                    Console.WriteLine(resultado);
                    break;
                case 4:
                    resultado = n1 - n2;
                    Console.WriteLine(resultado);
                    break;
                    

                default:
                    Console.WriteLine("opção inválida");
                    break;
            }
        }
    } 

}

