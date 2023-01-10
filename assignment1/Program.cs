using LenghtHelper;
using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            LengthHelper LH = new LengthHelper();
            var a = "hello world";

            Console.WriteLine(LengthHelper.lengthFinder(a));
        }
    }
}
