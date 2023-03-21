using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    partial class Meat
    {
        public int Shawarma(int pork,int etc,int x)
        {
            return (pork + etc) * x;
        }
        public Meat(int a,int b,int c)
        {
            Console.WriteLine(Shawarma(a, b ,c));
            Console.WriteLine(Kebab(a, b ,c));
        }
        public Meat(int a,int b)
        {
            Console.WriteLine(Shawarma(a, b, 1));
            Console.WriteLine(Kebab(a, b, 1));
        }
        public Meat()
        {
            Console.WriteLine(Shawarma(1, 1, 1));
            Console.WriteLine(Kebab(1, 1, 1));
        }

    }
}
