using System;

namespace LearningTravisCi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
