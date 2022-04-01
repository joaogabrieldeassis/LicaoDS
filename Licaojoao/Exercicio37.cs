using System;
namespace LICAOJOAO
{
    class Exercicio38
    {
        static void Main(string[] args)
        {
            int oneNumber, twoNumber, receiveNumber, receiveNumberOperation = 0;
            char receiveCaracter;
            while (true)
            {
                Console.WriteLine("1 – Adição\n 2 – Subtração\n 3 – Multiplicação\n 4 – Divisão ");
                receiveNumber = Convert.ToInt32(Console.ReadLine());
                switch (receiveNumber)
                {
                    case 1:
                        Console.WriteLine("Digite o 1º número");
                        oneNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o 2º número");
                        twoNumber = Convert.ToInt32(Console.ReadLine());
                        receiveNumberOperation = twoNumber + oneNumber;
                        Console.WriteLine("A soma dos números digitados é {0}", receiveNumberOperation);
                        break;
                    case 2:
                        Console.WriteLine("Digite o 1º número");
                        oneNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o 2º número");
                        twoNumber = Convert.ToInt32(Console.ReadLine());
                        receiveNumberOperation = oneNumber - twoNumber;
                        Console.WriteLine("A Subtração dos números digitados é {0}", receiveNumberOperation);
                        break;
                    case 3:
                        Console.WriteLine("Digite o 1º número");
                        oneNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o 2º número");
                        twoNumber = Convert.ToInt32(Console.ReadLine());
                        receiveNumberOperation = oneNumber * twoNumber;
                        Console.WriteLine("A Multiplicação dos números digitados é {0}", receiveNumberOperation);
                        break;
                    case 4:
                        Console.WriteLine("Digite o 1º número");
                        oneNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o 2º número");
                        twoNumber = Convert.ToInt32(Console.ReadLine());
                        receiveNumberOperation = oneNumber / twoNumber;
                        Console.WriteLine("A Divisão dos números digitados é {0}", receiveNumberOperation);
                        break;
                }
                Console.WriteLine("Deseja sair do programa ? S para sim N para não ");
                receiveCaracter = Convert.ToChar(Console.ReadLine());
                if (receiveCaracter == 's' || receiveCaracter == 'S')
                {
                    break;
                }
            }
        }
    }
}