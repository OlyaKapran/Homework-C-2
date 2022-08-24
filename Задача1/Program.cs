using System;

namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
            void SecondNumber()
            {
            Console.Write("Введите трехзначное число ");
            int x=Convert.ToInt32(Console.ReadLine());
            int x1=x/10;
            int x2=x1%10;
            Console.WriteLine("Вторая цифра = "+x2);
            }
            SecondNumber();
        }
    }
}
