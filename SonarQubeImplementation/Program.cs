using System;

namespace SonarQubeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 1;
            int y = 2;
            Console.WriteLine(x + y);
            if (x == y)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            string a = "mystring";
            string b = "";
            for (int i = 0; i < a.Length; i++){
                b = b + a[i];
            }
        }
    }
}
