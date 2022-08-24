using System;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            void ThirdNumber()
            {
            Console.Write("Введите число ");
            int x=Convert.ToInt32(Console.ReadLine());
            string x1 = Convert.ToString(x);
            if (x1.Length>2)
            {
                Console.WriteLine("Третья цифра = "+x1[2]);
            }
            else
            {
                Console.WriteLine("Третьей цифры нет"); 
            }
            }
            ThirdNumber();
        }
    }
}
