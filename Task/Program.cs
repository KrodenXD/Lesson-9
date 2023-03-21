using System;
using System.Text.RegularExpressions;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Convert.ToString(Console.ReadLine());
            string surname = Convert.ToString(Console.ReadLine());

            if(Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {

            }
            else
            {
                Console.WriteLine("Input Doesn't Meet Requirments");
            }
        }
    }
}
