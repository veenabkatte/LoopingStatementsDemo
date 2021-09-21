using System;

namespace LoopingStatementDemo
{
    class DoWhileDemo
    {
        static void Main()
        {
            int sum = 0;
            int i = 1;
            do
            {
                sum = sum + i;
                Console.WriteLine($"Sum {sum}");
                i++;
            } while (i <= 15);

            Console.ReadLine();
        }
    }
}
