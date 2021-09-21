using System;


namespace LoopingStatementDemo
{
    class WhileDemo
    {
       static void Main()
        {
            int sum = 0;
            int i = 1;

            while (i <= 15)
            {
                sum = sum + i;
                Console.WriteLine($"Sum is {sum}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
