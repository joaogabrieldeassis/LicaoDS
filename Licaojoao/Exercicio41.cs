using System;

namespace Licaojoao
{
    class Exercicio41
    {
        static void Main17(string[] args)
        {

            int toReceiveNumber = 0;
            Console.WriteLine("Digite a idade do nadador");
            toReceiveNumber = Convert.ToInt32(Console.ReadLine());
            if (toReceiveNumber >= 5 && toReceiveNumber <= 7)
            {
                Console.WriteLine("Infantil A = 5 a 7 anos ");
            }
            else if (toReceiveNumber >= 8 && toReceiveNumber <= 11)
            {
                Console.WriteLine("Infantil B = 8 a 11 anos  ");
            }
            else if (toReceiveNumber >= 12 && toReceiveNumber <= 13)
            {
                Console.WriteLine("Juvenil A = 12 a 13 anos  ");
            }
            else if (toReceiveNumber >= 14 && toReceiveNumber <= 17)
            {
                Console.WriteLine("Juvenil B = 14 a 17 anos");
            }
            else if (toReceiveNumber >= 18)
            {
                Console.WriteLine("Adultos = Maiores de 18 anos ");
            }


        }
    }
}
