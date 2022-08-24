using System;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            void DayNumber()
            {
                Console.Write("Введите число от 1 до 7: ");
                int x=Convert.ToInt32(Console.ReadLine());
                if (x==7|| x==8)
                {
                    Console.WriteLine(x+" - Выходной");
                }
                else
                {
                    Console.WriteLine(x+" - Это не выходной");
                }
            }
            DayNumber();
        }
    }
}
