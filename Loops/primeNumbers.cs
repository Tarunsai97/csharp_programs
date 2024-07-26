using System;

namespace Loops
{
    class Loop
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number to print the primne numbers");
            int num = Convert.ToInt32(Console.ReadLine());
        
            for(int i = 1; i <= num; i++)
            {
                int count = 0;
                for(int j=1; j<= num; j++)
                {
                    if(i%j == 0)
                    {
                        count++;
                    }
                }
                if(count == 2)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
