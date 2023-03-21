using System;

namespace Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Meat meat = new Meat();
            Meat meat1 = new Meat(a, b);
            Meat meat2 = new Meat(a, b, c);

            
        }
    }
}
